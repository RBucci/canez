using System;
using System.Data;
using System.Web;
using System.Web.UI;

namespace CanezPower.USUARIO1
{
    public partial class FUELUSE : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                string COMANDO123 = string.Format("select NICK_NAME from employeet");
                DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                DROPTEAM.DataSource = DS123.Tables[0];
                DROPTEAM.DataTextField = "NICK_NAME";
                DROPTEAM.DataBind();

                string COMANDO1234 = string.Format("select VEHICLE from vevicle");
                DataSet DS1234 = CLASS_CONECTAR.CONECTAR(COMANDO1234);
                DROPVEHICLE.DataSource = DS1234.Tables[0];
                DROPVEHICLE.DataTextField = "VEHICLE";
                DROPVEHICLE.DataBind();
                mostrar();

                BTNDELETE.Enabled = false;
                BTNEDIT.Enabled = false;
                VER12();
            }
            //TXTBUSCAR.Attributes.Add("onkeypress", "cambiaFoco('Button6_Click')");
            Panel1.DefaultButton = Button6.ID;
            GridView1.DataSourceID = null;
        }

        void VER12()
        {
            try
            {
                string COMANDO = string.Format("SELECT   DISTINCT     SUM(cast(QTY as float)) AS TOTAL FROM   USE_FUEL      WHERE  FUEL_TYPE='DIESEL' AND    EOMONTH(DATE)  = EOMONTH(GETDATE())");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO0.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
            }
            catch (Exception)
            {


            }


            try
            {
                string COMANDO = string.Format("SELECT   DISTINCT     SUM(cast(QTY as float)) AS TOTAL FROM   USE_FUEL      WHERE  FUEL_TYPE='GASOLINA' AND    EOMONTH(DATE)  = EOMONTH(GETDATE())");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO1.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
            }
            catch (Exception)
            {


            }




        }

        void mostrar()
        {

            try
            {
                string COMANDO = string.Format("SELECT        ID, DATE, VEHICLE, RESPONSIBLE, FUEL_TYPE AS [FUEL TYPE], FROM1 AS [FROM], QTY,NOTE, USER1 AS [USER] FROM            edgar2211.USE_FUEL  ORDER BY ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                    LIMPIAR();

            }
            catch (Exception)
            {
                
              
            }
        }

        public static string id = ""; 

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("EXEC NEW_FUELUSE '" + TXTDATE.Text + "','" + DROPVEHICLE.Text + "','" + DROPTEAM.Text + "','" + DROPFUELTYPE.Text + "','" + DROPFROM.Text + "','" + TXTQTY.Text + "','"+TXTNOTE.Text+"','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                mostrar();
                BTNSAVE.Enabled = true;
                BTNDELETE.Enabled = false;
                BTNEDIT.Enabled = false;
                Response.Redirect("~/FUELUSE.aspx");
            }
            catch (Exception)
            {
                
                
            }

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("EXEC EDIT_FUELUSE '" + id + "','" + TXTDATE.Text + "','" + DROPVEHICLE.Text + "','" + DROPTEAM.Text + "','" + DROPFUELTYPE.Text + "','" + DROPFROM.Text + "','" + TXTQTY.Text + "','"+TXTNOTE.Text+"','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                mostrar();
                BTNSAVE.Enabled = true;
                BTNDELETE.Enabled = false;
                BTNEDIT.Enabled = false;
                Response.Redirect("~/FUELUSE.aspx");
            }
            catch (Exception)
            {


            }

        }
      
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string COMANDO1 = string.Format("SELECT * FROM USE_FUEL WHERE ID ='"+COMANDO+"'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO1);
                DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE"].ToString());
                id = COMANDO;
                TXTDATE.Text = fecha1.ToString("yyyy-MM-dd");
                DROPVEHICLE.Text = DS.Tables[0].Rows[0]["VEHICLE"].ToString();
                DROPTEAM.Text = DS.Tables[0].Rows[0]["RESPONSIBLE"].ToString();
                DROPFUELTYPE.Text = DS.Tables[0].Rows[0]["FUEL_TYPE"].ToString();
                DROPFROM.Text = DS.Tables[0].Rows[0]["FROM1"].ToString();
                TXTQTY.Text = DS.Tables[0].Rows[0]["QTY"].ToString();
                TXTNOTE.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();
                BTNSAVE.Enabled = false;
                BTNDELETE.Enabled = true;
                BTNEDIT.Enabled = true;
            }
            catch (Exception)
            {
                
               
            }
        }

        void LIMPIAR()
        {
            TXTDATE.Text = "";
            TXTQTY.Text = "";
        }
        protected void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                string COMANDO = string.Format("DELETE FROM  USE_FUEL WHERE ID = '" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                mostrar();
                BTNSAVE.Enabled = true;
                BTNDELETE.Enabled = false;
                BTNEDIT.Enabled = false;
                Response.Redirect("~/FUELUSE.aspx");
            }
            catch (Exception)
            {


            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT        ID, DATE, VEHICLE, RESPONSIBLE, FUEL_TYPE AS [FUEL TYPE], FROM1 AS [FROM], QTY,NOTE, USER1 AS [USER] FROM            edgar2211.USE_FUEL  WHERE " + DROPCAMPO.Text + " LIKE '%" + TXTBUSCAR.Text + "%' ORDER BY ID DESC");
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
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT        ID, DATE, VEHICLE, RESPONSIBLE, FUEL_TYPE AS [FUEL TYPE], FROM1 AS [FROM], QTY,NOTE, USER1 AS [USER] FROM            edgar2211.USE_FUEL  WHERE (USE_FUEL.DATE>='" + TXTDESDE.Text + "')AND(USE_FUEL.DATE<='" + TXTHASTA1.Text + "') ORDER BY ID DESC");
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