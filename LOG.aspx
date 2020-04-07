<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="LOG.aspx.cs" Inherits="CanezPower.LOG" %>
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
      
    <table style="width: 49%; height: 177px;">
        <tr>
            <td colspan="8" style="font-size: xx-large">
                <h2>LOG</h2>
            </td>
        </tr>
        <tr>
            <td style="width: 100px" class="text-left">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
            <td class="text-left" style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td  style="height: 16px; width: 100px; text-align: center;" class="text-center">&nbsp;</td>
            <td  style="height: 16px; font-weight: bold; text-align: center;" class="text-center">DATE</td>
            <td  style="height: 16px; font-weight: bold; text-align: center;" class="text-center">SITE</td>
            <td style="height: 16px; font-weight: bold; text-align: center;" class="text-center">GENSET</td>
            <td style="height: 16px; text-align: center; font-weight: bold;" class="text-center">GENSET SERIAL#</td>
            <td style="height: 16px; text-align: center; font-weight: bold;" class="text-center">REFFERENCE</td>
            <td style="height: 16px; text-align: center;"><b>RUNNING HOURS</b></td>
            <td style="height: 16px; text-align: center;">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 21px" >
                &nbsp;</td>
            <td style="height: 21px; text-align: left">
                <asp:TextBox ID="txtdate" runat="server" Width="144px" TextMode="Date" Height="26px"></asp:TextBox>
            </td>
            <td style="height: 21px; text-align: left">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
                    </asp:DropDownList>
            </td>
            <td style="height: 21px">
                <asp:DropDownList ID="TXTGENSETSERIAL" runat="server" OnSelectedIndexChanged="TXTGENSETSERIAL_SelectedIndexChanged" AutoPostBack="True" Height="26px" Width="144px">
                </asp:DropDownList>
            </td>
            <td style="height: 21px">
                <asp:TextBox ID="TXTSERIAL" runat="server" Width="144px" Enabled="False" Height="26px"></asp:TextBox>
            </td>
            <td style="height: 21px">
                <asp:TextBox ID="TXTREFENCE2" runat="server" Width="144px" Height="26px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TXTREFENCE3" runat="server" Width="144px" Height="26px" OnTextChanged="TXTREFENCE3_TextChanged" TextMode="Number">0</asp:TextBox>
            </td>
            <td rowspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td style="text-align: right">&nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: right"><b>NOTE</b></td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td style="text-align: right">&nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td colspan="2" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION" runat="server" Height="43px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
            <td>
                    <asp:CheckBox ID="checkemail" runat="server" Text="E-Mail Team" />


               
                </td>
            <td colspan="2" style="text-align: center">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="257px" AllowMultiple="true"/>
                </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2" style="text-align: center">
                    <asp:Button ID="save0" runat="server" Text="Upload File"   OnClick="save0_Click" Width="142px" />
                </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td style="text-align: right">&nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td><asp:Button ID="save" runat="server" Text="SAVE AND SEND"  OnClientClick="return confirm('Are you sure you want to save this item?');"  OnClick="Button3_Click" Width="91px" />
            </td>
            <td>&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="EDIT" OnClientClick="return confirm('Are you sure you want to edit this item?');" OnClick="Button4_Click" Width="91px" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="DELETE" OnClientClick="return confirm('Are you sure you want to delete this item?');" OnClick="Button5_Click" Width="91px"  />
            </td>
            <td>&nbsp;</td>
            <td style="text-align: right">&nbsp;</td>
            <td style="text-align: center">
                <asp:Label ID="Label2" runat="server" Visible="False">0</asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td " style="width: 100px">
                &nbsp;</td>
            <td >
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
            <td class="text-center" style="text-align: left">
                &nbsp;</td>
            <td style="text-align: center" >
                Search</td>
            <td class="text-center" style="text-align: left">
                &nbsp;</td>
            <td style="text-align: center">
                <strong>SINCE</strong></td>
            <td style="text-align: center" >
                <strong>UNTIL</strong></td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px">&nbsp;</td>
            <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="144px">
                                <asp:ListItem>Site</asp:ListItem>
                                <asp:ListItem>Genset</asp:ListItem>
                                <asp:ListItem>Genset_Serial</asp:ListItem>
                                <asp:ListItem>Reference</asp:ListItem>
                            </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TXTREFENCE1" runat="server" Width="144px" Height="26px" ></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="TXTSearch" runat="server" Text="Search" OnClick="TXTSearch_Click" Width="91px" />
            </td>
            <td>
                <asp:TextBox ID="TXTDESDE" runat="server" Width="144px" Height="26px" TextMode="Date" ></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TXTHASTA" runat="server" Width="144px" Height="26px" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="TXTSearch0" runat="server" Text="Search" OnClick="TXTSearch0_Click" Width="91px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>

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
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" >
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
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                                DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Genset Serial" HeaderText="Genset Serial" SortExpression="Genset Serial" />
                            <asp:BoundField DataField="Reference" HeaderText="Reference" SortExpression="Reference" />
                            <asp:BoundField DataField="Running Hours" HeaderText="Running Hours" SortExpression="Running Hours" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                           <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>     
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot;+&quot;&quot;+&quot;' AND DOCUMENT_SHOP.tipo = 'log') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on   edgar2211.TBLOG.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset order by TBLOG.id desc"></asp:SqlDataSource>
               
                  </strong>
               
                  </td>
        </tr>
</table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
