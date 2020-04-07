using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NEW_CLIENT.aspx");
        }

        protected void BTNMANTENARCE_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EMPLOYES.aspx");
        }
    }
}