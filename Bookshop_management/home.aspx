<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Bookshop_management.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .head{
           color:white;
            background:#607d8b;
            text-align:center;
            padding:8px;
        }
        .link{
              color:red;
            margin-top:80px;
            text-align:center;
            padding:8px;
            position:relative;


        }
        .auto-style1 {
            color: red;
            margin-top: 80px;
            text-align: center;
            padding: 8px;
            position: relative;
            left: 0px;
            top: 67px;
            height: 42px;
            font-size:40px;
            width: 496px;
        }
        .img{
            position:absolute;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="head">
            <h2>Bookshop Management</h2>
           
        </div>
        
       
        <asp:Image ID="Image1" runat="server" Height="95%" ImageUrl="~/BooksBanner-Ad-HP-2018-07.png" Width="100%"   class="img" />
        
        <p class="auto-style1">
        
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">For details click here</asp:LinkButton>
        </p>
    </form>
</body>
</html>
