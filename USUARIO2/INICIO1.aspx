<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO2/Site2.Master" AutoEventWireup="true" CodeFile="INICIO1.aspx.cs" Inherits="CanezPower.USUARIO2.INICIO1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
 

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
                <asp:Button ID="Button9" runat="server" Height="32px" Text="WAREHOUSE" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button9_Click" />
            </td>
            <td>
                <asp:Button ID="Button7" runat="server" Height="32px" Text="PANEL CODES" Width="155px" BackColor="#507CD1" ForeColor="White" OnClick="Button7_Click" />
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

                

    <table style="width: 322px" >
                    <tr>
                        <td colspan="5">
                            <h2>EXTRACTING REPORT</h2>
                          
                        </td>
                        <td style="width: 88px">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <h5>SITE</h5>
                        </td>
                        <td style="width: 375px">
                    <asp:DropDownList ID="CBSITE" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBSITE_SelectedIndexChanged">
                    </asp:DropDownList>
                        </td>
                        <td style="width: 30px">
                     
                            &nbsp;&nbsp;&nbsp;</td>
                        <td style="text-align: right; font-size: x-small;">
                     
                            SINCE</td>
                        <td>
                     
                            <b>
                <asp:TextBox ID="TXTDESDE" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Date"></asp:TextBox>
                </b>
                     
                        </td>
                        <td style="width: 88px">
                     
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: right; height: 39px;">
                            <h5>GENSET</h5>
                        </td>
                        <td style="width: 375px; height: 39px;">
                    <asp:DropDownList ID="CBGENSET" runat="server" Height="26px" style="font-weight: bold" Width="144px" CssClass="auto-style25" AutoPostBack="True" OnSelectedIndexChanged="CBGENSET_SelectedIndexChanged">
                    </asp:DropDownList>
                        </td>
                        <td style="height: 39px; width: 30px;">
                            &nbsp;</td>
                        <td style="height: 39px; text-align: right; font-size: x-small;">
                            UNTIL</td>
                        <td style="height: 39px">
                            <b>
                <asp:TextBox ID="TXTHASTA" runat="server" Height="26px" Width="144px" CssClass="FixedHeader" TextMode="Date"></asp:TextBox>
                </b>
                        </td>
                        <td style="height: 39px; width: 88px;">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; height: 23px;">
                        </td>
                        <td style="width: 375px; height: 23px;">
                            <asp:CheckBox ID="CHECKALGENSET" runat="server" Text="ALL GENSET" CssClass="FixedHeader" />


               
                        </td>
                        <td style="width: 30px; height: 23px;">
                            </td>
                        <td style="height: 23px">
                        </td>
                        <td style="height: 23px">
                     
                            <asp:CheckBox ID="chekonlydate" runat="server" Text=" Search Only Date  " />
                        </td>
                        <td style="height: 23px; width: 88px">
                            </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            &nbsp;</td>
                        <td style="width: 375px; text-align: left;">
               <asp:Button ID="BTNBUSCAR" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR_Click" />


               
                        </td>
                        <td style="width: 30px">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
               <asp:Button ID="BTNBUSCAR0" runat="server" Text="SEARCH" CssClass="auto-style25" OnClick="BTNBUSCAR0_Click" />
                        </td>
                        <td style="width: 88px">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            &nbsp;</td>
                        <td colspan="4" >
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Panel ID="Panel1" runat="server" Width="157px">

                                 <asp:Button ID="BTNBUSCAR1" runat="server" Text="EXPORT EXCEL" CssClass="auto-style25" OnClick="BTNBUSCAR1_Click" />
               
                            </asp:Panel>

                       </td>
                        <td style="width: 88px">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            &nbsp;</td>
                        <td style="width: 375px">
                            &nbsp;</td>
                        <td colspan="2">
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                     </tr>
        </table>
     <table style="width: 37%; height: 2px;">
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
                                    <td style="width: 124px">

                            <asp:CheckBox ID="CHECKLOG" runat="server" Text="LOG" CssClass="FixedHeader" />


               
                                    </td>
                                    <td style="width: 124px">

                            <asp:CheckBox ID="chetall" runat="server" Text="ALL" CssClass="FixedHeader" />


               
                                    </td>
                                </tr>
                                </table>


               
                
     <table >
        <tr>
            <td>
                <h4>SERVICE</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
             <asp:GridView ID="GridView6" runat="server" Height="16px"  Width="1909px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small" Font-Names="Latha" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                          <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView6.PageSize * GridView6.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>

                            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Next Service" HeaderText="Next Service" ReadOnly="True" SortExpression="Next Service" />
                            <asp:BoundField DataField="Need a Review?" HeaderText="Need a Review?" SortExpression="Need a Review?" />
                            <asp:BoundField DataField="DATE_FINICH" HeaderText="DATE_FINICH" SortExpression="DATE_FINICH"
                                DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Team" HeaderText="Team" SortExpression="Team" />
                            <asp:BoundField DataField="Hour Master Reading" HeaderText="Hour Master Reading" SortExpression="Hour Master Reading" />
                            <asp:BoundField DataField="Oil Running Hr" HeaderText="Oil Running Hr" SortExpression="Oil Running Hr" />
                            <asp:BoundField DataField="Oil Engine Replace" HeaderText="Oil Engine Replace" SortExpression="Oil Engine Replace" />
                            <asp:BoundField DataField="Oil Qty Removed" HeaderText="Oil Qty Removed" SortExpression="Oil Qty Removed" />
                            <asp:BoundField DataField="Oil Qty (gl)" HeaderText="Oil Qty (gl)" SortExpression="Oil Qty (gl)" />
                            <asp:BoundField DataField="Oil Different" HeaderText="Oil Different" SortExpression="Oil Different" />
                            <asp:BoundField DataField="Oil Filter Replace" HeaderText="Oil Filter Replace" SortExpression="Oil Filter Replace" />
                            <asp:BoundField DataField="Tank Decarter Filter Replace" HeaderText="Tank Decarter Filter Replace" SortExpression="Tank Decarter Filter Replace" />
                            <asp:BoundField DataField="Pre-fuel Filter Replace" HeaderText="Pre-fuel Filter Replace" SortExpression="Pre-fuel Filter Replace" />
                            <asp:BoundField DataField="Fuel Filter Replace" HeaderText="Fuel Filter Replace" SortExpression="Fuel Filter Replace" />
                            <asp:BoundField DataField="Inner Air Filter Replace" HeaderText="Inner Air Filter Replace" SortExpression="Inner Air Filter Replace" />
                            <asp:BoundField DataField="Outer Air Filter Cheange" HeaderText="Outer Air Filter Cheange" SortExpression="Outer Air Filter Cheange" />
                            <asp:BoundField DataField="Decription" HeaderText="Decription" SortExpression="Decription" />
                          
                          <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>
                                      

                          <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="User Login" HeaderText="User Login" SortExpression="User Login" />
                     
                    
                       
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

                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT    DISTINCT    edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) &lt; 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service], 
                         edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, 
                         edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], 
                         edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], 
                         edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], 
                         edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], 
                         edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription, 
                         CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'service') THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]
FROM            edgar2211.technical LEFT OUTER JOIN
                         edgar2211.DOCUMENT_SHOP ON    edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET order by technical.ID desc "></asp:SqlDataSource>

            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h4>SHOP
                </h4>
            </td>
        </tr>
        <tr>
            <td colspan="2">
           <asp:GridView ID="GridView5" runat="server" Height="16px"  Width="1163px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" AutoGenerateColumns="False" DataKeyNames="System ID" DataSourceID="SqlDataSource1" OnRowCommand="GridView5_RowCommand" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        
                            <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView5.PageSize * GridView5.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                   

                  
                         <asp:BoundField DataField="System ID" HeaderText="System ID" SortExpression="System ID" InsertVisible="False" ReadOnly="True" />
                         <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date"
                         DataFormatString="{0:d}"
                            HtmlEncode="false" 
                             />
                         <asp:BoundField DataField="Refference" HeaderText="Refference" SortExpression="Refference" />
                         <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                         <asp:BoundField DataField="Genset Serial#" HeaderText="Genset Serial#" SortExpression="Genset Serial#" />
                         <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                       

                        
                         
                                      <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                         


                        <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>




                         <asp:BoundField DataField="Attachment" HeaderText="Attachment" SortExpression="Attachment" ReadOnly="True" />
                         
                     
                            <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                         

                         
                     
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
               
                  <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT DISTINCT   Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset &lt;&gt;'' and DOCUMENT_SHOP.tipo='shop') then 'YES' ELSE 'NO' end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN
                         edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN
                         edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id
ORDER BY [System ID] DESC"></asp:SqlDataSource>
               

            </td>
        </tr>
        <tr>
            <td >
                <h4>CORRECTIVE MAINTENANCE</h4>
            </td>
           
        </tr>
        <tr>
            <td>
            <asp:GridView ID="GridView2" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView2_RowCommand" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                          <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView2.PageSize * GridView2.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                           DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Genset Serial" HeaderText="Genset Serial" SortExpression="Genset Serial" />
                            <asp:BoundField DataField="Reference" HeaderText="Reference" SortExpression="Reference" />
                            <asp:BoundField DataField="Running Hours" HeaderText="Running Hours" SortExpression="Running Hours" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                           <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>     
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     cm2.id, Date, Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot;+&quot;&quot;+&quot;' AND DOCUMENT_SHOP.tipo = 'CM') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm2.id = DOCUMENT_SHOP.id_genset order by cm2.id desc"></asp:SqlDataSource>
               

            </td>
            
        </tr>
        <tr>
            <td>
                <h4>FUEL FILTER REPLACEMENT-CM</h4>
            </td>
            
        </tr>
        <tr>
            <td colspan="2">
              <asp:GridView ID="GridView4" runat="server" Height="16px"  Width="913px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: xx-small; margin-right: 0px;" Font-Names="Latha" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView4_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                        <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                    Text='<%# (GridView4.PageSize * GridView4.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>

                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" 
                             DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="SITE" HeaderText="SITE" SortExpression="SITE" />
                            <asp:BoundField DataField="GENSET" HeaderText="GENSET" SortExpression="GENSET" />
                            <asp:BoundField DataField="FILTER" HeaderText="FILTER" SortExpression="FILTER" />
                            <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                            <asp:BoundField DataField="RUNNING HOURS" HeaderText="RUNNING HOURS" SortExpression="RUNNING HOURS" />
                            <asp:BoundField DataField="HOURS USE" HeaderText="HOURS USE" SortExpression="HOURS USE" />
                            <asp:BoundField DataField="NOTE" HeaderText="NOTE" SortExpression="NOTE" />
                           
                          <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>    
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="USER1" HeaderText="USER1" SortExpression="USER1" />
                     
                    
                       
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

         
          


          <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     cm.ID, cm.DATE1 AS DATE, SITE, cm.GENSET, FILTER, QTY, RUNNING_HOURS AS [RUNNING HOURS], HOURS_USE AS [HOURS USE], NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot;+&quot;&quot;+&quot;' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN 'YES' ELSE 'NO' END AS Attachment,cm. USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm.id = DOCUMENT_SHOP.id_genset order by cm.id desc
                   "></asp:SqlDataSource>

            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <h4>LOG</h4>

            </td>
        </tr>
        <tr>
            <td colspan="2">
  
                
                <strong>
  
                
                <asp:GridView ID="GridView9" runat="server" Height="16px"  Width="980px" CellPadding="4" ForeColor="Black" CssClass="auto-style25" style="font-size: x-small; text-align: left;" Font-Names="Latha" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" OnRowCommand="GridView1_RowCommand1" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                          <asp:TemplateField HeaderText="No.">  
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"
                                    Text='<%# (GridView9.PageSize * GridView9.PageIndex) + Container.DisplayIndex + 1 %>'>  
                                </asp:Label>
                            </ItemTemplate>  
                         </asp:TemplateField>  

                          <asp:TemplateField>
                            <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="inSelect0" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" 
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Genset" HeaderText="Genset" SortExpression="Genset" />
                            <asp:BoundField DataField="Genset Serial" HeaderText="Genset Serial" SortExpression="Genset Serial" />
                            <asp:BoundField DataField="Reference" HeaderText="Reference" SortExpression="Reference" />
                            <asp:BoundField DataField="Running Hours" HeaderText="Running Hours" SortExpression="Running Hours" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                           <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver0" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>     
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                     
                    
                       
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
               
                  <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT   DISTINCT     TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '&quot;+&quot;&quot;+&quot;' AND DOCUMENT_SHOP.tipo = 'log') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  TBLOG.id = DOCUMENT_SHOP.id_genset order by TBLOG.id desc"></asp:SqlDataSource>
               
                  </strong>
               
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <h4>TROUBLE TIKET NUMBER</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
            <asp:GridView ID="GridView3" runat="server" Height="16px"  Width="1099px" CellPadding="4" ForeColor="#333333" CssClass="auto-style25" style="font-size: x-small; text-align: left;" AutoGenerateColumns="False" DataKeyNames="TTN" DataSourceID="SqlDataSource1" OnRowCommand="GridView3_RowCommand" OnRowDataBound="GridView3_RowDataBound" >
                    
                    
                    <AlternatingRowStyle BackColor="White" />
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
                      


                            <asp:BoundField DataField="TTN" HeaderText="TTN" InsertVisible="False" ReadOnly="True" SortExpression="TTN" />
                            <asp:BoundField DataField="Create By" HeaderText="Create By" SortExpression="Create By" />
                            <asp:BoundField DataField="Site" HeaderText="Site" SortExpression="Site" />
                            <asp:BoundField DataField="Task" HeaderText="Task" SortExpression="Task" />
                            <asp:BoundField DataField="Assing To" HeaderText="Assing To" SortExpression="Assing To" />
                            <asp:BoundField DataField="Jod Description" HeaderText="Jod Description" SortExpression="Jod Description" />
                            <asp:BoundField DataField="Feedback Description" HeaderText="Feedback Description" SortExpression="Feedback Description" />
                          <asp:TemplateField HeaderText="See Attachment">
                              <ItemTemplate>
                                  <asp:ImageButton ID="btnver" runat="server" CssClass="imgbtngv" ToolTip="Ver"  CommandName="btver" CommandArgument="<%# Container.DataItemIndex %>"
                                        
                                      ImageUrl="~/imagenes/1.jpg"  />
                              </ItemTemplate>
                          </asp:TemplateField>
                                    
                        <asp:BoundField DataField="Attachment" HeaderText="Attachment" ReadOnly="True" SortExpression="Attachment" />
                            <asp:BoundField DataField="USER1" HeaderText="CLOSED BY" SortExpression="USER1" />
                            <asp:BoundField DataField="Target date" HeaderText="Target date" SortExpression="Target date"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" 
                                />
                            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                        <asp:BoundField DataField="Date Finish" HeaderText="Date Finish" SortExpression="Date Finish"
                            DataFormatString="{0:d}"
                            HtmlEncode="false" />
                     
                    
                       
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
               
                              <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:Edgarpower_ConnectionString %>" SelectCommand="SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset &lt;&gt; '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET ORDER BY TTN DESC"></asp:SqlDataSource>
               

            </td>
        </tr>
        </table>
     
          
   


</asp:Content>