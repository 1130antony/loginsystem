<%@ Page Language="C#" AutoEventWireup="true" CodeFile="accountlogin.aspx.cs" Inherits="accountlogin" MasterPageFile="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="184px" BackColor="#FFCC99" HorizontalAlign="Center">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#3399FF" Text="登入系統"></asp:Label>
                <br />
                <br />
                帳號:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                密碼:
                <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;
                <asp:Button ID="送出按鈕" runat="server" Font-Bold="True" OnClick="送出ID_Click" Text="確定" Width="49px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="清空按鈕" runat="server" Font-Bold="True" OnClick="清空按鈕_Click" Text="清空" Width="49px" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" BorderColor="White" ForeColor="Red" Text="帳號或密碼輸入錯誤!" Visible="False"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
