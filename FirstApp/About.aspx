<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FirstApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="نام"></asp:Label>
    <asp:TextBox ID="NameText" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="نام خانوادگی"></asp:Label>
    <asp:TextBox ID="SurnameText" runat="server"></asp:TextBox><br/>
       <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="ذخیره" />
</asp:Content>
