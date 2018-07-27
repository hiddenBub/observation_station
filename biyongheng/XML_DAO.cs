using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace HainanDataCenter
{
  public  class XML_DAO
    {
      public static List<EquipInfo> GetFromXML()
      {
          List<EquipInfo> list = new List<EquipInfo>();
          try
          {

              XDocument doc = XDocument.Load("Equip.xml");
              var text = from t in doc.Descendants(@"Equip")
                         select new
                         {
                             EquipNO = t.Element("EquipNO").Value,
                             StationNo = t.Element("StationNo").Value,
                             ComName = t.Element("ComName").Value,
                             IsUsed = t.Element("Used").Value,
                             BaudRate = t.Element("BaudRate").Value,
                             dbName = t.Element("dbName").Value,
                             EquipLat =t.Element("EquipLat").Value,
                             EquipLong =t.Element("EquipLong").Value,
                             EquipTilt= t.Element("EquipTilt").Value
};
              foreach (var a in text)
              {
                  EquipInfo e = new EquipInfo();
                  e.EquipNo = a.EquipNO.ToString().Trim();
                  e.StationNo = a.StationNo.ToString().Trim();
                  e.ComName = a.ComName.ToString().Trim();
                  e.IsUsed = Convert.ToBoolean(a.IsUsed.ToString().Trim());
                  e.BandRate = a.BaudRate.ToString().Trim();
                  e.dbName = a.dbName.ToString().Trim();
                  e.EquipLat = a.EquipLat.ToString().Trim();
                  e.EquipLong = a.EquipLong.ToString().Trim();
                  e.EquipTilt = a.EquipTilt.ToString().Trim();
                  list.Add(e);
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }

          return list;
      }
      public static void Save2XML(List<EquipInfo> equipList)
      {
          List<XElement> li = new List<XElement>();
          foreach (EquipInfo info in equipList)
          {
              XElement x1 = new XElement("EquipNO", new XText(info.EquipNo));
              XElement x2 = new XElement("StationNo", new XText(info.StationNo));
              XElement x3 = new XElement("ComName", new XText(info.ComName));
              XElement x4 = new XElement("Used", new XText(info.IsUsed.ToString()));
              XElement x5 = new XElement("dbName", new XText(info.dbName));
              XElement x6 = new XElement("BaudRate", new XText(info.BandRate.ToString()));
              XElement x7 = new XElement("EquipLat", new XText(info.EquipLat.ToString()));
              XElement x8 = new XElement("EquipLong", new XText(info.EquipLong.ToString()));
              XElement x9 = new XElement("EquipTilt", new XText(info.EquipTilt.ToString()));
              XElement x0 = new XElement("Equip", x1, x2, x3, x4, x5,x6,x7,x8,x9);
              li.Add(x0);
          }
          //XElement x2 =  new XElement("pig", "pig is great");
          XElement root1 = new XElement("root", li);
          var xDoc = new XDocument(root1);
          //xDoc输出xml的encoding是系统默认编码,对于简体中文操作系统是gb2312
          //默认是缩进格式化的xml,而无须格式化设置
          xDoc.Save("Equip.xml");
      }




    }



}
