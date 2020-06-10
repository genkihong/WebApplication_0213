using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace WebApplication_0213
{
  public partial class WebForm_0213 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string content = GetJsonContent("https://api.kcg.gov.tw/api/service/get/91c06c05-6771-4195-8243-e28a997f5c6c");

      //建立的類別 ClassData 物件實體化
      ClassData Demo = new ClassData();

      //將取得的 JSON 由字串轉成物件，依據 ClassData 建立的格式 
      //Demo = JsonConvert.DeserializeObject<ClassData>(content);
      
      #region StringBuilder
      //StringBuilder sb = new StringBuilder(@"<table style='text-align: center;'><tr><th>編號</th><th width=80>年度</th><th>廣告招牌查報件數</th></tr>");
      //foreach (var item in Demo.data)
      //{
      //  sb.Append("<tr>");
      //  sb.Append($"<td>{item.seq}</td><td>{item.年度}</td><td>{item.廣告招牌查報件數}</td>");
      //  sb.Append("</tr>");
      //}

      //sb.Append("</table>");
      //Literal2.Text = sb.ToString();
      #endregion
      #region 組字串
      //建立表格的表頭
      //string fieldName = @" <table>
      //                   <tr>
      //  <th> 編號 </th>
      //  <th> 年度 </th>
      //  <th> 廣告招牌查報件數 </th>
      //  </tr> ";
      //Literal1.Text = fieldName;

      //foreach (Data item in Demo.data)
      //{
      //  Literal1.Text += $@"<tr>
      //                   <td> {item.seq} </td>
      //    <td> {item.年度} </td>
      //    <td> {item.廣告招牌查報件數} </td>
      //    </tr> ";
      //}
      //Literal1.Text += "</table>";
      #endregion(效能不好)

      #region Covid
      string str = GetJsonContent("https://od.cdc.gov.tw/eic/Weekly_Age_County_Gender_19CoV.json");
     
      Covid[] covid = JsonConvert.DeserializeObject<Covid[]>(str);
      StringBuilder sb = new StringBuilder(@"<table style='text-align: center;'><tr><th>確定病名</th><th width=80>發病年份</th><th>發病週別</th><th>縣市</th><th>性別</th><th>是否為境外移入</th><th>年齡層</th><th>確定病例數</th></tr>");
      foreach (Covid item in covid)
      {
        sb.Append("<tr>");
        sb.Append($"<td>{item.確定病名}</td><td>{item.發病年份}</td><td>{item.發病週別}</td><td>{item.縣市}</td><td>{item.性別}</td><td>{item.是否為境外移入}</td><td>{item.年齡層}</td><td>{item.確定病例數}</td>");
        sb.Append("</tr>");
      }
      sb.Append("</table>");
      Literal2.Text = sb.ToString();
      #endregion
    }

    //讀取網頁任何格式資料
    private string GetJsonContent(string Url)
    {
      try //程式主執行區或可能發生錯誤的地方
      {
        string targetURI = Url;
        var request = System.Net.WebRequest.Create(targetURI);  // Create a request for the URL.
        request.ContentType = "application/json; charset=utf-8";
        string text;
        var response = (System.Net.HttpWebResponse)request.GetResponse();
        using (var sr = new StreamReader(response.GetResponseStream()))
        {
          text = sr.ReadToEnd();
        }
        return text;
      }
      catch (Exception) //例外的處理方法，如秀出警告
      {
        return string.Empty;
      }
    }
  }
}