using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HainanDataCenter
{
    public class ObsParams
    {
        public string StationName;   // 设备站点名称
        public string EquipNO;       // 设备站点类型
        public int StationNO;        // 设备站点编号
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public int Second;
        public float GHI;
        public float GTI;
        public float PanleTemp;
        public float Temperature;
        public float Humitity;
        public float WindSpeed;
        public float WindDir;
        public float GHISum;
        public float GTISum;
        public float GHISum1000;
        public float GTISum1000;

        public ObsParams()
        {
            DateTime dt = DateTime.Now;
            Year = dt.Year;
            Month = dt.Month;
            Day = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
      
            GHI=0;
            GTI=0;
            PanleTemp=0;
            Temperature=0;
            Humitity=0;
            WindSpeed=0;
            WindDir=0;
            GHISum=0;
            GTISum=0;
            GTISum1000 = 0;
            GHISum1000 = 0;
        }

        private DateTime obsTime;
        public DateTime ObsTime
        {
          //  get { return new DateTime(Year, Month, Day, Hour, Minute, 0); }
            get
            {
                DateTime now = DateTime.Now;
                return new DateTime(now.Year,now.Month,now.Day,now.Hour,now.Minute,0); }
            set { obsTime = value; }
        }
    }

    public class EquipInfo
    {
        public bool IsUsed;
        public string StationNo;
        public string EquipNo;
        public string EquipLat;
        public string EquipLong;
        public string EquipTilt;
        public string ComName;
        public string BandRate;
        public string dbName;
        public bool OldEquip;
    }

    class EquipInfoCompare : IComparer<EquipInfo>
    {
        public int Compare(EquipInfo a, EquipInfo b)
        {
            return a.EquipNo.CompareTo(b.EquipNo);
        }
    }
}
