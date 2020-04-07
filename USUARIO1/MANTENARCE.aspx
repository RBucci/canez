<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="MANTENARCE.aspx.cs" Inherits="CanezPower.USUARIO1.MANTENARCE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

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
        <table >
            <tr>
                <td colspan="9">
                    <h2 style="color: #000000">SERVICES</h2>
                </td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 91px;" class="auto-style67">DATE</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style68">
                    <asp:TextBox ID="TXTDATE" runat="server"  style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style69" colspan="2">SITE</td>
                <td class="auto-style70">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
                    </asp:DropDownList>
                    </td>
               
                <td style="text-align: right; color: #000000; font-weight: bold;" class="auto-style71">GENSET</td>
               
                <td class="auto-style74">
                    <asp:DropDownList ID="CBGENSET" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBGENSET_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style72"></td>
                <td class="auto-style72"></td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 91px;" class="auto-style77">REMAINDER</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:TextBox ID="txtremainder" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold" TextMode="Number" OnTextChanged="txtremainder_TextChanged"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style54" colspan="2">TEAM</td>
                <td class="auto-style73">
                    <asp:DropDownList ID="CBTEAM" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                    </asp:DropDownList>
                </td>
             
                <td style="text-align: right; color: #000000; font-weight: bold;" class="auto-style76">&nbsp;READING HOUR</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="TXTORDMASATER" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px" TextMode="Number"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 91px;" class="auto-style61">OIL RUNNING HR</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style62">
                    <asp:TextBox ID="TXTRUNING" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px" TextMode="Number"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style63" colspan="2">OIL</td>
                <td class="auto-style64">
                    <asp:DropDownList ID="CBENGIERREPLACE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                      <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    
                    </asp:DropDownList>
                </td>
             
                <td style="text-align: right; color: #000000; font-weight: bold;" class="auto-style65">OIL QTY REMOVED</td>
              
                <td class="auto-style66">
                    <asp:TextBox ID="TXTQTYREMOVEDOIL" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; text-align: right; font-weight: bold; width: 91px;" class="auto-style55">OIL ADD</td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style56">
                    <asp:TextBox ID="TXTGL" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold"></asp:TextBox>
                </td>
              
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style57" colspan="2">OIL DIFFERENT</td>
                <td class="auto-style58">
                    <asp:TextBox ID="YXYDIFERENT" runat="server"  style="font-weight: bold" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000; font-weight: bold;" class="auto-style60">OIL FILTER</td>
               
                <td class="auto-style59">
                    <asp:DropDownList ID="CBFILTERREPLACE" style="font-weight: bold" runat="server" Height="26px" Width="144px" CssClass="auto-style25">
                         <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
            
                    </asp:DropDownList>
                </td>
             
            </tr>
            <tr>
             
                <td style="color: #000000; font-weight: bold; text-align: right; width: 91px;" class="auto-style34"><b style="color: #000000">TANK DECANTER</b></td>
             
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:DropDownList ID="CBDECANTERFILTER" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style54" colspan="2">PRE-FUEL FILTER</td>
                <td class="auto-style73">
                    <asp:DropDownList ID="CBRPRE_FILTERREPLACE" runat="server" Height="26px"  style="font-weight: bold" Width="144px" CssClass="auto-style25">
                         <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
                <td style="text-align: right; color: #000000; font-weight: bold;" class="auto-style76">FUEL FILTER </td>

                <td class="auto-style75">
                    <asp:DropDownList ID="CBFUELFILTERREPLACE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                          <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
     
                    </asp:DropDownList>
                </td>
              
            </tr>
            <tr>
                
                <td style="color: #000000; text-align: right; font-weight: bold; width: 91px;" class="auto-style39">INNER AIR FILTER</td>
                
                <td style="color: #000000; font-weight: bold;" class="auto-style40">
                    <asp:DropDownList ID="CBINNERAIRFILTERREPLACE" style="font-weight: bold" runat="server" Height="26px" Width="143px" CssClass="auto-style25">
                        <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                 
                    </asp:DropDownList>
                </td>
                
                <td style="color: #000000; text-align: right; font-weight: bold; width: 57px;" class="auto-style46" colspan="2">OUTER AIR FILTER</td>
                <td class="auto-style47">
                    <asp:DropDownList ID="CBAIRFILTEROUTERCHANGE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
                <td style="text-align: right; color: #000000; font-weight: 700;" class="auto-style31"><strong>&nbsp;NEED A REVIEW?</strong></td>
                
                <td class="auto-style44">
                    <asp:DropDownList ID="TXTVERIFICATION" runat="server" Height="26px"  style="font-weight: bold" Width="144px" CssClass="auto-style25">
                         <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>YES</asp:ListItem>
                      
                    </asp:DropDownList>
                </td>
               
            </tr>
            <tr>
              
                <td style="color: #000000; font-weight: bold; text-align: right; width: 91px;" class="auto-style35" rowspan="2"><b style="color: #000000">COMMENTS</b></td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style37" colspan="2" rowspan="2">
                    <asp:TextBox ID="TXTNOTAS" runat="server" CssClass="auto-style25" Height="68px" TextMode="MultiLine" Width="230px" style="font-weight: bold"></asp:TextBox>
                </td>
               
                <td style="color: #000000; font-weight: bold; text-align: center;" class="auto-style37" colspan="4">
                <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" Width="257px"/>
                </td>
               
            </tr>
            

            <tr>
              
                <td style="color: #000000; font-weight: bold; text-align: center;" class="auto-style37" colspan="4">
                    <asp:Button ID="save0" runat="server" Text="Upload File" Visible="false"   OnClick="save0_Click" Width="142px" />
                </td>
               
            </tr>
            

            <tr>
            
                <td colspan="1" class="auto-style78" style="width: 91px">
                    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </td>
              
               
               
                <td class="auto-style49">
                    <asp:CheckBox ID="checkemail" runat="server" Text="E-Mail Team" />


               
                </td>
              
               
               
                <td class="auto-style48" style="width: 57px" colspan="2">
                    &nbsp;</td>
              
               
               
            </tr>
            

            </table>
    <br />

       <table class="auto-style50" >
                    <tr>
                        <td class="auto-style51">
                    <asp:Button ID="BTNSAVE" runat="server"  OnClientClick="return confirm('Are you sure you want to save this item?');" Visible="false"  OnClicK  ="BTNSAVE_Click" Text="SAVE AND SEND" Width="91px" CssClass="auto-style25" />
                        </td>
                        <td class="auto-style51">
                            <span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNEDIT" runat="server"   OnClientClick="return confirm('Are you sure you want to edit this item?');" Visible="false"   Text="EDIT" Width="91px" CssClass="auto-style25" OnClick="BTNEDIT_Click" />
                            </span></span>
                        </td>
                        <td class="auto-style52"><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNDELETE" runat="server"  Text="DELETE" Width="91px" CssClass="auto-style25" OnClientClick="return confirm('are you sure you want to erase this item?');" Visible="false" OnClick="BTNDELETE_Click" />
                            </span></span>                
                    </table>
    <br />

      <table class="auto-style79">
          <tr>
              <td style="text-align: center">
                  &nbsp;Search</td>
              <td>
                  &nbsp;</td>
              <td style="width: 133px">
                  &nbsp;</td>
              <td style="width: 235px">
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
              <td style="text-align: center; font-weight: 700;">
                  SINCE</td>
              <td style="text-align: center; font-weight: 700;">
                  UNTIL</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>

                  <asp:Panel ID="Panel1" runat="server">
                      
                <asp:TextBox ID="TXTUSUARIO" runat="server" Height="26px" Width="144px" CssClass="auto-style25" ></asp:TextBox>
               

                  </asp:Panel>
               </td>
              <td>
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" Width="91px" />
              </td>
              <td style="width: 133px">
                  &nbsp;</td>
              <td style="width: 235px">
                  <span style="color: #000000"><span class="auto-style25">
                    <asp:DropDownList ID="CBINNERAIRFILTERREPLACE1" style="font-weight: bold" runat="server" Height="26px" Width="150px" CssClass="auto-style25">
                        <asp:ListItem>OIL_ENGINE_REPLACE</asp:ListItem>
                        <asp:ListItem>TANK_DECARTER_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>PRE_FUEL_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>FUEL_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>PRE_FUEL_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>FUEL_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>INNERT_A_IR_FILTER_REPLACE</asp:ListItem>
                        <asp:ListItem>OUTER_AIR_FILTER_CHANGE</asp:ListItem>
                        <asp:ListItem>VERIFICATION</asp:ListItem>
                    </asp:DropDownList>
                </span></span>
              </td>
              <td>
                  <span style="color: #000000"><span class="auto-style25">
                    <asp:DropDownList ID="CBINNERAIRFILTERREPLACE0" style="font-weight: bold; margin-bottom: 0px;" runat="server" Height="26px" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBINNERAIRFILTERREPLACE0_SelectedIndexChanged1">
                        <asp:ListItem>REPLACED</asp:ListItem>
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </span></span>
              </td>
              <td>
                    <asp:TextBox ID="txtdesde" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold" TextMode="Date" AutoPostBack="True"></asp:TextBox>
              </td>
              <td>
                    <asp:TextBox ID="txthasta" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold" TextMode="Date" AutoPostBack="True"></asp:TextBox>
              </td>
              <td>
               <asp:Button ID="BTNBUSCAR0" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR0_Click" Width="91px" />
              </td>
          </tr>
    </table>

    <br />


      <table class="auto-style79">
                    <tr>
                        <td>
            <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1909px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound1" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
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

                            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Next Service" HeaderText="Next Service" ReadOnly="True" SortExpression="Next Service" />
                            <asp:BoundField DataField="Need a Review?" HeaderText="Need a Review?" SortExpression="Need a Review?" />
                            <asp:BoundField DataField="DATE_FINICH" HeaderText="DATE_FINICH" SortExpression="DATE_FINICH"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Team" HeaderText="Team" SortExpression="Team" />
                            <asp:BoundField DataField="Hour Master Reading" HeaderText="Hour Master Reading" SortExpression="Hour Master Reading" />
                            <asp:BoundField DataField="Oil Running Hr" HeaderText="Oil Running Hr" SortExpression="Oil Running Hr" />
                            <asp:BoundField DataField="Oil Engine Replace" HeaderText="Oil Engine Replace" SortExpression="Oil Engine Replace" />
                            <asp:BoundField DataField="Oil Qty Removed" HeaderText="Oil Qty Removed" SortExpression="Oil Qty Removed" />
                            <asp:BoundField DataField="Oil Qty (gl)" HeaderText="Oil Qty (gl)" SortExpression="Oil Qty (gl)" />
                            <asp:BoundField DataField="Oil Different" HeaderText="Oil Different" SortExpression="Oil Different" />
                            <asp:BoundField DataField="Oil Filter Replace" HeaderText="Oil Filter Replace" SortExpression="Oil Filter Replace" />
                            <asp:BoundField DataField="Tank Decarter Filter Replace" HeaderText="Tank Decarter Filter Replace" SortExpression="Tank Decarter Filter Replace" />
                            <asp:BoundField DataField="Pre-fuel Filter Replace" HeaderText="Pre-fuel Filter Replace" SortExpression="Pre-fuel Filter Replace" />
                            <asp:BoundField DataField="Fuel Filter Replace" HeaderText="Fuel Filter Replace" SortExpression="Fuel Filter Replace" />
                            <asp:BoundField DataField="Inner Air Filter Replace" HeaderText="Inner Air Filter Replace" SortExpression="Inner Air Filter Replace" />
                            <asp:BoundField DataField="Outer Air Filter Cheange" HeaderText="Outer Air Filter Cheange" SortExpression="Outer Air Filter Cheange" />
                            <asp:BoundField DataField="Decription" HeaderText="Decription" SortExpression="Decription" />
                          
                          <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>
                                      

                          <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="User Login" HeaderText="User Login" SortExpression="User Login" />
                     
                    
                       
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

                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT    DISTINCT    edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) &lt; 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service], 
                         edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, 
                         edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], 
                         edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], 
                         edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], 
                         edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], 
                         edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription, 
                         CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]
FROM            edgar2211.technical LEFT OUTER JOIN
                         edgar2211.DOCUMENT_SHOP ON edgar2211.technical.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET AND DOCUMENT_SHOP.tipo = 'service'  order by technical.ID desc "></asp:SqlDataSource>

                        </td>
                    </tr>
                </table>




</asp:Content>
