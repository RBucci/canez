<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="PANEL_CODES.aspx.cs" Inherits="CanezPower.USUARIO2.PANEL_CODES" %>
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
    <table style="width: 9%">
    <tr>
        <td style="height: 31px; font-weight: 700; " colspan="3">
            <h2>PANEL CODE</h2>
            </td>
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;" class="FixedHeader">
            &nbsp;</td>
        <td style="height: 4px; width: 178px; " class="text-left">
           
            &nbsp;</td>
        <td style="height: 4px; width: 154px; text-align: right; font-size: xx-small;">
            &nbsp;</td>
        
        <td style="height: 4px; width: 267px">
           
            <b>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ENERGIE.aspx">ENGINE</asp:HyperLink>
                </b>
        
        </td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;">
            CODE:</td>
        <td style="height: 4px; width: 178px; " class="text-left">
           
            <asp:TextBox ID="TXTCODE" runat="server" Width="144px" TabIndex="60" Height="26px" style="font-size: xx-small" CssClass="FixedHeader"></asp:TextBox>
        
        </td>
        <td style="height: 4px; width: 154px; text-align: right; font-size: xx-small;">
            ENGINE<b>:</b></td>
        
        <td style="height: 4px; width: 267px; text-align: left;">
           
            <asp:DropDownList ID="DROPENGINE" runat="server" Height="26px" Width="144px">
            </asp:DropDownList>
        
        </td>
        
    </tr>
    <tr>
        <td style="width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">FMI:</td>
       <td style="height: 4px; width: 178px; " class="text-left">
           
            <asp:TextBox ID="TXTFMI" runat="server" Width="144px"  MaxLength="20" style="font-size: xx-small" Height="26px" CssClass="FixedHeader"></asp:TextBox>
        
        </td>
        <td style="width: 154px; height: 36px; text-align: right; font-size: xx-small;">
            &nbsp;</td>
        <td style="width: 267px; height: 36px;">
            &nbsp;</td>

    </tr>
    <tr>
        <td style="text-align: right" >DESCRIPTION:</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " colspan="3" rowspan="2">
            <asp:TextBox ID="TXTDESCRIPTION" runat="server" Width="401px"  MaxLength="200" TextMode="MultiLine" style="font-size: xx-small" Height="60px" CssClass="FixedHeader"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">&nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">&nbsp;</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 31px;">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE AND SEND" OnClientClick="return confirm('Are you sure you want to save this item?');" Width="91px" OnClick="BTNGUARDAR_Click1" style="font-size: xx-small"  />
        </td>
        <td style="width: 154px; height: 31px; text-align: right;">
            <span style="font-size: xx-small"></span>
            <asp:Button ID="BTNEDIT" runat="server" OnClientClick="return confirm('Are you sure you want to edit this item?');" Text="EDIT" Width="91px" OnClick="TXTEDIT_Click" style="font-size: xx-small"  />
        </td>
        <td style="width: 267px; height: 31px;">
            </span>
            <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="91px" OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false" OnClick="TXTDELETE_Click" style="font-size: xx-small"  />
        </td>
    </tr>
    <tr>
        <td class="right" style="width: 200px; color: #000000; text-align: right; height: 39px;"></td>
        <td class="right" style="color: #000000; text-align: left; font-weight: bold; height: 39px;" colspan="2">
            <span style="font-size: xx-small">
            <asp:Label ID="LBLESTADO" runat="server" style="color: #000000"></asp:Label>
        </td>
        <td style="width: 267px; height: 39px;">
            </span></td>
    </tr>
    <tr>
        <td class="right" style="width: 200px; color: #000000; text-align: right; height: 39px;">Fault Search</td>
        <td class="right" style="color: #000000; text-align: left; font-weight: bold; height: 39px;">
           
            <asp:Panel ID="Panel1" runat="server" Width="147px">

                 <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="144px" Height="26px" ></asp:TextBox>

            </asp:Panel>
              





        </td>
        <td class="right" style="color: #000000; text-align: left; font-weight: bold; height: 39px;">
           
                <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" OnClick="BTNBUSCAR_Click" Width="91px"  />

               
              





        </td>
        <td style="width: 267px; height: 39px;">
                &nbsp;</td>
    </tr>
    </table>
     <table >
        <tr>
            <td>
  
                
                <strong>
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"   Width="980px" CellPadding="4" ForeColor="Black"  style="font-size: x-small; text-align: left;"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
