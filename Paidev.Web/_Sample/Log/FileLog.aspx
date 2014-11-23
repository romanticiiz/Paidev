<%@ Page Title="" Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="FileLog.aspx.cs" Inherits="Paidev.Web._Sample.Log.FileLog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">
    <script type="text/javascript">
        function Log() {
            $("#<%=btnLog.ClientID %>").trigger('click');
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div>
        <button type="button" onclick="Log();">로그쌓기</button>
        <asp:Button runat="server" ID="btnLog" OnClick="btnLog_Button" style="display: none;" />
    </div>
</asp:Content>
