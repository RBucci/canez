using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class Site2 : System.Web.UI.MasterPage
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

            if (string.IsNullOrEmpty(Page.User.Identity.Name))
            {
                Response.Redirect("~/Default.aspx");

            }
            try
            {
                string CADENA = string.Format("SELECT * FROM employeet WHERE NAME1='" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                string LEVEL = DS.Tables[0].Rows[0]["LEVEL1"].ToString();
                if (LEVEL != "2")
                {
                    Response.Redirect("~/Default.aspx");
                }
                if (DS.Tables[0].Rows.Count > 0)
                {

                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }

            }
            catch (Exception)
            {


            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ////se borra la cookie de autenticacion
            //Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            //se redirecciona al usuario a la pagina de login
            _Default.DS2 = "";
            FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



        }
    }
}