<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Bookshop_management.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
    <style>
        .head{
            color:white;
            background:#607d8b;
            text-align:center;
            padding:8px;

        }
        .auto-style1 {
            height: 23px;
           margin:30px;
        }
        .auto-style2 {
            width: 193px;
        }
        .auto-style3 {
            height: 23px;
            width: 193px;
        }
        .auto-style4 {
            width: 193px;
            margin-left: 120px;
            color:red;
            /*font-size:20px;*/
        }
        .auto-style5 {
            margin-left: 158px;
        }
        .auto-style6 {
            margin-left: 159px;
        }
        .auto-style7 {
            margin-left: 162px;
           background-color:#607d8b;
           color:white;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="head">
           <h2> <b>Login Page</b></h2>
        </div>
        <br />
       
        <table style="width:100%;">
            
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User&nbsp; Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="368px" Height="24px" CssClass="auto-style5"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox2" runat="server" Width="367px" Height="24px" CssClass="auto-style5"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PassWord</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="28px" Width="366px" CssClass="auto-style6"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Height="34px" Width="139px" CssClass="auto-style7" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
             

        <p>
            &nbsp;</p>
    </form>
</body>
</html>
