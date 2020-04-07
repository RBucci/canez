<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="READINGEDIT.aspx.cs" Inherits="CanezPower.USUARIO1.READINGEDIT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Edit Reading</h1>
  
    <table style="width: 38%">
        <tr>
            <td>&nbsp;</td>
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
        <tr>
            <td>&nbsp;</td>
            <td style="text-align: center">RUNNING HOURS</td>
            <td style="text-align: center">ENERGY</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">RATE</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>  <asp:TextBox ID="txthoras" runat="server" Text="0" TextMode="Number"  Height="26px"  Width="144px" ></asp:TextBox></td>
            <td>  <asp:TextBox ID="txtenergy" runat="server"  Text="0" TextMode="Number" Height="26px"  Width="144px" ></asp:TextBox></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>  <asp:TextBox ID="txtrate" runat="server"  Text="0" TextMode="Number" Height="26px"  Width="144px" ></asp:TextBox></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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
        <tr>
            <td>&nbsp;</td>
            <td><span style="color: #000000"><span class="auto-style25">
                    <asp:Button ID="BTNSAVE" runat="server" OnClientClick="return confirm('Are you sure you want to save this item?');" Visible="false"   Text="SAVE AND SEND" Width="91px" CssClass="auto-style25" OnClick="BTNSAVE_Click" />
                </span></span></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SITE</td>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MONTH</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="16px" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged" Width="141px">
                    </asp:DropDownList>
                    </td>
            <td colspan="2">  <asp:TextBox ID="txtmesreading" runat="server" Height="26px" TextMode="Month" Width="144px" AutoPostBack="True" OnTextChanged="txtmesreading_TextChanged"></asp:TextBox></td>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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
     <asp:GridView ID="GridView3" runat="server" Height="16px"   Width="777px" CellPadding="4" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView3_SelectedIndexChanged1" >
         <Columns>
             
                          <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView3.PageSize * GridView3.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>

             


                         <%--<asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Delete" ID="inDelete" runat="server"  OnClientClick="return confirm('Are you sure you want to delete this item?');" CommandName="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
             
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="SITE" HeaderText="SITE" SortExpression="SITE" />
                        <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                        <asp:BoundField DataField=" RUNNING HOURS" HeaderText=" RUNNING HOURS" SortExpression=" RUNNING HOURS" />
                        <asp:BoundField DataField="ENERGY" HeaderText="ENERGY" SortExpression="ENERGY" />
                        <asp:BoundField DataField="RATE" HeaderText="RATE" SortExpression="RATE" />
                        <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE"
                         DataFormatString="{0:Y}"
                         HtmlEncode="false" 
                            />
                        <asp:BoundField DataField="USER1" HeaderText="LOADED BY" SortExpression="USER1" />






         </Columns>
                    <AlternatingRowStyle BackColor="White" />
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




       
  <br />

        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
