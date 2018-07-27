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
    public partial class frmobsdatall : Form
        
    {
        ObsParams params1 = new ObsParams();
        
        public frmobsdatall()
        {
            InitializeComponent();
        }

        private void frmobsdatall_Load(object sender, EventArgs e)
        {
        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
                //临高站
               textBoxX1.Text = Member.parameter_lg.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX2.Text = Member.parameter_lg.GHI.ToString();
               textBoxX3.Text = Member.parameter_lg.GTI.ToString();
               textBoxX4.Text = Member.parameter_lg.PanleTemp.ToString();
               textBoxX5.Text = Member.parameter_lg.Temperature.ToString();
               textBoxX6.Text = Member.parameter_lg.Humitity.ToString();
               textBoxX7.Text = Member.parameter_lg.WindDir.ToString();
               textBoxX8.Text = Member.parameter_lg.WindSpeed.ToString();
               textBoxX9.Text = Member.parameter_lg.GHISum.ToString();
               textBoxX10.Text = Member.parameter_lg.GTISum.ToString();
                // 洋浦
               textBoxX11.Text = Member.parameter_yp.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX12.Text = Member.parameter_yp.GHI.ToString();
               textBoxX13.Text = Member.parameter_yp.GTI.ToString();
               textBoxX14.Text = Member.parameter_yp.PanleTemp.ToString();
               textBoxX15.Text = Member.parameter_yp.Temperature.ToString();
               textBoxX16.Text = Member.parameter_yp.Humitity.ToString();
               textBoxX17.Text = Member.parameter_yp.WindDir.ToString();
               textBoxX18.Text = Member.parameter_yp.WindSpeed.ToString();
               textBoxX19.Text = Member.parameter_yp.GHISum.ToString();
               textBoxX20.Text = Member.parameter_yp.GTISum.ToString();

              //金盛达
               textBoxX21.Text = Member.parameter_jsd.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX22.Text = Member.parameter_jsd.GHI.ToString();
               textBoxX23.Text = Member.parameter_jsd.GTI.ToString();
               textBoxX24.Text = Member.parameter_jsd.PanleTemp.ToString();
               textBoxX25.Text = Member.parameter_jsd.Temperature.ToString();
               textBoxX26.Text = Member.parameter_jsd.Humitity.ToString();
               textBoxX27.Text = Member.parameter_jsd.WindDir.ToString();
               textBoxX28.Text = Member.parameter_jsd.WindSpeed.ToString();
               textBoxX29.Text = Member.parameter_jsd.GHISum.ToString();
               textBoxX30.Text = Member.parameter_jsd.GTISum.ToString();
              //中航特玻
               textBoxX31.Text = Member.parameter_zhtb.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX32.Text = Member.parameter_zhtb.GHI.ToString();
               textBoxX33.Text = Member.parameter_zhtb.GTI.ToString();
               textBoxX34.Text = Member.parameter_zhtb.PanleTemp.ToString();
               textBoxX35.Text = Member.parameter_zhtb.Temperature.ToString();
               textBoxX36.Text = Member.parameter_zhtb.Humitity.ToString();
               textBoxX37.Text = Member.parameter_zhtb.WindDir.ToString();
               textBoxX38.Text = Member.parameter_zhtb.WindSpeed.ToString();
               textBoxX39.Text = Member.parameter_zhtb.GHISum.ToString();
               textBoxX40.Text = Member.parameter_zhtb.GTISum.ToString();
               //屯昌
               textBoxX41.Text = Member.parameter_tc.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX42.Text = Member.parameter_tc.GHI.ToString();
               textBoxX43.Text = Member.parameter_tc.GTI.ToString();
               textBoxX44.Text = Member.parameter_tc.PanleTemp.ToString();
               textBoxX45.Text = Member.parameter_tc.Temperature.ToString();
               textBoxX46.Text = Member.parameter_tc.Humitity.ToString();
               textBoxX47.Text = Member.parameter_tc.WindDir.ToString();
               textBoxX48.Text = Member.parameter_tc.WindSpeed.ToString();
               textBoxX49.Text = Member.parameter_tc.GHISum.ToString();
               textBoxX50.Text = Member.parameter_tc.GTISum.ToString();
               //生物资源
               textBoxX51.Text = Member.parameter_swzy.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX52.Text = Member.parameter_swzy.GHI.ToString();
               textBoxX53.Text = Member.parameter_swzy.GTI.ToString();
               textBoxX54.Text = Member.parameter_swzy.PanleTemp.ToString();
               textBoxX55.Text = Member.parameter_swzy.Temperature.ToString();
               textBoxX56.Text = Member.parameter_swzy.Humitity.ToString();
               textBoxX57.Text = Member.parameter_swzy.WindDir.ToString();
               textBoxX58.Text = Member.parameter_swzy.WindSpeed.ToString();
               textBoxX59.Text = Member.parameter_swzy.GHISum.ToString();
               textBoxX60.Text = Member.parameter_swzy.GTISum.ToString();
              //海建
               textBoxX61.Text = Member.parameter_hj.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX62.Text = Member.parameter_hj.GHI.ToString();
               textBoxX63.Text = Member.parameter_hj.GTI.ToString();
               textBoxX64.Text = Member.parameter_hj.PanleTemp.ToString();
               textBoxX65.Text = Member.parameter_hj.Temperature.ToString();
               textBoxX66.Text = Member.parameter_hj.Humitity.ToString();
               textBoxX67.Text = Member.parameter_hj.WindDir.ToString();
               textBoxX68.Text = Member.parameter_hj.WindSpeed.ToString();
               textBoxX69.Text = Member.parameter_hj.GHISum.ToString();
               textBoxX70.Text = Member.parameter_hj.GTISum.ToString();
               //桂林洋
               textBoxX71.Text = Member.parameter_gly.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX72.Text = Member.parameter_gly.GHI.ToString();
               textBoxX73.Text = Member.parameter_gly.GTI.ToString();
               textBoxX74.Text = Member.parameter_gly.PanleTemp.ToString();
               textBoxX75.Text = Member.parameter_gly.Temperature.ToString();
               textBoxX76.Text = Member.parameter_gly.Humitity.ToString();
               textBoxX77.Text = Member.parameter_gly.WindDir.ToString();
               textBoxX78.Text = Member.parameter_gly.WindSpeed.ToString();
               textBoxX79.Text = Member.parameter_gly.GHISum.ToString();
               textBoxX80.Text = Member.parameter_gly.GTISum.ToString();
               //王五镇
               textBoxX81.Text = Member.parameter_wwz.ObsTime.ToString("yyyy-MM-dd HH:mm:ss");
               textBoxX82.Text = Member.parameter_wwz.GHI.ToString();
               textBoxX83.Text = Member.parameter_wwz.GTI.ToString();
               textBoxX84.Text = Member.parameter_wwz.PanleTemp.ToString();
               textBoxX85.Text = Member.parameter_wwz.Temperature.ToString();
               textBoxX86.Text = Member.parameter_wwz.Humitity.ToString();
               textBoxX87.Text = Member.parameter_wwz.WindDir.ToString();
               textBoxX88.Text = Member.parameter_wwz.WindSpeed.ToString();
               textBoxX89.Text = Member.parameter_wwz.GHISum.ToString();
               textBoxX90.Text = Member.parameter_wwz.GTISum.ToString();
        }

        private void tBHumitity_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX20_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX12_Click(object sender, EventArgs e)
        {

        }


           
    }
}
