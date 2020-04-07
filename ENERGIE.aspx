<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ENERGIE.aspx.cs" Inherits="CanezPower.ENERGIE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <br />
    <br />
    <h2>NEW&nbsp; ENERGIE</h2>
    <br />
    
    <table style="width: 90%">
        <tr>
            <td style="width: 24px; height: 44px;">
                <span style="font-size: xx-small"></td>
            <td style="width: 264px; height: 44px;">
                
                <asp:Panel ID="Panel1" runat="server">

                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="144px" style="font-size: xx-small" ></asp:TextBox>
                
                </asp:Panel>
            </td>
            <td style="width: 264px; height: 44px;">
                <span style="font-size: xx-small">

                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Search" Width="91px" />


                </span>

               
              





            </td>
            <td style="width: 264px; height: 44px;">
                </span>
                <br style="font-size: xx-small" />
                <br />

            </td>
            <td style="width: 264px; height: 44px;">
                &nbsp;</td>
            <td style="height: 44px;" colspan="2">
                <br style="font-size: xx-small" />
                <span style="font-size: xx-small">&nbsp;
                </span>
                <br style="font-size: xx-small" />
            </td>
        </tr>
        <tr>
            <td style="width: 24px; height: 15px;">
                </td>
            <td >
                <asp:Button ID="Button1" runat="server" Text="SAVE AND SEND" OnClientClick   ="return confirm('Are you sure you want to save this item?');" OnClick="BTNEXPO_Click" Width="91px" />
      
                 </td>
            <td style="width: 264px; height: 15px;">
                
                <asp:Button ID="BTNEDIT" runat="server" Text="EDIT" Width="91px"  OnClientClick="return confirm('Are you sure you want to edit this item?');"   style="font-weight: 700; font-size: xx-small;" OnClick="BTNEDIT_Click" />
                
                 </td>
            <td style="width: 264px; height: 15px;">
                
                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="91px"  OnClientClick="return confirm('Are you sure you want to delete this item?');"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNDELETE_Click" />

                 </td>
            <td style="width: 264px; height: 15px;">
                
                 &nbsp;</td>
            <td style="width: 199px; height: 15px;">
                <asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="198px" style="font-size: xx-small" Visible="False"></asp:TextBox>

               
              





            </td>
            <td style="height: 15px; text-align: left;">
                </td>
        </tr>
        <tr>
            <td style="width: 24px; ">
                </td>
            <td style="width: 264px; " colspan="2">
                &nbsp;</td>
            <td style="width: 264px; ">
                <asp:Label ID="LBLESTADO" runat="server" Text="Label"></asp:Label>
                </td>
            <td style="width: 264px; ">
                &nbsp;</td>
            <td style="width: 199px; ">
                </td>
            <td style="text-align: left;"></td>
        </tr>
        <tr>
            <td style="font-size: xx-small;" colspan="7">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="556px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
               
                  </td>
        </tr>
    </table>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
