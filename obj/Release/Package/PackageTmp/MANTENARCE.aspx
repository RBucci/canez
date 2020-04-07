<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="MANTENARCE.aspx.cs" Inherits="CanezPower.MANTENARCE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">




  <%--  <form id="form1" runat="server">--%>
        <table style="width: 88%">
            <tr>
                <td colspan="8">
                    <h1 style="color: #000000" class="auto-style29">MANTENANCE</h1>
                </td>
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style67">Date:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style68">
                    <asp:TextBox ID="TXTDATE" runat="server" BorderColor="White" style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; " class="auto-style69">Site:</td>
                <td class="auto-style70">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
                    </asp:DropDownList>
                    <b>:</b></td>
               
                <td style="text-align: right; color: #000000;" class="auto-style71">Genset</td>
               
                <td class="auto-style74">
                    <asp:DropDownList ID="CBGENSET" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                    </asp:DropDownList>
                </td>
                <td class="auto-style72"></td>
                <td class="auto-style72"></td>
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style77">Service Type:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:DropDownList ID="CBTYPESERVICE" runat="server" Height="25px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>CM</asp:ListItem>
                        <asp:ListItem>SERVICE</asp:ListItem>
                        <asp:ListItem>B.UP</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
                <td style="color: #000000; " class="auto-style54">Team</td>
                <td class="auto-style73">
                    <asp:DropDownList ID="CBTEAM" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                    </asp:DropDownList>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style76">Hour Meter Reading:</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="TXTORDMASATER" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style61">Oil Running Hr:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style62">
                    <asp:TextBox ID="TXTRUNING" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; " class="auto-style63">Oil Replace:</td>
                <td class="auto-style64">
                    <asp:DropDownList ID="CBENGIERREPLACE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                         <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style65">Oil Qty Removed:</td>
              
                <td class="auto-style66">
                    <asp:TextBox ID="TXTQTYREMOVEDOIL" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; " class="auto-style55">Oil Add:</td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style56">
                    <asp:TextBox ID="TXTGL" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold"></asp:TextBox>
                </td>
              
                <td style="color: #000000; " class="auto-style57">Oil Different:</td>
                <td class="auto-style58">
                    <asp:TextBox ID="YXYDIFERENT" runat="server" BorderColor="White" style="font-weight: bold" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style60">Oil Filter Replace:</td>
               
                <td class="auto-style59">
                    <asp:DropDownList ID="CBFILTERREPLACE" style="font-weight: bold" runat="server" Height="26px" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
            </tr>
            <tr>
             
                <td style="color: #000000; font-weight: bold;" class="auto-style34"><b style="color: #000000">Tank Decanter Replace:</b></td>
             
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:DropDownList ID="CBDECANTERFILTER" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
                <td style="color: #000000; " class="auto-style54">Pre-Fuel Filter Replace:</td>
                <td class="auto-style73">
                    <asp:DropDownList ID="CBRPRE_FILTERREPLACE" runat="server" Height="26px"  style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
                <td style="text-align: right; color: #000000;" class="auto-style76">Fuel&nbsp; Filter Replace: </td>

                <td class="auto-style75">
                    <asp:DropDownList ID="CBFUELFILTERREPLACE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
              
            </tr>
            <tr>
                
                <td style="color: #000000; " class="auto-style39">Inner Air Filter Replace:</td>
                
                <td style="color: #000000; font-weight: bold;" class="auto-style40">
                    <asp:DropDownList ID="CBINNERAIRFILTERREPLACE" style="font-weight: bold" runat="server" Height="26px" Width="143px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
                <td style="color: #000000; " class="auto-style46">Outer Air Filter Replace:</td>
                <td class="auto-style47">
                    <asp:DropDownList ID="CBAIRFILTEROUTERCHANGE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style31"><strong>Coolant Add:</strong></td>
                
                <td class="auto-style44">
                    <asp:DropDownList ID="CBCOOLANTADD" runat="server" Height="26px"  style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
            </tr>
            <tr>
             
                <td style="color: #000000; " class="auto-style77">Battery Walter Add:</td>
             
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:DropDownList ID="CBBACTERYWALTER" runat="server" Height="26px"  style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
                <td style="color: #000000; " class="auto-style54">Central Load:</td>
                <td class="auto-style73">
                    <asp:DropDownList ID="CBCENTRALLOAD" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25">
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>N/A</asp:ListItem>
                    </asp:DropDownList>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style35"><b style="color: #000000">Comments:</b></td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style37" colspan="5">
                    <asp:TextBox ID="TXTNOTAS" runat="server" CssClass="auto-style25" Height="68px" TextMode="MultiLine" Width="253px" style="font-weight: bold"></asp:TextBox>
                </td>
               
            </tr>
            

            <tr>
            
                <td colspan="1" class="auto-style78">
                    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                </td>
              
               
               
                <td class="auto-style49">
                    &nbsp;</td>
              
               
               
                <td class="auto-style48">
                    &nbsp;</td>
              
               
               
            </tr>
            

            </table>


    <table style="width: 254%; height: 222px;">
        <tr>
            <td style="width: 264px; height: 21px;"><span style="color: #000000"><span class="auto-style25">
                <br />
                <table class="auto-style50" align="center">
                    <tr>
                        <td class="auto-style51">
                    <asp:Button ID="BTNSAVE" runat="server" Height="28px" OnClick="BTNSAVE_Click" Text="SAVE" Width="97px" CssClass="auto-style25" />
                        </td>
                        <td class="auto-style51">
                            <span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNEDIT" runat="server" Height="28px"  Text="EDIT" Width="97px" CssClass="auto-style25" OnClick="BTNEDIT_Click" />
                            </span></span>
                        </td>
                        <td class="auto-style52"><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNDELETE" runat="server" Height="28px"  Text="DELETE" Width="97px" CssClass="auto-style25" OnClick="BTNDELETE_Click" />
                            </span></span>                </table>
                <br />
                SEARCH</span></span><span class="auto-style25">
                <br />
                </span>
                <asp:TextBox ID="TXTUSUARIO" runat="server" Height="26px" Width="240px" CssClass="auto-style25"></asp:TextBox>
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" />
            </td>
            <td style="width: 199px; height: 21px;">
                <br />
                &nbsp; </td>
            <td style="height: 21px; text-align: left;">
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" Height="106px"  Width="1909px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound1">
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
                    <HeaderStyle VerticalAlign="Bottom" BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>

            &nbsp;&nbsp;&nbsp;

                    
                <style type="text/css">
                    .vertical-text {
                        /*white-space: pre-wrap;
                        word-wrap: break-word;
                        width: 10px;
                        line-height: 25%;
                        filter: fliph()flipV();
                        writing-mode: vertical-rl;
                        width: 30xp;*/




                        /*display:block;*/
    	/*height:50px;
    	width:50px;*/
    	/*vertical-align:bottom;*/
		/*-webkit-transform: rotate(-40deg);     
		-moz-transform: rotate(-50deg);     
		-o-transform: rotate(-50deg);*/     
		/*filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=3*/






                    }
 
        




                    /*.auto-style6 {
                        height: 42px;
                    }
                    .auto-style7 {
                        width: 149px;
                        height: 42px;
                        font-size: xx-small;
                    }
                    .auto-style8 {
                        width: 115px;
                        height: 42px;
                    }
                    .auto-style10 {
                        width: 132px;
                        height: 42px;
                        font-size: x-small;
                        font-weight: bold;
                    }
                    .auto-style11 {
                        width: 133px;
                        height: 42px;
                    }
                    .auto-style12 {
                        width: 104px;
                        height: 42px;
                        font-size: xx-small;
                        font-weight: bold;
                    }
                    .auto-style14 {
                        width: 10px;
                    }
                    .auto-style15 {
                        width: 12px;
                    }
                                        
                    .auto-style16 {
                        width: 132px;
                        font-size: x-small;
                        font-weight: bold;
                    }
                    .auto-style17 {
                        width: 149px;
                        height: 24px;
                        font-size: xx-small;
                    }
                    .auto-style18 {
                        width: 115px;
                        height: 24px;
                    }
                    .auto-style19 {
                        width: 132px;
                        height: 24px;
                        font-size: x-small;
                        font-weight: bold;
                    }
                    .auto-style20 {
                        width: 133px;
                        height: 24px;
                    }
                    .auto-style21 {
                        width: 104px;
                        height: 24px;
                        font-size: xx-small;
                        font-weight: bold;
                    }
                    .auto-style22 {
                        height: 24px;
                    }
                    .auto-style23 {
                        width: 10px;
                        height: 24px;
                    }
                    .auto-style24 {
                        width: 12px;
                        height: 24px;
                    }
                                        
                    .auto-style25 {
                        font-size: xx-small;
                    }
                    .auto-style26 {
                        font-size: xx-small;
                        font-weight: bold;
                        width: 104px;
                    }
                    .auto-style27 {
                        font-size: xx-small;
                        width: 149px;
                    }
                    .auto-style28 {
                        width: 149px;
                    }
                    .auto-style29 {
                        font-size: x-large;
                    }
                                        
                    .auto-style31 {
                        font-size: xx-small;
                        width: 104px;
                    }
                    .auto-style32 {
                        width: 133px;
                    }
                    .auto-style33 {
                        width: 104px;
                    }*/
                                        
                    .auto-style29 {
                        height: 43px;
                    }
                    .auto-style31 {
                        width: 126px;
                        height: 29px;
                    }
                    .auto-style34 {
                        width: 70px;
                        text-align: right;
                    }
                    .auto-style35 {
                        height: 43px;
                        text-align: right;
                        width: 70px;
                    }
                                        
                    .auto-style37 {
                        height: 43px;
                        text-align: left;
                    }
                    .auto-style38 {
                        width: 54px;
                        text-align: left;
                    }
                    .auto-style39 {
                        width: 70px;
                        height: 29px;
                        text-align: right;
                        font-weight: bold;
                    }
                    .auto-style40 {
                        width: 54px;
                        text-align: left;
                        height: 29px;
                    }
                    .auto-style44 {
                        height: 29px;
                        width: 221px;
                    }
                    .auto-style46 {
                        width: 113px;
                        height: 29px;
                        text-align: right;
                        font-weight: bold;
                    }
                    .auto-style47 {
                        height: 29px;
                        width: 180px;
                    }
                    .auto-style48 {
                        width: 113px;
                    }
                    .auto-style49 {
                        width: 54px;
                    }
                                        
                    .auto-style50 {
                        width: 150%;
                        height: 26px;
                    }
                    .auto-style51 {
                        width: 301px;
                        height: 30px;
                    }
                    .auto-style52 {
                        width: 66px;
                        height: 30px;
                    }
                                        
                    .auto-style54 {
                        width: 113px;
                        text-align: right;
                        font-weight: bold;
                    }
                    .auto-style55 {
                        width: 70px;
                        text-align: right;
                        height: 33px;
                        font-weight: bold;
                    }
                    .auto-style56 {
                        width: 54px;
                        text-align: left;
                        height: 33px;
                    }
                    .auto-style57 {
                        width: 113px;
                        text-align: right;
                        height: 33px;
                        font-weight: bold;
                    }
                    .auto-style58 {
                        height: 33px;
                        width: 180px;
                    }
                    .auto-style59 {
                        height: 33px;
                        width: 221px;
                    }
                    .auto-style60 {
                        width: 126px;
                        height: 33px;
                        font-weight: bold;
                    }
                    .auto-style61 {
                        width: 70px;
                        text-align: right;
                        height: 34px;
                        font-weight: bold;
                    }
                    .auto-style62 {
                        width: 54px;
                        text-align: left;
                        height: 34px;
                    }
                    .auto-style63 {
                        width: 113px;
                        text-align: right;
                        height: 34px;
                        font-weight: bold;
                    }
                    .auto-style64 {
                        height: 34px;
                        width: 180px;
                    }
                    .auto-style65 {
                        width: 126px;
                        height: 34px;
                        font-weight: bold;
                    }
                    .auto-style66 {
                        height: 34px;
                        width: 221px;
                    }
                    .auto-style67 {
                        width: 70px;
                        text-align: right;
                        height: 32px;
                        font-weight: bold;
                    }
                    .auto-style68 {
                        width: 54px;
                        text-align: left;
                        height: 32px;
                    }
                    .auto-style69 {
                        width: 113px;
                        text-align: right;
                        height: 32px;
                        font-weight: bold;
                    }
                    .auto-style70 {
                        height: 32px;
                        width: 180px;
                    }
                    .auto-style71 {
                        width: 126px;
                        height: 32px;
                        font-weight: bold;
                    }
                    .auto-style72 {
                        height: 32px;
                    }
                    .auto-style73 {
                        width: 180px;
                    }
                    .auto-style74 {
                        height: 32px;
                        width: 221px;
                    }
                    .auto-style75 {
                        width: 221px;
                    }
                    .auto-style76 {
                        width: 126px;
                        font-weight: bold;
                    }
                    .auto-style77 {
                        width: 70px;
                        text-align: right;
                        font-weight: bold;
                    }
                    .auto-style78 {
                        width: 70px;
                    }
                                        
                    </style>


            </td>
        </tr>
    </table>




</asp:Content>
