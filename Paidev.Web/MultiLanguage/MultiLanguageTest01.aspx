<%@ Page Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="MultiLanguageTest01.aspx.cs" Inherits="Paidev.Web.MultiLanguage.MultiLanguageTest01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div>
        <asp:Label ID="lbMultiLng" runat="server" Text=""></asp:Label>
        <br />
        <asp:DropDownList ID="ddlChangeLng" runat="server">
            <asp:ListItem Value="ko-KR">한국어</asp:ListItem>
            <asp:ListItem Value="en-US">영어</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnChangeLng" runat="server" Text="" OnClick="btnChangeLng_Click" />
        <br />
        <%=this.Message("Content", "Name") %>: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <%=this.Message("Content", "Hp") %>: <asp:TextBox ID="txtHp" runat="server"></asp:TextBox>
    </div>
</asp:Content>
