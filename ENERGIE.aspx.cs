using System;
using System.Data;
using System.Web;
using System.Web.UI;

namespace CanezPower
{
    public partial class ENERGIE : System.Web.UI.Page
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




        public static string comando = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                ver_NEW_GENSET_();


            }
            //TextBox1.Attributes.Add("onkeypress", "cambiaFoco('btnbuscar_Click')");
            Panel1.DefaultButton = btnbuscar.ID;
        }
        void ver_NEW_GENSET_()
        {
            try
            {

                string COMANDO = string.Format("select * from ENERGIE");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception )
            {


            }

        }


        void NEW_GENSET()
        {
            try
            {

                string COMANDO = string.Format("insert into ENERGIE(ENEGIE)values('" + TextBox1.Text + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                ver_NEW_GENSET_();
                Response.Redirect("~/ENERGIE.aspx");

            }
            catch (Exception )
            {


            }



        }

        protected void BTNEXPO_Click(object sender, EventArgs e)
        {



            string coman = string.Format("select * from ENERGIE where ENEGIE = '" + TextBox1.Text + "' ");
            DataSet ds = CLASS_CONECTAR.CONECTAR(coman);
            if (ds.Tables[0].Rows.Count > 0)
            {
                LBLESTADO.Text = "YA EXISTE";

            }
            else
            {
                NEW_GENSET();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("select  * FROM ENERGIE WHERE ID='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                TextBox1.Text = DS.Tables[0].Rows[0]["ENEGIE"].ToString();

            }
            catch (Exception )
            {


            }
        }

        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {


                //string CADENA23 = string.Format("select * FROM gensetuniot WHERE id = '" + comando + "'");
                //DataSet DS23 = CLASS_CONECTAR.CONECTAR(CADENA23);
                //string CON = DS23.Tables[0].Rows[0]["GENSET"].ToString();
                //if (DS23.Tables[0].Rows.Count > 0)
                //{
                string CADENA = string.Format("update ENERGIE set ENEGIE='" + TextBox1.Text + "' WHERE ID='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);



                //    string CADENA2 = string.Format("update gensetfinal set GENSET='" + TextBox1.Text + "' WHERE GENSET = '" + CON + "'");
                //    DataSet DS2 = CLASS_CONECTAR.CONECTAR(CADENA2);


                //}




                //comando = GridView1.SelectedRow.Cells[2].Text;



                ver_NEW_GENSET_();
                Response.Redirect("~/ENERGIE.aspx");

            }
            catch (Exception )
            {


            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                //comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("delete from ENERGIE WHERE ID='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                ver_NEW_GENSET_();
                Response.Redirect("~/ENERGIE.aspx");

            }
            catch (Exception )
            {


            }
        }



        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string COMANDO = string.Format("select * from ENERGIE where ENEGIE like'%" + TextBox1.Text + "%'  ORDER BY id asc");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();




            }
            catch (Exception )
            {


            }
        }
    }
}