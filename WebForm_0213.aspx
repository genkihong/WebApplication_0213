<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_0213.aspx.cs" Inherits="WebApplication_0213.WebForm_0213" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div>
            <table>
                <tr>
                    <th>編號</th>
                    <th>年度</th>
                    <th>廣告招牌查報件數</th>
                </tr>
                <tr>
                    <td>1</td>
                    <td>109</td>
                    <td>200000</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>109</td>
                    <td>200000</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>109</td>
                    <td>200000</td>
                </tr>
            </table>
        </div>--%>
        <div>
            <%--只會呈現文字--%>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
        </div>
        <div>
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
