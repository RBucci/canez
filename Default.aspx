<%@ Page Title="Canez Power Division S.A." Language="C#" MasterPageFile="~/MASTERLOGIN.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CanezPower._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <table >
    <tr>
        <td style="font-weight: 700; text-align: center;" >
           
        </td>
        <td >
            &nbsp;</td>
    </tr>
</table>



     <table style="width: 100%">
    <tr>
        <td style="width: 280px" rowspan="7">
            <br />
             <br />
             <br />
             <br />
            <img alt="" src="imagenes/canez1.jpg" width="350" height="130" /></td>
        <td colspan="2"  >
           
            <h3 >&nbsp;&nbsp;&nbsp; Database Tracking Software</h3>
        </td>
    </tr>
    <tr>
        <td colspan="2" >
           
            <h3 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOGIN</h3>
        </td>
    </tr>
    <tr>
        <td class="right" style="text-align: right; height: 33px; width: 58px; font-weight: 700;">
            <br  />
            
            
          USER

       

        </td>
        <td >
            &nbsp;<asp:TextBox ID="TXTUSUARIO" runat="server" class="form-control" Width="194px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="text-align: right; width: 58px; height: 29px; font-weight: 700;">
           
          
           PASSWORD  </td>
        <td style="height: 29px">
           
          
            &nbsp;<asp:TextBox ID="TXTCLAVE" runat="server" TextMode="Password" class="form-control" Width="194px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 58px" >
            </td>
        <td >
            <br style="text-decoration: underline" />
            <asp:Button ID="BTNLOGIN" runat="server" Text="LOGIN"  OnClick="BTNLOGIN_Click" class="btn btn-success" Width="194px"    />
        </td>
    </tr>
    <tr>
        <td style="width: 58px; ">
            &nbsp;</td>
        <td>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;<asp:Label ID="LBLESTADO" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 58px" >
            &nbsp;</td>
        <td >
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Write all lowercase letters</td>
    </tr>
    </table>
    





    </asp:Content>
