<%@ Page Title="Calculate Premium" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CalculatePremium.aspx.cs" Inherits="Web_App.CalculatePremium" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Calculate your premium below</h2>
    <p style="left: 20px; right: 5px">&nbsp;</p>
    <div>
            <div style="height: 202px">
                Gender<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                Age
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
                <br />
                Your premium: <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
            </div>
        </div>
</asp:Content>
