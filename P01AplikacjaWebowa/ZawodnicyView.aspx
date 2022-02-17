<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyView.aspx.cs" Inherits="P01AplikacjaWebowa.ZawodnicyView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" />

        <asp:ListBox ID="lbDane" runat="server"></asp:ListBox>

    </form>
</body>
</html>
