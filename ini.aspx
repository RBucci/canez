<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ini.aspx.cs" Inherits="CanezPower.ini" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headcontent" runat="server">
 
    <div>
        <h1>Reporte</h1>
        <rsweb:reportviewer id="reportesReportViewer" runat="server" height="600px"
            showfindcontrols="False" showrefreshbutton="False" showzoomcontrol="False" width="850px" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="REPORTE_PRINCIPAL.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:reportviewer> 
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="CanezPower.DataSet1TableAdapters.gensetfinalTableAdapter"></asp:ObjectDataSource>
    </div>
   
  
    </asp:Content>
