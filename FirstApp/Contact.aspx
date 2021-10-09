<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FirstApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Welcome To My First Web App</h1>
    <asp:Label ID="Label1" runat="server" Text="Number1"></asp:Label><asp:TextBox ID="Number1TextBox" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label><asp:TextBox ID="Number2TextBox" runat="server"></asp:TextBox><br/>
            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label><asp:TextBox ID="ResultTextBox" runat="server"></asp:TextBox><br/>
    <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="Sum" />
       
</asp:Content>
