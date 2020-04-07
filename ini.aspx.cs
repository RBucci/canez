
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class ini : System.Web.UI.Page
    {
        //ReportDocument rprt = new ReportDocument();

        CLASS_CONECTAR con = new CLASS_CONECTAR();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //rprt.Load(Server.MapPath("~/CrystalReport1.rpt"));

                //SqlCommand cmd = new SqlCommand("select * from gensetfinal", con.CONECT1);
                //con.CONECT1.Open();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds, "gensetfinal");
                //rprt.SetDataSource(ds);
                //this.CrystalReportViewer1.DataBind();

                //this.CrystalReportViewer1.ReportSource = rprt;

                //con.CONECT1.Close();


            }
            catch (Exception )
            {
               

            }
        }
    }
}