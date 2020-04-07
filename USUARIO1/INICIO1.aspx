<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="INICIO1.aspx.cs" Inherits="CanezPower.USUARIO1.INICIO1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    <h2>DASHBOARD</h2>
    <table style="width: 86%; height: 127px;">
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Height="32px" Text="INVENTORY" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button3_Click" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Height="32px" Text="SERVICE" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button4_Click" />
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" Height="32px" Text="SHOP" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button6_Click" />
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" Height="32px" Text="FF-CM" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button8_Click" />
            </td>
            <td style="width: 5px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Height="32px" Text="CM" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button11" runat="server" Height="32px" Text="TTN" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button11_Click" />
            </td>
            <td>
                <asp:Button ID="Button9" runat="server" Height="32px" Text="CLIENT" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button9_Click" />
            </td>
            <td>
                <asp:Button ID="Button7" runat="server" Height="32px" Text="EMPLOYEE" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button7_Click" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Height="32px" Text="SPENDING TRACK" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button5_Click1" />
            </td>
            <td style="width: 5px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button10" runat="server" Height="32px" Text="INVOICES TRACK" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button10_Click" />
            </td>
        </tr>
    </table>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">

                

    <table style="width: 2%; height: 26px;">
                    <tr>
                        <td colspan="3">
                            <h2>EXTRACTING REPORT</h2>
                            <h2></h2>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <h5>SITE</h5>
                        </td>
                        <td style="width: 375px">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="16px" style="font-weight: bold" Width="188px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
                    </asp:DropDownList>
                        </td>
                        <td>
                     
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <h5>GENSET</h5>
                        </td>
                        <td style="width: 375px">
                    <asp:DropDownList ID="CBGENSET" runat="server" Height="16px" style="font-weight: bold" Width="187px" CssClass="auto-style25">
                    </asp:DropDownList>
                        </td>
                        <td>
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" />
                        </td>
                    </tr>
                </table>
     
           <table style="width: 39%; height: 2px;">
                                <tr>
                                    <td style="width: 124px"><asp:CheckBox ID="checkmaintenance" runat="server" Text="SERVICE" CssClass="FixedHeader" />


               
                                    </td>
                                    <td style="width: 124px"><asp:CheckBox ID="CHECKSHOP" runat="server" Text="SHOP" CssClass="FixedHeader" />


               
                                    </td>
                                    <td style="width: 124px"><asp:CheckBox ID="CHECKCM" runat="server" Text="FF-CM" CssClass="FixedHeader" />


               
                                    </td>
                                    <td style="width: 124px">

                            <asp:CheckBox ID="CHECKFFCM" runat="server" Text="CM" CssClass="FixedHeader" />


               
                                    </td>
                                    <td style="width: 124px">

                            <asp:CheckBox ID="CEHPTTN" runat="server" Text="TTN" CssClass="FixedHeader" />


               
                                    </td>
                                </tr>
                                </table>


               
                

    <table style="width: 80%; margin-right: 0px;">
        <tr>
            <td colspan="5">
                <h4>SERVICE</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
            <asp:GridView ID="GridView6" runat="server" Height="16px"  Width="940px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; margin-right: 0px;" Font-Names="Latha" Font-Size="5pt">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server"
                                    Text='<%# (GridView6.PageSize * GridView6.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
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
        <tr>
            <td colspan="6">
                <h4>SHOP
                </h4>
                <asp:Label ID="lblshop" runat="server" Text="Label" Visible="False" style="font-size: x-small"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
            <asp:GridView ID="GridView5" runat="server" Height="16px"  Width="935px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; margin-right: 0px;" Font-Names="Latha">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server"
                                    Text='<%# (GridView5.PageSize * GridView5.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
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
        <tr>
            <td colspan="5" style="height: 17px">
            </td>
            <td style="height: 17px"></td>
        </tr>
        <tr>
            <td colspan="5" style="height: 16px; font-size: small">
                <h4>CORRECTIVE MAINTENANCE</h4>
            </td>
            <td style="height: 16px"></td>
        </tr>
        <tr>
            <td colspan="5">
            <asp:GridView ID="GridView2" runat="server" Height="16px"  Width="931px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; margin-right: 0px;" Font-Names="Latha">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"
                                    Text='<%# (GridView2.PageSize * GridView2.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <h4>FUEL FILTER REPLACEMENT-CM</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
            <asp:GridView ID="GridView4" runat="server" Height="16px"  Width="930px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; margin-right: 0px;" Font-Names="Latha">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server"
                                    Text='<%# (GridView4.PageSize * GridView4.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
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
        <tr>
            <td colspan="5">
                <h4>TROUBLE TIKET NUMBER</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
            <asp:GridView ID="GridView3" runat="server" Height="16px"  Width="931px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; margin-right: 0px;" Font-Names="Latha">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server"
                                    Text='<%# (GridView3.PageSize * GridView3.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
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
        <tr>
            <td colspan="5">
                <h2>&nbsp;</h2>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>
