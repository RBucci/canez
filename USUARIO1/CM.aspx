<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="CM.aspx.cs" Inherits="CanezPower.USUARIO1.CM" %>
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
        <table style="width: 64%">
            <tr>
                <td colspan="9">
                    <h2 style="color: #000000">FUEL FILTER-CORRECTIVE MAINTENANCE</h2>
                </td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="FixedHeader">SITE</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style68">
                    <asp:DropDownList ID="DROPSITE" runat="server" Height="26px" Width="144px" AutoPostBack="True" OnSelectedIndexChanged="DROPSITE_SelectedIndexChanged" CssClass="FixedHeader">
                    </asp:DropDownList>
                </td>
               
                <td style="color: #000000; text-align: right;" class="FixedHeader">GENSET</td>
                <td class="auto-style70" style="text-align: center" colspan="2">
                    <b>
                    <asp:DropDownList ID="DROPGENSET" runat="server" Height="26px" Width="144px" AutoPostBack="True" OnSelectedIndexChanged="DROPGENSET_SelectedIndexChanged" CssClass="FixedHeader">
                    </asp:DropDownList>
                    </b></td>
               
                <td style="text-align: right; color: #000000;" class="FixedHeader">FILTER</td>
               
                <td class="auto-style74">
                    <asp:TextBox ID="TXTFILTER" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
                <td class="auto-style72"></td>
                <td class="auto-style72"></td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="FixedHeader">QTY</td>
               
                 <td style="color: #000000; font-weight: bold;" class="auto-style68">
                    <asp:TextBox ID="TXTQTY" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="FixedHeader">RUNNING HOURS</td>
                <td style="text-align: center" colspan="2">
                    <asp:TextBox ID="TXTHOURS" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px" AutoPostBack="True" OnTextChanged="TXTHOURS_TextChanged" TextMode="Number"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="FixedHeader">HOURS USE</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="TXTGOURSUSE" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px" Enabled="False"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
             
                <td style="color: #000000; " class="FixedHeader">&nbsp;</td>
             
                <td style="color: #000000; " class="FixedHeader">
                    &nbsp;</td>
             
                <td style="color: #000000; " class="FixedHeader">&nbsp;</td>
                <td class="FixedHeader" colspan="2">
                    &nbsp;</td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; text-align: right;" class="FixedHeader" rowspan="2">NOTE</td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style37" colspan="3" rowspan="2">
                    <asp:TextBox ID="TXTNOTAS" runat="server" CssClass="auto-style25" Height="68px" TextMode="MultiLine" Width="189px" style="font-weight: bold"></asp:TextBox>
                </td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style37" colspan="3">
                <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" Width="257px"/>
                </td>
               
            </tr>
            

            <tr>
              
                <td style="color: #000000; font-weight: bold; text-align: center;" class="auto-style37" colspan="3">
                    <asp:Button ID="save0" runat="server" Text="Upload File" Visible="false"   OnClick="save0_Click" Width="142px" />
                </td>
               
            </tr>
            

            <tr>
            
                <td colspan="1" class="FixedHeader">
                    &nbsp;</td>
              
               
               
                <td>
                    &nbsp;</td>
              
               
               
                <td class="FixedHeader">
                    &nbsp;</td>
              
               
               
            </tr>
            

            <tr>
            
                <td colspan="1" class="FixedHeader">
                    &nbsp;</td>
              
               
               
                <td>
                    <asp:CheckBox ID="checkemail" runat="server" Text="E-Mail Team" />


               
                        </td>
              
               
               
                <td class="FixedHeader">
                    &nbsp;</td>
              
               
               
            </tr>
            

            <tr>
            
                <td colspan="1" class="FixedHeader">
                    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </td>
              
               
               
                <td>
                    <b></b></td>
              
               
               
                <td class="FixedHeader">
                    &nbsp;</td>
              
               
               
            </tr>
            

            </table>


    <table style="width: 27%; height: 2px;">
                    <tr>
                        <td><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNSAVE" runat="server" Visible="false" OnClientClick="return confirm('Are you sure you want to save this item?');"  OnClick="BTNSAVE_Click" Text="SAVE AND SEND" Width="91px" CssClass="auto-style25" />
                </span></span></td>
                        <td><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNEDIT" runat="server"   Text="EDIT" Width="91px" Visible="false" OnClientClick="return confirm('Are you sure you want to edit this item?');" CssClass="auto-style25" OnClick="BTNEDIT_Click" />
                </span></span></td>
                        <td><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNDELETE" runat="server"   Text="DELETE" Width="91px" CssClass="auto-style25" OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false"   OnClick="BTNDELETE_Click" />
                </span></span></td>
                    </tr>
                </table>
          

    <table style="width: 4%">
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: center">&nbsp;Search</td>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="text-center" style="font-weight: bold">SINCE</td>
                        <td class="text-center" style="font-weight: bold">UNTIL</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="144px">
                                <asp:ListItem>Site</asp:ListItem>
                                <asp:ListItem>Genset</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td><span class="auto-style25">

                                <asp:Panel ID="Panel1" runat="server">
    <asp:TextBox ID="TXTUSUARIO" runat="server" Height="26px" Width="144px" CssClass="auto-style25" ></asp:TextBox>
               
                </asp:Panel>
               
                        
                            </span></td>
                        <td>
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" Width="91px" />
                        </td>
                        <td>&nbsp;</td>
                        <td><span class="auto-style25">
                <asp:TextBox ID="TXTDESDE" runat="server" Height="26px" Width="144px" TextMode="Date" CssClass="auto-style25" ></asp:TextBox>
                </span></td>
                        <td><span class="auto-style25">
                <asp:TextBox ID="TXTHASTA" runat="server" Height="26px" Width="144px" TextMode="Date" CssClass="auto-style25" ></asp:TextBox>
                </span></td>
                        <td>
               <asp:Button ID="BTNBUSCAR0" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR0_Click" Width="91px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
    <div>

          <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="913px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small; margin-right: 0px;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound1" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
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
                            <asp:BoundField DataField="SITE" HeaderText="SITE" SortExpression="SITE" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                            <asp:BoundField DataField="FILTER" HeaderText="FILTER" SortExpression="FILTER" />
                            <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                            <asp:BoundField DataField="RUNNING HOURS" HeaderText="RUNNING HOURS" SortExpression="RUNNING HOURS" />
                            <asp:BoundField DataField="HOURS USE" HeaderText="HOURS USE" SortExpression="HOURS USE" />
                            <asp:BoundField DataField="NOTE" HeaderText="NOTE" SortExpression="NOTE" />
                           
                          <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>    
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="USER1" HeaderText="USER1" SortExpression="USER1" />
                     
                    
                       
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

         
          


          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     cm.ID, cm.DATE1 AS DATE, SITE, cm.GENSET, FILTER, QTY, RUNNING_HOURS AS [RUNNING HOURS], HOURS_USE AS [HOURS USE], NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot;+&quot;&quot;+&quot;' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm. USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset     order by cm.id desc
                   "></asp:SqlDataSource>

         
          


    </div>

</asp:Content>
