using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CanezPower.USUARIO2
{
    public partial class Marriot : System.Web.UI.Page
    {


        public new System.Security.Principal.IPrincipal User
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
        public static string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //txttime.Text = DateTime.Now.ToString("HH:mm");

            try
            {
                if (!Page.IsPostBack)
                {
                    BTNSAVE.Enabled = true;
                    BTNEDITAR.Enabled = false;
                    BTNDELETE.Enabled = false;

                    string COMANDO = string.Format("SELECT DISTINCT edgar2211.site.site FROM edgar2211.site INNER JOIN edgar2211.gensetfinal ON edgar2211.site.site = edgar2211.gensetfinal.SITE  where edgar2211.site.id=47");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    DROPSITE.DataSource = DS.Tables[0];
                    DROPSITE.DataTextField = "site";
                    DROPSITE.DataBind();

                    string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + DROPSITE.SelectedValue + "'");
                    DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    DROPGENSET.DataSource = DS12.Tables[0];
                    DROPGENSET.DataTextField = "GENSET_MODEL";
                    DROPGENSET.DataValueField = "GENSET_MODEL";
                    DROPGENSET.DataBind();


                    try
                    {

                        string COMANDO123 = string.Format("select * from gensetfinal where SITE='" + DROPSITE.SelectedValue + "' and GENSET_MODEL='" + DROPGENSET.SelectedValue + "'");
                        DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                        TXTSERIAL.Text = DS123.Tables[0].Rows[0]["GENSETSERIAL"].ToString();


                    }
                    catch (Exception)
                    {


                    }
                }
            }
            catch (Exception)
            {
                
           
            }
        }

        protected void DROPGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string COMANDO12 = string.Format("select * from gensetfinal where SITE='" + DROPSITE.SelectedValue + "' and GENSET_MODEL='" + DROPGENSET.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                TXTSERIAL.Text = DS12.Tables[0].Rows[0]["GENSETSERIAL"].ToString();


            }
            catch (Exception)
            {


            }
        }

        protected void DROPSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + DROPSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                DROPGENSET.DataSource = DS12.Tables[0];
                DROPGENSET.DataTextField = "GENSET_MODEL";
                DROPGENSET.DataValueField = "GENSET_MODEL";
                DROPGENSET.DataBind();


            }
            catch (Exception)
            {
                
              
            }


            try
            {
                
                string COMANDO12 = string.Format("select * from gensetfinal where SITE='" + DROPSITE.SelectedValue + "' and GENSET_MODEL='" + DROPGENSET.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                TXTSERIAL.Text = DS12.Tables[0].Rows[0]["GENSETSERIAL"].ToString();


            }
            catch (Exception)
            {
                
              
            }

        }

        protected void BTNSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                string comando = string.Format("insert into MARRIOT values(getdate(),getdate(),'" + DROPSITE.Text + "','" + DROPGENSET.Text + "','" + TXTSERIAL.Text + "','" + TXTRUNNIGNHURS.Text + "','" + TXTLOAD.Text + "','" + TXTWATERTEMP.Text + "','" + TXTTUMBOTEMP.Text + "','" + TXTOILTEMP.Text + "','" + TXTFUELTEMP.Text + "','" + TXTPRESSURE.Text + "','" + TXTCENTRALLOAD.Text + "','" + TXTTUMBOATEMP.Text + "','" + TXTFUELGENSET.Text + "','" + TXTCOMENT.Text + "','" + GetTime() + "',getdate())");
                DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                Response.Redirect("~/USUARIO2/Marriot.aspx");
            }
            catch (Exception)
            {
                
              
            }
        }

        protected void BTNEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                string comando = string.Format("UPDATE MARRIOT SET  SITE1='" + DROPSITE.Text + "',GENSET='" + DROPGENSET.Text + "',SERIAL='" + TXTSERIAL.Text + "',runninghours='" + TXTRUNNIGNHURS.Text + "',LOAD1='" + TXTLOAD.Text + "',watertemp='" + TXTWATERTEMP.Text + "',turbobtemp='" + TXTTUMBOTEMP.Text + "',oiltemp='" + TXTOILTEMP.Text + "',fuletemp='" + TXTFUELTEMP.Text + "',oilpressure='" + TXTPRESSURE.Text + "',centralload='" + TXTCENTRALLOAD.Text + "',turboatemp='" + TXTTUMBOATEMP.Text + "',fuelgenset='" + TXTFUELGENSET.Text + "',comment='" + TXTCOMENT.Text + "',usert='" + GetTime() + "',dateregister=getdate() WHERE ID='"+id+"'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                Response.Redirect("~/USUARIO2/Marriot.aspx");
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

                string COMANDO12 = string.Format("select * from MARRIOT where id='" + COMANDO + "'order by id desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = COMANDO;
               DROPSITE.Text = DS.Tables[0].Rows[0]["Site1"].ToString();
               DROPSITE_SelectedIndexChanged(null, null);
                DROPGENSET.Text = DS.Tables[0].Rows[0]["Genset"].ToString();
                //DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["Date1"].ToString());
                //TXTDATE.Text = fecha1.ToString("yyyy-MM-dd");
                //DateTime fecha2 = Convert.ToDateTime(DS.Tables[0].Rows[0]["Time1"].ToString());
                //txttime.Text = fecha2.ToString("HH:mm");
               TXTRUNNIGNHURS.Text = DS.Tables[0].Rows[0]["runninghours"].ToString();
               TXTLOAD.Text = DS.Tables[0].Rows[0]["load1"].ToString();
               TXTWATERTEMP.Text = DS.Tables[0].Rows[0]["watertemp"].ToString();
               TXTTUMBOTEMP.Text = DS.Tables[0].Rows[0]["turbobtemp"].ToString();
               TXTOILTEMP.Text = DS.Tables[0].Rows[0]["oiltemp"].ToString();
               TXTFUELTEMP.Text = DS.Tables[0].Rows[0]["fuletemp"].ToString();
               TXTPRESSURE.Text = DS.Tables[0].Rows[0]["oilpressure"].ToString();
               TXTCENTRALLOAD.Text = DS.Tables[0].Rows[0]["centralload"].ToString();
               TXTTUMBOATEMP.Text = DS.Tables[0].Rows[0]["turboatemp"].ToString();
               TXTFUELGENSET.Text = DS.Tables[0].Rows[0]["fuelgenset"].ToString();
               TXTCOMENT.Text = DS.Tables[0].Rows[0]["comment"].ToString();

               BTNSAVE.Enabled = false;
               BTNEDITAR.Enabled = true;
               BTNDELETE.Enabled = true;


            }
            catch (Exception E)
            {
                

            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                GridView1.DataSource = null;
                 string COMANDO12 = string.Format("select * from MARRIOT where "+cbcentro.Text+"  like '%" + txtbuscar.Text + "%' order by id desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                GridView1.DataSource = DS.Tables[0];
            }
            catch (Exception)
            {
                
               
            }
        }
    }
}