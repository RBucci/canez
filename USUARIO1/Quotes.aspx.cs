using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;

namespace CanezPower.USUARIO1
{
    public partial class Quotes : System.Web.UI.Page
    {

        //public System.Security.Principal.IPrincipal User
        //{
        //    get;
        //    [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, ControlPrincipal = true)]
        //    set;
        //}
        public static string user = "";
        protected String GetTime()
        {

            string name = Page.User.Identity.Name;
            ver();
            user = Page.User.Identity.Name;
            return name;
        }




        void ver()
        {

            Response.Cache.SetCacheability(HttpCacheability.Server);

            Response.Cache.SetSlidingExpiration(true);
        }


        //public static string ID = "";
        public static string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            //TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");
            Panel1.DefaultButton = BTNBUSCAR.ID;
            if (!Page.IsPostBack)
            {
                MOSTRAR();

                string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                DROPCLIENT.DataSource = DS1.Tables[0];
                DROPCLIENT.DataTextField = "COMPANY_NAME";
                DROPCLIENT.DataBind();
            }
            BTNGUARDAR.Enabled = true;
            TXTEDIT.Enabled = false;
            TXTDELETE.Enabled = false;
        }
        void LIMPIAR()
        {
            //TXTDATE.Text = "";
            TXTINV.Text = "";
            TXTDESCRIPTION.Text = "";
            TXTTOTAL.Text = "";
            MOSTRAR();
        }

        void MOSTRAR()
        {
            try
            {

                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,'$'+TOTAL as [Total],DOCUMENT, USER1  FROM            edgar2211.quostes ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }

        }

        void NEW_INVOICES()
        {

            try
            {
                //string COMANDO = string.Format("EXEC  NEW_INVOICES'" + "GETDATE()" + "','" + DROPCLIENT.Text + "','" + TXTINV.Text + "','" + TXTDESCRIPTION.Text + "','" + TXTTOTAL.Text + "','" +  nombre+ "','" + GetTime() + "'");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                //LIMPIAR();
                //BTNGUARDAR.Enabled = true;
                //TXTEDIT.Enabled = false;
                //TXTDELETE.Enabled = false;
            }
            catch (Exception)
            {


            }
        }
        void EDIT_ENVOICES()
        {

            try
            {
                string COMANDO = string.Format("EXEC  EDIT_QUOSTER '" + id + "','" + DROPCLIENT.Text + "','" + TXTINV.Text + "','" + TXTDESCRIPTION.Text + "','" + TXTTOTAL.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
                Response.Redirect("~/Quotes.aspx");
            }
            catch (Exception)
            {


            }

        }

        void ELIMINAR_ENVOICES()
        {



            try
            {
                string COMANDO = string.Format("DELETE FROM quostes WHERE ID = '" + Convert.ToInt32(id) + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
                Response.Redirect("~/Quotes.aspx");
            }
            catch (Exception)
            {


            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMAN = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO = string.Format("SELECT * FROM quostes WHERE ID = '" + COMAN + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);


                //DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE"].ToString());

                //TXTDATE.Text = fecha1.ToString("yyyy-MM-dd");
                DROPCLIENT.Text = DS.Tables[0].Rows[0]["CLIENT"].ToString();
                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                TXTINV.Text = DS.Tables[0].Rows[0]["inv"].ToString();
                TXTTOTAL.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
                //CBSTATUS.Text = DS.Tables[0].Rows[0]["STATUS"].ToString();
                BTNGUARDAR.Enabled = false;
                TXTEDIT.Enabled = true;
                TXTDELETE.Enabled = true;
                id = COMAN;
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }
        public static string nombre, file1;
        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            try
            {


                if (File.Exists(Server.MapPath(".") + "/coti/" + FileUpload1.FileName))
                {
                    LBLESTADO.Text = "There is a file with this name, change the name to be able to upload it to server";
                }
                else
                {
                    FileUpload1.SaveAs(Server.MapPath(".") + "/coti/" + FileUpload1.FileName);

                    LBLESTADO.Text = "se realizo correctamente";
                    nombre = "http://canezpowerdivision.com/coti/" + FileUpload1.FileName;


                    string COMANDO = string.Format("EXEC  NEW_QUOSTER '" + DROPCLIENT.Text + "','" + TXTINV.Text + "','" + TXTDESCRIPTION.Text + "','" + TXTTOTAL.Text + "','" + nombre + "','" + GetTime() + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    LIMPIAR();
                    BTNGUARDAR.Enabled = true;
                    TXTEDIT.Enabled = false;
                    TXTDELETE.Enabled = false;



                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    Response.Redirect("~/Quotes.aspx");
                    //DATOS();
                }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }

        protected void TXTEDIT_Click(object sender, EventArgs e)
        {
            EDIT_ENVOICES();
        }

        protected void TXTDELETE_Click(object sender, EventArgs e)
        {
            ELIMINAR_ENVOICES();
        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,'$'+TOTAL as [Total],DOCUMENT, USER1  FROM            edgar2211.quostes  WHERE CLIENT LIKE '" + TXTUSUARIO.Text + "'  ORDER BY ID DESC");
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

        protected void BTNBUSCAR0_Click(object sender, EventArgs e)
        {

            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,'$'+TOTAL as [Total],DOCUMENT, USER1  FROM            edgar2211.quostes  WHERE (DATE >= '" + TXTDESDE.Text + "')AND(DATE <='" + TXTHASTA.Text + "')  ORDER BY ID DESC");
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



        protected void save0_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {

            if (e.CommandName == "btver")
            {

                try
                {

                    int valor = Convert.ToInt32(e.CommandArgument);
                    string CADENA = string.Format("SELECT * FROM quostes  WHERE ID='" + GridView1.Rows[valor].Cells[2].Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    file1 = DS.Tables[0].Rows[0]["DOCUMENT"].ToString();
                    Response.Write("<script>window.open('" + file1 + "' )</script>");


                }
                catch (Exception)
                {


                }
            }
        }

    }
}