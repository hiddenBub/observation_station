using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace HainanDataCenter
{
    public class Common
    {

        public static ObsParams GetObsParams(byte[] data1)
        {
            ObsParams param = null;
            using (MemoryStream memoryStream = new MemoryStream(data1))
            {
                try
                {
                    BinaryReader br = new BinaryReader(memoryStream);
                    br.ReadBytes(2);
                    int Count = Convert.ToInt32(br.ReadByte());
                    if (Count < 20)
                        return null;
                 
                    param = new ObsParams();
                    //param.EquipNO = Convert.ToInt32(ChangeXL(br.ReadSingle())).ToString();
                    //param.StationNO = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Year = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Month = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Day = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Hour = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Minute = Convert.ToInt32(ChangeXL(br.ReadSingle()));
                    //param.Second= Convert.ToInt32(ChangeXL(br.ReadSingle()));

                    param.GHISum = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()))/1000;
                    param.GTISum = Convert.ToSingle(ChangeXLU16(br.ReadUInt16 ()))/1000;
                    param.PanleTemp = Convert.ToSingle(ChangeXL16(br.ReadInt16()))/10;
                    param.Temperature = Convert.ToSingle(ChangeXL16(br.ReadInt16()))/10;
                    param.Humitity = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()))/10;
                    param.WindSpeed = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()))/10;
                    param.WindSpeed = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()))/10;
                    param.WindDir = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()));
                    param.GHI = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()));
                    param.GTI = Convert.ToSingle(ChangeXLU16(br.ReadUInt16()));

                    //param.WindSpeed = ChangeXL(br.ReadSingle());
                   // param.WindDir = ChangeXL(br.ReadSingle());
                    //param.mVisibity = ChangeXL(br.ReadSingle());
                    //param.BatteryVolt = ChangeXL(br.ReadSingle());
                    return param;
                }
                catch
                {
                    return null;
                }

            }


        }


        public static ObsParams GetObsParams_old(string data1)
        {
            ObsParams param = new ObsParams();
            try
            {
                string StationNO = data1.Substring(1, 4);
                uint num = uint.Parse(StationNO, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals = BitConverter.GetBytes(num);
                param.StationNO = BitConverter.ToInt16(floatVals, 0);

                string hexString = data1.Substring(87, 4);
                uint num2 = uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals2 = BitConverter.GetBytes(num2);
                param.GHISum = Convert.ToSingle(BitConverter.ToInt16(floatVals2, 0))/10;

                string GTISum= data1.Substring(79, 4);
                uint num3 = uint.Parse(GTISum, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals3 = BitConverter.GetBytes(num3);
                param.GTISum = Convert.ToSingle(BitConverter.ToInt16(floatVals3, 0)) / 10;

                string PanleTemp = data1.Substring(107, 4);
                uint num4 = uint.Parse(PanleTemp, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals4 = BitConverter.GetBytes(num4);
                param.PanleTemp = Convert.ToSingle(BitConverter.ToInt16(floatVals4, 0));

                string Temperature = data1.Substring(117, 4);
                uint num5 = uint.Parse(Temperature, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals5 = BitConverter.GetBytes(num5);
                param.Temperature = Convert.ToSingle(BitConverter.ToInt16(floatVals5, 0)) / 10;

                string Humitity = data1.Substring(117, 4);
                uint num6 = uint.Parse(Humitity, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals6 = BitConverter.GetBytes(num6);
                param.Humitity = Convert.ToSingle(BitConverter.ToInt16(floatVals6, 0)) / 10;

                string WindSpeed = data1.Substring(117, 4);
                uint num7 = uint.Parse(WindSpeed, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals7 = BitConverter.GetBytes(num7);
                param.WindSpeed = Convert.ToSingle(BitConverter.ToInt16(floatVals7, 0)) / 10;

                string WindDir = data1.Substring(117, 4);
                uint num8 = uint.Parse(WindDir, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals8 = BitConverter.GetBytes(num8);
                param.WindDir = Convert.ToSingle(BitConverter.ToInt16(floatVals8, 0)) / 10;

                string GHI = data1.Substring(117, 4);
                uint num9 = uint.Parse(GHI, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals9 = BitConverter.GetBytes(num9);
                param.GHI = Convert.ToSingle(BitConverter.ToInt16(floatVals9, 0)) / 10;
              
                string GTI = data1.Substring(117, 4);   
                uint num10 = uint.Parse(GHI, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals10 = BitConverter.GetBytes(num9);
                param.GHI = Convert.ToSingle(BitConverter.ToInt16(floatVals10, 0)) / 10;
                
            }
            catch (System.Exception ex)
            {
                param = null;
            }   
            return param;






        }
        public static float ChangeXL(float f1)
        {
            byte[] f = BitConverter.GetBytes(f1);
            byte tmp = f[0];
            f[0] = f[3];
            f[3] = tmp;
            tmp = f[1];
            f[1] = f[2];
            f[2] = tmp;
            return BitConverter.ToSingle(f, 0);
        }

        public static float ChangeXL16(Int16 f1)
        {
            byte[] f = BitConverter.GetBytes(f1);
            byte tmp = f[0];
            f[0] = f[1];
            f[1] = tmp;
            return BitConverter.ToInt16(f, 0);
        }

        public static float ChangeXLU16(UInt16 f1)
        {
            byte[] f = BitConverter.GetBytes(f1);
            byte tmp = f[0];
            f[0] = f[1];
            f[1] = tmp;
            return BitConverter.ToUInt16(f, 0);
        }

    }
}
