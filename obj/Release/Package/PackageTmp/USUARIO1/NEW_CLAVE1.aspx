<%@ Page Title="" Language="C#" MasterPageFile="~/USUARIO1/Site1.Master" AutoEventWireup="true" CodeBehind="NEW_CLAVE1.aspx.cs" Inherits="CanezPower.USUARIO1.NEW_CLAVE1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
             <br />
    <br />
           <h2>NEW PASSWORD</h2>
    <br />

    <table style="width: 90%">
        <tr>
            <td style="width: 24px; height: 44px;">
                <span style="font-size: xx-small"></td>
            <td style="width: 264px; height: 44px;">
                </span>
                <br style="font-size: xx-small" />
                <asp:TextBox ID="TextBox1" runat="server" Height="17px" Width="198px" style="font-size: xx-small"></asp:TextBox>

               
              





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
            <td style="width: 264px; height: 15px;">
                
                <asp:Button ID="BTNEXPO" runat="server" Text="SAVE" OnClick="BTNEXPO_Click" style="font-size: xx-small" Width="64px" />  
                
                 </td>
            <td style="width: 199px; height: 15px;">
            </td>
            <td style="height: 15px; text-align: left;">
                </td>
        </tr>
        <tr>
            <td style="width: 24px; ">
                </td>
            <td style="width: 264px; ">
                </td>
            <td style="width: 199px; ">
                </td>
            <td style="text-align: left;"></td>
        </tr>
        <tr>
            <td style="width: 24px; font-size: xx-small;">
                &nbsp;</td>
            <td colspan="3">
  
                
                <asp:Label ID="LBLESTADO" runat="server" style="font-size: xx-small"></asp:Label>
               
                  </td>
        </tr>
    </table>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
