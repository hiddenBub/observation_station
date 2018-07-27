namespace HainanDataCenter
{
    partial class frmEquipGL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipGL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rootNode = new DevComponents.AdvTree.Node();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbEquipNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbDbName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbBand = new System.Windows.Forms.ComboBox();
            this.cmbComm = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDisable = new System.Windows.Forms.ToolStripButton();
            this.dgvEquip = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.EquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipTilt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bandrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Databits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkEquip = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tbEquipLat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbEquipLong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.tbEquipTilt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.tbStationNO = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // rootNode
            // 
            this.rootNode.Name = "rootNode";
            this.rootNode.Text = "设备";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(39, 52);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(86, 23);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "站点名称：";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbEquipNo
            // 
            // 
            // 
            // 
            this.tbEquipNo.Border.Class = "TextBoxBorder";
            this.tbEquipNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEquipNo.Location = new System.Drawing.Point(131, 52);
            this.tbEquipNo.Name = "tbEquipNo";
            this.tbEquipNo.Size = new System.Drawing.Size(98, 21);
            this.tbEquipNo.TabIndex = 27;
            this.tbEquipNo.TextChanged += new System.EventHandler(this.tbEquipNo_TextChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(39, 125);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "数据库路径：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbDbName
            // 
            // 
            // 
            // 
            this.tbDbName.Border.Class = "TextBoxBorder";
            this.tbDbName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDbName.Enabled = false;
            this.tbDbName.Location = new System.Drawing.Point(131, 125);
            this.tbDbName.Name = "tbDbName";
            this.tbDbName.Size = new System.Drawing.Size(302, 21);
            this.tbDbName.TabIndex = 25;
            this.tbDbName.Text = "海南光伏自动站数据中心.accdb";
            this.tbDbName.TextChanged += new System.EventHandler(this.tbDbName_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(468, 54);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "串口号：";
            // 
            // cmbBand
            // 
            this.cmbBand.Items.AddRange(new object[] {
            "1200\t",
            "2400\t",
            "4800\t",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cmbBand.Location = new System.Drawing.Point(764, 54);
            this.cmbBand.Name = "cmbBand";
            this.cmbBand.Size = new System.Drawing.Size(98, 20);
            this.cmbBand.TabIndex = 22;
            // 
            // cmbComm
            // 
            this.cmbComm.FormattingEnabled = true;
            this.cmbComm.Location = new System.Drawing.Point(561, 52);
            this.cmbComm.Name = "cmbComm";
            this.cmbComm.Size = new System.Drawing.Size(98, 20);
            this.cmbComm.TabIndex = 21;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(683, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX2.Size = new System.Drawing.Size(76, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "波特率：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbAdd,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbDisable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 31);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(60, 28);
            this.tsbRefresh.Text = "刷新";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(60, 28);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.btnAddEquip_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 28);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbDisable
            // 
            this.tsbDisable.Image = ((System.Drawing.Image)(resources.GetObject("tsbDisable.Image")));
            this.tsbDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisable.Name = "tsbDisable";
            this.tsbDisable.Size = new System.Drawing.Size(60, 28);
            this.tsbDisable.Text = "保存";
            this.tsbDisable.Click += new System.EventHandler(this.tsbDisable_Click);
            // 
            // dgvEquip
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipNo,
            this.StationNo,
            this.EquipLat,
            this.EquipLong,
            this.EquipTilt,
            this.ComName,
            this.Column1,
            this.Bandrate,
            this.Databits});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquip.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEquip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEquip.EnableHeadersVisualStyles = false;
            this.dgvEquip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEquip.Location = new System.Drawing.Point(0, 170);
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquip.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEquip.RowTemplate.Height = 23;
            this.dgvEquip.Size = new System.Drawing.Size(909, 261);
            this.dgvEquip.TabIndex = 30;
            this.dgvEquip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquip_CellContentClick);
            // 
            // EquipNo
            // 
            this.EquipNo.HeaderText = "站点名称";
            this.EquipNo.Name = "EquipNo";
            this.EquipNo.ReadOnly = true;
            this.EquipNo.Width = 150;
            // 
            // StationNo
            // 
            this.StationNo.HeaderText = "设备编号";
            this.StationNo.Name = "StationNo";
            this.StationNo.ReadOnly = true;
            // 
            // EquipLat
            // 
            this.EquipLat.HeaderText = "纬度";
            this.EquipLat.Name = "EquipLat";
            this.EquipLat.ReadOnly = true;
            // 
            // EquipLong
            // 
            this.EquipLong.HeaderText = "经度";
            this.EquipLong.Name = "EquipLong";
            this.EquipLong.ReadOnly = true;
            // 
            // EquipTilt
            // 
            this.EquipTilt.HeaderText = "倾斜角度";
            this.EquipTilt.Name = "EquipTilt";
            this.EquipTilt.ReadOnly = true;
            // 
            // ComName
            // 
            this.ComName.HeaderText = "串口号";
            this.ComName.Name = "ComName";
            this.ComName.ReadOnly = true;
            this.ComName.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "启用";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Bandrate
            // 
            this.Bandrate.HeaderText = "波特率";
            this.Bandrate.Name = "Bandrate";
            this.Bandrate.ReadOnly = true;
            this.Bandrate.Width = 80;
            // 
            // Databits
            // 
            this.Databits.HeaderText = "数据库";
            this.Databits.Name = "Databits";
            this.Databits.ReadOnly = true;
            this.Databits.Width = 180;
            // 
            // chkEquip
            // 
            // 
            // 
            // 
            this.chkEquip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkEquip.Checked = true;
            this.chkEquip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEquip.CheckValue = "Y";
            this.chkEquip.Location = new System.Drawing.Point(562, 127);
            this.chkEquip.Name = "chkEquip";
            this.chkEquip.Size = new System.Drawing.Size(100, 23);
            this.chkEquip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkEquip.TabIndex = 31;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(470, 125);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(58, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "启用：";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(39, 91);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(86, 23);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "纬度：";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(257, 91);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(65, 23);
            this.labelX7.TabIndex = 34;
            this.labelX7.Text = "经度：";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX7.Click += new System.EventHandler(this.labelX7_Click);
            // 
            // tbEquipLat
            // 
            // 
            // 
            // 
            this.tbEquipLat.Border.Class = "TextBoxBorder";
            this.tbEquipLat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEquipLat.Location = new System.Drawing.Point(131, 88);
            this.tbEquipLat.Name = "tbEquipLat";
            this.tbEquipLat.Size = new System.Drawing.Size(98, 21);
            this.tbEquipLat.TabIndex = 35;
            // 
            // tbEquipLong
            // 
            // 
            // 
            // 
            this.tbEquipLong.Border.Class = "TextBoxBorder";
            this.tbEquipLong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEquipLong.Location = new System.Drawing.Point(343, 91);
            this.tbEquipLong.Name = "tbEquipLong";
            this.tbEquipLong.Size = new System.Drawing.Size(98, 21);
            this.tbEquipLong.TabIndex = 36;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(470, 90);
            this.labelX8.Name = "labelX8";
            this.labelX8.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX8.Size = new System.Drawing.Size(89, 23);
            this.labelX8.TabIndex = 37;
            this.labelX8.Text = "倾斜角度：";
            this.labelX8.Click += new System.EventHandler(this.labelX8_Click);
            // 
            // tbEquipTilt
            // 
            // 
            // 
            // 
            this.tbEquipTilt.Border.Class = "TextBoxBorder";
            this.tbEquipTilt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEquipTilt.Location = new System.Drawing.Point(562, 88);
            this.tbEquipTilt.Name = "tbEquipTilt";
            this.tbEquipTilt.Size = new System.Drawing.Size(98, 21);
            this.tbEquipTilt.TabIndex = 38;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(257, 51);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(79, 23);
            this.labelX9.TabIndex = 39;
            this.labelX9.Text = "站点编号：";
            this.labelX9.Click += new System.EventHandler(this.labelX9_Click);
            // 
            // tbStationNO
            // 
            // 
            // 
            // 
            this.tbStationNO.Border.Class = "TextBoxBorder";
            this.tbStationNO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbStationNO.Location = new System.Drawing.Point(342, 54);
            this.tbStationNO.Name = "tbStationNO";
            this.tbStationNO.Size = new System.Drawing.Size(98, 21);
            this.tbStationNO.TabIndex = 40;
            this.tbStationNO.TextChanged += new System.EventHandler(this.tbStationNO_TextChanged);
            // 
            // frmEquipGL
            // 
            this.ClientSize = new System.Drawing.Size(909, 431);
            this.Controls.Add(this.tbStationNO);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.tbEquipTilt);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.tbEquipLong);
            this.Controls.Add(this.tbEquipLat);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.chkEquip);
            this.Controls.Add(this.dgvEquip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.tbEquipNo);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbDbName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbComm);
            this.Controls.Add(this.cmbBand);
            this.DoubleBuffered = true;
            this.Name = "frmEquipGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理";
            this.Load += new System.EventHandler(this.frmEquipGL_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
 
        private DevComponents.AdvTree.Node rootNode;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEquipNo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDbName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cmbBand;
        private System.Windows.Forms.ComboBox cmbComm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDisable;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvEquip;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkEquip;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEquipLat;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEquipLong;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEquipTilt;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tbStationNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipTilt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bandrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Databits;
    }
}