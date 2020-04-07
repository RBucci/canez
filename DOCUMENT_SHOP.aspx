<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DOCUMENT_SHOP.aspx.cs" Inherits="CanezPower.DOCUMENT_SHOP" %>
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
    <table style="width: 100%">
        <tr>
            <td><h1>Attachment List </h1></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblid" runat="server" Text="Label" Visible="False"></asp:Label>
                  <asp:Label ID="lblgenset" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="font-weight: 700">

          <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="913px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small; margin-right: 0px;" Font-Names="Latha" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
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
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>

                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="ID_GENSET" HeaderText="ID_GENSET" SortExpression="ID_GENSET" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                            <asp:BoundField DataField="DOCUMENT" HeaderText="DOCUMENT" SortExpression="DOCUMENT" />
                            <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" 
                                   DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="UPLOAD BY" HeaderText="UPLOAD BY" SortExpression="UPLOAD BY" />
                            <asp:BoundField DataField="TYPE" HeaderText="TYPE" SortExpression="TYPE" />
                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="DELETE" ID="inSelect" runat="server" CommandName="Select" OnClientClick="return confirm('are you sure you want to erase this item?');" />
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

         
          


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT ID,ID_GENSET, GENSET,DOCUMENTO AS DOCUMENT, DATE1 AS DATE, USER1 AS [UPLOAD BY],TIPO AS TYPE FROM DOCUMENT_SHOP ORDER BY ID DESC
"></asp:SqlDataSource>

         
          


            </td>
        </tr>
    </table>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
