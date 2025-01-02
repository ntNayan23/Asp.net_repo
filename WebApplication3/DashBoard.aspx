<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="WebApplication3.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1>Welcome, <asp:Literal ID="litUsername" runat="server"></asp:Literal>!</h1>
                 <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Logout" OnClick="btn_click" />
        </div>
    </form>
</body>
</html>
