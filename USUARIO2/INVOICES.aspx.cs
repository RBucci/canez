using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CanezPower.USUARIO2
{
    public partial class INVOICES : System.Web.UI.Page
    {


        public System.Security.Principal.IPrincipal User
        {
            get;
            [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, ControlPrincipal = true)]
            set;
        }
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


        public static string ID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
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
            TXTDATE.Text = "";
            TXTINV.Text = "";
            TXTDESCRIPTION.Text = "";
            TXTTOTAL.Text = "";
            MOSTRAR();
        }

        void MOSTRAR()
        {
            try
            {
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,format(TOTAL,'" + "Currency" + "'),STATUS, USER1  FROM            edgar2211.INVOICES ORDER BY ID DESC");
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
                string COMANDO = string.Format("EXEC  NEW_INVOICES'"+TXTDATE.Text+"','"+DROPCLIENT.Text+"','"+TXTINV.Text+"','"+TXTDESCRIPTION.Text+"','"+TXTTOTAL.Text+"','"+CBSTATUS.Text+"','"+GetTime()+"'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
            }
            catch (Exception)
            {
                
                
            }
        }
        void EDIT_ENVOICES()
        {

            try
            {
                string COMANDO = string.Format("EXEC  EDIT_INVOICES '"+ID+"','" + TXTDATE.Text + "','" + DROPCLIENT.Text + "','" + TXTINV.Text + "','" + TXTDESCRIPTION.Text + "','" + TXTTOTAL.Text + "','"+CBSTATUS.Text+"','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
            }
            catch (Exception)
            {


            }

        }

        void ELIMINAR_ENVOICES()
        {



            try
            {
                string COMANDO = string.Format("DELETE FROM INVOICES WHERE ID = '"+ Convert.ToInt32(ID) +"'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
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
               
                string COMANDO = string.Format("SELECT * FROM INVOICES WHERE ID = '" + COMAN + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                
                DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE"].ToString());

                TXTDATE.Text = fecha1.ToString("yyyy-MM-dd");
                DROPCLIENT.Text = DS.Tables[0].Rows[0]["CLIENT"].ToString();
                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                TXTINV.Text = DS.Tables[0].Rows[0]["inv"].ToString();
                TXTTOTAL.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
                CBSTATUS.Text = DS.Tables[0].Rows[0]["STATUS"].ToString();
                BTNGUARDAR.Enabled = false;
                TXTEDIT.Enabled = true;
                TXTDELETE.Enabled = true;
                ID = COMAN;
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;    
            
            }
        }

        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            NEW_INVOICES();
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
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,format(TOTAL,'"+"Currency"+"'),STATUS, USER1  FROM            edgar2211.INVOICES  WHERE CLIENT LIKE '" + TXTUSUARIO.Text + "'  ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
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
                string COMANDO = string.Format("SELECT        ID, DATE, CLIENT, INV, DESCRIPTION,format(TOTAL,'" + "Currency" + "'),STATUS, USER1  FROM            edgar2211.INVOICES  WHERE (DATE >= '" + TXTDESDE.Text + "')AND(DATE <='" + TXTHASTA.Text + "')  ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }
        }


    }
}