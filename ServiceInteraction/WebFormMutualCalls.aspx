<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMutualCalls.aspx.cs" Inherits="ServiceInteraction.WebFormMutualCalls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Service Interaction</title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: Arial;">
        <p>
            <asp:Label ID="LabelCallCount" runat="server" Text="Number of calls: "></asp:Label>
            <asp:TextBox ID="TextBoxCallCount" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonCall" runat="server" Text="Call!" Width="52px" Height="21px" OnClick="ButtonCall_Click" />
        </p>
        <p>
            <asp:TextBox ID="TextBoxResult" ReadOnly="true" TextMode="MultiLine" runat="server" Height="130px" Width="450px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
