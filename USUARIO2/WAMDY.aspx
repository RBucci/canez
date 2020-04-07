<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="WAMDY.aspx.cs" Inherits="CanezPower.USUARIO2.WAMDY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">


    


  <%--  <form id="form1" runat="server">--%>
        <table style="width: 88%">
            <tr>
                <td colspan="8">
                    <h1 style="color: #000000" class="auto-style29">WANDY</h1>
                </td>
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style67">Date:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style68">
                    <asp:TextBox ID="TXTDATE" runat="server" BorderColor="White" style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; " class="auto-style69">Client:</td>
                <td class="auto-style70">
                    <b>
                    <asp:TextBox ID="txtcliente" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                    :</b></td>
               
                <td style="text-align: right; color: #000000;" class="auto-style71">Front/Site/Reff</td>
               
                <td class="auto-style74">
                    <asp:TextBox ID="txtsite" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
                <td class="auto-style72"></td>
                <td class="auto-style72"></td>
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style77">Motor Reff:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:TextBox ID="txtmotorreff" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; " class="auto-style54">Capacity</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcapacity" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style76">Motor Serial #</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="txtmotorserial" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
               
                <td style="color: #000000; " class="auto-style61">Job Description:</td>
               
                <td style="color: #000000; font-weight: bold;" class="auto-style62">
                    <asp:TextBox ID="txtdescripcion" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; " class="auto-style63">Date Out</td>
                <td class="auto-style64">
                    <asp:TextBox ID="txtdateout" runat="server" BorderColor="White" style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style65">Invoice:</td>
              
                <td class="auto-style66">
                    <asp:TextBox ID="txtinvoice" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; " class="auto-style55">Total</td>
              
                <td style="color: #000000; font-weight: bold;" class="auto-style56">
                    <asp:TextBox ID="txttotal" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold"></asp:TextBox>
                </td>
              
                <td style="color: #000000; " class="auto-style57">Status:</td>
                <td class="auto-style58">
                    <asp:TextBox ID="txtestatus" runat="server" BorderColor="White" style="font-weight: bold" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style60">Warranty Tag:</td>
               
                <td class="auto-style59">
                    <asp:TextBox ID="txtmarray" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
            </tr>
            <tr>
             
                <td style="color: #000000; " class="auto-style77">CPD&nbsp; INV TAG</td>
             
                <td style="color: #000000; font-weight: bold;" class="auto-style38">
                    <asp:TextBox ID="txtcpdinv" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="color: #000000; " class="auto-style54">CPD Total:</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcpdtotal" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
                
                <td style="text-align: right; color: #000000;" class="auto-style76">CPD INV Status</td>

                <td class="auto-style75">
                    <asp:TextBox ID="txtcpdinvstatus" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
             
                <td style="color: #000000; " class="auto-style77">&nbsp;</td>
             
                <td style="color: #000000; " class="auto-style80">
                    &nbsp;</td>
             
                <td style="color: #000000; " class="auto-style54">&nbsp;</td>
                <td class="auto-style79">
                    &nbsp;</td>
              
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


    <table style="width: 177%; height: 222px;">
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
                    <asp:Button ID="BTNDELETE" runat="server" Height="28px"  Text="DELETE" Width="97px" CssClass="auto-style25" OnClick="BTNDELETE_Click" Visible="False" />
                            </span></span>                </table>
                <br />
                SEARCH</span></span><span class="auto-style25">
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="99px">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>CLIENT</asp:ListItem>
                </asp:DropDownList>
                      <br />
                </span>
                <asp:TextBox ID="TXTUSUARIO" runat="server" Height="16px" Width="185px" CssClass="auto-style25"></asp:TextBox>
                  <br />
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" />
            </td>
            <td style="width: 264px; height: 21px;">&nbsp;</td>
            <td style="width: 199px; height: 21px;">
                <br />
                &nbsp; </td>
            <td style="height: 21px; text-align: left;">
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="4">
            <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1629px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound1">
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
                                        
                    .auto-style79 {
                        width: 180px;
                        font-weight: bold;
                    }
                    .auto-style80 {
                        width: 54px;
                        text-align: left;
                        font-weight: bold;
                    }
                                        
                    </style>


            </td>
        </tr>
    </table>

</asp:Content>
