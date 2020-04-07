using System;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Web.UI;

namespace CanezPower
{
    public partial class OtrosNuevos_usuarios : System.Web.UI.Page
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
                string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                DROPCLIEN.DataSource = DS1.Tables[0];
                DROPCLIEN.DataTextField = "COMPANY_NAME";
                DROPCLIEN.DataBind();
                string COMANDO = string.Format("select site from site");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                DROPSITE.DataSource = DS.Tables[0];
                DROPSITE.DataTextField = "site";
                DROPSITE.DataBind();
                GridView1.DataSourceID = null;
                DROPCLIEN_SelectedIndexChanged(null, null);
                MOSTRAR();
            }

            GridView1.DataSourceID = null;
         
        }

        void MOSTRAR()
        {

            try
            {
                string COMANDO = string.Format("SELECT * FROM otheruser ORDER BY ID DESC");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {

               
            }

        }


        public static string ID;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT * FROM otheruser WHERE ID ='" + GridView1.SelectedRow.Cells[2].Text + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                ID = GridView1.SelectedRow.Cells[2].Text;

                TXTUSER.Text = ds.Tables[0].Rows[0]["USERNAME"].ToString();
                DROPCLIEN.Text = ds.Tables[0].Rows[0]["COMPANY"].ToString();
                DROPSITE.Text = ds.Tables[0].Rows[0]["SITE"].ToString();


            }
            catch (Exception)
            {


            }
        }

        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            try
            {


                string COMANDO1 = string.Format("SELECT * FROM otheruser WHERE USERNAME ='" + TXTUSER.Text + "'");
                DataSet ds1 = CLASS_CONECTAR.CONECTAR(COMANDO1);

                if (ds1.Tables[0].Rows.Count>0)
                {
                    Response.Write("<script>alert('YOU ARE ALREADY A USER WITH THE NAME');</script>");
                }
                else
                {
                    string COMANDO = string.Format("INSERT INTO otheruser VALUES('" + DROPCLIEN.Text + "','" + TXTUSER.Text + "','" + "welcome1" + "','" + DROPSITE.Text + "','" + GetTime() + "')");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);

                    Response.Redirect("~/OtrosNuevos_usuarios.aspx");
                }
               


            }
            catch (Exception)
            {

                
            }
        }

        protected void TXTEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("update otheruser set COMPANY='" + DROPCLIEN.Text + "',SITE='" + DROPSITE.Text + "',LOADEDBY='" + GetTime() + "' WHERE ID ='"+ ID + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);

                Response.Redirect("~/OtrosNuevos_usuarios.aspx");


            }
            catch (Exception)
            {


            }
        }

        protected void TXTDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("DELETE FROM otheruser WHERE ID = '"+ ID + "' ");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);

                Response.Redirect("~/OtrosNuevos_usuarios.aspx");


            }
            catch (Exception)
            {


            }
        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT * FROM otheruser WHERE COMPANY LIKE'%"+TXTUSUARIO.Text+"%'   ORDER BY ID DESC");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }
        }

        protected void DROPCLIEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT * FROM clienst WHERE COMPANY_NAME ='" + DROPCLIEN.Text + "'   ORDER BY ID DESC");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                TXTEMAIL.Text = ds.Tables[0].Rows[0]["E_MAIL"].ToString();
            }
            catch (Exception)
            {

               
            }
        }
        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {

            if (e.CommandName == "reenviar")
            {
                int valor = Convert.ToInt32(e.CommandArgument);
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                string msg = string.Empty;

                try
                {

                    string comando = string.Format("select * from clienst where COMPANY_NAME ='" + GridView1.Rows[valor].Cells[3].Text + "'");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                    string dato = ds.Tables[0].Rows[0]["E_MAIL"].ToString();


                    DateTime DATE = DateTime.Today.Date;
                    string DAT = DATE.ToString("yyyy-MM-dd");
                    MailAddress fromAddress1 = new MailAddress("system@canezpowerdivision.com");
                    message.From = fromAddress1;
                    message.To.Add(dato);
                    message.Subject = "Resect Password";
                    message.IsBodyHtml = true;
                    message.Body = GridView1.Rows[valor].Cells[5].Text;
                    string mensaje = " Hello \n" + GridView1.Rows[valor].Cells[3].Text +
                           "<br/>" +
                            GetTime() + " Resect Your Password, <br/>  " +
                            "<br/>" +
                        //"TTN :" + dato122.ToString() +
                            "<br/>" +

                            "<table border=1    margin: 15px;  padding: 15px; >" +
                            "<tr>" +
                            "<td class=auto - style4>Date:</td>" +
                            " <td class=auto - style2>" + DateTime.Now.ToString() + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td class=auto - style4>User:</td>" +
                            "<td class=auto - style2>" + GridView1.Rows[valor].Cells[6].Text + "</td>" +
                            " </tr>" +
                            " <tr>" +
                            "<td class=auto - style6>Password:</td>" +
                            " <td class=auto - style7>" + GridView1.Rows[valor].Cells[5].Text + "</td>" +
                            " </tr>" +

                            " </table>" +

                            "<br/>   Please login and update your account as soon you solve it. \n" +
                            "<br/>" +
                            "<br/>  This email generate automatically by CANEZPOWERDIVISION.COM \n" +
                            "<br/>" +
                            "<br/>  CPD Tracking Software Team \n" +
                            "<br/>" +
                            "<br/>   Note, do not replay this email \n";

                    message.Body = mensaje;
                    smtpClient.Host = "relay-hosting.secureserver.net";   //-- Donot change.
                    smtpClient.Port = 25; //--- Donot change
                    smtpClient.EnableSsl = false;//--- Donot change
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("system@canezpowerdivision.com", "123456");

                    smtpClient.Send(message);
                    Response.Write("<script>alert('Successful!');</script>");
                    Response.Redirect("~/OtrosNuevos_usuarios.aspx");
                }
                catch (Exception error)
                {

                    Response.Write("<script>alert('"+" Error: "+error.Message+"');</script>");
                }
               





                }

            }
        }
}
