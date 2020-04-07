<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TTN.aspx.cs" Inherits="CanezPower.TTN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    


    <table style="width: 77%">
        <tr>
            <td colspan="4">
                <h2>TTN REGISTER</h2>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px" class="text-center">Site:</td>
            <td class="text-center" style="width: 72px">Task:</td>
            <td style="width: 123px" class="text-center">Target Date:</td>
            <td style="width: 106px" class="text-center">Assing To:</td>
            <td>Status:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px">
            <asp:DropDownList ID="CBSITE" runat="server" Height="27px" Width="100px" style="font-size: xx-small">
            </asp:DropDownList>
            </td>
            <td style="width: 72px">
            <asp:TextBox ID="TXTTAXK" runat="server" Width="103px"  MaxLength="200" style="font-size: xx-small" Height="16px"></asp:TextBox>
            </td>
            <td style="width: 123px">
            <asp:TextBox ID="TXTTAEGET" runat="server" Width="115px" Height="16px" MaxLength="200" TextMode="Date" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td style="width: 106px">
            <asp:DropDownList ID="CBASING" runat="server" Height="22px" Width="94px" style="font-size: xx-small">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="CBSTATUS" runat="server" Height="25px" Width="127px" style="font-size: xx-small">
                <asp:ListItem>OPEN</asp:ListItem>
                <asp:ListItem>ON GOING</asp:ListItem>
                <asp:ListItem>CLOSED</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px" class="text-center">Description</td>
            <td style="width: 72px">&nbsp;</td>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" rowspan="3"><asp:TextBox ID="TXTNOTA" runat="server" Width="182px"  MaxLength="200" Height="62px" TextMode="MultiLine" style="font-size: xx-small"></asp:TextBox>
            </td>
            <td style="width: 123px">
            <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE" Width="95px" OnClick="BTNGUARDAR_Click" style="font-size: xx-small" />
            </td>
            <td style="width: 106px" class="text-center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 123px">
            <asp:Button ID="BTNGUARDAR0" runat="server" Text="EDIT" Width="95px" style="font-size: xx-small" OnClick="EDIT" />
            </td>
            <td style="width: 106px">
                &nbsp;</td>
            <td class="text-left">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 123px">
            <asp:Button ID="BTNGUARDAR1" runat="server" Text="DELETE" Width="95px" OnClick="DELETE" style="font-size: xx-small" />
            </td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
               <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
            </td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px">
               <asp:Label ID="ESTADO" runat="server"></asp:Label>
            </td>
            <td style="width: 72px">&nbsp;</td>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px; height: 16px;" class="text-center">
                Assing To:</td>
            <td style="width: 72px; height: 16px;" class="text-center">
                Status:</td>
            <td style="width: 123px; height: 16px;" class="text-center">
                <span style="color: #000000">SEARCH</span></td>
            <td style="width: 106px; height: 16px;" class="text-center">&nbsp;</td>
            <td style="height: 16px"></td>
            <td style="height: 16px"></td>
        </tr>
        <tr>
            <td>
             
            <asp:DropDownList ID="CBASING0" runat="server" Height="22px" Width="94px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBASING0_SelectedIndexChanged">
            </asp:DropDownList>
                </td>
            <td style="width: 72px">
             
            <asp:DropDownList ID="CBSTATUS0" runat="server" Height="25px" Width="127px" style="font-size: xx-small" AutoPostBack="True" OnSelectedIndexChanged="CBSTATUS0_SelectedIndexChanged">
                <asp:ListItem>OPEN</asp:ListItem>
                <asp:ListItem>ON GOING</asp:ListItem>
                <asp:ListItem>CLOSED</asp:ListItem>
            </asp:DropDownList>
                </td>
            <td style="width: 123px">
             
                <asp:TextBox ID="TXTUSUARIO" runat="server"  Width="105px" Height="16px" style="font-size: xx-small"></asp:TextBox>
                </td>
            <td style="width: 106px">
             
                <asp:Button ID="Button1" runat="server" Text="SEARCH" Width="111px" style="font-size: xx-small" />
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px">TOTAL<asp:Label ID="LBLTOTAL" runat="server" Text=""></asp:Label>
                 </td>
            <td style="width: 72px">&nbsp;</td>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 105px">
             
                <asp:Button ID="Button2" runat="server" Text="NEXT" Width="111px" style="font-size: xx-small" OnClick="Button2_Click" Visible="False" />
                 </td>
            <td style="width: 72px">&nbsp;</td>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 106px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <strong>
                <asp:GridView ID="GridView1" runat="server" Height="16px"  Width="929px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                    
                    
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
               
                  </strong>
               
                  <br />
               
                  </td>
        </tr>
        <tr>
            <td colspan="6">
             
                <asp:Button ID="Button3" runat="server" Text="NEXT" Width="111px" style="font-size: xx-small" OnClick="Button3_Click" Visible="False" />
               
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
