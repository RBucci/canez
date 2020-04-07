<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site1.Master" AutoEventWireup="true" CodeFile="PLANTAS1.aspx.cs" Inherits="CanezPower.USUARIO1.PLANTAS1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
    <br />
    <table style="width: 91%">
        <tr>
            <td class="text-left" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<h2>&nbsp; INVENTORY</h2>
                </td>
            <td class="text-center" style="width: 148px">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 135px">Contract</td>
            <td class="text-center" style="width: 132px">Site</td>
            <td class="text-center" style="width: 104px">Genset Model</td>
            <td class="text-center" style="width: 148px">Team</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="height: 23px; width: 135px">

                <asp:DropDownList ID="DROPCONTRACT" runat="server" Height="24px" Width="126px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="DROPCONTRACT_SelectedIndexChanged">
                    <asp:ListItem>All</asp:ListItem>
                    <asp:ListItem>Rental</asp:ListItem>
                     <asp:ListItem>Leasing</asp:ListItem>
                    <asp:ListItem>O&amp;M</asp:ListItem>
                    <asp:ListItem>Retail</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="text-left" style="height: 23px; width: 132px">

                <asp:DropDownList ID="DROPSITE" runat="server" Height="24px" Width="126px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="DROPSITE_SelectedIndexChanged">

                </asp:DropDownList>


                </td>
            <td class="text-left" style="height: 23px; width: 104px">

                <asp:DropDownList ID="DROPGENSET" runat="server" Height="24px" Width="126px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="DROPGENSET_SelectedIndexChanged">
                </asp:DropDownList>


                </td>
            <td class="text-left" style="height: 23px; width: 148px;">


            <asp:DropDownList ID="CBASING" runat="server" Height="24px" Width="126px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBASING_SelectedIndexChanged">
            </asp:DropDownList>




            </td>
            <td style="height: 23px">




               &nbsp;&nbsp;&nbsp; 




            </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 135px; height: 16px">

            </td>
            <td class="text-left" style="width: 132px; height: 16px">


                </td>
            <td class="text-left" style="width: 104px; height: 16px">


                </td>
            <td class="text-left" style="height: 16px; width: 148px;">




            </td>
            <td class="text-left" style="height: 16px; ">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 135px; height: 7px">

                Select Column</td>
            <td class="text-center" style="width: 132px; height: 7px">

                Search by column</td>
            <td class="text-left" style="width: 104px; height: 7px">


                </td>
            <td class="text-left" style="height: 7px; width: 148px;">




            </td>
            <td class="text-left" style="height: 7px">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 135px; height: 23px">


                <asp:DropDownList ID="DROPCLIEN" runat="server" Height="24px" Width="126px" style="font-size: xx-small" OnSelectedIndexChanged="DROPCLIEN_SelectedIndexChanged">
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>Genset</asp:ListItem>
                    <asp:ListItem>GENSETID</asp:ListItem>
                    <asp:ListItem>GENSETSERIAL</asp:ListItem>
                    <asp:ListItem>ENERGIE_MODEL</asp:ListItem>
                    <asp:ListItem>TEAM</asp:ListItem>
                    <asp:ListItem>CONTRACT</asp:ListItem>
                </asp:DropDownList>




            </td>
            <td class="text-left" style="width: 132px; height: 23px">

                <asp:TextBox ID="TextBox1" runat="server" Width="114px"></asp:TextBox>


                </td>
            <td class="text-left" style="width: 104px; height: 23px">

                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Search" Width="91px" />


                </td>
            <td class="text-left" style="height: 23px; width: 148px;">




            </td>
            <td class="text-left" style="height: 23px">




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
  
                
                <strong>
  
                
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="1225px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
                    <SortedAscendingHeaderStyle BackColor="Black" />
                    <SortedDescendingCellStyle BackColor="Black" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
               
                  </strong>
               
                  </td>
        </tr>
    </table>

</asp:Content>
