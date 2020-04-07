<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeBehind="PLANTAS.aspx.cs" Inherits="CanezPower.USUARIO2.PLANTAS" %>
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
            document.getElementById(cajadestino);
        return cajadestino;
} 




    </script>
    <br />
    <table style="width: 61%; height: 209px;">
        <tr>
            <td class="text-left" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<h2>&nbsp; INVENTORY</h2>
                </td>
            <td class="text-center" style="width: 109px">&nbsp;</td>
            <td class="text-center" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 112px; text-align: center; height: 38px;">




                <asp:HyperLink ID="HyperLink1" runat="server" style="font-size: x-small" Visible="false"  NavigateUrl="~/NEWPLAN.aspx" OnLoad="HyperLink1_Load" >ADD NEW GENSET</asp:HyperLink>




            </td>
            <td style="width: 107px; text-align: center; height: 38px;">
                <asp:HyperLink ID="HyperLink2" runat="server" Visible="false" NavigateUrl="~/NEW_SITE.aspx" style="font-size: x-small">ADD NEW SITE</asp:HyperLink>

            </td>
            <td style="text-align: center; height: 38px;">
                <asp:HyperLink ID="HyperLink3" runat="server" Visible="false" NavigateUrl="~/RENTAIL.aspx" style="font-size: x-small">RETAIL</asp:HyperLink>

            </td>
            <td style="width: 109px; text-align: center; height: 38px;"></td>
            <td style="width: 100px; height: 38px;"></td>
        </tr>
        <tr>
            <td class="text-center" style="width: 112px; height: 7px; text-align: center; font-weight: bold;">

                SELECT COLUMN</td>
            <td class="text-center" style="width: 107px; height: 7px; font-weight: bold;">

                SEARCH BY COLUMN</td>
            <td class="text-left" style="height: 7px">


                </td>
            <td class="text-left" style="height: 7px; width: 109px;">




            </td>
            <td class="text-left" style="height: 7px; width: 100px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 112px; height: 23px">


                <asp:DropDownList ID="DROPCLIEN" runat="server" Height="26px" Width="144px" style="font-size: xx-small" OnSelectedIndexChanged="DROPCLIEN_SelectedIndexChanged">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>Genset</asp:ListItem>
                    <asp:ListItem>GENSETID</asp:ListItem>
                    <asp:ListItem>GENSETSERIAL</asp:ListItem>
                              </asp:DropDownList>




            </td>
            <td class="text-left" style="width: 107px; height: 23px">

                <asp:Panel ID="Panel1" runat="server">

                    
                <asp:TextBox ID="TextBox1" runat="server"  Width="144px"  Height="26px" ></asp:TextBox>
                
                </asp:Panel>

                </td>
            <td class="text-left" style="height: 23px">

                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Search" Width="91px" />


                </td>
            <td class="text-left" style="height: 23px; width: 109px;">




            </td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 23px; text-align: center;" colspan="2">


                 &nbsp; &nbsp;  &nbsp;<asp:CheckBox ID="checleasing" runat="server" Text="Leasing" />


               
                <asp:CheckBox ID="checrentail" runat="server" Text="Rental" />




                <asp:CheckBox ID="checoym" runat="server" Text="O&M" />




                <asp:Button ID="btnbuscar0" runat="server"  Text="Search" Width="91px" OnClick="btnbuscar0_Click" />


                </td>
            <td class="text-center" style="height: 23px; text-align: center;">

                &nbsp;</td>
            <td class="text-center" style="height: 23px; width: 109px; text-align: center;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 112px; height: 23px; text-align: center;">


                <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </td>
            <td class="text-center" style="width: 107px; height: 23px; text-align: center;">




                &nbsp;</td>
            <td class="text-center" style="height: 23px">

                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 109px;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
        </tr>
    </table>
      
   

    <table >
        <tr>
            <td>

  

                 <asp:GridView ID="GridView1" runat="server"   Width="971px" CellPadding="4" ForeColor="#333333"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="true" >
                    
                    
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
                     
                    
                       
                    </Columns>
                  

                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle CssClass="FixedHeader" VerticalAlign="Bottom" BackColor="#507CD1" Width="980px" Font-Bold="False" ForeColor="White"/>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                   
                  </td>
            <td>
  
              
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
