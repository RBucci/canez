﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NEW_SITE.aspx.cs" Inherits="CanezPower.NEW_SITE" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

           <br />
    <br />
           <h2>NEW SITE</h2>
    <br />

    <table style="width: 90%">
        <tr>
            <td style="width: 24px; height: 44px;">
                <span style="font-size: xx-small"></td>
            <td style="height: 44px; width: 81px;">
                </span>
                <br style="font-size: xx-small" />
                <asp:TextBox ID="TextBox1" runat="server" Height="17px" Width="118px" style="font-size: xx-small"></asp:TextBox>

               
              





                 </td>
            <td style="height: 44px;" colspan="2">
                <span style="font-size: xx-small">

                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Search" Width="91px" />


                </span>

               
              





                 </td>
            <td style="height: 44px;" colspan="2">
                <br style="font-size: xx-small" />
                <span style="font-size: xx-small">&nbsp;
                </span>
                <br style="font-size: xx-small" />
            </td>
        </tr>
        <tr>
            <td style="width: 24px; height: 15px;">
                </td>
            <td style="width: 81px; height: 15px;">
                
                <asp:Button ID="BTNEXPO" runat="server" Text="SAVE" OnClick="BTNEXPO_Click" style="font-size: xx-small" Width="64px" />  
                
                 </td>
            <td style="width: 110px; height: 15px;">
                
                <asp:Button ID="BTNEDIT" runat="server" Text="EDIT" Width="78px"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNEDIT_Click" />
                
                 </td>
            <td style="height: 15px;">
                
                <asp:Button ID="BTNDELETE" runat="server" Text="DELETE" Width="78px"  style="font-weight: 700; font-size: xx-small;" OnClick="BTNDELETE_Click" />
                
                 </td>
            <td style="width: 199px; height: 15px;">
                <asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="198px" style="font-size: xx-small" Visible="False"></asp:TextBox>

               
              





            </td>
            <td style="height: 15px; text-align: left;">
                </td>
        </tr>
        <tr>
            <td style="width: 24px; ">
                </td>
            <td colspan="3">
                <asp:Label ID="LBLESTADO" runat="server" style="font-size: xx-small"></asp:Label>
                </td>
            <td style="width: 199px; ">
                </td>
            <td style="text-align: left;"></td>
        </tr>
        <tr>
            <td style="width: 24px; font-size: xx-small;">
                &nbsp;</td>
            <td colspan="5">
  
                
                <asp:GridView ID="GridView1" runat="server" Height="180px"  Width="539px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
