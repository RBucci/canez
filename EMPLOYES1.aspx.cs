using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class EMPLOYES1 : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                MOSTRAL();
                BTNDELETE.Enabled = false;
                BTNEDITAR.Enabled = false;
                BTNSAVE.Enabled = true;

            }
            // TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNSAVE0_Click')");

            Panel1.DefaultButton = BTNSAVE0.ID;
        }

        void limpiar()
        {
            TXTNIF.Text = "";
            TXTNICK.Text = "";
            txtfirt.Text = "";
            TXTLASTNAME.Text = "";
            TXTLOCATION.Text = "";
            TXTTITLE.Text = "";
            TXTEMAIL.Text = "";
            TXTPHONE.Text = "";
            TXTSTARTING.Text = "";
            TXTACCOUNT.Text = "";
            TXTNOTE.Text = "";

        }

        void MOSTRAL()
        {

            try
            {

                string COMANDO = string.Format("SELECT employeet.ID, employeet.NICK_NAME AS [Nick],employeet.NAME1 AS [Fist Name],employeet.LAST_ANME AS [Last Name],employeet.LOCATION AS [Section],employeet.TITLE as Title ,employeet.E_MAIL AS [E-mail],Convert(date, employeet.FIRST_NAME,108) AS [Birthdate],employeet.PHONE_NUMBER AS Phone,employeet.NIF,employeet.ACCOUNT as [Bank Account],employeet.USER1 as [User],employeet.DRIVER as [Driver License],employeet.LEVEL1 AS [Level],employeet.DATE_STATING AS [Date Stating], VC FROM employeet ORDER BY ID ASC");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
                LBLTOTAL.Text = this.GridView1.Rows.Count.ToString();

            }
            catch (Exception error)
            {

                LBLESTADO.Text = error.Message;
            }


        }

        void NEW_EMPLOY()
        {
            try
            {

                if (CBTIPO.Text == "YES")
                {
                    string COMANDO = string.Format("exec NEW_EMPLOYEE'" + TXTNICK.Text + "','" + TXTNAME.Text + "','" + txtfirt.Text + "','" + TXTLASTNAME.Text + "','" + TXTTITLE.Text + "','" + TXTLOCATION.Text + "','" + TXTEMAIL.Text + "','" + "welcome1" + "','" + TXTPHONE.Text + "','" + TXTNIF.Text + "','" + CBTIPO.Text + "','" + CBTIPO0.Text + "','" + GetTime() + "','" + TXTSTARTING.Text + "','" + TXTACCOUNT.Text + "','" + TXTNOTE.Text + "','" + TXTLICENSE.Text + "','" + CBTIPO1.Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "Was successful";
                    MOSTRAL();
                    Response.Redirect("~/EMPLOYES1.aspx");
                }
                else
                {
                    string COMANDO = string.Format("exec NEW_EMPLOYEE'" + TXTNICK.Text + "','" + TXTNAME.Text + "','" + txtfirt.Text + "','" + TXTLASTNAME.Text + "','" + TXTTITLE.Text + "','" + TXTLOCATION.Text + "','" + TXTEMAIL.Text + "','" + "welcome1" + "','" + TXTPHONE.Text + "','" + TXTNIF.Text + "','" + CBTIPO.Text + "','" + CBTIPO0.Text + "','" + GetTime() + "','" + TXTSTARTING.Text + "','" + TXTACCOUNT.Text + "','" + TXTNOTE.Text + "','" + TXTLICENSE.Text + "','" + CBTIPO1.Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "Was successful";
                    MOSTRAL();
                    Response.Redirect("~/EMPLOYES1.aspx");
                }






            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }



        protected void BTNSAVE_Click(object sender, EventArgs e)
        {
            NEW_EMPLOY();
        }
        public static string id = "";
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                BTNDELETE.Enabled = true;
                BTNEDITAR.Enabled = true;
                BTNSAVE.Enabled = false;
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                id = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM employeet WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                TXTNICK.Text = DS.Tables[0].Rows[0]["NICK_NAME"].ToString();
                TXTNAME.Text = DS.Tables[0].Rows[0]["NAME1"].ToString();



                txtfirt.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["FIRST_NAME"]).ToString("yyyy-MM-dd");

                TXTLASTNAME.Text = DS.Tables[0].Rows[0]["LAST_ANME"].ToString();
                TXTTITLE.Text = DS.Tables[0].Rows[0]["TITLE"].ToString();
                TXTLOCATION.Text = DS.Tables[0].Rows[0]["LOCATION"].ToString();
                TXTEMAIL.Text = DS.Tables[0].Rows[0]["E_MAIL"].ToString();

                TXTPHONE.Text = DS.Tables[0].Rows[0]["PHONE_NUMBER"].ToString();
                TXTNIF.Text = DS.Tables[0].Rows[0]["NIF"].ToString();
                CBTIPO.Text = DS.Tables[0].Rows[0]["USER1"].ToString();
                CBTIPO0.Text = DS.Tables[0].Rows[0]["LEVEL1"].ToString();
                TXTSTARTING.Text = DS.Tables[0].Rows[0]["DATE_STATING"].ToString();
                TXTACCOUNT.Text = DS.Tables[0].Rows[0]["ACCOUNT"].ToString();
                TXTNOTE.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();
                TXTLICENSE.Text = DS.Tables[0].Rows[0]["DRIVER"].ToString();
                CBTIPO1.Text = DS.Tables[0].Rows[0]["VC"].ToString();
                TXTSTARTING.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE_STATING"]).ToString("yyyy-MM-dd");






            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }

        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                string COMANDO = string.Format("DELETE FROM employeet WHERE NIF = '" + TXTNIF.Text + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                MOSTRAL();
                BTNDELETE.Enabled = false;
                BTNEDITAR.Enabled = false;
                BTNSAVE.Enabled = true;
                limpiar();
                Response.Redirect("~/EMPLOYES1.aspx");

            }
            catch (Exception)
            {


            }
        }

        protected void BTNEDITAR_Click(object sender, EventArgs e)
        {


            try
            {



                //txtfirt.TextMode = TextBoxMode.Date;
                //TXTSTARTING.TextMode = TextBoxMode.Date;
                //txtfirt.Text = "yyyy-MM-dd"; 

                if (CBTIPO.Text == "NO")
                {
                    string COMANDO = string.Format("exec UPDATE_EMPLOYEE '" + id + "','" + TXTNICK.Text + "','" + TXTNAME.Text + "','" + txtfirt.Text + "','" + TXTLASTNAME.Text + "','" + TXTTITLE.Text + "','" + TXTLOCATION.Text + "','" + TXTEMAIL.Text + "','" + TXTPHONE.Text + "','" + TXTNIF.Text + "','" + CBTIPO.Text + "','" + TXTACCOUNT.Text + "','" + TXTNOTE.Text + "','" + TXTLICENSE.Text + "','" + TXTSTARTING.Text + "','" + "" + "','" + CBTIPO1.Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "Was successful";
                    MOSTRAL();

                    BTNDELETE.Enabled = false;
                    BTNEDITAR.Enabled = false;
                    BTNSAVE.Enabled = true;
                    limpiar();
                    Response.Redirect("~/EMPLOYES1.aspx");
                }
                else
                {
                    string COMANDO = string.Format("exec UPDATE_EMPLOYEE '" + id + "','" + TXTNICK.Text + "','" + TXTNAME.Text + "','" + txtfirt.Text + "','" + TXTLASTNAME.Text + "','" + TXTTITLE.Text + "','" + TXTLOCATION.Text + "','" + TXTEMAIL.Text + "','" + TXTPHONE.Text + "','" + TXTNIF.Text + "','" + CBTIPO.Text + "','" + TXTACCOUNT.Text + "','" + TXTNOTE.Text + "','" + TXTLICENSE.Text + "','" + TXTSTARTING.Text + "','" + CBTIPO0.Text + "','" + CBTIPO1.Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "Was successful";
                    MOSTRAL();

                    BTNDELETE.Enabled = false;
                    BTNEDITAR.Enabled = false;
                    BTNSAVE.Enabled = true;
                    limpiar();
                    Response.Redirect("~/EMPLOYES1.aspx");
                }




            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }


        }

        protected void TXTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //GridView1.PageIndex = e.NewPageIndex;
        }


        protected void next(object sender, EventArgs e)
        {
            int i = GridView1.PageIndex + 1;

            if (i <= GridView1.PageCount)
            {

                GridView1.PageIndex = i;
            }


        }


        protected void next1(object sender, EventArgs e)
        {
            int i = GridView1.PageCount;

            if (GridView1.PageIndex > 0)
            {

                GridView1.PageIndex = GridView1.PageIndex - 1;



            }

        }

        protected void BTNSAVE0_Click(object sender, EventArgs e)
        {
            try
            {
                string CADENA = string.Format("SELECT employeet.ID, employeet.NICK_NAME AS [Nick],employeet.NAME1 AS [Fist Name],employeet.LAST_ANME AS [Last Name],employeet.LOCATION AS [Section],employeet.TITLE as Title ,employeet.E_MAIL AS [E-mail],employeet.FIRST_NAME AS [Birthdate],employeet.PHONE_NUMBER AS Phone,employeet.NIF,employeet.ACCOUNT as [Bank Account],employeet.USER1 as [User],employeet.DRIVER as [Driver License],employeet.LEVEL1 AS [Level],employeet.DATE_STATING AS [Date Stating], VC FROM employeet  WHERE " + DropDownList1.Text + " LIKE '%" + TXTUSUARIO.Text + "%'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM employeet WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                //TXTNICK.Text = DS.Tables[0].Rows[0]["NICK_NAME"].ToString();
                //TXTNAME.Text = DS.Tables[0].Rows[0]["NAME1"].ToString();



                //txtfirt.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["FIRST_NAME"]).ToString("yyyy-MM-dd");

                //TXTLASTNAME.Text = DS.Tables[0].Rows[0]["LAST_ANME"].ToString();
                //TXTTITLE.Text = DS.Tables[0].Rows[0]["TITLE"].ToString();
                //TXTLOCATION.Text = DS.Tables[0].Rows[0]["LOCATION"].ToString();
                //TXTEMAIL.Text = DS.Tables[0].Rows[0]["E_MAIL"].ToString();

                //TXTPHONE.Text = DS.Tables[0].Rows[0]["PHONE_NUMBER"].ToString();
                //TXTNIF.Text = DS.Tables[0].Rows[0]["NIF"].ToString();
                //CBTIPO.Text = DS.Tables[0].Rows[0]["USER1"].ToString();
                //CBTIPO0.Text = DS.Tables[0].Rows[0]["LEVEL1"].ToString();
                //TXTSTARTING.Text = DS.Tables[0].Rows[0]["DATE_STATING"].ToString();
                //TXTACCOUNT.Text = DS.Tables[0].Rows[0]["ACCOUNT"].ToString();
                TXTNOTE.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();
                TXTLICENSE.Text = DS.Tables[0].Rows[0]["DRIVER"].ToString();

                TXTSTARTING.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE_STATING"]).ToString("yyyy-MM-dd");








            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }


        }

        protected void BTNSAVE1_Click(object sender, EventArgs e)
        {
            try
            {
                string CADENA = string.Format("UPDATE employeet SET PASSWORD1='welcome1'   WHERE ID='" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                LBLESTADO.Text = "Was successful";
                Response.Redirect("~/EMPLOYES1.aspx");
            }
            catch (Exception)
            {

            }
        }


    }
}