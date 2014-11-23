<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateTest01.aspx.cs" Inherits="Paidev.Web.Etc.ViewStateTest01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbTest01" runat="server" Text="Static Value" EnableViewState="false"></asp:Label><br />
        <asp:Label ID="lbTest02" runat="server" Text="Static Value" EnableViewState="true"></asp:Label><br />
        <p>
            <asp:Button ID="btnButton" runat="server" Text="Button" />
        </p>
    </div>
    </form>
</body>
</html>
