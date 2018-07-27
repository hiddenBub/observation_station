using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.IO.Ports;
using DevComponents.DotNetBar;

namespace HainanDataCenter
{



    public partial class Form2 : Office2007RibbonForm
    {
        // public event EventHandler<SerialHelperEventArgs> ReceiveData;

        List<EquipInfo> equipList = new List<EquipInfo>();
        List<System.IO.Ports.SerialPort> PortList = new List<System.IO.Ports.SerialPort>();

        DateTime nowtimeH;
        DateTime pretimeH;
        public class Global 
        {  public float[] GHISum1000 = new float[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
           public float[] GTISum1000 = new float[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
        }
      
        public Form2()
        {
            InitializeComponent();
        }

      
        private void btnObsSS_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(typeof(frmObsLS));
        }

        private void btnEquipGL_Click(object sender, EventArgs e)
        {
            //this.OpenChildForm(typeof(frmEquipGL));
            frmEquipGL frm = new frmEquipGL(equipList);
            frm.ShowDialog();
            equipList  = XML_DAO.GetFromXML();
 
        }


        private void OpenChildForm(Type childType)
        {
            bool isOpened = false;
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == childType)
                {
                    child.Activate();
                    isOpened = true;
                    break;
                }
            }
            if (!isOpened)
            {
                //动态生成一个类型的实例
                Form childFrm = (Form)Activator.CreateInstance(childType);
                childFrm.MdiParent = this;
                childFrm.WindowState = FormWindowState.Maximized;
                childFrm.Show();
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(typeof(frmObsLS1));

        }

     




        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Form2_Load(object sender, EventArgs e)
        {
            nowtimeH = DateTime.Today.AddHours(DateTime.Now.Hour);
            pretimeH = nowtimeH;
            equipList = XML_DAO.GetFromXML();   
            
        }

        private void btnService_Click(object sender, EventArgs e)
        {

            btnServiceStop.Enabled = true;
            btnService.Enabled = false;

            OpenChildForm(typeof(frmObsLS));
            //InsertFirstData.readHistoryData();

            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == typeof(frmObsLS))
                {
                    ((frmObsLS)child).StartSerialSerial(equipList);
                    break;
                }
            }
        }

        private void btnServiceStop_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == typeof(frmObsLS))
                {
                    ((frmObsLS)child).StopSerialSerial();;
                    break;
                }
            } btnServiceStop.Enabled = false;
            btnService.Enabled = true;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
         //   new Write2TXT().save(equipList, DateTime.Now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtimeH = DateTime.Today.AddHours(DateTime.Now.Hour);
            if (nowtimeH>pretimeH)
            {
               // Write2TXT.save(equipList, nowtimeH);
              //  pretimeH = nowtimeH;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(typeof(frmobsdatall));
        }

  

       // private void btnObsData_Click(object sender, EventArgs e)
        //{
           // this.OpenChildForm(typeof(frmObsData));
        //}
       
    }
}