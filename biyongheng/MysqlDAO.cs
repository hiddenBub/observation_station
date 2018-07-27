using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace HainanDataCenter
{
    public class MysqlDAO
    {
        //   <add name="gpsstatus" connectionString="Server=localhost;User Id=root;Password=radar;Persist Security Info=True;Database=GPSNET;">


        public static int Insert2Db(ObsParams params1)
        {
            //"datasource=localhost;username=root;password=NCEPU_fluence.;database=topflag
            string connectionString = "Server=localhost;User Id=root;Password=123456789;Persist Security Info=True;Database=topflag;";
            MySqlConnection cn = new MySqlConnection(connectionString);
            //int EXIST = Exist(params1.StationName, params1.ObsTime);
            //if (EXIST==1)
            //{
                //return 0;
           // }
            int res = 0;
            try
            {//(   StationID) Values ( @StationID);

                string sql = @" 
                                insert into obsdata(StationName,StationNO,ObsTime,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum) 
                                values(@StationName,@StationNO,@ObsTime,@GHI,@GTI,@PanleTemp,@Temperature,@Humitity,@WindSpeed,@WindDir,@GHISum,@GTISum)";
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.Add(new MySqlParameter("@StationName", MySqlDbType.VarChar) { Value = params1.StationName });
                cmd.Parameters.Add(new MySqlParameter("@StationNO", MySqlDbType.Int32) { Value = params1.StationNO });
                cmd.Parameters.Add(new MySqlParameter("@ObsTime", MySqlDbType.DateTime) { Value = params1.ObsTime });

                cmd.Parameters.Add(new MySqlParameter("@GHI", MySqlDbType.Float) { Value = params1.GHI });
                cmd.Parameters.Add(new MySqlParameter("@GTI", MySqlDbType.Float) { Value = params1.GTI });
                cmd.Parameters.Add(new MySqlParameter("@PanleTemp", MySqlDbType.Float) { Value = params1.PanleTemp });
                cmd.Parameters.Add(new MySqlParameter("@Temperature", MySqlDbType.Float) { Value = params1.Temperature });

                cmd.Parameters.Add(new MySqlParameter("@Humitity", MySqlDbType.Float) { Value = params1.Humitity });
                cmd.Parameters.Add(new MySqlParameter("@WindSpeed", MySqlDbType.Float) { Value = params1.WindSpeed });
                cmd.Parameters.Add(new MySqlParameter("@WindDir", MySqlDbType.Float) { Value = params1.WindDir });
                cmd.Parameters.Add(new MySqlParameter("@GHISum", MySqlDbType.Float) { Value = params1.GHISum });
                cmd.Parameters.Add(new MySqlParameter("@GTISum", MySqlDbType.Float) { Value = params1.GTISum });

                cn.Open();
                res = cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                res = -1;
            }
            finally
            {

                cn.Close();
                cn.Dispose();
            }
            return res;

        }

        public static int Insert2Db1000(ObsParams params1,float[]GHISum1000 ,float[]GTISum1000 )
        {
            //"datasource=localhost;username=root;password=NCEPU_fluence.;database=topflag
            string connectionString = "Server=localhost;User Id=root;Password=123456789;Persist Security Info=True;Database=topflag;";
            MySqlConnection cn = new MySqlConnection(connectionString);
            //int EXIST = Exist(params1.StationName, params1.ObsTime);
            //if (EXIST==1)
            //{
            //return 0;
            // }
            int res = 0;
            try
            {//(   StationID) Values ( @StationID);

                string sql = @" 
                                insert into obsdata1000(StationName,StationNO,ObsTime,GHI,GTI,GHISum,GTISum,GHISum1000,GTISum1000) 
                                values(@StationName,@StationNO,@ObsTime,@GHI,@GTI,@GHISum,@GTISum,@GHISum1000,@GTISum1000)";
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.Add(new MySqlParameter("@StationName", MySqlDbType.VarChar) { Value = params1.StationName });
                cmd.Parameters.Add(new MySqlParameter("@StationNO", MySqlDbType.Int32) { Value = params1.StationNO });
                cmd.Parameters.Add(new MySqlParameter("@ObsTime", MySqlDbType.DateTime) { Value = params1.ObsTime });

                cmd.Parameters.Add(new MySqlParameter("@GHI", MySqlDbType.Float) { Value = params1.GHI });
                cmd.Parameters.Add(new MySqlParameter("@GTI", MySqlDbType.Float) { Value = params1.GTI });
                cmd.Parameters.Add(new MySqlParameter("@GHISum", MySqlDbType.Float) { Value = params1.GHISum });
                cmd.Parameters.Add(new MySqlParameter("@GTISum", MySqlDbType.Float) { Value = params1.GTISum });
                cmd.Parameters.Add(new MySqlParameter("@GHISum1000", MySqlDbType.Float) { Value = GHISum1000[params1.StationNO-1] });
                cmd.Parameters.Add(new MySqlParameter("@GTISum1000", MySqlDbType.Float) { Value = GTISum1000[params1.StationNO-1] });

                cn.Open();
                res = cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                res = -1;
            }
            finally
            {

                cn.Close();
                cn.Dispose();
            }
            return res;

        }

        public static DataTable SelectData(string stationName, DateTime starttime, DateTime endtime1)
        {
            //string connectionString = "Server=127.0.0.1;User Id=test;Password=test;Persist Security Info=True;Database=topflag;";

            string connectionString = "Server=localhost; User Id=root;Password=123456789;Persist Security Info=True;Database=topflag;";
            DataTable dt = new DataTable();
            string sql = @" SELECT ObsTime,StationNO,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum
                            FROM obsdata
                            where StationName =@StationName and obstime > @starttime and obstime<@endtime";
            MySqlConnection cn = new MySqlConnection(connectionString);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.Add(new MySqlParameter("@StationName", MySqlDbType.VarChar) { Value = stationName });
                cmd.Parameters.Add(new MySqlParameter("@starttime", MySqlDbType.DateTime) { Value = starttime });
                cmd.Parameters.Add(new MySqlParameter("@endtime", MySqlDbType.DateTime) { Value = endtime1 });

                cn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (System.Exception ex)
            {

            }
            finally { cn.Close(); cn.Dispose(); }
            return dt;
//            string connectionString = "Server=127.0.0.1;User Id=test;Password=test;Persist Security Info=True;Database=topflag;";
//            DataTable dt = new DataTable();
//            string sql = @" SELECT ObsTime,StationNO,GHI,GTI,PanleTemp,Temperature,Humitity,WindSpeed,WindDir,GHISum,GTISum
//                            FROM obsdata
//                            where StationName =@StationName and obstime > @starttime and obstime<@endtime";
//            MySqlConnection cn = new MySqlConnection(connectionString);
//            try
//            {
//                MySqlCommand cmd = new MySqlCommand(sql, cn);
//                cmd.Parameters.Add(new MySqlParameter("@StationName", MySqlDbType.VarChar) { Value = stationName });
//                cmd.Parameters.Add(new MySqlParameter("@starttime", MySqlDbType.DateTime) { Value = starttime });
//                cmd.Parameters.Add(new MySqlParameter("@endtime", MySqlDbType.DateTime) { Value = endtime1 });

//                cn.Open();
//                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
//                adp.Fill(dt);
//            }
//            catch (System.Exception ex)
//            {

//            }
//            finally { cn.Close(); cn.Dispose(); }
//            return dt;

        }



        public static int Exist(string stationName, DateTime starttime)
        {
            string connectionString = "Server=localhost;User Id=test;Password=test;Persist Security Info=True;Database=topflag;";
            string sql = @" SELECT  ObsTime 
                            FROM obsdata
                            where StationName =@StationNo and obstime = @starttime";//; //
            DataTable dtt = new DataTable(); ;

            int ret = 0;
            MySqlConnection cn = new MySqlConnection(connectionString);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.Add(new MySqlParameter("@StationName", MySqlDbType.VarChar) { Value = stationName });
                cmd.Parameters.Add(new MySqlParameter("@starttime", MySqlDbType.DateTime) { Value = starttime });

                cn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dtt);
                if (dtt != null && dtt.Rows.Count > 0) //
                    ret= 1;

                else ret= 0;
            }
            catch (System.Exception ex)
            {
                ret= -1;
            }
            finally { cn.Close(); cn.Dispose(); }

            return ret;

        }

    }
}
