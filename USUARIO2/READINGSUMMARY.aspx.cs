using System;
using System.Data;
using System.Web.UI;

namespace CanezPower.USUARIO2
{
    public partial class READINGSUMMARY : System.Web.UI.Page
    {
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
            }

        }

        void MOSTRAR()
        {

            try
            {
                GridView3.DataSourceID = null;

                string COMANDO = string.Format("select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING ORDER BY DATE DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView3.DataSource = DS.Tables[0];
                GridView3.DataBind();
                
            }
            catch (Exception)
            {

               
            }

        }

        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridView3.DataSourceID = null;
                string COMANDO = string.Format("select	ID, SITE, GENSET, RUNNING_HOURS AS [ RUNNING HOURS], ENERGY, RATE, DATE, USER1 FROM TBREADING WHERE SITE LIKE '%"+CBSITE.Text+ "%' ORDER BY DATE DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView3.DataSource = DS.Tables[0];
                GridView3.DataBind();

            }
            catch (Exception)
            {


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