<%@ Page Title="" Language="C#" MasterPageFile="~/otheruser/user.Master" AutoEventWireup="true" CodeFile="gaiaviewuser.aspx.cs" Inherits="CanezPower.otheruser.gaiaviewuser" %>
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


    <script runat=server>

      

</script>


    
    <table style="width: 59%">
    <tr>
        <td  colspan="3">
            <h2>GAIA</h2>
            </td>
        <td style="height: 31px; width: 267px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/GAIA.aspx" Visible="False">NEW ATTACHMENT</asp:HyperLink>
        </td>
        
    </tr>
    <tr>
        <td class="right" style="width: 283px; color: #000000; text-align: right; height: 39px;">Fault Search</td>
        <td class="right" style="color: #000000; text-align: left; font-weight: bold; height: 39px;">
           
            <asp:Panel ID="Panel1" runat="server">
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
  
                
                <div class="scroll" style="width: 1068px; height: 150px">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"   Width="980px" CellPadding="4" ForeColor="Black"  style="font-size: x-small; text-align: left;"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" >
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
                                <asp:LinkButton Text="View" ID="inSelect" runat="server" CommandName="Select"  />
                            </ItemTemplate>
                        </asp:TemplateField>
   
                         <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                           
                        <asp:BoundField DataField="SECTION" HeaderText="SECTION" SortExpression="SECTION" />
                            <asp:BoundField DataField="CATEGORY" HeaderText="CATEGORY" SortExpression="CATEGORY" />
                            <asp:BoundField DataField="ENGINE" HeaderText="ENGINE" SortExpression="ENGINE" />
                            <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" SortExpression="DESCRIPTION" />
                            <asp:BoundField DataField="USER1" HeaderText="UPLOAD BY" SortExpression="USER1" />
                            <asp:BoundField DataField="DOCUMENT" HeaderText="DOCUMENT" SortExpression="DOCUMENT" />
                         <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select * from TBGAIA ORDER BY ID DESC"></asp:SqlDataSource>
               
                 </div>
                
                
                  </td>
        </tr>
    </table>
    
   
  
    <iframe id="MyIframe" src="<% =user.ToString() %>" style="width: 1068px; height: 800px"></iframe>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
       <table style="width: 31%">
             <tr>
                 <td>
      
    <asp:TextBox ID="TextBox1" placeholder="Search" runat="server" Height="30px" Width="154px" Visible="False"></asp:TextBox>
                 </td>
                 <td>

                     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                         <ContentTemplate>
                              <asp:Button ID="btnbuscar1" runat="server" Text="Search pdf" Width="106px" OnClick="btnbuscar1_Click" Visible="False" />
                         </ContentTemplate>

                         <Triggers>
                             <asp:AsyncPostBackTrigger ControlID="btnbuscar1"  />
                         </Triggers>
                     </asp:UpdatePanel>
                    
                 </td>
             </tr>
         </table>
</asp:Content>


