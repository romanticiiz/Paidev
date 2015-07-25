<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Paidev.Web.Etc.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="/Js/jquery-1.9.0.js"></script>    
    <script type="text/javascript">
        $(document).ready(function () {
            $('.container a').on('click', function (e) {
                //e.preventDefault();

                var pageUrl = $(this).attr('href');

                // 호출 URL Ajax통신
                $.ajax({
                    url: pageUrl,
                    success: function (data) {
                        $('.container').html(data);
                    }
                });

                // 현재 URL과 Ajax통신 URL이 다르면 URL 저장
                history.pushState({ page: pageUrl }, 'title', pageUrl);

                return false;
            });
        });

        window.onpopstate = function (event) {
            loadStateContent(event.state);
        };

        function loadStateContent(state) {
            alert(state.page);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <p><a href="list.aspx">List Page</a></p>
            <p><a href="view.aspx"><b>View Page</b></a></p>
        </div>        
    </div>
    </form>
</body>
</html>
