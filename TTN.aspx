<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TTN.aspx.cs" Inherits="CanezPower.TTN" %>
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





    <table style="width: 47%; height: 4px;">
        <tr>
            <td colspan="4">
                <h2>TROUBLE TIKET NUMBER</h2>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; font-weight: bold; text-align: center;" class="text-center">SITE</td>
            <td class="text-center" style="width: 72px; font-weight: bold; text-align: center;">TASK</td>
            <td style="width: 153px; font-weight: bold; text-align: center;" class="text-center">TARGET DATE</td>
            <td style="width: 106px; font-weight: bold; text-align: center;" class="text-center">ASSING TO</td>
            <td style="width: 106px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px">

                   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
              <asp:DropDownList ID="CBSITE" runat="server" Height="26px" Width="144px" AutoPostBack="true" style="font-size: xx-small" CssClass="FixedHeader" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
            </asp:DropDownList>
        </ContentTemplate>

        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="CBSITE" EventName="selectedindexchanged" />
        </Triggers>
    </asp:UpdatePanel>


          
            </td>
            <td style="width: 72px">
            <asp:TextBox ID="TXTTAXK" runat="server"  Height="26px" Width="144px"  MaxLength="200" style="font-size: xx-small"  CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td style="width: 153px">
            <asp:TextBox ID="TXTTAEGET" runat="server" Width="144px" Height="26px" MaxLength="200" TextMode="Date" style="font-size: xx-small" CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td style="width: 106px">
            <asp:DropDownList ID="CBASING" runat="server" Height="26px" Width="144px" style="font-size: xx-small" CssClass="FixedHeader">
            </asp:DropDownList>
            </td>
            <td style="width: 106px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; font-weight: bold; text-align: center;" class="text-center">GENSET</td>
            <td style="width: 72px; text-align: center;">&nbsp;</td>
            <td style="width: 153px; text-align: center;">&nbsp;</td>
            <td style="font-weight: bold; text-align: center;" class="text-center">STATUS</td>
            <td style="font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; font-weight: bold; text-align: center;" class="text-center">


                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="CBGENSET" runat="server" Height="26px" Width="144px" Style="font-size: xx-small" CssClass="FixedHeader">
                        </asp:DropDownList>
                    </ContentTemplate>


                </asp:UpdatePanel>
           
            </td>
            <td style="width: 72px; text-align: center;">&nbsp;</td>
            <td style="width: 153px; text-align: center;">&nbsp;</td>
            <td style="font-weight: bold; text-align: left;" class="text-center">
            <asp:DropDownList ID="CBSTATUS" runat="server" Height="26px" Width="144px" style="font-size: xx-small" CssClass="FixedHeader">
                <asp:ListItem>OPEN</asp:ListItem>
                <asp:ListItem>ON GOING</asp:ListItem>
                <asp:ListItem>CLOSED</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td style="font-weight: bold; text-align: left;" class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; font-weight: bold; text-align: right;" class="text-center">&nbsp;</td>
            <td style="width: 72px; text-align: center;">&nbsp;</td>
            <td style="width: 153px; text-align: center;">&nbsp;</td>
            <td style="font-weight: bold; text-align: left;" class="text-center">&nbsp;</td>
            <td style="font-weight: bold; text-align: left;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; font-weight: bold; text-align: center;" class="text-center">JOB DESCRIPTION</td>
            <td style="width: 153px; ">&nbsp;&nbsp;&nbsp;<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FEEDBACK DECRIPTION</strong></td>
            <td style="width: 153px; text-align: center;">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="115px" AllowMultiple="true"/>
            </td>
            <td style="font-weight: bold; text-align: left;" class="text-center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td style="font-weight: bold; text-align: left;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td rowspan="3" style="width: 144px; text-align: center;"><asp:TextBox ID="TXTNOTA" runat="server"  Height="60px" Width="144px" MaxLength="200" TextMode="MultiLine" style="font-size: xx-small" CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td rowspan="3" style="text-align: center">
                <asp:TextBox ID="TXTNOTA2" runat="server" Width="139px"  MaxLength="200" Height="62px" TextMode="MultiLine" style="font-size: xx-small" CssClass="FixedHeader"></asp:TextBox>
            </td>
            <td style="width: 153px">
                <asp:Button ID="save0" runat="server" Text="Upload File"   OnClick="save0_Click" Width="118px" />
            </td>
            <td class="text-center">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE AND SEND" Width="91px" OnClientClick="return confirm('Are you sure you want to save this item?');"  OnClick="BTNGUARDAR_Click" style="font-size: xx-small" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 153px">
                &nbsp;</td>
            <td class="text-center">
            <asp:Button ID="BTNGUARDAR0" runat="server" Text="EDIT" Width="91px"  OnClientClick="return confirm('Are you sure you want to edit this item?');"   style="font-size: xx-small" OnClick="EDIT" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 153px">
                &nbsp;</td>
            <td class="text-center">
            <asp:Button ID="BTNGUARDAR1" runat="server" Text="DELETE" Width="91px "  OnClientClick="return confirm('Are you sure you want to delete this item?');"  OnClick="DELETE" style="font-size: xx-small" CssClass="FixedHeader" />
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <b>
               <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </b>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px">
                <b>
               <asp:Label ID="ESTADO" runat="server"></asp:Label>
                </b>
            </td>
            <td style="width: 72px"><b></b></td>
            <td style="width: 153px"><b></b></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                &nbsp;</td>
            <td style="width: 72px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                &nbsp;</td>
            <td style="width: 153px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                &nbsp;</td>
            <td style="height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
            <td style="height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                </td>
            <td style="width: 72px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                </td>
            <td style="width: 153px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                </td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center"></td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                ASSING TO</td>
            <td style="width: 72px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                STATUS</td>
            <td style="width: 153px; height: 16px; font-weight: bold; text-align: center;" class="text-center">
                Search</td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
            <td style="width: 106px; height: 16px; font-weight: bold; text-align: center;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px">
             
            <asp:DropDownList ID="CBASING0" runat="server" Height="26px" Width="144px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBASING0_SelectedIndexChanged" CssClass="FixedHeader">
            </asp:DropDownList>
                </td>
            <td style="width: 72px">
             
            <asp:DropDownList ID="CBSTATUS0" runat="server" Height="26px" Width="144px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBSTATUS0_SelectedIndexChanged" CssClass="FixedHeader">
                <asp:ListItem>OPEN</asp:ListItem>
                <asp:ListItem>ON GOING</asp:ListItem>
                <asp:ListItem>CLOSED</asp:ListItem>
            </asp:DropDownList>
                </td>
            <td style="width: 153px">
                 <asp:DropDownList ID="cbcampo" runat="server" Height="26px" Width="144px" Style="font-size: xx-small" CssClass="FixedHeader">
                     <asp:ListItem>SITE</asp:ListItem>
                     <asp:ListItem>GENSET</asp:ListItem>
                     <asp:ListItem>TASK</asp:ListItem>
                     <asp:ListItem>NOTE</asp:ListItem>
                     <asp:ListItem>NOTE2</asp:ListItem>
                     <asp:ListItem></asp:ListItem>
                        </asp:DropDownList></td>
            <td style="width: 106px">
             
                <asp:Panel ID="Panel1" runat="server" Width="16px">
                    <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="144px" Height="26px" style="font-size: xx-small" CssClass="FixedHeader" ></asp:TextBox>
               

                </asp:Panel>
                 
                </td>
            <td style="width: 106px">
             
                <asp:Button ID="Button1" runat="server" Text="SEARCH" Width="91px" style="font-size: xx-small" OnClick="Button1_Click" CssClass="FixedHeader" />
                </td>
        </tr>
        <tr>
            <td style="width: 144px"><b><asp:Label ID="LBLTOTAL" runat="server" Text=""></asp:Label>
                 </b>
                 </td>
            <td style="width: 72px"><b></b></td>
            <td style="width: 153px"><b></b></td>
            <td style="width: 106px"><b></b></td>
            <td style="width: 106px">&nbsp;</td>
        </tr>
        </table>

   








     <table style="width: 100%">
                      <tr>
                          <td>

                              <asp:Panel ID="Panel2" runat="server">
                                  <strong>
                                  <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1099px" CssClass="auto-style25" style="font-size: x-small; text-align: left;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="TTN" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333"  >
                                      <%-- <AlternatingRowStyle BackColor="White" />
                    --%>
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
                                          <asp:BoundField DataField="TTN" HeaderText="TTN" InsertVisible="False" ReadOnly="True" SortExpression="TTN" />
                                          <asp:BoundField DataField="Create By" HeaderText="Create By" SortExpression="Create By" />
                                          <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                                           <asp:BoundField DataField="GENSET" HeaderText="Genset" SortExpression="GENSET" />
                                        
                                          <asp:BoundField DataField="Task" HeaderText="Task" SortExpression="Task" />
                                          <asp:BoundField DataField="Assing To" HeaderText="Assing To" SortExpression="Assing To" />
                                          <asp:BoundField DataField="Jod Description" HeaderText="Job Description" SortExpression="Jod Description" />
                                          <asp:BoundField DataField="Feedback Description" HeaderText="Feedback Description" SortExpression="Feedback Description" />
                                          <asp:TemplateField HeaderText="See Attachment">
                                              <ItemTemplate>
                                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                                              </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                                          <asp:BoundField DataField="USER1" HeaderText="CLOSED BY" SortExpression="USER1" />
                                          <asp:BoundField DataField="Target date" HeaderText="Target date" SortExpression="Target date"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                                          <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                                          <asp:BoundField DataField="Date Finish" HeaderText="Date Finish" SortExpression="Date Finish"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" />
                                      </Columns>
                                      <HeaderStyle VerticalAlign="Bottom" BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
                                      <%--  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />--%><%-- <RowStyle BackColor="#EFF3FB" />--%><%--  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />--%><%--   <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />--%>
                                  </asp:GridView>
                                  </strong>




                              </asp:Panel>      
                              <strong>
               
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site, edgar2211.ttn.GENSET AS Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET ORDER BY TTN DESC"></asp:SqlDataSource>
               
                  </strong>
               
                          </td>
                      </tr>
                </table>




  
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <%--<style type="text/css">
        .auto-style1 {
            text-align: right;
            height: 45px;
            width: 62px;
        }
        .auto-style2 {
            height: 48px;
            width: 13px;
            text-align: left;
        }
        .auto-style4 {
            height: 47px;
            width: 13px;
            text-align: left;
        }
        .auto-style5 {
            height: 43px;
            width: 13px;
            text-align: left;
        }
        .auto-style6 {
            height: 45px;
            width: 13px;
            text-align: left;
        }
        .auto-style8 {
            text-align: right;
            height: 48px;
            width: 62px;
        }
        .auto-style10 {
            text-align: right;
            height: 47px;
            width: 62px;
        }
        .auto-style11 {
            text-align: right;
            height: 43px;
            width: 62px;
        }
        .auto-style12 {
            height: 39px;
            width: 62px;
        }
    .auto-style13 {
        height: 31px;
        width: 106px;
    }
    .auto-style14 {
        height: 48px;
        width: 106px;
    }
    .auto-style16 {
        height: 47px;
        width: 106px;
    }
    .auto-style17 {
        height: 43px;
        width: 106px;
    }
    .auto-style18 {
        height: 45px;
        width: 106px;
    }
    .auto-style19 {
        height: 39px;
        width: 106px;
    }
    .auto-style24 {
        height: 31px;
        width: 14px;
    }
    .auto-style25 {
        text-align: right;
        height: 48px;
        width: 14px;
    }
    .auto-style27 {
        text-align: right;
        height: 47px;
        width: 14px;
    }
    .auto-style28 {
        text-align: right;
        height: 43px;
        width: 14px;
    }
    .auto-style29 {
        text-align: right;
        height: 45px;
        width: 14px;
    }
    .auto-style30 {
        height: 39px;
        width: 14px;
    }
    .auto-style31 {
        height: 44px;
        width: 115px;
    }
    .auto-style32 {
        height: 15px;
        width: 115px;
    }
    .auto-style33 {
        width: 115px;
    }
        .auto-style34 {
            width: 303px;
            height: 59px;
        }
        .auto-style35 {
            text-align: right;
            height: 59px;
            width: 14px;
        }
        .auto-style36 {
            text-align: right;
            height: 59px;
            width: 62px;
        }
        .auto-style37 {
            height: 59px;
            width: 13px;
            text-align: left;
        }
        .auto-style38 {
            height: 59px;
            width: 106px;
        }
        .auto-style39 {
            height: 39px;
            width: 13px;
        }
    </style>--%>

</asp:Content>
