<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ADMIN.aspx.cs" Inherits="CanezPower.ADMIN" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
    <tr>
        <td style="width: 558px">
             <asp:Button ID="BTNGENSET" runat="server" Height="53px" OnClick="Button1_Click" Text="CLIENT" Width="165px" />
            <asp:Button ID="BTNEMPLOYE" runat="server" Height="53px" OnClick="BTNMANTENARCE_Click" Text="EMPLOYEE" Width="165px" />
     
              </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

</asp:Content>
