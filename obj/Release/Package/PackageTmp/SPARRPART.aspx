<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SPARRPART.aspx.cs" Inherits="CanezPower.SPARRPART" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 49%">
        <tr>
            <td colspan="3" style="font-size: xx-large">Spare Parts</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px;">Part Name</td>
            <td class="text-center" style="height: 16px">Part#</td>
            <td class="text-center" style="height: 16px">Genset Model</td>
            <td class="text-center" style="height: 16px">Engiene</td>
            <td class="text-center" style="height: 16px">Firter Type</td>
            <td class="text-center" style="height: 16px">Accpac</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:TextBox ID="TXTPARTNAME" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTPARNUMERO" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="CBGENSETMODEL" runat="server">
                </asp:DropDownList>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTENGINIENE" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTFILTERTYPE" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTACCPAC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">Genuine</td>
            <td class="text-center">Donaldson</td>
            <td class="text-center">Baldwin</td>
            <td class="text-center">LuberFiner</td>
            <td class="text-center">Others</td>
            <td class="text-center">Stock QTY</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:TextBox ID="TXTGENIUNE" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTDONALSON" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTBALDWIIN" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTLUBERFILTER" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTOTHER" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTSTOREQTY" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:Button ID="Button3" runat="server" Text="SAVE" OnClick="Button3_Click" />
            </td>
            <td class="text-center">
                <asp:Button ID="Button4" runat="server" Text="EDIT" OnClick="Button4_Click" />
            </td>
            <td class="text-center">
                <asp:Button ID="Button5" runat="server" Text="DELETE" OnClick="Button5_Click" />
            </td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:Label ID="LBLESTADO" runat="server" Text="Label"></asp:Label>

    <br />
    <table style="width: 100%">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
  
                
                <strong>
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView1.PageSize * GridView1.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  


                        <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                     
                    
                       
                    </Columns>
                  

                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle VerticalAlign="Bottom" BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="Black" />
                    <SortedDescendingCellStyle BackColor="Black" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
               
                  </strong>
               
                  </td>
        </tr>
</table>
    <br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
