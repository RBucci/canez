<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="TRACINGTTN.aspx.cs" Inherits="CanezPower.TRACINGTTN" %>
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





    <table style="width: 47%; height: 4px;">
        <tr>
            <td colspan="4">
                <h2>TRACING TTN</h2>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                ASSING TO</td>
            <td style="width: 72px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                STATUS</td>
            <td style="width: 153px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                Search</td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px">
             
            <asp:DropDownList ID="CBASING0" runat="server" Height="26px" Width="144px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBASING0_SelectedIndexChanged" CssClass="FixedHeader">
            </asp:DropDownList>
                </td>
            <td style="width: 72px">
             
            <asp:DropDownList ID="CBSTATUS0" runat="server" Height="26px" Width="144px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBSTATUS0_SelectedIndexChanged" CssClass="FixedHeader">
                <asp:ListItem>OPEN</asp:ListItem>
                <asp:ListItem>ON GOING</asp:ListItem>
                <asp:ListItem>CLOSED</asp:ListItem>
            </asp:DropDownList>
                </td>
            <td style="width: 153px">
                 <asp:DropDownList ID="cbcampo" runat="server" Height="26px" Width="144px" Style="font-size: xx-small" CssClass="FixedHeader">
                     <asp:ListItem>SITE</asp:ListItem>
                     <asp:ListItem>GENSET</asp:ListItem>
                     <asp:ListItem>TASK</asp:ListItem>
                     <asp:ListItem>NOTE</asp:ListItem>
                     <asp:ListItem>NOTE2</asp:ListItem>
                     <asp:ListItem></asp:ListItem>
                        </asp:DropDownList></td>
            <td style="width: 106px">
             
                <asp:Panel ID="Panel1" runat="server" Width="16px">
                    <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="144px" Height="26px" style="font-size: xx-small" CssClass="FixedHeader" ></asp:TextBox>
               

                </asp:Panel>
                 
                </td>
            <td style="width: 106px">
             
                &nbsp;</td>
            <td style="width: 106px">
             
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px"><b><asp:Label ID="LBLTOTAL" runat="server" Text=""></asp:Label>
                 </b>
                 </td>
            <td style="width: 72px"><b></b></td>
            <td style="width: 153px"><b></b></td>
            <td style="width: 106px"><b>
             
                <asp:Button ID="Button1" runat="server" Text="SEARCH" Width="139px" style="font-size: xx-small" OnClick="Button1_Click" CssClass="FixedHeader" />
                </b></td>
            <td style="width: 106px">&nbsp;</td>
            <td style="width: 106px">&nbsp;</td>
        </tr>
        </table>

   








     <table style="width: 100%">
                      <tr>
                          <td>

                              <asp:Panel ID="Panel2" runat="server">
                                  <strong>
                                  <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1099px" CssClass="auto-style25" style="font-size: x-small; text-align: left;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="TTN" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333"  >
                                      <%-- <AlternatingRowStyle BackColor="White" />
                    --%>
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
                                          <asp:BoundField DataField="TTN" HeaderText="TTN" InsertVisible="False" ReadOnly="True" SortExpression="TTN" />
                                          <asp:BoundField DataField="Create By" HeaderText="Create By" SortExpression="Create By" />
                                          <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                                           <asp:BoundField DataField="GENSET" HeaderText="Genset" SortExpression="GENSET" />
                                        
                                          <asp:BoundField DataField="Task" HeaderText="Task" SortExpression="Task" />
                                          <asp:BoundField DataField="Assing To" HeaderText="Assing To" SortExpression="Assing To" />
                                          <asp:BoundField DataField="Jod Description" HeaderText="Job Description" SortExpression="Jod Description" />
                                          <asp:BoundField DataField="Feedback Description" HeaderText="Feedback Description" SortExpression="Feedback Description" />
                                          <asp:TemplateField HeaderText="See Attachment">
                                              <ItemTemplate>
                                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                                              </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                                          <asp:BoundField DataField="USER1" HeaderText="CLOSED BY" SortExpression="USER1" />
                                          <asp:BoundField DataField="Target date" HeaderText="Target date" SortExpression="Target date"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                                          <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                                          <asp:BoundField DataField="Date Finish" HeaderText="Date Finish" SortExpression="Date Finish"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" />
                                      </Columns>
                                      <HeaderStyle VerticalAlign="Bottom" BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
                                      <%--  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />--%><%-- <RowStyle BackColor="#EFF3FB" />--%><%--  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />--%><%--   <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />--%>
                                  </asp:GridView>
                                  </strong>




                              </asp:Panel>      
                              <strong>
               
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site, edgar2211.ttn.GENSET AS Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET ORDER BY TTN DESC"></asp:SqlDataSource>
               
                  </strong>
               
                          </td>
                      </tr>
                </table>




  
</asp:Content>
