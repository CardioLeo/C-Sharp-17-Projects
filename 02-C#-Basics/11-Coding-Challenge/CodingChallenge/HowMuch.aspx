<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HowMuch.aspx.cs" Inherits="MyFirstWebApp.Identity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?&nbsp;
            <asp:TextBox ID="ageBox" runat="server"></asp:TextBox>
            <br />
            <br />
            How much would you like to save (in USD)?&nbsp;
            <asp:TextBox ID="savingsGoalBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" Text="Click Me, Please" OnClick="okButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
