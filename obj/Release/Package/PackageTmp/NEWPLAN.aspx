<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="NEWPLAN.aspx.cs" Inherits="CanezPower.NEWPLAN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">

    
    <BR />
    <table style="width: 100%">
        <tr>
            <td colspan="4">
                <h2><span style="color: #000000"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Genset Master File</strong></span></h2>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">&nbsp;</td>
            <td>

                <asp:Button ID="BTNVER" runat="server" Text="SHOW" Width="56px"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNVER_Click" Visible="False" />


            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Genset Model:</b></td>
            <td>

                <asp:DropDownList ID="DROPGENSET" runat="server" Height="36px" Width="197px" style="font-size: xx-small">
                </asp:DropDownList>


                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/GENSETUNIT.aspx" style="font-size: xx-small">NEW GENSET MODEL</asp:HyperLink>


            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Genset ID:</b></td>
            <td>
                <asp:TextBox ID="TXTGENSETID" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Genset</b></td>
            <td>
                <asp:TextBox ID="TXTGENSETMODEL" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Genset Serial#</b></td>
            <td>
                <asp:TextBox ID="TXTGENSETSERIAL" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Engine Model:</b></td>
            <td>
                <asp:TextBox ID="TXTMODEL" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Engine Serial #:</b></td>
            <td>
                <asp:TextBox ID="TXTSERIAL" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Panel Model:</b></td>
            <td>
                <asp:TextBox ID="TXTPANERLMODEL" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Breaker</b></td>
            <td>
                <asp:TextBox ID="TXTBREACKCAPACITY" runat="server" Width="197px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Site:</b></td>
            <td>
                <asp:DropDownList ID="DROPSITE" runat="server" Height="36px" Width="197px" style="font-size: xx-small">

                </asp:DropDownList>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/NEW_SITE.aspx" style="font-size: xx-small">ADD NEW SITE</asp:HyperLink>

            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Contract:</b></td>
            <td>

                <asp:DropDownList ID="DROPCONTRACT" runat="server" Height="36px" Width="197px" style="font-size: xx-small">
                    <asp:ListItem>Rental</asp:ListItem>
                     <asp:ListItem>Leasing</asp:ListItem>
                    <asp:ListItem>O&amp;M</asp:ListItem>
                    <asp:ListItem>Retail</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right"><b>Client:</b></td>
            <td>


                <asp:DropDownList ID="DROPCLIEN" runat="server" Height="36px" Width="197px" style="font-size: xx-small">
                </asp:DropDownList>




            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700;">Team:</td>
            <td>


            <asp:DropDownList ID="CBASING" runat="server" Height="16px" Width="197px" style="font-size: xx-small">
            </asp:DropDownList>




            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700;">Note</td>
            <td>


                <asp:TextBox ID="TXTNOTE2" runat="server" Width="307px" style="font-size: xx-small" Height="77px" TextMode="MultiLine"></asp:TextBox>




            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold">C<strong>omsumables:</strong></td>
            <td rowspan="3">
                <asp:TextBox ID="TXTNOTE" runat="server" Height="80px" MaxLength="200" TextMode="MultiLine" Width="308px" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE" Width="129px" OnClick="BTNGUARDAR_Click" style="font-weight: 700; font-size: xx-small;" />
                <asp:Button ID="BTNEDIT" runat="server" Text="EDIT" Width="129px"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNEDIT_Click" />
                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="129px"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNDELETE_Click" />
                <br />
                <asp:Label ID="LBLESTADO" runat="server" style="font-size: xx-small"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
