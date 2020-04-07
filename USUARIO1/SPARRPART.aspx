<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="SPARRPART.aspx.cs" Inherits="CanezPower.USUARIO1.SPARRPART" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>

    function jsDecimals(e) {

        var evt = (e) ? e : window.event;
        var key = (evt.keyCode) ? evt.keyCode : evt.which;
        if (key != null) {
            key = parseInt(key, 10);
            if ((key < 48 || key > 57) && (key < 96 || key > 105)) {
                //Aca tenemos que reemplazar "Decimals" por "NoDecimals" si queremos que no se permitan decimales
                if (!jsIsUserFriendlyChar(key, "Decimals")) {
                    return false;
                }
            }
            else {
                if (evt.shiftKey) {
                    return false;
                }
            }
        }
        return true;
    }

    // Función para las teclas especiales
    //------------------------------------------
    function jsIsUserFriendlyChar(val, step) {
        // Backspace, Tab, Enter, Insert, y Delete
        if (val == 8 || val == 9 || val == 13 || val == 45 || val == 46) {
            return true;
        }
        // Ctrl, Alt, CapsLock, Home, End, y flechas
        if ((val > 16 && val < 21) || (val > 34 && val < 41)) {
            return true;
        }
        if (step == "Decimals") {
            if (val == 190 || val == 110) {  //Check dot key code should be allowed
                return true;
            }
        }
        // The rest
        return false;
    }


</script>

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



    <table style="width: 49%">
        <tr>
            <td colspan="3" style="font-size: xx-large">
                <h2>WAREHOUSE</h2>
            </td>
            <td>&nbsp;</td>
            <td style="text-align: center; font-size: small;" colspan="2">TOTAL : $&nbsp;

    <asp:Label ID="LBLESTADO1" runat="server" style="text-align: center; font-size: small; color: #0000FF; font-weight: 700; text-decoration: underline; font-style: italic"></asp:Label>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px; text-align: center;" class="text-center">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/STOCKENTER.aspx">STOCK ENTER</asp:HyperLink>
            </td>
            <td style="text-align: center"><b>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/STOCKOUT.aspx">STOCK OUT</asp:HyperLink>
                </b></td>
            <td style="text-align: center"><b>
                <asp:HyperLink ID="HyperLink3" runat="server" Visible="false" NavigateUrl="~/CATEGORY.aspx">CATEGORY</asp:HyperLink>
                </b></td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
            <td class="text-center" style="width: 30px; text-align: center;">&nbsp;</td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
            <td class="text-center" style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px; font-weight: bold; text-align: center;">PART #</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">ACCPAC</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">CATEGORY</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">UNIT COST</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">DISCOUNT %</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">DESCRIPTION</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:TextBox ID="TXTPART" runat="server" Height="26px" Width="144px" CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:TextBox ID="TXTACCPAC" runat="server" Height="26px" Width="144px" CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="DROPCATEGORY" runat="server" Height="26px" Width="144px">
                </asp:DropDownList>
            </td>
            <td class="text-center">
     
                <asp:TextBox ID="TXTCOST" runat="server" Height="26px" Width="144px" CssClass="FixedHeader"  onkeydown="return jsDecimals(event);"></asp:TextBox>
            </td>
            <td class="text-center" style="width: 30px">
              
                <asp:TextBox ID="TXTDISCOUNT" runat="server" Height="26px" Width="144px" CssClass="FixedHeader"  onkeydown="return jsDecimals(event);"></asp:TextBox>
                
            
            </td>
            <td class="text-center" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION" runat="server" Height="45px" Width="144px" CssClass="FixedHeader" TextMode="MultiLine"></asp:TextBox>
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
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:Button ID="BTNSAVE" runat="server" OnClientClick="return confirm('Are you sure you want to save this item?');"  Visible="false" Text ="SAVE AND SEND" OnClick="Button3_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                <asp:Button ID="BTNEDIT" runat="server"  OnClientClick="return confirm('Are you sure you want to edit this item?');" Visible="false"   Text="EDIT" OnClick="Button4_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                <asp:Button ID="BTNDELETE" runat="server"  OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false" Text="DELETE" OnClick="Button5_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center" style="font-weight: bold" colspan="2">
                <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" Width="257px"/>
                </td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px"><b></b></td>
            <td><b></b></td>
            <td><b></b></td>
            <td colspan="2" style="text-align: center"><b>
                    <asp:Button ID="save0" runat="server" Text="File Upload" Visible="false"   OnClick="save0_Click" Width="142px" />
                </b></td>
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
            <td><b></b></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">
                <asp:DropDownList ID="DROPCAMPO" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>PART</asp:ListItem>
                    <asp:ListItem>ACCPAC</asp:ListItem>
                    <asp:ListItem>CATEGORY</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>

                <asp:Panel ID="Panel1" runat="server">

                      <asp:TextBox ID="TXTHASTA" runat="server" Height="26px" Width="144px" CssClass="FixedHeader"></asp:TextBox>
  
                </asp:Panel>

                        </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="SEARCH" OnClick="Button6_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td><b></b></td>
            <td><b></b></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <br />

    <table style="width: 72%">
        <tr>
            <td>
  
                
                <strong>
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1223px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
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
                            <asp:BoundField DataField="PART" HeaderText="PART" SortExpression="PART" />
                            <asp:BoundField DataField="ACCPAC" HeaderText="ACCPAC" SortExpression="ACCPAC" />
                            <asp:BoundField DataField="CATEGORY" HeaderText="CATEGORY" SortExpression="CATEGORY" />
                            <asp:BoundField DataField="STOCK" HeaderText="STOCK" SortExpression="STOCK" />
                            <asp:BoundField DataField="UNIT COST" HeaderText="UNIT COST" ReadOnly="True" SortExpression="UNIT COST" />
                            <asp:BoundField DataField="%" HeaderText="%" ReadOnly="True" SortExpression="%" />
                            <asp:BoundField DataField="DISCOUNT" HeaderText="DISCOUNT" ReadOnly="True" SortExpression="DISCOUNT" />
                            <asp:BoundField DataField="NEXT COST" HeaderText="NEXT COST" ReadOnly="True" SortExpression="NEXT COST" />
                            <asp:BoundField DataField="GRANT TOTAL" HeaderText="GRANT TOTAL" ReadOnly="True" SortExpression="GRANT TOTAL" />
                            <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" SortExpression="DESCRIPTION" />
                        <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>  


                          <asp:BoundField DataField="Attachment QTY" HeaderText="Attachment QTY" ReadOnly="True" SortExpression="Attachment QTY" />
                            <asp:BoundField DataField="USER_LOGIN" HeaderText="Create By" SortExpression="USER_LOGIN" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   distinct           SPARTPART.ID, PART, ACCPAC, CATEGORY, STOCK, '$'+format(convert(money,replace(COST,',','.')),'n','de-de') AS [UNIT COST], DISCOUNT+''+'%' AS [%],'$'+DISCOUNT1 AS DISCOUNT,'$'+ format(convert(money,replace(NEXT_COST,',','.')),'n','de-de') AS [NEXT COST],'$'+format(convert(money,replace(GRANT_TOTAL,',','.')),'n','de-de') AS [GRANT TOTAL] , DESCRIPTION,CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot; + &quot;&quot; + &quot;' AND DOCUMENT_SHOP.tipo = 'SP') THEN '1' ELSE '0' END AS [Attachment QTY], USER_LOGIN FROM            edgar2211.SPARTPART LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.SPARTPART.accpac = edgar2211.DOCUMENT_SHOP.GENSET and SPARTPART.accpac = DOCUMENT_SHOP.GENSET 
 order by SPARTPART.ID DESC"></asp:SqlDataSource>
               
                  </strong>
               
                  </td>
        </tr>
</table>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
