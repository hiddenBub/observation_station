using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HainanDataCenter
{
    public partial class frmObsLS1 : DevComponents.DotNetBar.OfficeForm
    {
        List<EquipInfo> equiplist = null;
        public frmObsLS1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = DAO.SelectData(cmbEquip.Text, dtPickerStart.Value, dtPickerEnd.Value.AddDays(1));
            dataGridViewX1.DataSource = dt;

        }

        private void frmObsLS1_Load(object sender, EventArgs e)
        {
            equiplist = XML_DAO.GetFromXML();
            BindCmbEquip(equiplist);
            dtPickerStart.Value = DateTime.Today.AddDays(-1);
            DateTime now = DateTime.Now;
            dtPickerEnd.Value = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);

            dataGridViewX1.AutoGenerateColumns = false;
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

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOutputfile_Click(object sender, EventArgs e)
        {
         //   DAO.OutExcelFile(cmbEquip.Text, dtPickerStart.Value, dtPickerEnd.Value.AddDays(1));
            DAO.dataGridViewToCSV(dataGridViewX1);
        }


    }
}