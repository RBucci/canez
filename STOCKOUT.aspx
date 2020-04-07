<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="STOCKOUT.aspx.cs" Inherits="CanezPower.STOCKOUT" %>

<script runat="server">

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowIndex == 0)
                e.Row.Style.Add("height", "50px");
        }
    }
</script>

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
    <table style="width: 49%">
        <tr>
            <td colspan="2" style="font-size: xx-large" rowspan="2">
                <h2>STOCK OUT</h2>
            </td>
            <td rowspan="2">&nbsp;</td>
            <td rowspan="2">&nbsp;</td>
            <td>TOTAL: $&nbsp;&nbsp;&nbsp;<asp:Label ID="LBLESTADO0" runat="server" style="color: #0066FF; text-decoration: underline"></asp:Label>

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px; text-align: center;">
                TEAM</td>
            <td style="text-align: center"><b>SITE</b></td>
            <td style="text-align: center"><b>GENSET</b></td>
            <td style="text-align: center"><b>GENSET SERIAL N</b></td>
            <td style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px; font-weight: bold;">
                <asp:DropDownList ID="DROPTEAM" runat="server" Height="26px" Width="144px">
                </asp:DropDownList>
            </td>
            <td class="text-center" style="height: 16px; font-weight: bold;">
                <asp:DropDownList ID="DROPSITE" runat="server" Height="26px" Width="144px" OnSelectedIndexChanged="DROPSITE_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="text-center" style="height: 16px; font-weight: bold;">
                <asp:DropDownList ID="DROPGENSET" runat="server" Height="26px" Width="144px" OnSelectedIndexChanged="DROPGENSET_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="text-center" style="height: 16px; font-weight: bold;">
                <asp:TextBox ID="TXTSERIAL" runat="server" Height="26px" Width="144px"  Enabled="False"></asp:TextBox>
            </td>
            <td class="text-center" style="height: 16px; font-weight: bold;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="height: 16px; font-weight: bold;">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 16px; width: 121px; font-weight: bold; text-align: center;">PART #</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">ACCPAC</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">DESCRIPTION</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">QTY</td>
            <td class="text-center" style="height: 16px; font-weight: bold; text-align: center;">NOTE</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px; height: 30px;">
                <asp:DropDownList ID="DROPPART" runat="server" Height="26px" Width="144px" AutoPostBack="True" OnSelectedIndexChanged="DROPPART_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="text-center" style="height: 30px">
                <asp:TextBox ID="TXTACCPAC" runat="server" Height="26px" Width="144px"  Enabled="False"></asp:TextBox>
            </td>
            <td class="text-center" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION" runat="server" Height="45px" Width="144px" TextMode="MultiLine" Enabled="False"></asp:TextBox>
            </td>
            <td class="text-center" style="height: 30px">
                <asp:TextBox ID="TXTQTY" runat="server" Height="26px" Width="144px"  TextMode="Number">0</asp:TextBox>
            </td>
            <td class="text-center" style="font-weight: bold" rowspan="2">
                <asp:TextBox ID="TXTDESCRIPTION0" runat="server" Height="45px" Width="144px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px; font-weight: bold;">&nbsp;</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td class="text-center">
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 121px">
                <asp:Button ID="BTNSAVE" runat="server" Text="SAVE AND SEND" OnClick="Button3_Click" Width="91px" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold">
                &nbsp;</td>
            <td class="text-center" style="font-weight: bold">
                <asp:TextBox ID="TXTCANTI" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" Enabled="False" Visible="False"></asp:TextBox>
            </td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px"><b></b></td>
            <td colspan="2">

    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>

    

            </td>
            <td><b></b></td>
            <td>&nbsp;</td>
        </tr>
    </table>

    

    <table >
        <tr>
            <td >TOTAL: <asp:Label ID="LBLESTADO1" runat="server" style="color: #0066FF; text-decoration: underline"></asp:Label>

            </td>
            <td >&nbsp;</td>
            <td> &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="width: 5px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: center" >Search</td>
            <td class="text-center" style="font-weight: bold">&nbsp;</td>
            <td><b></b></td>
            <td style="text-align: center"><b>SINCE</b></td>
            <td style="text-align: center"><b>UNTIL</b></td>
            <td style="width: 5px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">
                <asp:DropDownList ID="DROPCAMPO" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>PART</asp:ListItem>
                    <asp:ListItem>ACCPAC</asp:ListItem>
                    <asp:ListItem>TEAM</asp:ListItem>
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>GENSET</asp:ListItem>
                    <asp:ListItem>GENSETSERIAL</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                
                <asp:Panel ID="Panel1" runat="server">
                     <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="144px"  ></asp:TextBox>
      
                </asp:Panel>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button6_Click" Width="91px"  />
            </td>
            <td style="text-align: center"><b>
                <asp:TextBox ID="TXTDESDE" runat="server" Height="26px" Width="144px"  TextMode="Date" ></asp:TextBox>
                </b></td>
            <td style="text-align: center"><b>
                <asp:TextBox ID="TXTHASTA" runat="server" Height="26px" Width="144px"  TextMode="Date" ></asp:TextBox>
                </b></td>
            <td style="width: 5px">
                <asp:Button ID="Button6" runat="server" Text="SEARSH"  Width="91px" OnClick="Button6_Click1" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <table style="width: 122%">
        <tr>
            <td>
  
         
  
               
                  </td>
        </tr>
</table>
        <table style="width: 1049px; background-color: #507CD1; color:#ffffff">
            <tr>
                <td style="width:10PX">NO.</td>
                <td style="width:20PX"> &nbsp;</td>
                <td style="width:35PX">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID</td>
                <td style="width:20PX">DATE</td>
                <td style="width:35PX">&nbsp;&nbsp; TEAM</td>
                <td style="width:33px">&nbsp;&nbsp;&nbsp; SITE</td>
                <td style="width:30px">GENSET</td>
                <td style="width:120px">GENSET SERIAL</td>
                <td style="width:60px">PART#</td>
                <td style="width:80px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACCPAC</td>
                <td style="width:50px">&nbsp; &nbsp;CATEGORY</td>
                
                <td style="width:30PX">&nbsp; COST</td>
                <td style="width:30PX">&nbsp;&nbsp;&nbsp; QTY</td>
                <td style="width:90PX">TOTAL</td>
                <td style="width:71px">NOTE</td>
                <td style="width:30PX">USER</td>
            </tr>
        </table>
 
    
                <div class="scroll" style="width: 1068px; height: 271px">
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1049px" CellPadding="4" ForeColor="Black" ShowHeader="false"   Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" 
 OnRowDataBound="GridView1_RowDataBound">
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
                             <asp:LinkButton Text="DELETE" ID="inSelect" runat="server" CommandName="Select" OnClientClick="return confirm('are you sure you want to erase this item?');" />
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" 
                                 DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="TEAM" HeaderText="TEAM" SortExpression="TEAM" />
                            <asp:BoundField DataField="SITE" HeaderText="SITE" SortExpression="SITE" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                            <asp:BoundField DataField="GENSET_SERIAL" HeaderText="GENSET_SERIAL" SortExpression="GENSET_SERIAL" />
                            <asp:BoundField DataField="PART" HeaderText="PART" SortExpression="PART" />
                            <asp:BoundField DataField="ACCPAC" HeaderText="ACCPAC" SortExpression="ACCPAC" />
                            <asp:BoundField DataField="CATEGORY" HeaderText="CATEGORY" SortExpression="CATEGORY" />
                            <asp:BoundField DataField="COST" HeaderText="COST" ReadOnly="True" SortExpression="COST" />
                            <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                            <asp:BoundField DataField="TOTAL" HeaderText="TOTAL" ReadOnly="True" SortExpression="TOTAL" />
                            <asp:BoundField DataField="NOTE" HeaderText="NOTE" SortExpression="NOTE" />
                            <asp:BoundField DataField="USER1" HeaderText="Create By" SortExpression="USER1" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,  edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.PART = edgar2211.SPARTPART.PART   order by ID DESC
"></asp:SqlDataSource>
               </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
