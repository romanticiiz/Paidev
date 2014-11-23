<%@ Page Title="" Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="Delegate.aspx.cs" Inherits="Paidev.Web.Etc.Delegate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <asp:Label runat="server">델리게이트</asp:Label>
    <br />
    <asp:TextBox ID="txtCompare1" runat="server" />    
    <asp:TextBox ID="txtCompare2" runat="server" />    
    <asp:Button ID="btnCompare" runat="server" OnClick="btnCompare_Button" Text="버튼" />
    <br />
    <asp:Label ID="lblResult1" runat="server"></asp:Label><br />
    <asp:Label ID="lblResult2" runat="server"></asp:Label>
</asp:Content>
