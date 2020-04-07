using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Security.Principal;
using System.Security.Permissions;

namespace CanezPower.USUARIO1
{




    public partial class Site1 : System.Web.UI.MasterPage
    {



        public IPrincipal User
        {
            get;
            [SecurityPermissionAttribute(SecurityAction.Demand, ControlPrincipal = true)]
            set;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (_Default.DS2 == "" || _Default.DS2 == null || _Default.DS2 == "0")
            {
                Response.Redirect("~/Default.aspx");
            }

            //Label1.Text = Page.User.Identity.Name;
            //ver();


        }

        void ver()
        {

            Response.Cache.SetCacheability(HttpCacheability.Server);

            Response.Cache.SetSlidingExpiration(true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ////se borra la cookie de autenticacion
            //Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            //se redirecciona al usuario a la pagina de login
            _Default.DS2 = "";
            Response.Redirect("~/Default.aspx");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            ////se borra la cookie de autenticacion
            //Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            //se redirecciona al usuario a la pagina de login


            Response.Redirect("~/NEW_CLAVE1.aspx");





        }

    }
}