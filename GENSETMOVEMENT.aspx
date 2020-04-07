<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="GENSETMOVEMENT.aspx.cs" Inherits="CanezPower.GENSETMOVEMENT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
     <br />
    <table style="width: 61%; height: 209px;">
        <tr>
            <td class="text-left" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<h2>GENSET MOVEMENT</h2>
                </td>
            <td class="text-center" style="width: 109px">&nbsp;</td>
            <td class="text-center" style="width: 100px">&nbsp;</td>
            <td class="text-center" style="width: 100px">&nbsp;</td>
            <td class="text-center" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 112px; text-align: center; height: 38px;">




                &nbsp;</td>
            <td style="width: 107px; text-align: center; height: 38px;">
                &nbsp;</td>
            <td style="text-align: center; height: 38px;">
                &nbsp;</td>
            <td style="width: 109px; text-align: center; height: 38px;"></td>
            <td style="width: 100px; height: 38px;"></td>
            <td style="width: 100px; height: 38px;">&nbsp;</td>
            <td style="width: 100px; height: 38px;">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 112px; height: 7px; text-align: center; font-weight: bold;">

                SELECT COLUMN</td>
            <td class="text-center" style="width: 107px; height: 7px; font-weight: bold; text-align: center;">

                SEARCH BY COLUMN</td>
            <td class="text-left" style="height: 7px">


                </td>
            <td class="text-left" style="height: 7px; width: 109px;">




            </td>
            <td class="text-left" style="height: 7px; width: 100px; text-align: center;">




                SINCE</td>
            <td class="text-left" style="height: 7px; width: 100px; text-align: center;">




                UNTIL</td>
            <td class="text-left" style="height: 7px; width: 100px;">




                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 112px; height: 23px">


                <asp:DropDownList ID="DROPCLIEN" runat="server" Height="26px" Width="144px" style="font-size: xx-small" >
                    <asp:ListItem>SITE</asp:ListItem>
                    <asp:ListItem>Genset</asp:ListItem>
                    <asp:ListItem>NEW_SITE</asp:ListItem>
                    <asp:ListItem>SERIAL</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                              </asp:DropDownList>




            </td>
            <td class="text-left" style="width: 107px; height: 23px">

                <asp:Panel ID="Panel1" runat="server">

                    
                <asp:TextBox ID="TextBox1" runat="server"  Width="144px"  Height="26px" ></asp:TextBox>
                
                </asp:Panel>

                </td>
            <td class="text-left" style="height: 23px">

                <asp:Button ID="btnbuscar" runat="server" Text="Search" Width="91px" OnClick="btnbuscar_Click" />


                </td>
            <td class="text-left" style="height: 23px; width: 109px;">




            </td>
            <td class="text-left" style="height: 23px; width: 100px;">




                <asp:TextBox ID="TextBox2" runat="server"  Width="144px"  Height="26px" TextMode="Date" ></asp:TextBox>
                
                </td>
            <td class="text-left" style="height: 23px; width: 100px;">




                <asp:TextBox ID="TextBox3" runat="server"  Width="144px"  Height="26px" TextMode="Date" ></asp:TextBox>
                
                </td>
            <td class="text-left" style="height: 23px; width: 100px;">




                <asp:Button ID="btnbuscar0" runat="server" Text="Search" Width="91px" OnClick="btnbuscar0_Click" />


                </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 23px; text-align: center;" colspan="2">


                 &nbsp; &nbsp;  &nbsp;</td>
            <td class="text-center" style="height: 23px; text-align: center;">

                &nbsp;</td>
            <td class="text-center" style="height: 23px; width: 109px; text-align: center;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
            <td class="text-left" style="height: 23px; width: 100px;">




                &nbsp;</td>
        </tr>
        </table>
      
   

    <table >
        <tr>
            <td>

  

                 <asp:GridView ID="GridView1" runat="server"   Width="1032px" CellPadding="4" ForeColor="#333333"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
                    
                    
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
                             <asp:LinkButton Text="Delete" ID="inSelect" runat="server" CommandName="Select"     OnClientClick="return confirm('Are you sure you want to delete this item?');" />
                            </ItemTemplate>
                        </asp:TemplateField>


                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                
                                />
                            <asp:BoundField DataField="FROM" HeaderText="FROM" SortExpression="FROM" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                            <asp:BoundField DataField="SERIAL" HeaderText="SERIAL" SortExpression="SERIAL" />
                            <asp:BoundField DataField="NEW SITE" HeaderText="NEW SITE" SortExpression="NEW SITE" />
                            <asp:BoundField DataField="NOTE" HeaderText="NOTE" SortExpression="NOTE" />
                            <asp:BoundField DataField="CREATE BY" HeaderText="CREATE BY" SortExpression="CREATE BY" />
                     
                    
                       
                    </Columns>
                  

                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle CssClass="FixedHeader" VerticalAlign="Bottom" BackColor="#507CD1" Width="980px" Font-Bold="False" ForeColor="White"/>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                   
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select ID, DATE, SITE AS [FROM], GENSET, SERIAL,NEW_SITE AS [NEW SITE], NOTE, USER1 AS [CREATE BY] from  GENSET_MOVEMENT order by id desc"></asp:SqlDataSource>
                   
                  </td>
            <td>
  
              
                &nbsp;</td>
        </tr>
    </table>





</asp:Content>
