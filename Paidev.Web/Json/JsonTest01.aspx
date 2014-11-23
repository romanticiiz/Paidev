<%@ Page Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="JsonTest01.aspx.cs" Inherits="Paidev.Web.Json.JsonTest01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div>
        배열값의 길이: <%=intArrLength %>
        <br />
        배열첫번째값: <%=stringArrText %>
        <br />
        문자열값: <%=stringName %>
        <br />
        SubObject의 값: <%=objAge %>, <%=objSex %>, <%=objCity %>
    </div>
</asp:Content>
