<%@ Page Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="CookieTest01.aspx.cs" Inherits="Paidev.Web.Cookie.CookieTest01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div>
        <asp:Button ID="btnSetCookieButton" runat="server" Text="HttpCookie 셋팅" OnClick="btnSetCookieButton_Click" />        
        <asp:Button ID="btnDeleteCookieButton" runat="server" Text="HttpCookie 쿠키삭제" OnClick="btnDeleteCookieButton_Click" />
        <br />
        쿠키Value: <asp:Label ID="lbCookieText" runat="server" Text=""></asp:Label>
        <br />
        쿠키존재여부: <asp:Label ID="lbIsCookie" runat="server" Text=""></asp:Label>
        <br />
        -------------------------------------------------------------------------
        <br />
        <asp:Button ID="btnResponseCookieSetButton" runat="server" Text="Response쿠키셋팅" OnClick="btnResponseCookieSetButton_Click" />        
        <asp:Button ID="btnResponseCookieDelButton" runat="server" Text="Response쿠키삭제" OnClick="btnResponseCookieDelButton_Click" />
        <br />
        ResPonse쿠키Value: <asp:Label ID="lbResponseCookie" runat="server" Text=""></asp:Label>
        <br />
        ResPonse쿠키존재여부: <asp:Label ID="lbResPonseIsCokie" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
