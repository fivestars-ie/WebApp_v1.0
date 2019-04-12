<%@ Page Language="C#" AutoEventWireup="true" CodeBehind=".aspx.cs" Inherits="VicLyfe.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Incorrect password and/or password!" Visible="False"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
