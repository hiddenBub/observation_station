using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Instrumentation;
namespace HainanDataCenter
{
    public partial class frmObsLS : DevComponents.DotNetBar.Office2007Form
    {
        List<EquipInfo> equiplist = null;
        List<System.IO.Ports.SerialPort> PortList = new List<System.IO.Ports.SerialPort>();
        ObsParams params1 = new ObsParams();
        string selectStationNo;
        public float[] GHISum1000 = new float[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] GTISum1000 = new float[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        


        public frmObsLS()
        {
            InitializeComponent();
        }

        public void StartSerialSerial(List<EquipInfo> list)
        {
            equiplist.Clear();
            equiplist = list;
            BindCmbEquip(equiplist);

            selectStationNo = cmbEquip.Text;

            foreach (EquipInfo info in equiplist)
            {
                try
                {
                    System.IO.Ports.SerialPort serialPort2 = new System.IO.Ports.SerialPort(info.ComName);
                    serialPort2.BaudRate = Convert.ToInt16(info.BandRate);
                    serialPort2.Parity = System.IO.Ports.Parity.None;
                    serialPort2.StopBits = System.IO.Ports.StopBits.One;
                    serialPort2.DataBits = 8;
                    serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort_DataReceived);
                    serialPort2.Open();
                    PortList.Add(serialPort2);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
 
            }
            SendCommandData();
        }

        public bool IfOld(string commname)
        {
            bool ret = true; ;
            foreach (EquipInfo info in equiplist)
            {
                if (info.ComName == commname)
                {
                    ret = info.OldEquip;
                }
            }
            return ret;
        }
        public void StopSerialSerial()
        {
            //             equiplist.Clear();
            //             equiplist = list;
            //             BindCmbEquip(equiplist);


            foreach (System.IO.Ports.SerialPort pt in PortList)
            {

                if (pt.IsOpen)
                    pt.Close();
                pt.Dispose();

                //  PortList.Remove(pt);
                ;
                //PortList.Add(serialPort2);

            }
            PortList.Clear();
        }



        public void UpdateFrom(System.IO.Ports.SerialPort port1)
        {
            string comName = port1.PortName;
            //
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort sport = sender as System.IO.Ports.SerialPort;

            //    BackgroundWorker bw = new BackgroundWorker();
            //    bw.WorkerReportsProgress = true;
            //     bw.WorkerSupportsCancellation = true;
            //     bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //     bw.RunWorkerAsync(sport);
            bw_DoWork(sport);

        }

        public void SendCommandData()
        {
            byte[] buffer = new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x0A, 0xC5, 0xCD };
            // byte[] buffer_old = new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x0A, 0xC5, 0xCD }; //#7659030CG
            foreach (System.IO.Ports.SerialPort pt in PortList)
            {
                try
                {
                    string commname = pt.PortName;
                    bool equiptype = IfOld(commname);
                    if (pt.IsOpen)
                    {
                        pt.Write(buffer, 0, buffer.Length);
                    }                             

                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // void bw_DoWork(object sender, DoWorkEventArgs e)
        void bw_DoWork(System.IO.Ports.SerialPort sport)
        {   // 需要在此写入接收程序,判断信息
            //  System.IO.Ports.SerialPort sport = e.Argument as System.IO.Ports.SerialPort;
            string sp = sport.PortName;
            string stationName = GetEquipNo(sp);
            string StationNo = GetStationNo(sp);
            bool equiptype = IfOld(sp);
            if (equiptype == false)
            {
                byte[] RcvBytes = new byte[sport.BytesToRead];



                Thread.Sleep(3000);
                int lIntLen = sport.Read(RcvBytes, 0, RcvBytes.Length);
                if (params1 != null)
                {
                    params1 = null;

                }
                //从串口获取数据
                params1 = new ObsParams();    // 定义到数据库文件,应该是一样的
                if (lIntLen < 25)
                {
                    byte[] RcyByte_all = RcvBytes;
                    sp = sport.PortName;
                    stationName = GetEquipNo(sp);
                    StationNo = GetStationNo(sp);
                    byte[] RcvBytes_new = new byte[sport.BytesToRead];
                    lIntLen = sport.Read(RcvBytes_new, 0, RcvBytes_new.Length);

                    byte[] result = new byte[RcyByte_all.Length + RcvBytes_new.Length];
                    RcyByte_all.CopyTo(result, 0);
                    RcvBytes_new.CopyTo(result, RcyByte_all.Length);

                    RcvBytes = result;
                    
                    //lIntLen = sport.Read(RcvBytes, 0, RcvBytes.Length);
                    if (RcvBytes.Length < 25)
                    {
                        return;
                    }
    
                }
               params1 = Common.GetObsParams(RcvBytes);
            }
            else
            {
                char[] RcvBytes_old = new char[sport.BytesToRead];
                Thread.Sleep(3000);
                int lIntLen = sport.Read(RcvBytes_old, 0, RcvBytes_old.Length);
                if (params1 != null)
                {
                    params1 = null;

                }
                //从串口获取数据
                params1 = new ObsParams();    // 定义到数据库文件,应该是一样的
                if (lIntLen < 117)
                {
                    char[] RcyByte_all = RcvBytes_old;
                    sp = sport.PortName;
                    stationName = GetEquipNo(sp);
                    StationNo = GetStationNo(sp);
                    char[] RcvBytes_new =new char[sport.BytesToRead];
                    lIntLen = sport.Read(RcvBytes_new, 0, RcvBytes_new.Length);

                    char[] result = new char[RcyByte_all.Length + RcvBytes_new.Length];
                    RcyByte_all.CopyTo(result, 0);
                    RcvBytes_new.CopyTo(result, RcyByte_all.Length);
                    RcvBytes_old = result;

                }
                    
                    string RcvBytes_string = new string(RcvBytes_old);
                   
                    params1 = Common.GetObsParams_old(RcvBytes_string);
                    //lIntLen = sport.Read(RcvBytes, 0, RcvBytes.Length);
                    if (RcvBytes_old.Length < 117)
                    {
                        return;
                    }



            }




            if (params1 == null)
            {
                return;
            }

            params1.StationName = stationName;
            int.TryParse(StationNo, out params1.StationNO);
  
           // int ret = DAO.Exist(params1.StationName, params1.ObsTime);// 判断是否有重复的数据
            //if (ret<1)
            //{
                
            DAO.InsertData(params1);



            try
            {

                    ObsParams parameter_lg =new ObsParams();
                    ObsParams parameter_yp = new ObsParams();
                    ObsParams parameter_gly = new ObsParams();
                    ObsParams parameter_zhtb = new ObsParams();
                    ObsParams parameter_wwz = new ObsParams();
                    ObsParams parameter_swzy = new ObsParams();
                    ObsParams parameter_jsd = new ObsParams();
                    ObsParams parameter_hj = new ObsParams();
                    ObsParams parameter_tc = new ObsParams();
                if (params1.StationNO != null)
                {
                    // Member.obsParamsList.Add(params1);
                    switch (Convert.ToInt32(params1.StationNO))
                    {
                        case 1:
                            Member.parameter_lg = params1;
                            break;
                        case 2:
                            Member.parameter_yp = params1;
                            break;
                        case 3:
                            Member.parameter_jsd = params1;
                            break;
                        case 4:
                            Member.parameter_zhtb = params1;
                            break;
                        case 5:
                            Member.parameter_tc = params1;
                            break;
                        case 6:
                            Member.parameter_swzy = params1;
                            break;
                        case 7:
                            Member.parameter_hj = params1;
                            break;
                        case 8:
                            Member.parameter_gly = params1;
                            break;
                        case 9:
                            Member.parameter_wwz = params1;

                            break;
                        default:
                            //Member.parameter_wwz = params1;
                            break;

                    }
                }
            }
            
            catch (System.Exception ex)
            {

            }
        

            /*case 1

                 Member.parameter_lg = params1;
            endswitc
            if (Convert.ToInt32(params1.StationNO) == 1)
            {
                Member.parameter_lg = params1;
            }

            if (Convert.ToInt32(params1.StationNO) == 2)
            {
                Member.parameter_yp = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 3)
            {
                Member.parameter_jsd = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 4)
            {
                Member.parameter_zhtb = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 5)
            {
                Member.parameter_tc = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 6)
            {
                Member.parameter_swzy = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 7)
            {
                Member.parameter_hj = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 8)
            {
                Member.parameter_gly = params1;
            }
            if (Convert.ToInt32(params1.StationNO) == 9)
            {
                Member.parameter_wwz = params1;
            }*/
            

            //frmobsdatall.FenpeiData(params1);

              //  判断是否大于1000，数据是否增加  biyonghrng  xinjia
  
               //if (params1.Hour==0 && params1.Minute==0)
               //{
               //    GHISum1000 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
               //    GTISum1000 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               //} 
               //else
               //{
               //    if (params1.GHI >= 1000 || params1.GTI >= 1000)
               //    {

               //        GHISum1000[params1.StationNO-1] = GHISum1000[params1.StationNO-1] + params1.GHI / 1000000*20;
               //        GTISum1000[params1.StationNO-1] = GTISum1000[params1.StationNO-1] + params1.GTI / 1000000*20;

               //        DAO.InsertData1000(params1,GHISum1000,GTISum1000);
               //    }
               //}
                  


               //////

                //MysqlConnection.InsertToDb(params1);
                //InsertFirstDataDao.readHistoryData();
                //Ms_SQLDAO.InsertToDb(params1);
                
            //}


            if (stationName == selectStationNo)
            {
                MethodInvoker mi = new MethodInvoker(SetControlsProp);
                BeginInvoke(mi);
            }

        }



        private void SetControlsProp()
        {
            try
            {
                lblTime.Text = @"观测站" + params1.StationName + "观测时间： " + params1.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");

                GaugePointer pointerGHI = GetLinearPointer(gc_GHI, "Scale1", "Pointer1");
                if (pointerGHI != null)
                    pointerGHI.Value = params1.GHI;
                tbGHI.Text = params1.GHI.ToString();


                GaugePointer pointerGTI = GetLinearPointer(gc_GTI, "Scale1", "Pointer1");
                if (pointerGTI != null)
                    pointerGTI.Value = params1.GTI;
                tBGTI.Text = params1.GTI.ToString();


                GaugePointer pointerPanleTemp = GetLinearPointer(gcPanleTemp, "Scale1", "Pointer1");
                if (pointerPanleTemp != null)
                    pointerPanleTemp.Value = params1.PanleTemp;
                tBPanleTemp.Text = params1.PanleTemp.ToString();

                GaugePointer pointerTemperature = GetLinearPointer(gcTemperature, "Scale1", "Pointer1");
                if (pointerTemperature != null)
                    pointerTemperature.Value = params1.Temperature;
                tBTemperature.Text = params1.Temperature.ToString();

                GaugePointer pointerHumitity = GetLinearPointer(gcHumitity, "Scale1", "Pointer1");
                if (pointerHumitity != null)
                    pointerHumitity.Value = params1.Humitity;
                tBHumitity.Text = params1.Humitity.ToString();


                GaugePointer pointerGHISum = GetLinearPointer(gcGHISum, "Scale1", "Pointer1");
                if (pointerGHISum != null)
                    pointerGHISum.Value = params1.GHISum;
                tBGHISum.Text = params1.GHISum.ToString();
                
                GaugePointer pointerGTISum = GetLinearPointer(gcGTISum, "Scale1", "Pointer1");
                if (pointerGTISum != null)
                    pointerGTISum.Value = params1.GTISum;
                tBGTIsum.Text = params1.GTISum.ToString();

                GaugePointer pointerFx = gcFX.CircularScales["Scale1"].Pointers["Pointer1"];
                if (pointerFx != null)
                    pointerFx.Value = params1.WindDir;
                tbWindDirection.Text = params1.WindDir.ToString();


                GaugePointer pointerWindspeed = gcFengsu.CircularScales["Scale1"].Pointers["Pointer1"];
                    //GetLinearPointer(gcFengsu, "Scale1", "Pointer1"); 
       
             if (pointerWindspeed != null)
                    pointerWindspeed.Value = params1.WindSpeed;
                tbWindspeed.Text = params1.WindSpeed.ToString();




                //////////////////////////////////////////////////////////////////////////

                GaugePointer pointerGHISum1000 = GetLinearPointer(gCGHISum1000, "Scale1", "Pointer1");
                if (pointerGHISum1000 != null)
                    pointerGHISum1000.Value = GHISum1000[params1.StationNO-1];
                tBGHISum1000.Text = GHISum1000[params1.StationNO-1].ToString();

                GaugePointer pointerGTISum1000 = GetLinearPointer(gCGTISum1000, "Scale1", "Pointer1");
                if (pointerGTISum1000 != null)
                    pointerGTISum1000.Value = GTISum1000[params1.StationNO-1];
                tBGTISum1000.Text = GTISum1000[params1.StationNO-1].ToString();


                ////////////

            
           }
            catch (System.Exception ex)
            {

            }

        }


        private GaugePointer GetLinearPointer(GaugeControl gauge, string sname, string pname)
        {
            GaugeScale scale = gauge.LinearScales[sname];

            return (scale != null ? scale.Pointers[pname] : null);
        }



        private string GetEquipNo(string comName)
        {
            foreach (EquipInfo info in equiplist)
            {
                if (info.ComName == comName)
                    return info.EquipNo;
            }
            return "";
        }

        private string GetStationNo(string comName)
        {
            foreach (EquipInfo info in equiplist)
            {
                if (info.ComName == comName)
                    return info.StationNo;
            }
            return "";
        }

        private void frmObsSS_Load(object sender, EventArgs e)
        {
            equiplist = XML_DAO.GetFromXML();
            BindCmbEquip(equiplist);



        }
        private void BindCmbEquip(List<EquipInfo> list)
        {
            cmbEquip.Items.Clear();
            foreach (EquipInfo info in equiplist)
            {
                cmbEquip.Items.Add(info.EquipNo);
            }
            if (cmbEquip.Items.Count > 0)
                cmbEquip.SelectedIndex = 0;
        }



        private void cmbEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectStationNo = cmbEquip.Text;
            SendCommandData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendCommandData();
        }

        private void tbWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel10_Click(object sender, EventArgs e)
        {

        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel7_Click(object sender, EventArgs e)
        {

        }

        private void gcWendu_Click(object sender, EventArgs e)
        {

        }

        private void gcGHI_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void gcLoudian_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void gcBatteryVolt_Click(object sender, EventArgs e)
        {

        }

        private void gcPress_Click(object sender, EventArgs e)
        {

        }

        private void tbFX_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel8_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel5_Click(object sender, EventArgs e)
        {

        }

        private void gcGHIsum_Click(object sender, EventArgs e)
        {

        }

        private void gcTemperature_Click(object sender, EventArgs e)
        {

        }

        private void tBhumitity_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel11_Click(object sender, EventArgs e)
        {

        }

        private void tbGHI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}