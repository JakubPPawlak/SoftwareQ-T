<%@ Page Title="Calculate Premium" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CalculatePremium.aspx.cs" Inherits="Web_App.CalculatePremium" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>YES</p>
        </div>
    </form>
</body>
</html>--%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Form</h2>
    <p>Gender:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>Age:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
        <div>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </p>
            <p>Your premium:
                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
            </p>
        </div>
</asp:Content>
