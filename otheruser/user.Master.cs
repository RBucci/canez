using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.otheruser
{
    public partial class user : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Page.User.Identity.Name))
            {
                Response.Redirect("~/Default.aspx");

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ////se borra la cookie de autenticacion
            //Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            //se redirecciona al usuario a la pagina de login
            //_Default. = "";
            FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



        }


    }
}