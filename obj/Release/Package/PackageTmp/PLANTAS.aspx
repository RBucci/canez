<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PLANTAS.aspx.cs" Inherits="CanezPower.PLANTAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <td style="width: 112px; text-align: center;">




                <asp:HyperLink ID="HyperLink1" runat="server" style="font-size: x-small" NavigateUrl="~/NEWPLAN.aspx" OnLoad="HyperLink1_Load" >ADD NEW GENSET</asp:HyperLink>




            </td>
            <td style="width: 95px; text-align: center;">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/NEW_SITE.aspx" style="font-size: xx-small">ADD NEW SITE</asp:HyperLink>

            </td>
            <td style="text-align: center;">&nbsp;</td>
            <td style="width: 109px; text-align: center;">&nbsp;</td>
            <td style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 112px; height: 7px; text-align: center;">

                Select Column</td>
            <td class="text-center" style="width: 95px; height: 7px; text-align: center;">

                Search by column</td>
            <td class="text-left" style="height: 7px">


                </td>
            <td class="text-left" style="height: 7px; width: 109px;">




            </td>
            <td class="text-left" style="height: 7px; width: 100px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 112px; height: 23px">


                <asp:DropDownList ID="DROPCLIEN" runat="server" Height="24px" Width="126px" style="font-size: xx-small" OnSelectedIndexChanged="DROPCLIEN_SelectedIndexChanged">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>Genset</asp:ListItem>
                    <asp:ListItem>GENSETID</asp:ListItem>
                    <asp:ListItem>GENSETSERIAL</asp:ListItem>
                              </asp:DropDownList>




            </td>
            <td class="text-left" style="width: 95px; height: 23px">

                <asp:TextBox ID="TextBox1" runat="server" Width="114px" AutoPostBack="True"></asp:TextBox>


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


               
                <asp:CheckBox ID="checrentail" runat="server" Text="Retail" />




                <asp:CheckBox ID="checrental" runat="server" Text="Rental" />




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


                &nbsp;</td>
            <td class="text-center" style="width: 95px; height: 23px; text-align: center;">




                &nbsp;</td>
            <td class="text-center" style="height: 23px">

                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 109px;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
        </tr>
    </table>

    <br />

    <table style="width: 90%">
        <tr>
            <td style="width: 24px; ">
                </td>
            <td style="width: 264px; ">
                <asp:Label ID="LBLESTADO" runat="server" Text="Label"></asp:Label>
                </td>
            <td style="width: 199px; font-size: xx-small;">
                &nbsp;
                
            </td>
            <td style="text-align: left;"></td>
        </tr>
        <tr>
            <td style="width: 24px; font-size: xx-small;">
                &nbsp;</td>
            <td colspan="3">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="180px"  Width="1209px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnDataBound="GridView1_DataBound" >
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
    </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
