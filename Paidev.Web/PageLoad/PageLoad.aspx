<%@ Page Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="PageLoad.aspx.cs" Inherits="Paidev.Web.PageLoad.PageLoad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server"></asp:Label> 
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Button" />   
    </div>
</asp:Content>