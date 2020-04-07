<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site2.Master" AutoEventWireup="true" CodeFile="Reading.aspx.cs" Inherits="CanezPower.USUARIO1.Reading" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <br />
    <br />
    <table style="width: 50%; height: 5px;">
        <tr>
            <td colspan="2" rowspan="2"><h1>NEW READING</h1></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 99px">&nbsp;</td>
            <td style="width: 89px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="4">
                <asp:Label ID="LBLESTADO" runat="server" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; font-weight: 700; ">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SITE</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Month Reading</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 99px">&nbsp;</td>
            <td style="width: 89px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                    <asp:DropDownList ID="CBSITE" runat="server" Height="28px"  AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged" Width="150px">
                    </asp:DropDownList>
                    </td>
            <td>  <asp:TextBox ID="txtmesreading" runat="server" Height="26px" TextMode="Date" Width="144px" AutoPostBack="True" OnTextChanged="txtmesreading_TextChanged"></asp:TextBox></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 99px">
                <asp:Button ID="Button3" runat="server" Visible="false" OnClick="Button3_Click1" Text="Summary" Width="141px" />
            </td>
            <td style="width: 89px">&nbsp;</td>
        </tr>
        <tr>
            <td style="font-weight: 700; text-decoration: underline">
                    </td>
            <td>  &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 99px">&nbsp;</td>
            <td style="width: 89px">&nbsp;</td>
        </tr>
        <tr>
            <td>


                <asp:Label ID="LBLESTADO0" runat="server"></asp:Label>
            </td>
            <td>  
               <%-- <asp:Button ID="BTNSAVE" runat="server" OnClick="BTNSAVE_Click" Text="SAVE" Width="135px" />--%>
                <asp:Button ID="BTNSAVE" runat="server" Visible="false" OnClick="BTNSAVE_Click" Text="Save and Send" Width="141px" Enabled="False" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 99px">&nbsp;</td>
            <td style="width: 89px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
  
                <br />
                <strong>
  
                
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select SITE,GENSET_MODEL AS GENSET from gensetfinal"></asp:SqlDataSource>
               
                  </strong>
               
                  </td>
            <td style="width: 89px">
  
                
                &nbsp;</td>
            <td>
  
                
                
  
                
                &nbsp;</td>
        </tr>
        </table>


             <table style="width: 71px; height: 108px" >
                 <tr>
                     <td rowspan="2" >


             <asp:GridView ID="GridView1" runat="server" Height="16px"    Width="777px" CellPadding="4"    AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                            <asp:BoundField DataField="SITE" HeaderText="SITE" SortExpression="SITE" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                         <asp:TemplateField HeaderText="Running Hours">  
                            <ItemTemplate>
                                <asp:TextBox ID="txthoras" runat="server" Text="0" TextMode="Number" ></asp:TextBox>
                            </ItemTemplate>  
                         </asp:TemplateField>  
                         <asp:TemplateField HeaderText="Energy(kwh)">  
                            <ItemTemplate>
                               <asp:TextBox ID="txtenergy" runat="server" Text="0" TextMode="Number" ></asp:TextBox>
                            </ItemTemplate>  
                         </asp:TemplateField>  
                         <asp:TemplateField HeaderText="Rate">  
                            <ItemTemplate>
                                <asp:TextBox ID="txtrate" runat="server"  Text="0" TextMode="Number" ></asp:TextBox>
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


                     </td>
                     <td style="background-color: #507CD1; height: 26px; color: #FFFFFF;" >
                         HOURS

        </td>
                     <td style="background-color: #507CD1; height: 26px; color: #FFFFFF;">
                          ENERGY 


                     </td>
                     <td style="background-color: #507CD1; height: 26px; color: #FFFFFF;" >
                         AVERAGE LOAD

        </td>
                 </tr>
                 <tr>
                     <td >

        <asp:GridView ID="GridView3" runat="server" Height="26px"   Width="100px" CellPadding="4" ShowHeader="false"   >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        
                       



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


     


                     </td>
                     <td>

        <asp:GridView ID="GridView5" runat="server" Height="212px"   Width="100px" CellPadding="4" ShowHeader="false" style="margin-right: 70px"   >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                     



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


     



     



     


                     </td>
                     <td >

        <asp:GridView ID="GridView6" runat="server" Height="212px"   Width="100px" CellPadding="4" ShowHeader="false"   >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                     



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
                </asp:GridView></td>
                 </tr>
       </table>




  
       <br />
    <asp:Label ID="Label1" runat="server" Text="MONTH THAT YOU TRY TO ENTER" Visible="false"></asp:Label>
    <br />
     <asp:GridView ID="GridView4" runat="server" Height="16px"   Width="777px" CellPadding="4" AutoGenerateColumns="False" >
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




       
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING ORDER BY ID DESC"></asp:SqlDataSource>


     

       
       <br />

     <asp:GridView ID="GridView2" runat="server" Height="16px"   Width="777px" CellPadding="4" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"  >
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


 
   
       

     


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
