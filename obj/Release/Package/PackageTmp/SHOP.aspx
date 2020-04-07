<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SHOP.aspx.cs" Inherits="CanezPower.SHOP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <table style="width: 49%; height: 177px;">
        <tr>
            <td colspan="3" style="font-size: xx-large">Shop</td>
            <td style="font-size: xx-large">&nbsp;</td>
            <td style="font-size: xx-large">&nbsp;</td>
            <td style="font-size: xx-large">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px" class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td  style="height: 16px; width: 100px; text-align: center;" class="text-center">Date:</td>
            <td  style="height: 16px; " class="text-center">Refferance:</td>
            <td style="height: 16px; text-align: right;" class="text-center">Status:&nbsp;&nbsp;&nbsp;</td>
            <td style="height: 16px; text-align: center;" class="text-center">Genset Serial#</td>
            <td style="height: 16px; text-align: center;">Descripcion</td>
            <td style="height: 16px; ">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 21px" >
                <asp:TextBox ID="TXTDATE" runat="server" TextMode="Date" Width="116px"></asp:TextBox>
            </td>
            <td style="height: 21px; text-align: left">
                <asp:TextBox ID="TXTREFENCE" runat="server" Width="128px"></asp:TextBox>
            </td>
            <td style="height: 21px">
                <asp:DropDownList ID="TXTESTATUS" runat="server">
                    <asp:ListItem>Operational</asp:ListItem>
                    <asp:ListItem>On Repair</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 21px">
                <asp:DropDownList ID="TXTGENSETSERIAL" runat="server">
                    <asp:ListItem>Operational</asp:ListItem>
                    <asp:ListItem>On Repair</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION" runat="server" Height="43px" TextMode="MultiLine" Width="208px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                <asp:Button ID="Button3" runat="server" Text="SAVE" OnClick="Button3_Click" />
            </td>
            <td>&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="EDIT" OnClick="Button4_Click" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="DELETE" OnClick="Button5_Click"  />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td " style="width: 100px">
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 100px">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px">&nbsp;</td>
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
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
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
