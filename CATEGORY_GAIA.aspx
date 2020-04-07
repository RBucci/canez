<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CATEGORY_GAIA.aspx.cs" Inherits="CanezPower.CATEGORY_GAIA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <script>
function cambiaFoco(cajadestino) 
{ 
/*Esta funcion funciona con KeyPress y recibe como parametro el nombre de la caja destino(que es una cadena)*/ 

//Primero debes obtener el valor ascii de la tecla presionada 
var key=window.event.keyCode; 

//Si es enter(13) 
if(key==13) 
//Se pasa el foco a la caja destino 
document.getElementById(cajadestino).focus(); 
} 




    </script>

           <br />
    <br />
           <h2>CATEGORY GAIA</h2>
    <br />

    <table style="width: 90%">
        <tr>
            <td style="width: 24px; height: 44px;">
                <span style="font-size: xx-small"></td>
            <td style="height: 44px; width: 81px;">
                </span>
                <br style="font-size: xx-small" />
                   <asp:Panel ID="Panel1" runat="server">

                <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="144px" style="font-size: xx-small"></asp:TextBox>
                
                </asp:Panel>
              





                 </td>
            <td style="height: 44px;" colspan="2">
                <span style="font-size: xx-small">

                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Search" Width="91px" />


                </span>

               
              





                 </td>
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
            <td style="width: 81px; height: 15px;">
                
                <asp:Button ID="BTNEXPO" runat="server" OnClientClick="return confirm('Are you sure you want to save this item?');" Text="SAVE AND SEND" OnClick="BTNEXPO_Click" style="font-size: xx-small" Width="91px" />  
                
                 </td>
            <td style="width: 110px; height: 15px;">
                
                <asp:Button ID="BTNEDIT" runat="server" Text="EDIT" Width="91px"  OnClientClick="return confirm('Are you sure you want to edit this item?');"   style="font-weight: 700; font-size: xx-small;" OnClick="BTNEDIT_Click" />
                
                 </td>
            <td style="height: 15px;">
                
                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="91px"  OnClientClick="return confirm('Are you sure you want to delete this item?');"   style="font-weight: 700; font-size: xx-small;" OnClick="BTNDELETE_Click" />
                
                 </td>
            <td style="width: 199px; height: 15px;">
                <asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="198px" style="font-size: xx-small" Visible="False"></asp:TextBox>

               
              





            </td>
            <td style="height: 15px; text-align: left;">
                </td>
        </tr>
        <tr>
            <td style="width: 24px; ">
                </td>
            <td colspan="3">
                <asp:Label ID="LBLESTADO" runat="server" style="font-size: xx-small"></asp:Label>
                </td>
            <td style="width: 199px; ">
                </td>
            <td style="text-align: left;"></td>
        </tr>
        <tr>
            <td style="width: 24px; font-size: xx-small;">
                &nbsp;</td>
            <td colspan="5">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="539px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
