using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class NEW_CLAVE : System.Web.UI.Page
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

        }

        protected void BTNEXPO_Click(object sender, EventArgs e)
        {

            NEW_site();
        }
        void NEW_site()
        {
            try
            {

                string COMANDO = string.Format("exec newclave'" + GetTime() +"','"+TextBox1.Text+"'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                LBLESTADO.Text = "YOUR PASSWORD IS UPDATED";

                Response.Redirect("~/NEW_CLAVE.aspx");
            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }
        }
}
}