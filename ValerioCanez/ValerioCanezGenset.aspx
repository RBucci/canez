<%@ Page Title="" Language="C#" MasterPageFile="~/ValerioCanez/Site.Master" AutoEventWireup="true" CodeFile="ValerioCanezGenset.aspx.cs" Inherits="CanezPower.ValerioCanez.ValerioCanezGenset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <script>
         function cambiaFoco(cajadestino) {
             /*Esta funcion funciona con KeyPress y recibe como parametro el nombre de la caja destino(que es una cadena)*/

             //Primero debes obtener el valor ascii de la tecla presionada 
             var key = window.event.keyCode;

             //Si es enter(13) 
             if (key == 13)
                 //Se pasa el foco a la caja destino 
                 document.getElementById(cajadestino);
             return cajadestino;
         }




    </script>
    <br />
    <table style="width: 97%; height: 209px;">
        <tr>
            <td class="text-left" colspan="4">
                <h2>VALERIO CANEZ S.A. </h2>
                <h2>SDMO Registration&nbsp;</h2>
                </td>
            <td class="text-center" style="width: 109px; text-align: center;">




                &nbsp;</td>
            <td class="text-center" style="width: 163px; text-align: center;">




                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 178px; text-align: center; height: 38px;">




                &nbsp;</td>
            <td style="width: 185px; text-align: center; height: 38px;">
                <%--     
                <asp:CheckBox ID="checrentail" runat="server" Text="Rental" />




                <asp:CheckBox ID="checoym" runat="server" Text="O&M" />--%>

            </td>
            <td style="text-align: center; height: 38px;" colspan="2">
     

            </td>
            <td style="text-align: center; " colspan="2" rowspan="2">
       
               <%--<asp:Button ID="btnbuscar0" runat="server"  Text="Search" Width="91px" OnClick="btnbuscar0_Click" />--%>



                </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 178px; height: 7px; text-align: center; font-weight: bold;">

                SELECT COLUMN</td>
            <td class="text-center" style="width: 185px; height: 7px; font-weight: bold; text-align: center;">

                SEARCH BY COLUMN</td>
            <td class="text-left" style="height: 7px" colspan="2">


                </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 178px; height: 54px">


                <asp:DropDownList ID="DROPCLIEN" runat="server" class="form-control">
                    <asp:ListItem>user1</asp:ListItem>
                    <asp:ListItem>addressuser</asp:ListItem>
                    <asp:ListItem>genset</asp:ListItem>
                    <asp:ListItem>genset_serial</asp:ListItem>
                              </asp:DropDownList>




            </td>
            <td class="text-left" style="width: 185px; height: 54px">

                <asp:Panel ID="Panel1" runat="server">

                    
                <asp:TextBox ID="TextBox1" runat="server"  class="form-control" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
                
                </asp:Panel>

                </td>
            <td class="text-left" style="height: 54px; width: 171px;">

                <asp:Button ID="btnbuscar" runat="server"  Text="Search"  class="btn btn-success" OnClick="btnbuscar_Click" Height="35px" Width="133px" />


                </td>
            <td class="text-left" style="height: 54px">




                <asp:HyperLink ID="HyperLink1" runat="server" class="btn btn-success" NavigateUrl="~/ValerioCanez/NewValerioCanez.aspx" >ADD NEW GENSET</asp:HyperLink>




                </td>
            <td class="text-left" style="height: 54px; width: 109px;">




<%--                <asp:Button ID="btnrentail" runat="server"  Text="Retail" Width="91px" OnClick="btnrentail_Click"  />

--%>


            </td>
            <td class="text-left" style="height: 54px; width: 163px;">



<%--
                <asp:Button ID="btnEngineReplacement" runat="server"  Text="Engine Replacement" Width="121px" OnClick="btnEngineReplacement_Click"/>--%>


                <asp:Button ID="sportexcel" runat="server"  Text="EXPORT EXCEL"  class="btn btn-success" OnClick="sportexcel_Click" Height="42px" />


                </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 23px; text-align: center;" colspan="2">


<%--                 &nbsp; &nbsp;  &nbsp;<asp:CheckBox ID="checleasing" runat="server" Text="Leasing" />
--%>

          <%--     
                <asp:CheckBox ID="checrentail" runat="server" Text="Rental" />




                <asp:CheckBox ID="checoym" runat="server" Text="O&M" />--%>




                <%--<asp:Button ID="btnbuscar0" runat="server"  Text="Search" Width="91px" OnClick="btnbuscar0_Click" />--%>


                </td>
            <td class="text-center" style="height: 23px; text-align: center;" colspan="2">

                &nbsp;</td>
            <td class="text-center" style="height: 23px; width: 109px; text-align: center;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 163px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 178px; height: 23px; text-align: center;">


                <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </td>
            <td class="text-center" style="width: 185px; height: 23px; text-align: center;">




                &nbsp;</td>
            <td class="text-center" style="height: 23px" colspan="2">

                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 109px;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 163px;">




                &nbsp;</td>
        </tr>
    </table>
      
   

    <table >
        <tr>
            <td>

  

                 <asp:GridView ID="GridView1" runat="server" class="table table-bordered"   Width="1208px"   AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataSourceID="SqlDataSource1" >
                    
                    
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
                             <asp:LinkButton Text="Select" ID="inSelect"  class="btn btn-warning" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Genset Serial" HeaderText="Genset Serial" SortExpression="Genset Serial" />
                            <asp:BoundField DataField="End User" HeaderText="Job Order" SortExpression="End User" />
                            <asp:BoundField DataField="Address" HeaderText="End User" SortExpression="Address" />
                            <asp:BoundField DataField="Engine" HeaderText="Engine" SortExpression="Engine" />
                            <asp:BoundField DataField="Engine Serial" HeaderText="Engine Serial" SortExpression="Engine Serial" />
                            <asp:BoundField DataField="Altentor" HeaderText="Altentor" SortExpression="Altentor" />
                            <asp:BoundField DataField="Altenator Serial" HeaderText="Altenator Serial" SortExpression="Altenator Serial" />
                            <asp:BoundField DataField="Serial Sold" HeaderText="Serial Sold" SortExpression="Serial Sold" />
                            <asp:BoundField DataField="Control Panel" HeaderText="Control Panel" SortExpression="Control Panel" />
                            <asp:BoundField DataField="Enclosure" HeaderText="Enclosure" SortExpression="Enclosure" />
                            <asp:BoundField DataField="Application" HeaderText="Application" SortExpression="Application" />
                            <asp:BoundField DataField="Frequency" HeaderText="Frequency" SortExpression="Frequency" />
                            <asp:BoundField DataField="Connection (Phase)" HeaderText="Connection (Phase)" SortExpression="Connection (Phase)" />
                            <asp:BoundField DataField="Voltage" HeaderText="Voltage" SortExpression="Voltage" />
                            <asp:BoundField DataField="Date of Delivery" HeaderText="Date of Delivery" SortExpression="Date of Delivery"  DataFormatString="{0:d}"/>
                            <asp:BoundField DataField="Date of Commissioning" HeaderText="Date of Commissioning" SortExpression="Date of Commissioning" DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Date Register" HeaderText="Date Register" ReadOnly="True" SortExpression="Date Register" DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Date Update" HeaderText="Date Update" ReadOnly="True" SortExpression="Date Update" DataFormatString="{0:d}"/>
                     
                    
                       
                    </Columns>
                  

                    <HeaderStyle CssClass="FixedHeader" VerticalAlign="Bottom" Width="980px"/>
                </asp:GridView>
                   
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT         genset AS Genset, genset_serial AS [Genset Serial], user1 AS [End User], addressuser AS Address, engine AS Engine, engine_serial AS [Engine Serial], altenator AS Altentor, altenator_serial AS [Altenator Serial], soid_serial AS [Serial Sold], contro_panel AS [Control Panel], enclosure AS Enclosure, application1 AS Application, frequency AS Frequency, connection AS [Connection (Phase)], voltage AS Voltage, CONVERT(date,Date_Delivery) AS [Date of Delivery], CONVERT(date, Date_Commssioning )AS [Date of Commissioning],CONVERT(date, date_register) AS [Date Register], CONVERT(date,date_Mode )AS [Date Update] FROM            edgar2211.Genset_Venta order by id desc"></asp:SqlDataSource>
                   
                  </td>
            <td>
  
              
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
