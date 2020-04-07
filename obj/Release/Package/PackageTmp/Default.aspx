<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MASTERLOGIN.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CanezPower._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
   
    <table style="width: 100%" align="center">
    <tr>
        <td style="font-weight: 700; text-align: center;" >
            <h3>Database Tracking Software</h3>
        </td>
    </tr>
</table>



     <table style="width: 100%">
    <tr>
        <td style="width: 353px" rowspan="6">
            <img alt="" src="imagenes/WhatsApp%20Image%202017-02-21%20at%2016.56.49%20(1).jpeg" style="width: 380px; height: 125px" /></td>
        <td style="width: 75px">
            &nbsp;</td>
        <td style="font-weight: 700">
           
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            LOGIN</h3>
        </td>
    </tr>
    <tr>
        <td class="right" style="text-align: right; height: 33px; width: 75px;">
            <br />
            
            
            USER

        </td>
        <td style="height: 33px">
            &nbsp;<asp:TextBox ID="TXTUSUARIO" runat="server" Width="225px" BorderColor="Black"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="text-align: right; width: 75px; height: 29px;">
            <br />
          
            PASSWORD </td>
        <td style="height: 29px">
           
          
            &nbsp;<asp:TextBox ID="TXTCLAVE" runat="server" Width="226px" TextMode="Password" BorderColor="Black"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="height: 28px; width: 75px;">
            </td>
        <td style="height: 28px">
            <br />
            <asp:Button ID="BTNLOGIN" runat="server" Text="LOGIN" Width="238px" OnClick="BTNLOGIN_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            &nbsp;</td>
        <td>
            <asp:Label ID="LBLESTADO" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            &nbsp;</td>
        <td>
            Write all lowercase letters</td>
    </tr>
    </table>

</asp:Content>
