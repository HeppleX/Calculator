<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            计算器<br />
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="110px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="1" Width="40px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="2" Width="40px" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="3" Width="40px" OnClick="Button3_Click" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="4" Width="40px" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="5" Width="40px" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="6" Width="40px" OnClick="Button6_Click" />
            <br />
            <asp:Button ID="Button7" runat="server" Text="7" Width="40px" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="8" Width="40px" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="9" Width="40px" OnClick="Button9_Click" />
            <br />
            <asp:Button ID="Button10" runat="server" Text="0" Width="40px" OnClick="Button10_Click" />
            <asp:Button ID="Button11" runat="server" Text="+" Width="40px" OnClick="Button11_Click" />
            <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="-" Width="40px" />
            <br />
            <asp:Button ID="Button13" runat="server" Text="✖" Width="40px" OnClick="Button13_Click" />
            <asp:Button ID="Button14" runat="server" Text="➗" Width="40px" OnClick="Button14_Click" />
            <asp:Button ID="Button15" runat="server" Text="=" Width="40px" OnClick="Button15_Click" />
            <br />
            Copyright by Hepple.X
        </div>
    </form>
</body>
</html>
