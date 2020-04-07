using System;
using System.Web;
using System.Web.UI;
using System.Data;

namespace CanezPower
{
    public partial class NEW_CLIENT : System.Web.UI.Page
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




        protected void Page_Load(object sender, EventArgs e)
        {

            //TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");
            Panel1.DefaultButton = BTNBUSCAR.ID;
            if (!Page.IsPostBack)
            {
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
            }

         

        }


        void LIMPIAR()
        {
            TXTCOMPANYNAME.Text = "";
            TXTCONTNAME.Text = "";
            TXTPHONE1.Text = "";
            TXTEMAIL.Text = "";
        
            TXTNORE.Text = "";
          

        }
      

        void NE_CLIENT()
        {
            try
            {
                string COMANDO = string.Format("exec NEW_CLIENT '" + TXTCOMPANYNAME.Text + "','" + TXTCONTNAME.Text + "','" + TXTPHONE1.Text + "','" + TXTEMAIL.Text + "','" + TXTNORE.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                MOTRAL_GENSET();
                Response.Redirect("~/NEW_CLIENT.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }



        void MOTRAL_GENSET()
        {

            try
            {
                string COMANDO = String.Format("SELECT        ID, COMPANY_NAME AS [Company  Name], CONTACT_NAME AS [Contact Name], PHONE AS Phone, E_MAIL AS [E -Mail], NOTA AS Note, USERS AS [User] FROM            edgar2211.clienst  order by ID DESC ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }



        }

        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            NE_CLIENT();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BTNGUARDAR.Enabled = false;
                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;

                string COMANDO = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO12 = string.Format("select * from clienst where ID='" + COMANDO + "'order by ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = COMANDO;
                TXTCOMPANYNAME.Text = DS.Tables[0].Rows[0]["COMPANY_NAME"].ToString();

                TXTCONTNAME.Text = DS.Tables[0].Rows[0]["CONTACT_NAME"].ToString();

                TXTPHONE1.Text = DS.Tables[0].Rows[0]["PHONE"].ToString();

                TXTEMAIL.Text = DS.Tables[0].Rows[0]["E_MAIL"].ToString();
                TXTNORE.Text = DS.Tables[0].Rows[0]["NOTA"].ToString();
                USER = DS.Tables[0].Rows[0]["USERS"].ToString();
            

            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        public static string id = "";
        public static string USER = "";

        protected void TXTEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("exec EDIT_CLIENT '" + id + "','" + TXTCOMPANYNAME.Text + "','" + TXTCONTNAME.Text + "','" + TXTPHONE1.Text + "','" + TXTEMAIL.Text + "','" + TXTNORE.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/NEW_CLIENT.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }
        }
        protected void TXTDELETE_Click(object sender, EventArgs e)
        {

            try
            {
                string COMANDO12 = string.Format("DELETE  from clienst where ID='" + id + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/NEW_CLIENT.aspx");
            }
            catch (Exception)
            {
                
               
            }
          

        }
        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = String.Format("SELECT        ID, COMPANY_NAME AS [Company  Name], CONTACT_NAME AS [Contact Name], PHONE AS Phone, E_MAIL AS [E -Mail], NOTA AS Note, USERS AS [User] FROM            edgar2211.clienst  WHERE   COMPANY_NAME LIKE '%"+TXTUSUARIO.Text+"%'  order by ID DESC ");
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
}
}