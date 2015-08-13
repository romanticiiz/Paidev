<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Paidev.Web.Etc.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="/Js/jquery-1.9.0.js"></script>
    <script type="text/javascript" src="/Js/fnObj.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="ajaxContents">
        <div id="contents" class="boardView">
            <p><b><%=n4ArticleSN %>번글 뷰페이지</b></p>
            <p><a href="#" onclick="history.back(); return false;">뒤로가기</a></p>
        </div>        
    </div>
    </form>
</body>
</html>
