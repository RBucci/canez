using System;
using System.Data;
using System.Web;
using System.Web.UI;

namespace CanezPower.USUARIO2
{
    public partial class PANEL_CODES : System.Web.UI.Page
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


            //  TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");
            Panel1.DefaultButton = BTNBUSCAR.ID;
            if (!Page.IsPostBack)
            {
                string COMANDO1 = string.Format("select ENEGIE from ENERGIE");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                DROPENGINE.DataSource = DS1.Tables[0];
                DROPENGINE.DataTextField = "ENEGIE";
                DROPENGINE.DataBind();


                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
            }



        }


        void LIMPIAR()
        {
            TXTCODE.Text = "";
            TXTFMI.Text = "";
            TXTDESCRIPTION.Text = "";
           


        }


        void NE_CLIENT()
        {
            try
            {
                Int64 code = Convert.ToInt32(TXTCODE.Text);
                string COMANDO = string.Format("exec new_panelcodes '" + code + "','" + TXTFMI.Text + "','" + DROPENGINE.SelectedValue + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                MOTRAL_GENSET();
                Response.Redirect("~/PANEL_CODES.aspx");
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
                string COMANDO = String.Format("SELECT        CODE, FMI, ENGINE, DESCRIPTION1, USER1, ID FROM            edgar2211.PANELCODES    order by CODE ASC ");
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

                string COMANDO = GridView1.SelectedRow.Cells[7].Text;

                string COMANDO12 = string.Format("select * from PANELCODES where ID='" + COMANDO + "'order by ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = COMANDO;
                TXTCODE.Text = DS.Tables[0].Rows[0]["CODE"].ToString();

                TXTFMI.Text = DS.Tables[0].Rows[0]["FMI"].ToString();

                DROPENGINE.Text = DS.Tables[0].Rows[0]["ENGINE"].ToString();

                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION1"].ToString();
              


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
                Int64 code = Convert.ToInt32(TXTCODE.Text);

                string COMANDO = string.Format("exec edit_panelcodes '"+id+"','" + code + "','" + TXTFMI.Text + "','" + DROPENGINE.SelectedValue + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
              
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/PANEL_CODES.aspx");
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
                string COMANDO12 = string.Format("DELETE  from PANELCODES where ID='" + id + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/PANEL_CODES.aspx");
            }
            catch (Exception)
            {


            }


        }
        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = String.Format("SELECT        CODE, FMI, ENGINE, DESCRIPTION1, USER1, ID FROM            edgar2211.PANELCODES  WHERE   CODE LIKE '%" + TXTUSUARIO.Text + "%'  order by CODE ASC ");
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