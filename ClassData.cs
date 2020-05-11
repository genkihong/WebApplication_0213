using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_0213
{
  public class ClassData
  {
    //建立 JSON 內的屬性，注意名稱要一樣!
    public bool isIamge { set; get; }
    public OneData[] data { set; get; }
    public string id { set; get; }
    public bool success { set; get; }
  }

  public class OneData
  {
    public int seq { set; get; }
    public string 年度 { set; get; }
    public string 廣告招牌查報件數 { set; get; }
  }
}