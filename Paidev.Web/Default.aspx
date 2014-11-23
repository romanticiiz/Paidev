<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Paidev.Web.Default" %>
<%@ Register Src="~/Uc/PaidevUserControl01.ascx" TagName="TopNav" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>                        
        <uc1:TopNav ID="topNav" runat="server" />
        This Default.aspx
    </div>
    </form>
</body>
</html>
