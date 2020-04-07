using System;
using System.Data;
using System.Web;
using System.Web.UI;

namespace CanezPower.USUARIO2
{
    public partial class LEASING : System.Web.UI.Page
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
            mostra();
        }


        void mostra()
        {
            try
            {

                string COMANDO = String.Format(" SELECT DISTINCT       edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.gensetfinal.GENSET AS [GENSET MODEL], edgar2211.gensetfinal.GENSETSERIAL AS [GENSET SERIAL],   MAX(edgar2211.technical.HOUR_MASTER_READING) AS [HOUR MASTER READING],   edgar2211.gensetfinal.ENERGIE_MODEL AS [ENERGIE MODEL], edgar2211.gensetfinal.TEAM, edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE AS CONSUMABLES, edgar2211.gensetfinal.ID AS [SYSTEM ID]   FROM   edgar2211.gensetfinal   LEFT OUTER JOIN edgar2211.technical ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.technical.GENSET  where edgar2211.gensetfinal.CONTRACT='leasing'  GROUP BY edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL, edgar2211.gensetfinal.GENSETSERIAL, edgar2211.gensetfinal.GENSET, edgar2211.gensetfinal.GENSETID, edgar2211.gensetfinal.TEAM,     edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE,edgar2211.gensetfinal.ID,     edgar2211.gensetfinal.ENERGIE_MODEL");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            catch (Exception )
            {
                //LBLESTADO.Text = E.Message;

            }


        }
    }
}