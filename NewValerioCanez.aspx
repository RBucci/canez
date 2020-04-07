<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Codefile="NewValerioCanez.aspx.cs" Inherits="CanezPower.NewValerioCanez" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <BR />
    <table style="width: 99%; height: 505px;">
        <tr>
            <td colspan="5">
                <h2><span style="color: #000000"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Warranty Registration</strong></span></h2>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; height: 24px; " colspan="4"></td>
            <td style="text-align: right; height: 24px; width: 420px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>SDMO Distributor/Dealer:</b></td>
            <td colspan="3">

                <asp:TextBox ID="txtdealer" runat="server" Width="344px" Text="Valerio Canez S.A." Enabled="false" class="form-control" Height="26px"></asp:TextBox>


            </td>
            <td style="width: 420px">

                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Address:</b></td>
            <td colspan="3">
                <asp:TextBox ID="txtaddressdealer" runat="server" Width="351px" Text="65, Route Delmas, Port au Prince, Haiti" Enabled="false" class="form-control" Height="26px"></asp:TextBox>
            </td>
            <td style="width: 420px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Job Order</td>
            <td colspan="3">
                <asp:TextBox ID="txtuser" runat="server"  class="form-control" ></asp:TextBox>
            </td>
            <td style="width: 420px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Address:</b></td>
            <td colspan="3">
                <asp:TextBox ID="txtaddessuser" runat="server"  class="form-control" ></asp:TextBox>
            </td>
            <td style="width: 420px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Generating Set<b>:</b></td>
            <td style="width: 376px">
                <asp:TextBox ID="txtgeneration" runat="server"  class="form-control"></asp:TextBox>
            </td>
            <td style="text-align: right; width: 210px"><b>Serial Number</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtgensetserial" runat="server"  class="form-control" Width="284px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Engine:</b></td>
            <td style="width: 376px">
                <asp:TextBox ID="txtengine" runat="server"  class="form-control" ></asp:TextBox>
            </td>
            <td style="text-align: right; width: 210px"><b>Serial Number</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtengineserial" runat="server"  class="form-control" Width="284px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px; font-weight: 700;">Alternator<b>:</b></td>
            <td style="width: 376px">
                <asp:TextBox ID="txtaltenado" runat="server"  class="form-control" ></asp:TextBox>
            </td>
            <td style="text-align: right; width: 210px"><b>Serial Number</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtserialaltenador" runat="server" class="form-control" Width="284px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px; font-weight: 700;">ATS (if sold by SDMO):</td>
            <td style="width: 376px">
                <asp:TextBox ID="txtsoiddealer" runat="server"  class="form-control" ></asp:TextBox>
            </td>
            <td style="text-align: right; width: 210px"><b>Serial Number</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtserialdealer" runat="server"  class="form-control" Width="284px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Control Panel:</b></td>
            <td style="width: 376px">
                <asp:DropDownList ID="cbpanelcontrol" runat="server"   class="form-control">
                     <asp:ListItem>APM303</asp:ListItem>
                     <asp:ListItem>APM802</asp:ListItem>
                    <asp:ListItem>TELYS</asp:ListItem>
                    <asp:ListItem>DEC3000</asp:ListItem>
                     <asp:ListItem>RDC2</asp:ListItem>
                    <asp:ListItem>MPAC550</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>

            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Enclosure:</b></td>
            <td style="width: 376px">

                <asp:DropDownList ID="cbenclosure" runat="server" class="form-control">
                     <asp:ListItem>Canopy</asp:ListItem>
                     <asp:ListItem>Open</asp:ListItem>
                    
                </asp:DropDownList>
            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 162px;"><b>Application:</b></td>
            <td style="width: 376px">


                <asp:DropDownList ID="cbapplication" runat="server"  class="form-control">
               <asp:ListItem>Stand By</asp:ListItem>
                     <asp:ListItem>Prime Power</asp:ListItem>
                    <asp:ListItem>COP</asp:ListItem>
                    
                     </asp:DropDownList>




            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Frequency:</td>
            <td style="width: 376px">


            <asp:DropDownList ID="cbfrequecy" runat="server"  class="form-control">
            <asp:ListItem>60Hz</asp:ListItem>
                    <asp:ListItem>50Hz</asp:ListItem>
                 </asp:DropDownList>




            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Connection (Phase)</td>
            <td style="width: 376px">


            <asp:DropDownList ID="cbconection" runat="server"  class="form-control">
               <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>




            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Voltage</td>
            <td style="width: 376px">


            <asp:DropDownList ID="cbvoltage" runat="server"  class="form-control">
                <asp:ListItem>240/120</asp:ListItem>
                <asp:ListItem>208/120</asp:ListItem>
                 <asp:ListItem>480/277</asp:ListItem>
               <asp:ListItem>N/A</asp:ListItem>
                 
            </asp:DropDownList>




            </td>
            <td style="text-align: right; width: 210px">&nbsp;</td>
            <td style="width: 82px">&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700; width: 162px;">Date of Delivery</td>
            <td colspan="3">


                <asp:TextBox ID="cbdelivery" runat="server"  class="form-control"  TextMode="Date"></asp:TextBox>




            </td>
            <td style="width: 420px">


                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-weight: bold; width: 162px;"><strong>Date of Commissioning:</strong></td>
            <td  colspan="3">
                <asp:TextBox ID="txtdatecommissioning" runat="server"  MaxLength="200" TextMode="Date"  class="form-control"></asp:TextBox>
            </td>
            <td style="width: 420px">
                &nbsp;</td>
            <td  style="width: 268435488px">
                &nbsp;</td>

        </tr>
        <tr>
            <td style="width: 162px; text-align: right; font-weight: 700;">Note</td>
              <td colspan="3">
                <asp:TextBox ID="txtnote" runat="server"  class="form-control" Height="92px" TextMode="MultiLine" Width="346px" ></asp:TextBox>
            </td>
              <td style="width: 420px">
                  &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px"></td>
            <td colspan="3">
                    <asp:CheckBox ID="checkemail" runat="server" Text="E-Mail Team" />

                </td>
            <td style="width: 420px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">&nbsp;</td>
            <td colspan="3" rowspan="2">
                <asp:Label ID="LBLESTADO" runat="server" ></asp:Label>
                    <br />
                <br />
                <asp:Button ID="BTNGUARDAR" runat="server" Text="SAVE AND SEND"   OnClientClick="return confirm('Are you sure you want to save this item?');"     class="btn btn-success" OnClick="BTNGUARDAR_Click" />
                <br />
                <br />
                
                 <asp:Button ID="BTNEDIT" runat="server" Text="EDIT"   OnClientClick="return confirm('Are you sure you want to edit this item?');" class="btn btn-info" OnClick="BTNEDIT_Click"   />
                <br />  
                <br /> <asp:Button ID="BTNDELETE" runat="server" Text="DELETE"  OnClientClick="return confirm('are you sure you want to erase this item?');" class="btn btn-danger"  OnClick="BTNDELETE_Click"  />
            </td>

            <td rowspan="2" style="width: 420px">
                &nbsp;</td>

        </tr>
    </table>

</asp:Content>
