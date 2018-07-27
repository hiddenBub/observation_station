using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace HainanDataCenter
{
    public class DAO
    {
        //static string conn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=海南光伏自动站数据中心.accdb; User Id=admin; Password=";// System.Configuration.ConfigurationManager.ConnectionStrings["AccessConStr"].ConnectionString;

        public static int InsertData(ObsParams params1)
        {   
            int ret = MysqlDAO.Insert2Db(params1);
            return ret;
        /*    string sql = @" insert into obsdata(StationName,StationNO,ObsTime,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum) 
                            values(@StationName,@StationNO,@ObsTime,@GHI,@GTI,@PanleTemp,@Temperature,@Humitity,@WindSpeed,@WindDir,@GHISum,@GTISum)
                          
                            ";
                         
            try
            {
                List<OleDbParameter> paramList = new List<OleDbParameter>();
                paramList.Add(new OleDbParameter("@StationName", params1.StationName));
                paramList.Add(new OleDbParameter("@StationNO", params1.StationNO));
                paramList.Add(new OleDbParameter("@ObsTime", params1.ObsTime));
                paramList.Add(new OleDbParameter("@GHI", params1.GHI));
                paramList.Add(new OleDbParameter("@GTI", params1.GTI));
                paramList.Add(new OleDbParameter("@PanleTemp", params1.PanleTemp));
                paramList.Add(new OleDbParameter("@Temperature", params1.Temperature));
                paramList.Add(new OleDbParameter("@Humitity", params1.Humitity));
                paramList.Add(new OleDbParameter("@WindSpeed", params1.WindSpeed));
                paramList.Add(new OleDbParameter("@WindDir", params1.WindDir));
                paramList.Add(new OleDbParameter("@GHISum", params1.GHISum));
                paramList.Add(new OleDbParameter("@GTISum", params1.GTISum));
           
                return AccessHelper.ExecuteNonQuery(conn, sql, paramList.ToArray());
            }
            catch (System.Exception ex)
            {
                return 0;
            }*/

        }



        public static int InsertData1000(ObsParams params1,float[] GHISum1000,float[]GTISum1000 )
        {
            int ret = MysqlDAO.Insert2Db1000(params1, GHISum1000, GTISum1000);
            return ret;
            /*    string sql = @" insert into obsdata(StationName,StationNO,ObsTime,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum) 
                                values(@StationName,@StationNO,@ObsTime,@GHI,@GTI,@PanleTemp,@Temperature,@Humitity,@WindSpeed,@WindDir,@GHISum,@GTISum)
                          
                                ";
                         
                try
                {
                    List<OleDbParameter> paramList = new List<OleDbParameter>();
                    paramList.Add(new OleDbParameter("@StationName", params1.StationName));
                    paramList.Add(new OleDbParameter("@StationNO", params1.StationNO));
                    paramList.Add(new OleDbParameter("@ObsTime", params1.ObsTime));
                    paramList.Add(new OleDbParameter("@GHI", params1.GHI));
                    paramList.Add(new OleDbParameter("@GTI", params1.GTI));
                    paramList.Add(new OleDbParameter("@PanleTemp", params1.PanleTemp));
                    paramList.Add(new OleDbParameter("@Temperature", params1.Temperature));
                    paramList.Add(new OleDbParameter("@Humitity", params1.Humitity));
                    paramList.Add(new OleDbParameter("@WindSpeed", params1.WindSpeed));
                    paramList.Add(new OleDbParameter("@WindDir", params1.WindDir));
                    paramList.Add(new OleDbParameter("@GHISum", params1.GHISum));
                    paramList.Add(new OleDbParameter("@GTISum", params1.GTISum));
           
                    return AccessHelper.ExecuteNonQuery(conn, sql, paramList.ToArray());
                }
                catch (System.Exception ex)
                {
                    return 0;
                }*/

        }


        public static DataTable SelectData(string stationName, DateTime starttime, DateTime endtime1)
        {
            DataTable dt = MysqlDAO.SelectData(stationName, starttime, endtime1);
            return dt;
//            string sql = @" SELECT ObsTime,StationNO,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum
//                            FROM obsdata
//                            where StationName =@StationName and obstime > @starttime and obstime<@endtime";//; //
//            DataTable dt = null;
//            try
//            {//equipno=@equipnoand
//                List<OleDbParameter> paramList = new List<OleDbParameter>();
//                paramList.Add(new OleDbParameter("@StationName", stationName));
//                paramList.Add(new OleDbParameter("@starttime", starttime));
//                paramList.Add(new OleDbParameter("@endtime", endtime1));
//                DataSet ds = AccessHelper.ExecuteDataSet(conn, sql, paramList.ToArray());//
//                dt = ds.Tables[0];

//            }
//            catch (System.Exception ex)
//            {

//            }
//            return dt;
        }


        public static int Exist(string stationNO, DateTime starttime)
        {
            int ret = MysqlDAO.Exist(stationNO, starttime);
            return ret;
//            string sql = @" SELECT  ObsTime 
//                            FROM obsdata
//                            where StationName =@StationName and obstime = @starttime";//; //
//            DataTable dt = null;
//            try
//            {    //equipno=@equipnoand
//                List<OleDbParameter> paramList = new List<OleDbParameter>();
//                paramList.Add(new OleDbParameter("@StationName", stationName));
//                paramList.Add(new OleDbParameter("@starttime", starttime));

//                DataSet ds = AccessHelper.ExecuteDataSet(conn, sql, paramList.ToArray());//
//                dt = ds.Tables[0];
//                if (dt != null && dt.Rows.Count > 0)
//                {
//                    return 1;
//                }
//                else return 0;
//            }
//            catch (System.Exception ex)
//            {
//                return -1;
//            }
         
        }


        public static int OutExcelFile(string stationName, DateTime starttime, DateTime endtime1)
        {
            
            OleDbConnection con = new OleDbConnection();
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ("Excel 文件(*.xls)|*.xls");//指定文件后缀名为Excel 文件。
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFile.FileName;
                    if (System.IO.File.Exists(filename))
                    {
                        System.IO.File.Delete(filename);//如果文件存在删除文件。
                    }
                    int index = filename.LastIndexOf("//");//获取最后一个/的索引
                    filename = filename.Substring(index + 1);//获取excel名称(新建表的路径相对于SaveFileDialog的路径)
                    //select * into 建立 新的表。
                    //[[Excel 8.0;database= excel名].[sheet名] 如果是新建sheet表不能加$,如果向sheet里插入数据要加$.　
                    //sheet最多存储65535条数据。
                   // string sql = @" SELECT ObsTime,StationNO,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum
                                    //into [Excel 8.0;database=" + filename + "].[sheet1] from obsdata where StationName =@StationName and obstime > @starttime and obstime<@endtime";
                    string sql = "select top 65535 *  into   [Excel 8.0;database=" + filename + "].[sheet1] from obsdata ";
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=海南光伏自动站数据中心.accdb; User Id=admin; Password=";// +Application.StartupPath + "//Appdata.mdb";//将<a href="http://lib.csdn.net/base/14" class='replace_word' title="MySQL知识库" target='_blank' style='color:#df3434; font-weight:bold;'>数据库</a>放到debug目录下。
                    OleDbCommand com =  new System.Data.OleDb.OleDbCommand(sql  ,con);
                    con.Open();
                    com.ExecuteNonQuery();

                    MessageBox.Show("导出数据成功", "导出数据", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return 0;
        }


        public static bool dataGridViewToCSV(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("没有数据可导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.FileName = null;
            saveFileDialog.Title = "保存";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.GetEncoding(-0));
                string strLine = "";
                try
                {
                    //表头
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        if (i > 0)
                            strLine += ",";
                        strLine += dataGridView.Columns[i].HeaderText;
                    }
                    strLine.Remove(strLine.Length - 1);
                    sw.WriteLine(strLine);
                    strLine = "";
                    //表的内容
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        strLine = "";
                        int colCount = dataGridView.Columns.Count;
                        for (int k = 0; k < colCount; k++)
                        {
                            if (k > 0 && k < colCount)
                                strLine += ",";
                            if (dataGridView.Rows[j].Cells[k].Value == null)
                                strLine += "";
                            else
                            {
                                string cell = dataGridView.Rows[j].Cells[k].Value.ToString().Trim();
                                //防止里面含有特殊符号
                                cell = cell.Replace("\"", "\"\"");
                                cell = "\"" + cell + "\"";
                                strLine += cell;
                            }
                        }
                        sw.WriteLine(strLine);
                    }
                    sw.Close();
                    stream.Close();
                    MessageBox.Show("数据被导出到：" + saveFileDialog.FileName.ToString(), "导出完毕", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "导出错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

    }
}
