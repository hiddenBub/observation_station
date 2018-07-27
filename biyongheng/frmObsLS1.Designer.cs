namespace HainanDataCenter
{
    partial class frmObsLS1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbEquip = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnOutputfile = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.设备编号 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem4 = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.obstime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanleTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WindDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Windspeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHISum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTISum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Controls.Add(this.labelX1);
            this.bar1.Controls.Add(this.cmbEquip);
            this.bar1.Controls.Add(this.dtPickerStart);
            this.bar1.Controls.Add(this.dtPickerEnd);
            this.bar1.Controls.Add(this.btnSearch);
            this.bar1.Controls.Add(this.btnOutputfile);
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.设备编号,
            this.controlContainerItem4,
            this.labelItem1,
            this.labelItem2,
            this.controlContainerItem2,
            this.labelItem4,
            this.controlContainerItem3,
            this.controlContainerItem5,
            this.controlContainerItem6});
            this.bar1.Location = new System.Drawing.Point(3, 4);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(851, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 18;
            this.bar1.TabStop = false;
            this.bar1.Text = "起始日期";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(134, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "                                 ";
            // 
            // cmbEquip
            // 
            this.cmbEquip.DisplayMember = "Text";
            this.cmbEquip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquip.FormattingEnabled = true;
            this.cmbEquip.ItemHeight = 18;
            this.cmbEquip.Location = new System.Drawing.Point(197, 2);
            this.cmbEquip.Name = "cmbEquip";
            this.cmbEquip.Size = new System.Drawing.Size(121, 24);
            this.cmbEquip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEquip.TabIndex = 16;
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.Location = new System.Drawing.Point(384, 3);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.Size = new System.Drawing.Size(115, 23);
            this.dtPickerStart.TabIndex = 18;
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Location = new System.Drawing.Point(559, 3);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(115, 23);
            this.dtPickerEnd.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(678, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOutputfile
            // 
            this.btnOutputfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOutputfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOutputfile.Location = new System.Drawing.Point(757, 3);
            this.btnOutputfile.Name = "btnOutputfile";
            this.btnOutputfile.Size = new System.Drawing.Size(75, 23);
            this.btnOutputfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOutputfile.TabIndex = 20;
            this.btnOutputfile.Text = "导出数据";
            this.btnOutputfile.Click += new System.EventHandler(this.btnOutputfile_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.labelX1;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // 设备编号
            // 
            this.设备编号.Name = "设备编号";
            this.设备编号.Text = "站点名称";
            // 
            // controlContainerItem4
            // 
            this.controlContainerItem4.AllowItemResize = false;
            this.controlContainerItem4.Control = this.cmbEquip;
            this.controlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem4.Name = "controlContainerItem4";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem3});
            this.labelItem2.Text = "起始日期";
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "起始日期";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.dtPickerStart;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "终止时间";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.dtPickerEnd;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // controlContainerItem5
            // 
            this.controlContainerItem5.AllowItemResize = false;
            this.controlContainerItem5.Control = this.btnSearch;
            this.controlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem5.Name = "controlContainerItem5";
            // 
            // controlContainerItem6
            // 
            this.controlContainerItem6.AllowItemResize = false;
            this.controlContainerItem6.Control = this.btnOutputfile;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // dataGridViewX1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obstime,
            this.StationNO,
            this.GHI,
            this.GTI,
            this.PanleTemp,
            this.Temperature,
            this.Humidity,
            this.WindDir,
            this.Windspeed,
            this.GHISum,
            this.GTISum});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(1010, 627);
            this.dataGridViewX1.TabIndex = 21;
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bar1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewX1);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 678);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 22;
            // 
            // obstime
            // 
            this.obstime.DataPropertyName = "obstime";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.obstime.DefaultCellStyle = dataGridViewCellStyle7;
            this.obstime.HeaderText = "观测时间";
            this.obstime.Name = "obstime";
            this.obstime.Width = 150;
            // 
            // StationNO
            // 
            this.StationNO.DataPropertyName = "StationNO";
            this.StationNO.HeaderText = "设备编号";
            this.StationNO.Name = "StationNO";
            this.StationNO.Width = 80;
            // 
            // GHI
            // 
            this.GHI.DataPropertyName = "GHI";
            this.GHI.HeaderText = "水平总辐射";
            this.GHI.Name = "GHI";
            this.GHI.Width = 80;
            // 
            // GTI
            // 
            this.GTI.DataPropertyName = "GTI";
            this.GTI.HeaderText = "倾斜辐射";
            this.GTI.Name = "GTI";
            this.GTI.Width = 80;
            // 
            // PanleTemp
            // 
            this.PanleTemp.DataPropertyName = "PanleTemp";
            this.PanleTemp.HeaderText = "背板温度";
            this.PanleTemp.Name = "PanleTemp";
            this.PanleTemp.Width = 80;
            // 
            // Temperature
            // 
            this.Temperature.DataPropertyName = "Temperature";
            this.Temperature.HeaderText = "温度";
            this.Temperature.Name = "Temperature";
            this.Temperature.Width = 80;
            // 
            // Humidity
            // 
            this.Humidity.DataPropertyName = "Humitity";
            this.Humidity.HeaderText = "湿度";
            this.Humidity.Name = "Humidity";
            this.Humidity.Width = 80;
            // 
            // WindDir
            // 
            this.WindDir.DataPropertyName = "WindDir";
            this.WindDir.HeaderText = "风向";
            this.WindDir.Name = "WindDir";
            this.WindDir.Width = 80;
            // 
            // Windspeed
            // 
            this.Windspeed.DataPropertyName = "WindSpeed";
            this.Windspeed.HeaderText = "风速";
            this.Windspeed.Name = "Windspeed";
            this.Windspeed.Width = 80;
            // 
            // GHISum
            // 
            this.GHISum.DataPropertyName = "GHISum";
            this.GHISum.HeaderText = "日累计总辐射";
            this.GHISum.Name = "GHISum";
            // 
            // GTISum
            // 
            this.GTISum.DataPropertyName = "GTISum";
            this.GTISum.HeaderText = "倾斜辐射日累计";
            this.GTISum.Name = "GTISum";
            // 
            // frmObsLS1
            // 
            this.ClientSize = new System.Drawing.Size(1010, 678);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmObsLS1";
            this.Text = "历史数据";
            this.Load += new System.EventHandler(this.frmObsLS1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEquip;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelItem 设备编号;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX btnOutputfile;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn obstime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanleTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WindDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Windspeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHISum;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTISum;
    }
}