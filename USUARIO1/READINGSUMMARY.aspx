<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="READINGSUMMARY.aspx.cs" Inherits="CanezPower.USUARIO1.READINGSUMMARY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <h1>READING</h1>
  
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
    </table>
  
        <asp:GridView ID="GridView3" runat="server" Height="16px"   Width="697px" CellPadding="4" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                     



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


     
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING ORDER BY ID DESC"></asp:SqlDataSource>


     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
