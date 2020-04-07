<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="FUELUSE.aspx.cs" Inherits="CanezPower.USUARIO2.FUELUSE" %>
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


    <table style="width: 49%">
        <tr>
            <td colspan="3" style="font-size: xx-large" rowspan="2">
                <h2>FUEL USE</h2>
            </td>
            <td style="text-align: right">DIESEL:</td>
            <td style="font-size: small;" colspan="2" class="text-left">

    <asp:Label ID="LBLESTADO0" runat="server"></asp:Label>

            </td>
            <td rowspan="2"></td>
        </tr>
        <tr>
            <td style="text-align: right">GASOLINA:</td>
            <td style="font-size: small;" colspan="2" class="text-left">

    <asp:Label ID="LBLESTADO1" runat="server"></asp:Label>

            </td>
        </tr>
        <tr>
            <td style="width: 121px; text-align: center;" class="text-center">
                &nbsp;</td>
            <td style="text-align: center"><b>
                <asp:HyperLink ID="HyperLink2" runat="server" Visible="false" NavigateUrl="~/VEHICLE.aspx">VEHICLE</asp:HyperLink>
                </b></td>
            <td style="text-align: center">&nbsp;</td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
            <td class="text-center" style="width: 30px; text-align: center;">&nbsp;</td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px; font-weight: bold; text-align: center;">DATE</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">VEHICLE</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">RESPONSIBLE</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">FUEL TYPE</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">FROM</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">QTY</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:TextBox ID="TXTDATE" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Date"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="DROPVEHICLE" runat="server" Height="26px" Width="144px">
                </asp:DropDownList>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="DROPTEAM" runat="server" Height="26px" Width="144px">
                </asp:DropDownList>
            </td>
            <td class="text-center">
     
                <asp:DropDownList ID="DROPFUELTYPE" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>DIESEL</asp:ListItem>
                    <asp:ListItem>GASOLINA</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="text-center" style="width: 30px">
              
                <asp:DropDownList ID="DROPFROM" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>VC</asp:ListItem>
                    <asp:ListItem>CPD</asp:ListItem>
                </asp:DropDownList>
                
            
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTQTY" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Number"></asp:TextBox>
            </td>
            <td class="text-center" style="font-weight: bold">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold; width: 30px;">&nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold; width: 30px;">&nbsp;</td>
            <td class="text-center">
                NOTE</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold; width: 30px;">&nbsp;</td>
            <td class="text-center" rowspan="2">
                <asp:TextBox ID="TXTNOTE" runat="server" Height="52px" Width="144px" CssClass="FixedHeader" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:Button ID="BTNSAVE" runat="server" Text="SAVE AND SEND" OnClientClick="return confirm('Are you sure you want to save this item?');" OnClick="Button3_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                <asp:Button ID="BTNEDIT" runat="server" OnClientClick="return confirm('Are you sure you want to edit this item?');"  Text ="EDIT" OnClick="Button4_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                <asp:Button ID="BTNDELETE" runat="server"  OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false"   Text="DELETE" OnClick="Button5_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold; width: 30px;">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px"><b></b></td>
            <td><b></b></td>
            <td><b></b></td>
            <td><b></b></td>
            <td style="width: 30px">&nbsp;</td>
            <td><b></b></td>
            <td><b></b></td>
        </tr>
    </table>

    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>

    <br />
    <table style="width: 1%; height: 9px;">
        <tr>
            <td class="text-center" style="font-weight: bold; width: 205px;">Search</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td><b></b></td>
            <td><b></b></td>
            <td style="text-align: center"><b>SINCE</b></td>
            <td>&nbsp;</td>
            <td style="width: 172px; text-align: center">UNTIL</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">
                <asp:DropDownList ID="DROPCAMPO" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>VEHICLE</asp:ListItem>
                    <asp:ListItem>RESPONSIBLE</asp:ListItem>
                    <asp:ListItem>FUEL_TYPE</asp:ListItem>
                    <asp:ListItem>FROM1</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Panel ID="Panel1" runat="server">

                    
                <asp:TextBox ID="TXTBUSCAR" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" ></asp:TextBox>
           
                </asp:Panel>
 </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="SEARCH" OnClick="Button6_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td>&nbsp;</td>
            <td style="text-align: center"><b>
                <asp:TextBox ID="TXTDESDE" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Date" ></asp:TextBox>
                </b></td>
            <td>&nbsp;</td>
            <td style="width: 172px">
                <asp:TextBox ID="TXTHASTA1" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Date" ></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button7" runat="server" Text="SEARCH" OnClick="Button7_Click" Width="91px" CssClass="FixedHeader" />
            </td>
        </tr>
    </table>

    <br />

    <table style="width: 72%">
        <tr>
            <td>
  
                
                <strong>
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1018px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
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
                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" 
                                  DataFormatString="{0:d}"
                            HtmlEncode="false" 
                          
                                />
                            <asp:BoundField DataField="VEHICLE" HeaderText="VEHICLE" SortExpression="VEHICLE" />
                            <asp:BoundField DataField="RESPONSIBLE" HeaderText="RESPONSIBLE" SortExpression="RESPONSIBLE" />
                            <asp:BoundField DataField="FUEL TYPE" HeaderText="FUEL TYPE" SortExpression="FUEL TYPE" />
                            <asp:BoundField DataField="FROM" HeaderText="FROM" SortExpression="FROM" />
                            <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                            <asp:BoundField DataField="NOTE" HeaderText="NOTE" SortExpression="NOTE" />
                            <asp:BoundField DataField="USER" HeaderText="USER" SortExpression="USER" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT        ID, DATE, VEHICLE, RESPONSIBLE, FUEL_TYPE AS [FUEL TYPE], FROM1 AS [FROM], QTY,NOTE, USER1 AS [USER] FROM            edgar2211.USE_FUEL  ORDER BY ID DESC"></asp:SqlDataSource>
               
                  </strong>
               
                  </td>
        </tr>
</table>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
