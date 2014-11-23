<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageButtonTest01.aspx.cs" Inherits="Paidev.Web.Etc.ImageButtonTest01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function testFunction() {            
            alert(1);
        };

        function testFunction2() {
            document.getElementById("<%=btnIPinNext.ClientID%>").click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div>
        <asp:UpdatePanel ID="contentHolder" runat="server">
            <ContentTemplate>
                <asp:PlaceHolder ID="cphContent" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>    
        <asp:Button ID="btnIPinNext" OnClick="btnIPinNext_Click" runat="server" Style="width: 0; height: 0; display: none;" />
        <asp:ImageButton ID="ImgBtnTest" runat="server" OnClick="ImgBtnTest_Click2" AlternateText="이미지버튼 테스트2" />
    </div>
    </form>
</body>
</html>
