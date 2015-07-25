<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="historyApiView.aspx.cs" Inherits="Paidev.Web.Etc.historyApiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onpopstate = function (event) {
            loadStateContent(event.state);
        };

        function loadStateContent(state) {
            var con = document.getElementById("contents");
            con.innerHTML = "복구된 " + state.page + "페이지 " + "hello" + state.name;
        }

        function viewContents(idx) {
            event.preventDefault();

            var con = document.getElementById("contents");

            switch (idx) {
                case 1:
                    history.pushState({ page: 1, name: '리스트' }, 'pushState - 1', '/etc/historyApiList.aspx?page=list');
                    con.innerHTML = "리스트 페이지";
                    break;
                case 2:
                    history.pushState({ page: 2, name: '뷰' }, 'pushState - 2', '/etc/historyApiView.aspx?page=view');
                    con.innerHTML = "뷰 페이지";
                    break;
                default:
                    break;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="contents"></p>
        <ul>
            <li><a href="#" onclick="viewContents(1);">List 페이지</a></li>
            <li><a href="#" onclick="viewContents(2);">View 페이지</a></li>
        </ul>        
    </div>
    </form>
</body>
</html>
