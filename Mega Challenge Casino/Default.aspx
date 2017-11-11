<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mega_Challenge_Casino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="slotImage1" runat="server" />
            <asp:Image ID="slotImage2" runat="server" />
            <asp:Image ID="slotImage3" runat="server" />
            <br />
            <br />
            Your bet: <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="pullButton" runat="server" Text="Pull The Lever" />
            <br />
            <br />
            <br />
            Player&#39;s money:
            <asp:Label ID="playersMoneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            1 Cherry - x2 Your Bet<br />
            2 Cherries - x3 Your Bet<br />
            3 Cherries - x4 Your Bet<br />
            <br />
            3 7&#39;s - Jackpot - x100 Your Bet<br />
            <br />
            HOWEVER<br />
            <br />
            <br />
            If there&#39;s even one BAR you win nothing.</div>
    </form>
</body>
</html>
