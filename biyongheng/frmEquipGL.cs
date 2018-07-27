using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
namespace HainanDataCenter
{
    public partial class frmEquipGL : DevComponents.DotNetBar.Office2007Form
    {
        public List<EquipInfo> equipList = new List<EquipInfo>();
        public frmEquipGL()
        {
            InitializeComponent();
        }
        public frmEquipGL(List<EquipInfo> equipList1)
        {
            InitializeComponent();
            equipList = equipList1;
        }
        private void btnAddEquip_Click(object sender, EventArgs e)
        {;

            string EquipNo = tbEquipNo.Text.Trim();
            string StationNo = tbStationNO.Text.Trim();
            string ComName = cmbComm.Text;
            string BandRate = cmbBand.SelectedItem.ToString();
            string EquipLat = tbEquipLat.Text.Trim();
            string EquipLong = tbEquipLong.Text.Trim();
            string EQuipTilt = tbEquipTilt.Text.Trim();

            if (EquipNo == "")
            {
                MessageBox.Show("设备编号不能为空！");
                return;
            }


            if (StationNo == "")
            {
                MessageBox.Show("站点编号不能为空！");
                return;
            }


            foreach (EquipInfo einfo in equipList)
            {
                if (einfo.StationNo == StationNo)
                {
                    MessageBox.Show("设备已存在！");
                    return;
                }
            }

            foreach (EquipInfo einfo in equipList)
            {
                if (einfo.EquipNo == EquipNo)
                {
                    MessageBox.Show("设备已存在！");
                    return;
                }
            }
            foreach (EquipInfo einfo in equipList)
            {
                if (einfo.ComName == ComName)
                {
                    MessageBox.Show("该串口已被其他设备使用！");
                    return;
                }
            }

            EquipInfo info = new EquipInfo();
            info.StationNo = StationNo;
            info.ComName = ComName;
            info.EquipNo = EquipNo;
            info.EquipLat = EquipLat;
            info.EquipLong = EquipLong;
            info.EquipTilt = EQuipTilt;
            info.IsUsed = chkEquip.Checked;
            info.BandRate = BandRate;
            info.dbName = tbDbName.Text.Trim();
            equipList.Add(info);
            equipList.Sort(new EquipInfoCompare());

            dgvEquipBind(equipList);

        }

        private void dgvEquipBind(List<EquipInfo> elist)
        {
            dgvEquip.Rows.Clear();
            foreach (EquipInfo model in elist)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = model.EquipNo;
                row.Cells.Add(cell);


                cell = new DataGridViewTextBoxCell();
                cell.Value = model.StationNo;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = model.EquipLat;
                row.Cells.Add(cell);


                cell = new DataGridViewTextBoxCell();
                cell.Value = model.EquipLong;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = model.EquipTilt;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = model.ComName;
                row.Cells.Add(cell);

                cell = new DataGridViewCheckBoxCell();
                cell.Value = model.IsUsed ? true : false;
                row.Cells.Add(cell);


                cell = new DataGridViewTextBoxCell();
                cell.Value = model.BandRate;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = model.dbName;
                row.Cells.Add(cell);

                this.dgvEquip.Rows.Add(row);
                row.Tag = model;

            }
        }


        private void frmEquipGL_Load(object sender, EventArgs e)
        {

            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                cmbComm.Items.Add(name);
            }
            //cmbBand.Text = "9600";
            dgvEquipBind(equipList);
        }

        private void tbEquipNo_TextChanged(object sender, EventArgs e)
        {
          //  tbDbName.Text = "\\Data\\" + tbEquipNo.Text + @".accdb";
        }

        private void tsbDisable_Click(object sender, EventArgs e)
        {
            XML_DAO.Save2XML(equipList);
            string datapath = Application.StartupPath + "\\data";
            
//             if (!Directory.Exists(datapath))
//                 Directory.CreateDirectory(datapath);
//             try
//             {
//                 foreach (EquipInfo info in equipList)
//                 {
//                     string newfilename = Application.StartupPath + info.dbName;
//                     string backupname = Application.StartupPath + "\\backup\\hh.accdb";
//                     if(!File.Exists(newfilename))
//                         File.Copy(backupname, newfilename);
//                 }
//             }
//             catch (Exception ex)
//             {
//                 MessageBox.Show("创建数据库失败！！");
//             }

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvEquip.SelectedRows)
            {
                EquipInfo info =(EquipInfo) r.Tag;
                equipList.Remove(info);
                dgvEquip.Rows.Remove(r);
            }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvEquip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void tbStationNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}