<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Marriot.aspx.cs" Inherits="CanezPower.Marriot" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">       
     
    
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



    <table style="width: 70%; height: 329px;">
        <tr>
            <td colspan="4">
                <h3><strong>MARRIOTT POWER PLANT</strong></h3>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                <%--DATE--%> 

            </td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <%--<asp:TextBox ID="TXTDATE" runat="server" class="form-control" TextMode="Date" ></asp:TextBox>--%>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
               </td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <%--<asp:TextBox ID="txttime" runat="server" class="form-control" TextMode="Time"></asp:TextBox>--%>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                SITE</td>
            <td style="width: 60px">
               <asp:DropDownList ID="DROPSITE" class="form-control" aria-describedby="nameHelp" placeholder="Nombre Completo"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DROPSITE_SelectedIndexChanged">
                  
                  </asp:DropDownList>
                                  



            </td>
            <td style="font-weight: bold; text-align: right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                GENSET</td>
            <td style="width: 60px">
               <asp:DropDownList ID="DROPGENSET" class="form-control" aria-describedby="nameHelp" placeholder="Nombre Completo"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DROPGENSET_SelectedIndexChanged">
                  
                  </asp:DropDownList>
                                  



            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small">
                <strong>OIL TEMP</strong></span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTOILTEMP" runat="server" class="form-control" TextMode="Number" ></asp:TextBox>
                
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
            <span style="font-size: xx-small">
                <b>GENSET SERIAL</b></span></td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTSERIAL" runat="server" class="form-control" Enabled="False" Width="189px"  ></asp:TextBox>
            
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small">
                <strong>FUEL TEMP</strong></span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTFUELTEMP" runat="server" class="form-control" TextMode="Number" ></asp:TextBox>
                
                 </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                RUNNING HOURS</td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTRUNNIGNHURS" runat="server" class="form-control" TextMode="Number"  ></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                OIL PRESSURE</td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTPRESSURE" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
            
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                LOAD</td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTLOAD" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                CENTRAL LOAD</td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTCENTRALLOAD" runat="server" TextMode="Number" class="form-control"></asp:TextBox>

                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                WATER TEMP</td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTWATERTEMP" runat="server" TextMode="Number" class="form-control"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                TURBO A TEMP</td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTTUMBOATEMP" runat="server"   class="form-control" TextMode="Number"></asp:TextBox>

                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                TURBO B TEMP</td>
            <td style="width: 60px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTTUMBOTEMP" runat="server" class="form-control" TextMode="Number"></asp:TextBox>

                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                FUEL GENSET</td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTFUELGENSET" runat="server"  TextMode="Number" class="form-control"></asp:TextBox>

                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 124px;">
                COMENT</td>
            <td style="width: 60px">
                <span style="font-size: xx-small; font-weight: 700;">
           
               
                <asp:TextBox ID="TXTCOMENT" runat="server" class="form-control" TextMode="MultiLine" Width="146px" ></asp:TextBox>
                
              








                </span>




            </td>
            <td style="text-align: right; font-weight: 700">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="height: 23px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="height: 23px">
            <span style="font-size: xx-small">
                <asp:Button ID="BTNSAVE" runat="server" Text="SAVE AND SEND"    OnClientClick="return confirm('Are you sure you want to save this item?');" class="btn btn-success" OnClick="BTNSAVE_Click" />
                

                <asp:Button ID="BTNEDITAR" runat="server" Text="EDIT"  OnClientClick="return confirm('Are you sure you want to edit this item?');"  class="btn btn-info" OnClick="BTNEDITAR_Click" />
                




                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Visible="false"   OnClientClick="return confirm('Are you sure you want to delete this item?');"  class="btn btn-danger" />
                




                </span>




            </td>
        </tr>
        <tr>
            <td colspan="4">
  
                
   



            </td>
        </tr>
       
       </table>
 <br />
    <br />
    <br />
            <table style="width: 39%; height: 38px">
                <tr>
                    <td>
              
               <asp:DropDownList ID="cbcentro" class="form-control" aria-describedby="nameHelp" placeholder="Nombre Completo"  runat="server">
                    <asp:ListItem>Site1</asp:ListItem>
                   <asp:ListItem>Genset</asp:ListItem>
                   <asp:ListItem>Serial</asp:ListItem>
                   <asp:ListItem>RunningHours</asp:ListItem>
                  
                  </asp:DropDownList>
                                  
                    </td>
                    <td>
                 
                   <asp:TextBox ID="txtbuscar" class="form-control" aria-describedby="nameHelp" placeholder="Busqueda" runat="server" ></asp:TextBox>
                    </td>
                    <td>
                
                <asp:Button ID="BtnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="BtnBuscar_Click"  />
               
                    </td>
                </tr>
            </table>

   

               
  


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
                 <asp:GridView ID="GridView1" runat="server" class="table table-bordered" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="1140px" >
                    <Columns>

                           <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:LinkButton ID="Label1" runat="server"
                                    Text='<%# (GridView1.PageSize * GridView1.PageIndex) + Container.DisplayIndex + 1 %>'>
                                </asp:LinkButton>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          

                        <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" class="btn btn-warning" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>

                            <asp:BoundField DataField="id" HeaderText="Code" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="date1" HeaderText="Date" SortExpression="date1" DataFormatString="{0:d}" />
                            <asp:BoundField DataField="time1" HeaderText="Time" SortExpression="time1" />
                            <asp:BoundField DataField="site1" HeaderText="Site" SortExpression="site1" />
                            <asp:BoundField DataField="genset" HeaderText="Genset" SortExpression="genset" />
                            <asp:BoundField DataField="serial" HeaderText="Serial" SortExpression="serial" />
                            <asp:BoundField DataField="runninghours" HeaderText="Running Hours" SortExpression="runninghours" />
                            <asp:BoundField DataField="load1" HeaderText="Load" SortExpression="load1" />
                            <asp:BoundField DataField="watertemp" HeaderText="Water Temp" SortExpression="watertemp" />
                            <asp:BoundField DataField="turbobtemp" HeaderText="Turbo B Temp" SortExpression="turbobtemp" />
                            <asp:BoundField DataField="oiltemp" HeaderText="Oil Temp" SortExpression="oiltemp" />
                            <asp:BoundField DataField="fuletemp" HeaderText="Fule Temp" SortExpression="fuletemp" />
                            <asp:BoundField DataField="oilpressure" HeaderText="Oil Pressure" SortExpression="oilpressure" />
                            <asp:BoundField DataField="centralload" HeaderText="Central Load" SortExpression="centralload" />
                            <asp:BoundField DataField="turboatemp" HeaderText="Turbo A Temp" SortExpression="turboatemp" />
                            <asp:BoundField DataField="fuelgenset" HeaderText="Fuel Genset" SortExpression="fuelgenset" />
                            <asp:BoundField DataField="comment" HeaderText="Coment" SortExpression="comment" />
                            <asp:BoundField DataField="usert" HeaderText="Operator" SortExpression="usert" />
                            <asp:BoundField DataField="dateregister" HeaderText="Date Register" SortExpression="dateregister" DataFormatString="{0:d}" />

                    
                       
                    </Columns>
                  

                    <HeaderStyle VerticalAlign="Bottom"/>
                </asp:GridView>

                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select * from MARRIOT order by id desc"></asp:SqlDataSource>

</asp:Content>

