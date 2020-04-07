<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="WAMDY.aspx.cs" Inherits="CanezPower.WAMDY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">


    


  <%--  <form id="form1" runat="server">--%>
        <table style="width: 13%">
            <tr>
                <td colspan="9">
                    <h1 style="color: #000000" class="auto-style29">WANDY</h1>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style67">Date:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="TXTDATE" runat="server"  style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style69">Client</td>
                <td class="auto-style70">
                    <b>
                    <asp:TextBox ID="txtcliente" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                    </b></td>
               
                <td style="text-align: right; color: #000000;" class="auto-style71">Front/Site/Reff</td>
               
                <td class="auto-style74">
                    <asp:TextBox ID="txtsite" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
                <td class="auto-style72"></td>
                <td class="auto-style72" style="font-size: small">&nbsp;</td>
                <td class="auto-style72">&nbsp;</td>
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style77">Motor Reff:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtmotorreff" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style54">Capacity</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcapacity" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style76">Motor Serial #</td>
               
                <td class="auto-style75">
                    <asp:TextBox ID="txtmotorserial" runat="server" style="font-weight: bold" Height="26px" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
               
                <td style="color: #000000; text-align: right;" class="auto-style61">Job Description:</td>
               
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtdescripcion" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
               
                <td style="color: #000000; text-align: right;" class="auto-style63">Date Out</td>
                <td class="auto-style64">
                    <asp:TextBox ID="txtdateout" runat="server"  style="font-weight: bold" Height="26px" TextMode="Date" CssClass="auto-style25" Width="144px"></asp:TextBox>
                </td>
             
                <td style="text-align: right; color: #000000;" class="auto-style65">Invoice:</td>
              
                <td class="auto-style66">
                    <asp:TextBox ID="txtinvoice" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
              
                <td style="color: #000000; text-align: right;" class="auto-style55">Total</td>
              
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txttotal" runat="server" Height="26px" CssClass="auto-style25"  Width="144px" style="font-weight: bold" TextMode="Number">0</asp:TextBox>
                </td>
              
                <td style="color: #000000; text-align: right;" class="auto-style57">Status:</td>
                <td class="auto-style58">
                    <asp:TextBox ID="txtestatus" runat="server"  style="font-weight: bold" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
                </td>
               
                <td style="text-align: right; color: #000000;" class="auto-style60">Warranty Tag:</td>
               
                <td class="auto-style59">
                    <asp:TextBox ID="txtmarray" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
            </tr>
            <tr>
             
                <td style="color: #000000; text-align: right;" class="auto-style77">CPD&nbsp; INV TAG</td>
             
                <td style="color: #000000; font-weight: bold;">
                    <asp:TextBox ID="txtcpdinv" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
             
                <td style="color: #000000; text-align: right;" class="auto-style54">CPD Total:</td>
                <td class="auto-style73">
                    <asp:TextBox ID="txtcpdtotal" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px" TextMode="Number">0</asp:TextBox>
                </td>
                
                <td style="text-align: right; color: #000000;" class="auto-style76">CPD INV Status</td>

                <td class="auto-style75">
                    <asp:TextBox ID="txtcpdinvstatus" runat="server" style="font-weight: bold" CssClass="auto-style25" Height="26px" Width="144px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
             
                <td style="color: #000000; " class="auto-style77">&nbsp;</td>
             
                <td style="color: #000000; ">
                    &nbsp;</td>
             
                <td style="color: #000000; " class="auto-style54">&nbsp;</td>
                <td class="auto-style79">
                    &nbsp;</td>
              
            </tr>
                        

            </table>
   
    <table style="width: 46%">
        <tr>
            <td style="width: 41px; text-align: right">Comments:</td>
            <td rowspan="2">
                    <asp:TextBox ID="TXTNOTAS" runat="server" CssClass="auto-style25" Height="68px" TextMode="MultiLine" Width="253px" style="font-weight: bold"></asp:TextBox>
                </td>
            <td>&nbsp;</td>
            <td>
                    <span style="font-size: small">TOTAL:$</span></td>
            <td>
                    <asp:Label ID="LBLESTADO0" runat="server" style="font-size: x-small; text-decoration: underline; color: #0000FF; font-weight: 700"></asp:Label>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 41px; text-align: right">&nbsp;</td>
            <td>
                    &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
  

    <table >
                    <tr>
                        <td >
                    <asp:Button ID="BTNSAVE" runat="server" Height="28px"  OnClientClick="return confirm('Are you sure you want to save this item?');" OnClick="BTNSAVE_Click" Text="SAVE" Width="97px" CssClass="auto-style25" />
                        </td>
                        <td >
                          
                    <asp:Button ID="BTNEDIT" runat="server" Height="28px"  OnClientClick="return confirm('Are you sure you want to edit this item?');"   Text="EDIT" Width="97px" CssClass="auto-style25" OnClick="BTNEDIT_Click" />
                         
                        </td>
                        <td >
                    <asp:Button ID="BTNDELETE" runat="server" Height="28px"  OnClientClick="return confirm('Are you sure you want to delete this item?');"  Text="DELETE" Width="97px" CssClass="auto-style25" OnClick="BTNDELETE_Click" />
                                          <tr>
                        <td >
                            &nbsp;</td>
                        <td >
                          
                            &nbsp;</td>
                        <td >
                            &nbsp;<tr>
                        <td >
                    <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                        </td>
                        <td >
                          
                            &nbsp;</td>
                        <td >
                            &nbsp;</table>

  
     <table class="auto-style81">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fault Search</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td ></td>
            <td style="text-align: left" >
                <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="144px">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>CLIENT</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TXTUSUARIO" runat="server" Height="26px" Width="144px" CssClass="auto-style25"></asp:TextBox>
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" Width="91px" />
                
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td style="text-align: left" >
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
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


            </td>
        </tr>
    </table>
</asp:Content>
