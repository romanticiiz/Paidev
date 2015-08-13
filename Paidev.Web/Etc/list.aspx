<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Paidev.Web.Etc.list" %>

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
        <div id="contents" class="boardList">
            <p><a href="view.aspx?n4ArticleSN=1" data-ajax-board="view">1번글</a></p>
            <p><a href="view.aspx?n4ArticleSN=2" data-ajax-board="view">2번글</a></p>            
            <p><a href="view.aspx?n4ArticleSN=3" data-ajax-board="view">3번글</a></p>            
            <p><a href="view.aspx?n4ArticleSN=4" data-ajax-board="view">4번글</a></p>            
            <p><a href="view.aspx?n4ArticleSN=5" data-ajax-board="view">5번글</a></p>            
            <p><a href="view.aspx?n4ArticleSN=6" data-ajax-board="view">6번글</a></p>            
        </div>        
    </div>
    </form>
</body>
</html>
