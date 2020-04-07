using System;
using System.Data;
using System.Web;

namespace CanezPower
{
    public partial class READINGEDIT : System.Web.UI.Page
    {




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
                MOSTRAR();

                string COMANDO = string.Format("select site from site");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                CBSITE.DataSource = DS.Tables[0];
                CBSITE.DataTextField = "site";
                CBSITE.DataBind();
                GridView3.DataSourceID = null;
            }


        }

        void MOSTRAR()
        {
            try
            {
                string COMANDO = string.Format("select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING  ORDER BY DATE DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView3.DataSource = DS.Tables[0];
                GridView3.DataBind();

            }
            catch (Exception)
            {

              
            }

        }


        public static string ID = "";

        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                string COMANDO = string.Format("select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING WHERE SITE LIKE '%" + CBSITE.Text + "%' ORDER BY DATE DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView3.DataSource = DS.Tables[0];
                GridView3.DataBind();

            }
            catch (Exception)
            {


            }
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void BTNSAVE_Click(object sender, EventArgs e)
        {
            //try
            //{

                string COMANDO = string.Format("UPDATE TBREADING SET RUNNING_HOURS = '"+txthoras.Text+"' , ENERGY='"+txtenergy.Text+"', RATE='"+txtrate.Text+"',USER1='"+GetTime()+"' WHERE ID='" + ID.ToString() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                Response.Redirect("~/READINGEDIT.aspx");

            //}
            //catch (Exception ERROR)
            //{

            //    Label2.Text = ERROR.Message;
            //}
        }

        protected void GridView3_SelectedIndexChanging(object sender, System.Web.UI.WebControls.GridViewSelectEventArgs e)
        {
          
        }

        protected void GridView3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {





                string comando = GridView3.SelectedRow.Cells[2].Text;
                ID = comando;

                string COMANDO = string.Format("select * FROM TBREADING WHERE ID = '" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                txthoras.Text = DS.Tables[0].Rows[0]["RUNNING_HOURS"].ToString();
                txtenergy.Text = DS.Tables[0].Rows[0]["ENERGY"].ToString();
                txtrate.Text = DS.Tables[0].Rows[0]["RATE"].ToString();
            }
            catch (Exception ERROR)
            {

                Label2.Text = ERROR.Message;
            }
        }

        protected void txtmesreading_TextChanged(object sender, EventArgs e)
        {
            try
            {

                GridView3.DataSourceID = null;
                DateTime datev = Convert.ToDateTime(txtmesreading.Text);
                string COMANDO = string.Format("exec mostrarantes_ACTUAL'" + CBSITE.Text + "','" + datev.ToString("yyyy-MM-dd") + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                GridView3.DataSource = DS.Tables[0];
                GridView3.DataBind();



            }
            catch (Exception)
            {

            }
        }
    }
}