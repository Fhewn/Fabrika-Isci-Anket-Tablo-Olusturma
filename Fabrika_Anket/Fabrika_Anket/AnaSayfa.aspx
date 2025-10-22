<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Denim_Anket.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          <asp:DataList ID="dataSoru" RepeatColumns="5" RepeatLayout="Table" runat="server" GridLines="Horizontal">
            <ItemTemplate>              
              <asp:Label ID="Label" runat="server" Text='<%#Eval("Soru") %>'></asp:Label>
            </ItemTemplate>
          </asp:DataList>
        </div>
    </form>
</body>
</html>
