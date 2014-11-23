<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="etcTest.aspx.cs" Inherits="Paidev.Web.Etc.etcTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        (function () {
            if (typeof String.trim == "undefined") {
                String.prototype.trim = function () {
                    return this.replace(/(^\s*)|(\s*$)/g, "");
                }
            }

            var str = " 띄어쓰기가 들어간 문자열 에 트림을 해볼 것임        ";

            if (str.trim() == "띄어쓰기가 들어간 문자열 에 트림을 해볼 것임") {
                alert('Trim이 있기때문에 이 얼럿이 뜸\r\n얼럿안뜨면 trim이 안되서 문자열이 틀린것임');
            }
        })();
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
