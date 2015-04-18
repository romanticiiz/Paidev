<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="txtFileLoad.aspx.cs" Inherits="Paidev.Web.Etc.txtFileLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="/Js/jquery-1.9.0.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#btnConfirm").click(function () {
                var file = "/Upload_img/" + "<%=fileName %>";
                
                $.ajax({
                    url: file,
                    dataType: "text",
                    success: function (data) {
                        $("#target").html(data);
                    }
                });
            });

            $("#<%=FileUpload.ClientID %>").change(function () {
                $("#<%=btnFileUpload.ClientID %>").trigger("click");
            });

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload" runat="server" />
        <button type="button" name="btnConfirm" id="btnConfirm">확인</button>
        <p id="pTag"></p>
        <div id="target"></div>
        <asp:Button runat="server" ID="btnFileUpload" OnClick="btnFileUpload_Button" />        
    </div>
    </form>
</body>
</html>
