<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EMPLOYES.aspx.cs" Inherits="CanezPower.EMPLOYES" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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



    <table style="width: 67%">
        <tr>
            <td colspan="15">
                <h3><strong>REGISTER EMPLOYEE</strong></h3>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                NIF</span><b></span></b></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNIF" runat="server" class="form-control" ></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small">
                <strong>NICK NAME</strong></span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNICK" runat="server" class="form-control" ></asp:TextBox>
                
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small">
                <b>FIRST NAME</b></span></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNAME" runat="server" class="form-control" OnTextChanged="TXTNAME_TextChanged"  ></asp:TextBox>
            
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small">
                <strong>LAST NAME</strong></span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTLASTNAME" runat="server" class="form-control" ></asp:TextBox>
                
                 </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                BIRTHDATE</span></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="txtfirt" runat="server" class="form-control" TextMode="Date"  ></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small; font-weight: bold;">
                TITLE</span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTTITLE" runat="server" class="form-control"></asp:TextBox>
            
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                SECTION</span></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTLOCATION" runat="server" class="form-control"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small; font-weight: bold;">
                E-MAIL</span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTEMAIL" runat="server" TextMode="Email" class="form-control"></asp:TextBox>

                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                PHONE NUMBRE</span></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTPHONE" runat="server" TextMode="Phone" class="form-control"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small; font-weight: bold;">
                STARTING DATE</span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTSTARTING" runat="server"  TextMode="Date" class="form-control"></asp:TextBox>

                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                User:</span><b></span></b></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="CBTIPO" runat="server" class="form-control">
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
            <span style="font-size: xx-small; font-weight: bold;">
                DRIVER LICENSE</span></td>
            <td colspan="8">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="TXTLICENSE" runat="server" class="form-control">
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
                Level</td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="CBTIPO0" runat="server" class="form-control">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right" colspan="3">
                VC</td>
            <td colspan="8">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="CBTIPO1" runat="server" class="form-control">
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 107px;" colspan="2">
            <span style="font-size: xx-small; font-weight: bold;">
                BANK ACCOUNT</span></td>
            <td style="width: 161px" colspan="2">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTACCOUNT" runat="server" class="form-control" ></asp:TextBox>
                </span>




            </td>
            <td style="text-align: right; font-weight: 700" colspan="3">NOTE</td>
            <td colspan="8">
                <span style="font-size: xx-small; font-weight: 700;">
           
               
                <asp:TextBox ID="TXTNOTE" runat="server" class="form-control" TextMode="MultiLine" ></asp:TextBox>
                
              








                </span></td>
        </tr>
        <tr>
            <td colspan="15" style="height: 23px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="15" style="height: 23px">
            <span style="font-size: xx-small">
                <asp:Button ID="BTNSAVE" runat="server" Text="SAVE AND SEND"    OnClientClick="return confirm('Are you sure you want to save this item?');"  OnClick="BTNSAVE_Click" class="btn btn-success" />
                




                <asp:Button ID="BTNEDITAR" runat="server" Text="EDIT"  OnClientClick="return confirm('Are you sure you want to edit this item?');"  class="btn btn-info"   OnClick="BTNEDITAR_Click" />
                




                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE"   OnClientClick="return confirm('Are you sure you want to delete this item?');"  class="btn btn-danger" OnClick="BTNDELETE_Click" />
                




                </span>




            </td>
        </tr>
        <tr>
            <td colspan="15" style="height: 23px">
            <span style="font-size: xx-small">
                




                <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                            




                </span>




            </td>
        </tr>
        <tr>
            <td style="height: 23px">
                <span style="font-size: xx-small">
                <span style="color: #000000">
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                    <asp:ListItem>NICK_NAME</asp:ListItem>
                    <asp:ListItem>TITLE</asp:ListItem>
                    <asp:ListItem>LEVEL1</asp:ListItem>
                    <asp:ListItem>NAME1</asp:ListItem>
                </asp:DropDownList>
                 </span></span>




            </td>
            <td colspan="2" style="height: 23px">
                <span style="font-size: xx-small">
                <span style="color: #000000">
                         <asp:TextBox ID="TXTUSUARIO" runat="server" class="form-control"></asp:TextBox>
               

                 </span></span>




            </td>
            <td colspan="2" style="height: 23px">
                <span style="font-size: xx-small">
                <span style="color: #000000">
                <asp:Button ID="BTNSAVE0" runat="server" Text="SEARCH"  OnClick="BTNSAVE0_Click" class="btn btn-success" />
                




                 </span></span>




            </td>
            <td style="height: 23px">
                &nbsp;</td>
            <td colspan="3" style="height: 23px">
                &nbsp;</td>
            <td colspan="2" style="height: 23px">
                &nbsp;</td>
            <td colspan="3" style="height: 23px">
                &nbsp;</td>
            <td style="height: 23px; width: 268435488px;">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7" style="height: 16px">
                <span style="font-size: xx-small">
                <span style="color: #000000">
                    <asp:Panel ID="Panel1" runat="server">
               

                    </asp:Panel>
                




                 <br />

                TOTAL:
                <asp:Label ID="LBLTOTAL" runat="server" Text=""></asp:Label>
                 <br />
                 </span></span>




            </td>
            <td style="height: 16px" colspan="8"><span style="font-size: xx-small">
                <span style="color: #000000">
                
                <asp:Button ID="BTNSAVE1" runat="server" Text="RESET PASSWORD"  OnClientClick="return confirm('Are you sure you want to recieve the password?');"  OnClick="BTNSAVE1_Click"  class="btn btn-success" />
                




                 </span></span>




            </td>
        </tr>
        <tr>
            <td colspan="15">
  
                
                <asp:GridView ID="GridView1" runat="server" class="table table-bordered" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
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

                    
                       
                    </Columns>
                  

                    <HeaderStyle VerticalAlign="Bottom"/>
                </asp:GridView>




            </td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 268435488px">&nbsp;</td>
        </tr>
    </table>








</asp:Content>
