<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="INVOICES1.aspx.cs" Inherits="CanezPower.USUARIO2.INVOICES1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
   <script>
       function cambiaFoco(cajadestino) {
           /*Esta funcion funciona con KeyPress y recibe como parametro el nombre de la caja destino(que es una cadena)*/

           //Primero debes obtener el valor ascii de la tecla presionada 
           var key = window.event.keyCode;

           //Si es enter(13) 
           if (key == 13)
               //Se pasa el foco a la caja destino 
               document.getElementById(cajadestino).focus();
       }




    </script>
      
    
    <table style="width: 36%; height: 185px;">
    <tr>
        <td style="height: 31px; font-weight: 700; " colspan="3">
            <h2>INVOICES</h2>
            </td>
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;">
            <b>CLIENT:</b></td>
        <td style="height: 4px; width: 178px; " class="text-left">
           
            <asp:DropDownList ID="DROPCLIENT" runat="server" Height="26px" Width="144px" CssClass="FixedHeader">
            </asp:DropDownList>
        
        </td>
        <td style="height: 4px; width: 154px; text-align: right; font-size: xx-small;">
            &nbsp;</td>
        
        <td style="height: 4px; width: 267px" class="text-left">
           
            &nbsp;</td>
        
        <td style="height: 4px; width: 267px" class="text-left">
           
            &nbsp;</td>
        
        <td style="height: 4px; width: 267px" class="text-left">
           
            &nbsp;</td>
        
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">INV #:</td>
       <td style="height: 4px; width: 178px; " class="text-left">
            <asp:TextBox ID="TXTINV" runat="server" Width="144px"  MaxLength="200" TextMode="SingleLine" style="font-size: xx-small" Height="26px"></asp:TextBox>
        </td>
        <td style="width: 154px; height: 36px; text-align: right; font-size: xx-small;">
            <b>TOTAL:</b></td>
        <td style="width: 267px; height: 36px;" class="text-left">
            <asp:TextBox ID="TXTTOTAL" runat="server" Width="144px" MaxLength="200" TextMode="Number" style="font-size: xx-small" Height="26px"></asp:TextBox>
        </td>

        <td style="width: 267px; height: 36px; font-weight: 700;" class="text-left">
            STATUS</td>

        <td style="width: 267px; height: 36px;" class="text-left">
           
            <asp:DropDownList ID="CBSTATUS" runat="server" Height="21px" Width="84px" CssClass="FixedHeader">
                <asp:ListItem>PAID</asp:ListItem>
                <asp:ListItem>PENDING</asp:ListItem>
            </asp:DropDownList>
        
        </td>

    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">DESCRIP<b>TION:</b></td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " colspan="3" rowspan="2">
            <asp:TextBox ID="TXTDESCRIPTION" runat="server" Width="269px"  MaxLength="200" TextMode="MultiLine" style="font-size: xx-small" Height="60px"></asp:TextBox>
        </td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " rowspan="2">
            &nbsp;</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " rowspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">&nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">&nbsp;</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: center; height: 31px;" colspan="2">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="257px"/>
        </td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">&nbsp;</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: center; height: 31px;" colspan="2">
                    <asp:Button ID="save0" runat="server" Text="Upload File"   OnClick="save0_Click" Width="142px" Visible="False" />
        </td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">&nbsp;</td>
        <td class="right" style="font-weight: bold; width: 178px; color: #000000; text-align: right; height: 31px;">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE AND SEND" Width="91px" OnClientClick="return confirm('Are you sure you want to save this item?');"  OnClick ="BTNGUARDAR_Click1" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="width: 154px; height: 31px; text-align: right;">
            <span style="font-size: xx-small"></span>
            <asp:Button ID="TXTEDIT" runat="server"  OnClientClick="return confirm('Are you sure you want to edit this item?');"  Text="EDIT" Width="91px" OnClick="TXTEDIT_Click" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="width: 267px; height: 31px;">
            </span>
            <asp:Button ID="TXTDELETE" runat="server"  OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false" Text="DELETE" Width="91px" OnClick="TXTDELETE_Click" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="width: 200px; color: #000000; text-align: right; height: 39px;"></td>
        <td class="text-left" style="color: #000000; font-weight: bold; height: 39px;" colspan="2">
            <span style="font-size: xx-small">
            <asp:Label ID="LBLESTADO" runat="server" style="color: #000000"></asp:Label>
        </td>
        <td style="width: 267px; height: 39px;">
            </span></td>
        <td style="width: 267px; height: 39px;">
            &nbsp;</td>
        <td style="width: 267px; height: 39px;">
            &nbsp;</td>
    </tr>
    </table>
     <table style="width: 56%; height: 24px;">
        <tr>
            <td style="width: 264px; height: 2px; text-align: center;">

               
              





                 &nbsp;Search</td>
            <td style="height: 2px;">

               
              





                 </td>
            <td style="height: 2px; text-align: center;">
                <b>SINCE</b></td>
            <td style="height: 2px; text-align: center;">
                <b>UNTIL</b></td>
            <td style="height: 2px;">
              
            </td>
        </tr>
        <tr>
            <td style="width: 264px; height: 44px;">
                <asp:Panel ID="Panel1" runat="server">
                     &nbsp;<asp:TextBox ID="TXTUSUARIO" runat="server"  Width="144px" Height="26px" ></asp:TextBox>
              
               
                </asp:Panel>
               
              





                 </td>
            <td style="height: 44px;">
                <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" OnClick="BTNBUSCAR_Click" Width="91px"  />

               
              





                 </td>
            <td style="height: 44px;">
                <asp:TextBox ID="TXTDESDE" runat="server"  Width="144px" Height="26px" TextMode="Date" AutoPostBack="True"></asp:TextBox>
                </td>
            <td style="height: 44px;">
                <asp:TextBox ID="TXTHASTA" runat="server"  Width="144px" Height="26px" TextMode="Date" AutoPostBack="True"></asp:TextBox>
                </td>
            <td style="height: 44px;">
              
            &nbsp;<asp:Button ID="BTNBUSCAR0" runat="server" Text="SEARCH" OnClick="BTNBUSCAR0_Click" Width="91px"  />

               
              





                 &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
  
                
                <strong>
  
    
               
                  </strong>
               
                  </td>
        </tr>
    </table>

    <div>

            
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand1" >
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
                            <asp:BoundField DataField="CLIENT" HeaderText="CLIENT" SortExpression="CLIENT" />
                            <asp:BoundField DataField="INV" HeaderText="INV" SortExpression="INV" />
                            <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" SortExpression="DESCRIPTION" />
                            <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="True" SortExpression="Total" />
                            <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" />
                            <asp:BoundField DataField="DOCUMENT" HeaderText="DOCUMENT" SortExpression="DOCUMENT" />
                            <asp:BoundField DataField="USER1" HeaderText="USER1" SortExpression="USER1" />
                     
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



                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,'$'+TOTAL as [Total],STATUS, DOCUMENT,USER1  FROM            edgar2211.INVOICES ORDER BY ID DESC"></asp:SqlDataSource>



    </div>


</asp:Content>
