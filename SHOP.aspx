<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SHOP.aspx.cs" Inherits="CanezPower.SHOP" %>



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
document.getElementById(cajadestino); 
} 




    </script>


            <table style="width: 8%; height: 50px;">
        <tr>
            <td colspan="4" style="font-size: xx-large">
                <h2>SHOP</h2>
            </td>
            <td style="font-size: xx-large">&nbsp;</td>
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
            <td class="text-left">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td  style="height: 16px; width: 100px; text-align: center;" class="text-center"></td>
            <td  style="height: 16px; font-weight: bold; text-align: center;" class="text-center">DATE</td>
            <td  style="height: 16px; font-weight: bold; text-align: center;" class="text-center">REFFERENCE</td>
            <td style="height: 16px; font-weight: bold; text-align: center;" class="text-center">STATUS</td>
            <td style="height: 16px; text-align: center; font-weight: bold;" class="text-center">GENSET</td>
            <td style="height: 16px; text-align: center; font-weight: bold;" class="text-center">GENSET SERIAL#</td>
            <td style="height: 16px; text-align: center;">&nbsp;</td>
            <td style="height: 16px; text-align: center;">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 21px" >
                &nbsp;</td>
            <td style="height: 21px; text-align: left">
                <asp:TextBox ID="TXTDATE" runat="server" Width="144px" Height="26px" TextMode="Date"></asp:TextBox>
            </td>
            <td style="height: 21px; text-align: left">
                <asp:TextBox ID="TXTREFENCE" runat="server" Width="144px" Height="26px"></asp:TextBox>
            </td>
            <td style="height: 21px">
                <asp:DropDownList ID="TXTESTATUS" runat="server" Height="26px" Width="144px" AutoPostBack="false" OnSelectedIndexChanged="TXTESTATUS_SelectedIndexChanged">
                    <asp:ListItem>Operational</asp:ListItem>
                    <asp:ListItem>On Repair</asp:ListItem>
                    <asp:ListItem>Under Maintenance</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 21px">
                <asp:DropDownList ID="TXTGENSETSERIAL" runat="server" OnSelectedIndexChanged="TXTGENSETSERIAL_SelectedIndexChanged" AutoPostBack="True" Height="26px" Width="144px">
                    <asp:ListItem>Operational</asp:ListItem>
                    <asp:ListItem>On Repair</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 21px">
                <asp:TextBox ID="TXTREFENCE0" runat="server" Width="195px" Enabled="false" Height="26px"></asp:TextBox>
            </td>
            <td colspan="2" rowspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: right"><b>DESCRIPTION</b></td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center" colspan="2" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION" runat="server" Height="43px" TextMode="MultiLine" Width="307px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td colspan="2" style="text-align: center">SELECT FILE:</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td>
                    <asp:CheckBox ID="checkemail" runat="server" Text="E-Mail Team" />


               
                </td>
            <td colspan="2">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="257px" AllowMultiple="true"/>
            </td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2" style="text-align: center"><asp:Button ID="save0" runat="server" Text="Upload File"   OnClick="save0_Click" Width="142px" />
                </td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: left" colspan="2">
                &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2" rowspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center"><asp:Button ID="save" runat="server" Text="SAVE AND SEND"    OnClientClick="return confirm('Are you sure you want to save this item?');"   OnClick="Button3_Click" Width="91px" />
                </td>
            <td style="text-align: center">
                <asp:Button ID="Button4" runat="server" Text="EDIT"   OnClientClick="return confirm('Are you sure you want to edit this item?');"    OnClick="Button4_Click" Width="91px" />
            </td>
            <td style="text-align: center">
                <asp:Button ID="Button5" runat="server" Text="DELETE" OnClientClick="return confirm('are you sure you want to erase this item?');"    OnClick="Button5_Click" Width="91px"  />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td  style="width: 100px; ">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;&nbsp;&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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
            <td class="text-center" style="font-weight: bold">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold; text-align: center;">
                  SINCE</td>
            <td class="text-center" style="font-weight: bold; text-align: center;">
                UNTIL</td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px">&nbsp;</td>
            <td style="text-align: right">
                &nbsp;Search</td>
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    
                <asp:TextBox ID="TXTREFENCE1" runat="server"  Width="144px" Height="26px" ></asp:TextBox>
            
                </asp:Panel>

            </td>
            <td><asp:Button ID="TXTSearch" runat="server" Text="Search" OnClick="TXTSearch_Click" Width="91px" />
                </td>
            <td>
                <asp:TextBox ID="TXTDESDE" runat="server" Width="144px" Height="26px" TextMode="Date" ></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TXTHASTA" runat="server" Width="144px" Height="26px" TextMode="Date" 
                    ></asp:TextBox>
            </td>
            <td><asp:Button ID="TXTSearch0" runat="server" Text="Search" OnClick="TXTSearch0_Click" Width="91px" />
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
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1163px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="System ID" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnRowUpdating="GridView1_RowUpdating" >
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
                     
                         <asp:BoundField DataField="System ID" HeaderText="System ID" SortExpression="System ID" InsertVisible="False" ReadOnly="True" />
                         <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                             DataFormatString="{0:d}"
                              HtmlEncode="false" 
                             />
                         <asp:BoundField DataField="Refference" HeaderText="Refference" SortExpression="Refference" />
                         <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                         <asp:BoundField DataField="Genset Serial#" HeaderText="Genset Serial#" SortExpression="Genset Serial#" />
                         <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                       
                                <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>
                                      
                        
                         
                                      <asp:BoundField DataField="Attachment" HeaderText="Attachment" SortExpression="Attachment" ReadOnly="True" />
                         



                         <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                         
                     
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT DISTINCT 
                         edgar2211.Shop.id AS [System ID], edgar2211.Shop.Date, edgar2211.Shop.Refference, edgar2211.gensetfinal.GENSET_MODEL AS Genset, 
                         edgar2211.Shop.Genset_Serial AS [Genset Serial#], edgar2211.Shop.Status1 AS Status, CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'shop') 
                         THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.Shop.Description, edgar2211.Shop.User_Login AS [User]
FROM            edgar2211.gensetfinal right OUTER JOIN
                         edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN
                         edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id
ORDER BY [System ID] DESC"></asp:SqlDataSource>
               
                  </strong>
               
                  </td>
        </tr>
</table>
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
