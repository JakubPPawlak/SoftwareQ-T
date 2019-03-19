<%@ Page Title="Calculate Premium" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CalculatePremium.aspx.cs" Inherits="Web_App.CalculatePremium" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center">Calculate your premium below</h2>
    <p style="left: 20px; right: 5px">&nbsp;</p>
    <div>
            <div style="height: auto; text-align: center">
                <asp:Label ID="genderLabel" runat="server" Text="Gender" Width="70px" Font-Size="Medium"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="ageLabel" runat="server" Text="Age" Width="70px" Font-Size="Medium"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" BackColor="Black" BorderStyle="Solid" BorderColor="White" BorderWidth="1px" ForeColor="White" OnClick="Button1_Click1" Text="Submit" Width="100px" UseSubmitBehavior="False" />
                <br />
                <br />
                <asp:Label ID="premiumLabel" runat="server" Text="Your premium: " Font-Size="Medium"></asp:Label>
                <asp:Label ID="Label1" runat="server" ForeColor="Green" Text="0" Font-Size="Medium"></asp:Label>
            </div>
        </div>
</asp:Content>
