<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="SPENDINGTRANCK.aspx.cs" Inherits="CanezPower.USUARIO1.SPENDINGTRANCK" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">

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
    
    <table style="width: 12%">
    <tr>
        <td style="height: 31px; font-weight: 700; " colspan="3">
            <h2>EXPENSES TRACK</h2>
            </td>
        <td style="height: 31px; width: 111px">
            &nbsp;</td>
        
        <td style="height: 31px; width: 321px">
            &nbsp;</td>
        
        <td style="height: 31px; width: 267px">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;">
            &nbsp;</td>
        <td style="height: 4px; width: 182px; " class="text-left">
           
            &nbsp;</td>
        <td style="height: 4px; text-align: right; font-size: xx-small;">
            &nbsp;</td>
        
        <td style="height: 4px; width: 111px">
           



                <asp:HyperLink ID="HyperLink1"  Visible="false" runat="server" style="font-size: x-small" NavigateUrl="~/NEW_PROVIDER.aspx" >ADD NEW PROVIDER</asp:HyperLink>




        </td>
        
        <td style="height: 4px; text-align: right;" colspan="2">
           



                &nbsp;</td>
        
    </tr>
    <tr>
        <td style="height: 4px; width: 200px; text-align: right; font-size: xx-small;" class="FixedHeader">
            DATE</td>
              <td class="right" style="font-weight: bold; width: 182px; color: #000000; text-align: right; height: 36px;">
           
            <asp:TextBox ID="txtdate" runat="server" Width="144px" TabIndex="60" Height="26px" style="font-size: xx-small" TextMode="Date" CssClass="FixedHeader"></asp:TextBox>
        
        </td>
        <td style="height: 4px; text-align: right; font-size: xx-small;">
            <b>PROVIDER</b></td>
        
        <td style="height: 4px; width: 111px">
           
            <asp:DropDownList ID="TXTPROVIDER" runat="server" Height="26px" Width="144px" CssClass="FixedHeader">
            </asp:DropDownList>
        
        </td>
        
        <td style="height: 4px; text-align: right;" colspan="2">
           



                &nbsp;</td>
        
    </tr>
    <tr>
        <td class="FixedHeader" style="width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">INV #</td>
        <td class="right" style="font-weight: bold; width: 182px; color: #000000; text-align: right; height: 36px;">
            <asp:TextBox ID="TXTINV" runat="server" Width="144px"  MaxLength="200" TextMode="SingleLine" style="font-size: xx-small" Height="26px" CssClass="FixedHeader"></asp:TextBox>
        </td>
        <td style="height: 36px; text-align: right; font-size: xx-small; font-weight: 700;">
            PO</td>
        <td style="width: 111px; height: 36px;">
            <asp:TextBox ID="TXTPO" runat="server" Width="144px" MaxLength="200" style="font-size: xx-small" Height="26px" CssClass="FixedHeader"></asp:TextBox>
        </td>

        <td style="height: 36px;" colspan="2">
            &nbsp;</td>

    </tr>
    <tr>
        <td class="FixedHeader" style="width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">TOTAL</td>
        <td class="right" style="font-weight: bold; width: 182px; color: #000000; text-align: right; height: 36px;">
            <asp:TextBox ID="TXTTOTAL" runat="server" Width="144px" MaxLength="200" style="font-size: xx-small" Height="26px" CssClass="FixedHeader"  onkeydown="return jsDecimals(event);"></asp:TextBox>
        </td>
        <td style="height: 36px; text-align: right; font-size: xx-small;">
            <b></b></td>
        <td style="width: 111px; height: 36px;">
            <b></b></td>

        <td style="height: 36px;" colspan="2">
            &nbsp;</td>

    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">DESCRIPTION</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " colspan="3" rowspan="2">
            <asp:TextBox ID="TXTDECRIPCION" runat="server" Width="401px"  MaxLength="200" TextMode="MultiLine" style="font-size: xx-small" Height="60px" CssClass="FixedHeader"></asp:TextBox>
        </td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; width: 321px;" rowspan="2">
            &nbsp;</td>
        <td class="right" style="font-weight: bold; color: #000000; text-align: left; " rowspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 33px; font-size: xx-small;">&nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="font-weight: bold; width: 200px; color: #000000; text-align: right; height: 31px; font-size: xx-small;">&nbsp;</td>
        <td class="right" style="font-weight: bold; width: 182px; color: #000000; text-align: right; height: 31px;">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE AND SEND" Width="91px"  OnClientClick="return confirm('Are you sure you want to save this item?');" Visible="false"  OnClick="BTNGUARDAR_Click1" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="height: 31px; text-align: right;">
            <span style="font-size: xx-small"></span>
            <asp:Button ID="TXTEDIT" runat="server" Text="EDIT" Width="91px"  OnClientClick="return confirm('Are you sure you want to edit this item?');" Visible="false"  OnClick="TXTEDIT_Click" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="width: 111px; height: 31px;">
            </span>
            <asp:Button ID="TXTDELETE" runat="server" Text="DELETE" Width="91px"  OnClientClick="return confirm('Are you sure you want to delete this item?');" Visible="false"   OnClick="TXTDELETE_Click" style="font-size: xx-small" Height="23px"  />
        </td>
        <td style="width: 321px; height: 31px;">
            &nbsp;</td>
        <td style="width: 267px; height: 31px;">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="right" style="width: 200px; color: #000000; text-align: right; height: 39px;"></td>
        <td class="right" style="color: #000000; text-align: right; font-weight: bold; height: 39px;" colspan="2">
            <span style="font-size: xx-small">
            <asp:Label ID="LBLESTADO" runat="server" style="color: #000000"></asp:Label>
        </td>
        <td style="width: 111px; height: 39px;">
            </span></td>
        <td style="width: 321px; height: 39px;">
            &nbsp;</td>
        <td style="width: 267px; height: 39px;">
            &nbsp;</td>
    </tr>
    </table>
     <table style="width: 28%; height: 7px;">
        <tr>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 &nbsp;</td>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 &nbsp;</td>
            <td style="height: 14px;">

               
              





                 &nbsp;</td>
            <td style="height: 14px; text-align: center; font-weight: 700;">
               
                             
                &nbsp;</td>
            <td style="height: 14px; text-align: right; font-weight: 700;">
             
                TOTAL: $&nbsp;</td>
            <td style="height: 14px;">

               
              





            <span style="font-size: xx-small">
            <asp:Label ID="LBLESTADO0" runat="server" style="color: #0066FF"></asp:Label>
        
               
              





                </td>
        </tr>
        <tr>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 &nbsp;</td>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 &nbsp;</td>
            <td style="height: 14px;">

               
              





                 &nbsp;</td>
            <td style="height: 14px; text-align: center; font-weight: 700;">
               
                             
                &nbsp;</td>
            <td style="height: 14px; text-align: center; font-weight: 700;">
             
                &nbsp;</td>
            <td style="height: 14px;">

               
              





                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 Search</td>
            <td style="width: 264px; height: 14px;" class="text-center">
             
               
              





                 &nbsp;</td>
            <td style="height: 14px;">

               
              





                 </td>
            <td style="height: 14px; text-align: center; font-weight: 700;">
               
                             
                SINCE</td>
            <td style="height: 14px; text-align: center; font-weight: 700;">
             
                UNTIL</td>
            <td style="height: 14px;">

               
              





                </td>
        </tr>
        <tr>
            <td style="width: 264px; ">
             
                <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>Provider</asp:ListItem>
                    <asp:ListItem>Inv</asp:ListItem>
                    <asp:ListItem>Po</asp:ListItem>
                </asp:DropDownList>
                
               
              





                 </td>
            <td>
             <br />
                <asp:Panel ID="Panel1" runat="server" >

                     <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="144px" Height="26px" ></asp:TextBox>
               

                </asp:Panel>
                <br />

               
              





                 </td>
            <td>
                <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" Width="91px" OnClick="BTNBUSCAR_Click" Height="26px"  />

               
              





                 </td>
            <td>
               
                             
                <asp:TextBox ID="TXTDESDE" runat="server"  Width="144px" Height="26px" TextMode="Date"></asp:TextBox>
                </td>
            <td>
             
                <asp:TextBox ID="TXTHASTA" runat="server"  Width="144px" Height="26px" TextMode="Date" ></asp:TextBox>
                </td>
            <td>
                <asp:Button ID="BTNBUSCAR0" runat="server" Text="SEARCH" Width="91px" OnClick="BTNBUSCAR0_Click" Height="26px"  />

               
              





                </td>
        </tr>
        <tr>
            <td>
  
                
                &nbsp;</td>
            <td colspan="3">
  
                
                <strong>
  
              
               
                  </strong>
               
                  </td>
            <td>
  
                
                &nbsp;</td>
            <td>
  
                
                &nbsp;</td>
        </tr>
    </table>

    <div>

          
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small;" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
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
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date"
                                DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Provider" HeaderText="Provider" SortExpression="Provider" />
                            <asp:BoundField DataField="Inv" HeaderText="Inv" SortExpression="Inv" />
                            <asp:BoundField DataField="Po" HeaderText="Po" SortExpression="Po" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                            <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="True" SortExpression="Total" />
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

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT    ID,    DATE1 AS Date, PROVIDER AS Provider, INV AS Inv, PO AS Po, DESCRIPTION1 AS Description,'$'+TOTAL AS Total, USER1 AS [User] FROM            edgar2211.SPENDING   order by ID DESC"></asp:SqlDataSource>

    </div>




</asp:Content>
