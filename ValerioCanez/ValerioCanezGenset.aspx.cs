using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
namespace CanezPower.ValerioCanez
{
    public partial class ValerioCanezGenset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView1.DataSourceID = null;
		
                btnbuscar_Click(null,null);
            }
            
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = String.Format("SELECT         genset AS Genset, genset_serial AS [Genset Serial], user1 AS [End User], addressuser AS Address, engine AS Engine, engine_serial AS [Engine Serial], altenator AS Altentor, altenator_serial AS [Altenator Serial], soid_serial AS [Serial Sold], contro_panel AS [Control Panel], enclosure AS Enclosure, application1 AS Application, frequency AS Frequency, connection AS [Connection (Phase)], voltage AS Voltage, CONVERT(date,Date_Delivery) AS [Date of Delivery], CONVERT(date, Date_Commssioning )AS [Date of Commissioning],CONVERT(date, date_register) AS [Date Register], CONVERT(date,date_Mode )AS [Date Update] FROM            edgar2211.Genset_Venta where "+DROPCLIEN.Text+" like '%"+TextBox1.Text+"%'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
            }
            catch (Exception)
            {
                
                
            }
        }

        public string COMANDO = "";
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            COMANDO = GridView1.SelectedRow.Cells[3].Text.ToString();

            //string cmd = "NEWPLAN.aspx?id=" + COMANDO;
            //Session.Add("LK", COMANDO);

            //Server.Transfer("NEWPLAN.aspx");
            //Response.Redirect("NEWPLAN.aspx?id=" + COMANDO);
            //NEWPLAN NE = new NEWPLAN();







            //            A) Pasarlo por la querystring. 

            Response.Redirect("~/ValerioCanez/NewValerioCanez.aspx?MyVar=" + COMANDO.ToString()); 
        }
        protected void sportexcel_Click(object sender, EventArgs e)
        {
            try
            {
                
                //HttpResponse response = Response;
               // StringWriter sw = new StringWriter();
                //HtmlTextWriter htw = new HtmlTextWriter(sw);
                //Page pageToRender = new Page();
                //HtmlForm form = new HtmlForm();
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = "application/ms-excel";
                Response.AddHeader("content-disposition",string.Format("attachment;filename={0}.xls","selectedrows"));
                Response.Charset = "";
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                GridView1.RenderControl(htw);
                Response.Write(sw.ToString());
                Response.End();


                //Image imagen = new Image();

                //imagen.ImageUrl = "~/imagenes/canez1.jpg";

                //form.Controls.Add(imagen);

                //TableCell cell = new TableCell();
                //cell.Text = "<img src=imagenes/canez1.jpg />";
                //response.Write("<img src=E:/trabajo actuales/PROYECTOS EN ASP/CONEZ/CanezPower/imagenes/canez1.jpg />");
                //form.Controls.Add(cell);
                //TableCell cell0 = new TableCell();
                //cell0.Text = "<H1>Canez Power Division</H1>";
                ////form.Controls.Add(cell0);
                //TableCell cell2 = new TableCell();
                //cell2.Text = "<H1>SDMO Registration</H1>";
                //form.Controls.Add(cell2);
                //form.Controls.Add(GridView1);
                ////TableCell cell3 = new TableCell();
                ////cell3.Text = "<H1>Shop</H1>";
                ////form.Controls.Add(cell3);
                ////form.Controls.Add(GridView5);
                ////TableCell cell4 = new TableCell();
                ////cell4.Text = "<H1>CM</H1>";
                ////form.Controls.Add(cell4);
                ////form.Controls.Add(GridView2);
                ////TableCell cell5 = new TableCell();
                ////cell5.Text = "<H1>FF-CM</H1>";
                ////form.Controls.Add(cell5);
                ////form.Controls.Add(GridView4);

                ////TableCell cell6 = new TableCell();
                ////cell6.Text = "<H1>TTN</H1>";
                ////form.Controls.Add(cell6);
                ////form.Controls.Add(GridView3);
                ////TableCell cell7 = new TableCell();
                ////cell7.Text = "<H1>LOG</H1>";
                ////form.Controls.Add(cell7);
                ////form.Controls.Add(GridView9);

                //pageToRender.Controls.Add(form);
                //response.Clear();
                //response.Buffer = true;
                //response.ContentType = "application/vnd.ms-excel";
                //response.AddHeader("Content-Disposition", "attachment;filename=" + "Extracting_Report.xls");
                //response.Charset = "UTF-8";
                //response.ContentEncoding = Encoding.Default;
                //pageToRender.RenderControl(htw);
                //response.Write(sw.ToString());
                //response.End();

            }
            catch (Exception)
            {
                
              
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }



}
}