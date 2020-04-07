<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="WAMDY1.aspx.cs" Inherits="CanezPower.USUARIO2.WAMDY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">


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


  <%--  <form id="form1" runat="server">--%>
        <table style="width: 13%">
            <tr>
                <td colspan="9">
                    <h1 style="color: #000000" class="auto-style29">WANDY</h1>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style67">Date:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="TXTDATE" runat="server"  style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style69">Cliet:</td>
                <td class="auto-style70">
                    <asp:TextBox ID="txtsite" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style71"></td>
               
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style72"></td>
                <td class="auto-style72" style="font-size: small">&nbsp;</td>
                <td class="auto-style72">&nbsp;</td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style77">Motor Reff:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtmotorreff" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style54">Capacity</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcapacity" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style76">Motor Serial #</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="txtmotorserial" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style61">Job Description:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtdescripcion" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style63">Date Out</td>
                <td class="auto-style64">
                    <asp:TextBox ID="txtdateout" runat="server"  style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style65">Invoice:</td>
              
                <td class="auto-style66">
                    <asp:TextBox ID="txtinvoice" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; text-align: right;" class="auto-style55">Total</td>
              
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txttotal" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold" TextMode="Number">0</asp:TextBox>
                </td>
              
                <td style="color: #000000; text-align: right;" class="auto-style57">Status:</td>
                <td class="auto-style58">
                    <asp:TextBox ID="txtestatus" runat="server"  style="font-weight: bold" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style60">Warranty Tag:</td>
               
                <td class="auto-style59">
                    <asp:TextBox ID="txtmarray" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
            </tr>
            <tr>
             
                <td style="color: #000000; text-align: right;" class="auto-style77">CPD&nbsp; INV TAG</td>
             
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtcpdinv" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="color: #000000; text-align: right;" class="auto-style54">CPD Total:</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcpdtotal" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px" TextMode="Number">0</asp:TextBox>
                </td>
                
                <td style="text-align: right; color: #000000;" class="auto-style76">CPD INV Status</td>

                <td class="auto-style75">
                    <asp:TextBox ID="txtcpdinvstatus" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
             
                <td style="color: #000000; " class="auto-style77">&nbsp;</td>
             
                <td style="color: #000000; ">
                    &nbsp;</td>
             
                <td style="color: #000000; " class="auto-style54">&nbsp;</td>
                <td class="auto-style79">
                    &nbsp;</td>
              
            </tr>
                        

            </table>
   
    <table style="width: 46%">
        <tr>
            <td style="width: 41px; text-align: right">Comments:</td>
            <td rowspan="2">
                    <asp:TextBox ID="TXTNOTAS" runat="server" CssClass="auto-style25" Height="68px" TextMode="MultiLine" Width="253px" style="font-weight: bold"></asp:TextBox>
                </td>
            <td>&nbsp;</td>
            <td>
                    <span style="font-size: small">TOTAL:$</span></td>
            <td>
                    <asp:Label ID="LBLESTADO0" runat="server" style="font-size: x-small; text-decoration: underline; color: #0000FF; font-weight: 700"></asp:Label>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>
                    &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>
               <asp:FileUpload ID="FileUpload1" runat="server" Width="257px" AllowMultiple="true"/>

                
                
                 </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td style="text-align: center">
                    <asp:Button ID="save0" runat="server" Text="Upload File"   OnClick="save0_Click" Width="142px" />
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>
                    &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
  

    <table >
                    <tr>
                        <td >
                    <asp:Button ID="BTNSAVE" runat="server"   OnClientClick="return confirm('Are you sure you want to save this item?');" OnClick="BTNSAVE_Click" Text="SAVE AND SEND" Width="91px" CssClass="auto-style25" />
                        </td>
                        <td >
                          
                    <asp:Button ID="BTNEDIT" runat="server" OnClientClick="return confirm('Are you sure you want to edit this item?');"   Text="EDIT" Width="91px" CssClass="auto-style25" OnClick="BTNEDIT_Click" />
                         
                        </td>
                        <td >
                    <asp:Button ID="BTNDELETE" runat="server"   OnClientClick="return confirm('Are you sure you want to delete this item?');"  Text="DELETE" Width="91px" Visible="false" CssClass="auto-style25" OnClick="BTNDELETE_Click" />
                                          <tr>
                        <td >
                            &nbsp;</td>
                        <td >
                          
                            &nbsp;</td>
                        <td >
                            &nbsp;<tr>
                        <td >
                    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                        </td>
                        <td >
                          
                            &nbsp;</td>
                        <td >
                            &nbsp;</table>

        <table style="width: 35%">
            <tr>
                <td style="text-align: center">Search</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>CLIENT</asp:ListItem>
                </asp:DropDownList>
                
                        </td>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                           <asp:TextBox ID="TXTUSUARIO" runat="server" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>


                    </asp:Panel>


                             
                            </td>
                <td>
               
                <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" Width="91px" />
                        </td>
            </tr>
        </table>



     <table class="auto-style81">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
            <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1629px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound1" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
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
                            <asp:BoundField DataField="DATE IN" HeaderText="DATE IN" SortExpression="DATE IN"
                                   DataFormatString="{0:d}"
                            HtmlEncode="false"
                                />
                           
                            <asp:BoundField DataField="CLIENT" HeaderText="CLIENT" SortExpression="CLIENT" />
                            <asp:BoundField DataField="MOTOR REFF" HeaderText="MOTOR REFF" SortExpression="MOTOR REFF" />
                            <asp:BoundField DataField="CAPACITY" HeaderText="CAPACITY" SortExpression="CAPACITY" />
                            <asp:BoundField DataField="MOTOR SERIAL #" HeaderText="MOTOR SERIAL #" SortExpression="MOTOR SERIAL #" />
                            <asp:BoundField DataField="JOB DESCRIPTION" HeaderText="JOB DESCRIPTION" SortExpression="JOB DESCRIPTION" />
                            <asp:BoundField DataField="DATE OUT" HeaderText="DATE OUT" SortExpression="DATE OUT" 
                               
                                   DataFormatString="{0:d}"
                            HtmlEncode="false"
                                />
                            <asp:BoundField DataField="INVOICE" HeaderText="INVOICE" SortExpression="INVOICE" />
                            <asp:BoundField DataField="WANDY TOTAL" HeaderText="WANDY TOTAL" ReadOnly="True" SortExpression="WANDY TOTAL" />
                            <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" />
                            <asp:BoundField DataField="WARRANTY TAG" HeaderText="WARRANTY TAG" SortExpression="WARRANTY TAG" />
                            <asp:BoundField DataField="CPD INV" HeaderText="CPD INV" SortExpression="CPD INV" />
                            <asp:BoundField DataField="CPD TOTAL" HeaderText="CPD TOTAL" ReadOnly="True" SortExpression="CPD TOTAL" />
                            <asp:BoundField DataField="CPD PROFIT" HeaderText="CPD PROFIT" ReadOnly="True" SortExpression="CPD PROFIT" />
                            <asp:BoundField DataField="CPD INV STATUS" HeaderText="CPD INV STATUS" SortExpression="CPD INV STATUS" />
                            <asp:BoundField DataField="COMMENT" HeaderText="COMMENT" SortExpression="COMMENT" />
                            <asp:BoundField DataField="LOADED BY" HeaderText="LOADED BY" SortExpression="LOADED BY" />
                     
                    <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>
                       
                           <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                     
                    
                       
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


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     edgar2211.WANDY.ID,edgar2211.WANDY.DATEIN AS [DATE IN], edgar2211.WANDY.SITE AS CLIENT, edgar2211.WANDY.MOTOR_REFF AS [MOTOR REFF], edgar2211.WANDY.CAPACITY, 
                         edgar2211.WANDY.MOTOR_SERIAL AS [MOTOR SERIAL #], edgar2211.WANDY.JOB_DESCRIPTION AS [JOB DESCRIPTION], edgar2211.WANDY.DATEOUT AS [DATE OUT], edgar2211.WANDY.INVOICE, 
                         '$' + edgar2211.WANDY.TOTAL + '.00' AS [WANDY TOTAL], edgar2211.WANDY.STATUS, edgar2211.WANDY.WARRANTY_TAG AS [WARRANTY TAG], edgar2211.WANDY.CPD_INV AS [CPD INV], 
                         '$' + edgar2211.WANDY.CPD_TOTAL + '.00' AS [CPD TOTAL], CASE WHEN ((CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL))) &lt;= 0 THEN 0 ELSE (CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL)) 
                         END AS [CPD PROFIT], edgar2211.WANDY.CPD_INV_STATUS AS [CPD INV STATUS], edgar2211.WANDY.COMMENT, edgar2211.WANDY.USER1 AS [LOADED BY],CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'WANDY') THEN 'YES' ELSE 'NO' END AS Attachment
FROM            edgar2211.WANDY LEFT OUTER JOIN
                         edgar2211.DOCUMENT_SHOP ON edgar2211.WANDY.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET AND edgar2211.WANDY.SITE = edgar2211.DOCUMENT_SHOP.GENSET


  ORDER BY  WANDY.ID DESC"></asp:SqlDataSource>


            </td>
        </tr>
    </table>
</asp:Content>
