<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="NEW_CLIENT.aspx.cs" Inherits="CanezPower.NEW_CLIENT" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

      
    
    <table style="width: 72%">
    <tr>
        <td style="height: 31px; font-weight: 700; text-decoration: underline;" colspan="3">
            <h2>CLIENT REGISTER</h2>
            </td>
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;">
            <b>ACCOUNT:</b></td>
        <td style="height: 4px; width: 178px; " class="text-left">
            <asp:TextBox ID="TXTACCOUNT" runat="server" Width="190px" MaxLength="20" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="height: 4px; width: 181px; text-align: right; font-size: xx-small;">
            <b>COMPANY NAME:</b></td>
        
        <td style="height: 4px; width: 267px">
           
            <asp:TextBox ID="TXTCOMPANYNAME" runat="server" Width="190px" TabIndex="60" Height="16px" style="font-size: xx-small"></asp:TextBox>
        
        </td>
        
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 36px; font-size: xx-small;">PASANTE / NIF:</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 36px;">
            <asp:TextBox ID="TXTNIF" runat="server" Width="190px" MaxLength="20" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="width: 181px; height: 36px; text-align: right; font-size: xx-small;">
            <b>CONTACT NAME:</b></td>
        <td style="width: 267px; height: 36px;">
            <asp:TextBox ID="TXTCONTNAME" runat="server" Width="190px"  MaxLength="20" style="font-size: xx-small"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">LAST NAME:</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 31px;">
            <asp:TextBox ID="TXTLASNAME" runat="server" Width="190px" MaxLength="200" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="width: 181px; height: 31px; text-align: right; font-size: xx-small;">
            <b>E-MAIL:</b></td>
        <td style="width: 267px; height: 31px;">
            <asp:TextBox ID="TXTEMAIL" runat="server" Width="190px" MaxLength="200" TextMode="Email" style="font-size: xx-small"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">PHONE:</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 33px;">
            <asp:TextBox ID="TXTPHONE1" runat="server" Width="190px"  MaxLength="200" TextMode="Phone" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="width: 181px; height: 33px; text-align: right; font-size: xx-small;">
            <b>TECHINICAL CONTACT NAME</b></td>
        <td style="width: 267px; height: 33px;">
            <asp:TextBox ID="TXTTECHICAL" runat="server" Width="190px" MaxLength="200" style="font-size: xx-small"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 37px; font-size: xx-small;">LAST NAME</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 37px;">
            <asp:TextBox ID="TXTLASNAME1" runat="server" Width="190px"  MaxLength="200" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="width: 181px; height: 37px; text-align: right; font-size: xx-small;">
            <b>E-MAIL:</b></td>
        <td style="width: 267px; height: 37px;">
            <asp:TextBox ID="TXTEMAIL1" runat="server" Width="190px"  MaxLength="200" TextMode="Email" style="font-size: xx-small"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">PHONE:</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 31px;">
            <asp:TextBox ID="TXTPHO" runat="server" Width="190px"  MaxLength="200" TextMode="Phone" style="font-size: xx-small"></asp:TextBox>
        </td>
        <td style="width: 181px; height: 31px; text-align: right;">
            <span style="font-size: xx-small"></td>
        <td style="width: 267px; height: 31px;">
            </span></td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 39px;"></td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: right; height: 39px;" colspan="2">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE" Width="247px" OnClick="BTNGUARDAR_Click1" style="font-size: xx-small"  />
        </td>
        <td style="width: 267px; height: 39px;">
            </span></td>
    </tr>
    <tr>
        <td class="right" style="width: 200px; color: #000000; text-align: right; height: 39px;"></td>
        <td class="right" style="color: #000000; text-align: right; font-weight: bold; height: 39px;" colspan="2">
            <span style="font-size: xx-small">
            <asp:Label ID="LBLESTADO" runat="server" style="color: #000000"></asp:Label>
        </td>
        <td style="width: 267px; height: 39px;">
            </span></td>
    </tr>
    </table>
     <table style="width: 113%">
        <tr>
            <td style="width: 264px; height: 44px;">
                <span style="color: #000000">SEARCH</span>
             
                <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="240px"></asp:TextBox>
                <br />
                <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH"  />

               
              





                 </td>
            <td style="height: 44px;">
                &nbsp;</td>
            <td style="height: 44px;">
                <br />
            &nbsp;
                <asp:Button ID="BTNEXPO" runat="server" Text="EXPORT EXCEL"  />  
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" Width="946px" CellPadding="4" ForeColor="#333333" GridLines="None" style="font-size: xx-small">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
               
                  </td>
        </tr>
    </table>

</asp:Content>
