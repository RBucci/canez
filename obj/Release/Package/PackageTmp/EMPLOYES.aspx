<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EMPLOYES.aspx.cs" Inherits="CanezPower.EMPLOYES" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">




    <table style="width: 100%">
        <tr>
            <td colspan="11">
                <h3><strong>REGISTER EMPLOYEE</strong></h3>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                Nif:</span><b></span></b></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNIF" runat="server" Width="150px" style="font-size: xx-small" ></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small">
                <strong>Nick Name:</strong></span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNICK" runat="server" Width="100px" style="font-size: xx-small" ></asp:TextBox>
                
                </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small">
                <b>First Name</b><strong>:</strong></span></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTNAME" runat="server" Width="150px" style="font-size: xx-small" OnTextChanged="TXTNAME_TextChanged" ></asp:TextBox>
            
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small">
                <strong>Last Name:</strong></span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTLASTNAME" runat="server" Width="150px" style="font-size: xx-small" ></asp:TextBox>
                
                 </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                Birthdate:</span><b></span></b></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="txtfirt" runat="server" Width="150px" style="font-size: xx-small" TextMode="Date" ></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small; font-weight: bold;">
                Title:</span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTTITLE" runat="server" Width="150px" style="font-size: xx-small"></asp:TextBox>
            
                </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2" rowspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                Section:</span></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTLOCATION" runat="server" Width="150px" style="font-size: xx-small"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small; font-weight: bold;">
                E-mailL:</span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTEMAIL" runat="server" TextMode="Email" Width="150px" style="font-size: xx-small"></asp:TextBox>

                </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                Phone Nomber:</span></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTPHONE" runat="server" TextMode="Phone" Width="150px" style="font-size: xx-small"></asp:TextBox>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small; font-weight: bold;">
                Starting Date</span></td>
            <td>
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTSTARTING" runat="server" Width="150px" TextMode="Date" style="font-size: xx-small"></asp:TextBox>

                </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                User:</span><b></span></b></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="CBTIPO" runat="server" Height="18px" Width="59px" style="font-size: xx-small">
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
            <span style="font-size: xx-small; font-weight: bold;">
                Driver License:</span></td>
            <td>
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="TXTLICENSE" runat="server" Height="22px" Width="179px" style="font-size: xx-small">
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
                Level</td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                
                <asp:DropDownList ID="CBTIPO0" runat="server" Height="18px" Width="59px" style="font-size: xx-small">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                </span>




            </td>
            <td style="font-weight: bold; text-align: right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 76px;">
            <span style="font-size: xx-small; font-weight: bold;">
                Bank Account:</span></td>
            <td style="width: 13px">
            <span style="font-size: xx-small">
                <asp:TextBox ID="TXTACCOUNT" runat="server" Width="150px" style="font-size: xx-small" ></asp:TextBox>
                </span>




            </td>
            <td>&nbsp;</td>
            <td>
            <span style="font-size: xx-small">
           
               
                Note:<br />
          
         
                <asp:TextBox ID="TXTNOTE" runat="server" Width="225px" style="font-size: xx-small" Height="37px" TextMode="MultiLine" ></asp:TextBox>
                
              








                </span></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="10" style="height: 23px">
            <span style="font-size: xx-small">
                <asp:Button ID="BTNSAVE" runat="server" Text="SAVE" Width="109px"  style="font-size: xx-small" OnClick="BTNSAVE_Click" />
                




                <asp:Button ID="BTNEDITAR" runat="server" Text="EDIT" Width="94px"  style="font-size: xx-small" OnClick="BTNEDITAR_Click" />
                




                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="91px"  style="font-size: xx-small" OnClick="BTNDELETE_Click" />
                




                <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
                            




                </span>




            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td colspan="3" style="height: 16px">
            <span style="font-size: xx-small">
                <span style="color: #000000">SEARCH<br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>NICK_NAME</asp:ListItem>
                    <asp:ListItem>TITLE</asp:ListItem>
                    <asp:ListItem>LEVEL1</asp:ListItem>
                    <asp:ListItem>NAME1</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TXTUSUARIO" runat="server" Width="146px" style="font-size: xx-small" AutoPostBack="True"></asp:TextBox>
                
                <asp:Button ID="BTNSAVE0" runat="server" Text="SEARCH" Width="109px"  style="font-size: xx-small" OnClick="BTNSAVE0_Click" />
                




                 <br />

                TOTAL:
                <asp:Label ID="LBLTOTAL" runat="server" Text=""></asp:Label>
                 <br />
                 </span></span>




            </td>
            <td style="height: 16px"></td>
            <td style="height: 16px">&nbsp;</td>
            <td style="height: 16px">&nbsp;</td>
            <td style="height: 16px">&nbsp;</td>
            <td style="height: 16px">&nbsp;</td>
            <td style="height: 16px">&nbsp;</td>
            <td style="height: 16px"></td>
            <td style="height: 16px"></td>
        </tr>
        <tr>
            <td colspan="11">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="983px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
                    <AlternatingRowStyle BackColor="White" />
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
        <tr>
            <td colspan="2">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>








</asp:Content>
