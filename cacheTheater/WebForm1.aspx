<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="cacheTheater.WebForm1" %>
<%@ OutputCache Duration="300" VaryByParam="None"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 391px; margin-left: 40px">
    
        Select One theater:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Timing" />
    
    </div>
    </form>
</body>
</html>
