<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="buybook.aspx.cs" Inherits="Bookshop_management.buybook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Buy Book</h1>
    <h4>Fill up this field</h4>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Customer Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="269px"></asp:TextBox>
               
            </td>
        </tr>
        <br />
         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="270px"></asp:TextBox>
               
            </td>
        </tr>
        <br />
         <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="267px"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="267px"></asp:TextBox>
               
            </td>
        </tr>
    </table>
    
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="92px" />
</asp:Content>
