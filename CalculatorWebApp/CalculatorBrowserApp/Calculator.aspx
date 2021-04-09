<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorBrowserApp.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label" runat="server" Text="First Number :"></asp:Label>
            <asp:TextBox ID="firstNumTextBox" runat="server" Height="16px" Width="124px"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="label1" runat="server" Text="Second Number :"></asp:Label>
            <asp:TextBox ID="secondNumTextBox" runat="server" Height="16px" Width="124px"></asp:TextBox>
             <br /> <br />
            <asp:Label ID="label2" runat="server" Text="Result :"></asp:Label>
            <asp:TextBox ID="resultTextBox" runat="server" Height="16px" Width="124px"></asp:TextBox>
             <br /> <br />
            <asp:Button ID="addButton" runat="server" Text="+" OnClick="addButton_Click" />
            <asp:Button ID="subButton" runat="server" Text="-" OnClick="subButton_Click" />
            <asp:Button ID="mulButton" runat="server" Text="*" OnClick="mulButton_Click" />
            <asp:Button ID="divButton" runat="server" Text="/" OnClick="divButton_Click" />
            <asp:Button ID="reminderButton" runat="server" Text="%" OnClick="reminderButton_Click" />
            <asp:Button ID="clearButton" runat="server" Text="C" OnClick="clearButton_Click" />
        </div>
       
      
    </form>
</body>
</html>
