using System;
using System.Data;
using System.Web.UI.WebControls;

namespace CanezPower.otheruser
{
    public partial class DOCUMENTO : System.Web.UI.Page
    {
        public string IDGENSET, GENSET, page = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            IDGENSET = Request.QueryString.Get("ID");
            GENSET = Request.QueryString.Get("GENSET");
            page = Request.QueryString.Get("page");

            //lblid.Text = IDGENSET;
            //lblgenset.Text = GENSET;

            if (!IsPostBack)
            {
                GridView1.DataSourceID = null;
                mostrar();
            }           //VER();
        }

        void mostrar()
        {

            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT ID,ID_GENSET, GENSET,DOCUMENTO AS DOCUMENT, DATE1 AS DATE, USER1 AS [UPLOAD BY],TIPO AS TYPE FROM DOCUMENT_SHOP WHERE ID_GENSET like'%" + IDGENSET + "%' AND GENSET like'%" + GENSET + "%' and TIPO LIKE '%" + page + "%' order by ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception)
            {


            }
        }


        void VER()
        {

            try
            {

                string COMANDO = string.Format("SELECT * FROM DOCUMENT_SHOP ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception)
            {


            }

        }




        public static string file1;
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "btver")
            {

                try
                {

                    int valor = Convert.ToInt32(e.CommandArgument);
                    string CADENA = string.Format("SELECT * FROM DOCUMENT_SHOP  WHERE ID='" + GridView1.Rows[valor].Cells[2].Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    file1 = DS.Tables[0].Rows[0]["DOCUMENTO"].ToString();
                    Response.Write("<script>window.open('" + file1 + "' )</script>");


                }
                catch (Exception)
                {


                }
            }
            if (e.CommandName == "inSelect")
            {


            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string CADENA = string.Format("delete  FROM DOCUMENT_SHOP  WHERE ID='" + GridView1.SelectedRow.Cells[2].Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                //Response.Redirect("~/SHOP.aspx");
            }
            catch (Exception)
            {


            }
        }
    }
}