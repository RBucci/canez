using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class LOG : System.Web.UI.Page
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
            TXTREFENCE1.Attributes.Add("onkeypress", "cambiaFoco('TXTSearch_Click')");

            if (!Page.IsPostBack)
            {

                string COMANDO = string.Format("select site from site");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                CBSITE.DataSource = DS.Tables[0];
                CBSITE.DataTextField = "site";
                CBSITE.DataBind();
               
                CBSITE_SelectedIndexChanged(null, null);
                TXTGENSETSERIAL_SelectedIndexChanged(null, null);
                Button4.Enabled = false;
                Button5.Enabled = false;
                mostar();
            }






        }


        void LIMPIAR()
        {

            TXTREFENCE2.Text = "";
            TXTREFENCE3.Text = "0";
            TXTDESCRIPTION.Text = "";

            mostar();
        }


        void mostar()
        {

            try
            {
                //string COMANDO = string.Format("SELECT        id, Date, Site, Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description], User_Login as [User] FROM            edgar2211.cm2 order by id desc");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();



            }
            catch (Exception)
            {


            }

        }
        private string datos;

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (checkemail.Checked == true)
                {
                    correos();
                }
                datos = TXTDESCRIPTION.Text;

                string COMANDO12 = string.Format("exec new_LOG'" + txtdate.Text + "','" + CBSITE.SelectedValue + "','" + TXTGENSETSERIAL.SelectedValue + "','" + TXTSERIAL.Text + "','" + TXTREFENCE2.Text + "','" + TXTREFENCE3.Text + "','" + Label2.Text + "','" + datos + "','" + GetTime() + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                LBLESTADO.Text = "se realizo correctamente";
                mostar();
                LIMPIAR();
                Response.Redirect("~/LOG.aspx");
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }



        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + CBSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                TXTGENSETSERIAL.DataSource = DS12.Tables[0];
                TXTGENSETSERIAL.DataTextField = "GENSET_MODEL";
                TXTGENSETSERIAL.DataValueField = "GENSET_MODEL";
                TXTGENSETSERIAL.DataBind();
                TXTGENSETSERIAL.Items.Insert(0, new ListItem("SITE"));
                TXTGENSETSERIAL_SelectedIndexChanged(null, null);

            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }
        }






        public static string use = "";

        protected void TXTGENSETSERIAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (TXTGENSETSERIAL.Text=="SITE")
                {
                    TXTSERIAL.Text = "";
                }
                else
                {
                    string COMANDO12 = string.Format("select * from gensetfinal where SITE='" + CBSITE.SelectedValue + "' and GENSET_MODEL='" + TXTGENSETSERIAL.SelectedValue + "'");
                    DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    TXTSERIAL.Text = DS12.Tables[0].Rows[0]["GENSETSERIAL"].ToString();

                }
               

            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }





        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {


                if (checkemail.Checked == true)
                {
                    correos();
                }


                string COMANDO12 = string.Format("exec actu_LOG '" + id + "','" + txtdate.Text + "','" + CBSITE.Text + "','" + TXTGENSETSERIAL.Text + "','" + TXTSERIAL.Text + "','" + TXTREFENCE2.Text + "','" + TXTREFENCE3.Text + "','" + Label2.Text + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                LBLESTADO.Text = "se realizo correctamente";
                mostar();
                save.Enabled = true;
                Button4.Enabled = false;
                Button5.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/LOG.aspx");
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }
        public static int id = 0;

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {



                if (checkemail.Checked == true)
                {
                    correos();
                }

                string COMANDO12 = string.Format("delete  from TBLOG where id='" + id + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                mostar();
                save.Enabled = true;
                Button4.Enabled = false;
                Button5.Enabled = false;
                LIMPIAR();
                Response.Redirect("~/LOG.aspx");
            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }


        }

        void correos()
        {

            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;


            try
            {

                //correo = CBASING.SelectedItem.ToString();
                //string comando = string.Format("select * from employeet where NICK_NAME like'%" + CBASING.SelectedValue + "%'");
                //DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                //string dato = ds.Tables[0].Rows[0]["E_MAIL"].ToString();

                //string comando12 = string.Format("select * from ttn ORDER BY TTN_ID ASC");
                //DataSet ds12 = CLASS_CONECTAR.CONECTAR(comando12);
                //int dato12 = Convert.ToInt32(ds12.Tables[0].Rows[0]["TTN_ID"].ToString());

                DateTime DATE = DateTime.Today.Date;
                string DAT = DATE.ToString("yyyy-MM-dd");
                MailAddress fromAddress1 = new MailAddress("system@canezpowerdivision.com");
                message.From = fromAddress1;
                message.To.Add("team@canezgeneration.com");
                message.Subject = "NEW TEAM";
                message.IsBodyHtml = true;
                //message.Body = TXTNOTA.Text;
                string mensaje = " Hello   TEAM,\n" +
                       "<br/>" +
                        GetTime() + " Want you to check the following information<br/>  " +
                        "<br/>" +
                        "LOG:" +
                        "<br/>" +

                        "<table border=1    margin: 15px;  padding: 15px; >" +
                        "<tr>" +
                        "<td class=auto - style4>Date:</td>" +
                        " <td class=auto - style2>" + txtdate.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Site:</td>" +
                        "<td class=auto - style2>" + CBSITE.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        "<td class=auto - style6>Genset:</td>" +
                        " <td class=auto - style7>" + TXTGENSETSERIAL.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        " <td class=auto - style8>Genset Serial:</td>" +
                        " <td class=auto - style9>" + TXTSERIAL.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "  <td class=auto - style5>Refference:</td>" +
                        "  <td class=auto - style3>" + TXTREFENCE2.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Running Hours:</td>" +
                        "  <td class=auto - style3>" + TXTREFENCE3.Text + "</td>" +
                        " </tr>" +
                          "<tr>" +
                        "  <td class=auto - style5>Note:</td>" +
                        "  <td class=auto - style3>" + TXTDESCRIPTION.Text + "</td>" +
                        " </tr>" +


                        " </table>" +

                          "<br/>   This email been generate automatically by CPD DataBase." +
                        "<br/>" +

                        "<br/>  Please do NOT Replay this email.  \n" +
                        "<br/>" +
                        "<br/>Best Regards," +
                         "<br/>" +
                        "<br/>   \n CANEZ POWER DIVISION S.A \n" +
                        "<br/>" +
                        "<br/>   \n";
                message.Body = mensaje;
                smtpClient.Host = "relay-hosting.secureserver.net";   //-- Donot change.
                smtpClient.Port = 25; //--- Donot change
                smtpClient.EnableSsl = false;//--- Donot change
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("system@canezpowerdivision.com", "123456");

                smtpClient.Send(message);


            }
            catch (Exception)
            {


            }



            //Response.Redirect("~/TTN.aspx");

        }



        protected void TXTSearch_Click(object sender, EventArgs e)
        {
            try
            {



                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT DISTINCT        TBLOG.id, TBLOG.Date, TBLOG.Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.TBLOG.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and TBLOG.id = DOCUMENT_SHOP.id_genset   where TBLOG." + DropDownList1.Text + " like '%" + TXTREFENCE1.Text + "%'   order by TBLOG.id desc");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO12 = string.Format("select * from TBLOG where id='" + COMANDO + "'order by id desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = Convert.ToInt32(COMANDO);
                CBSITE.Text = DS.Tables[0].Rows[0]["Site"].ToString();
                CBSITE_SelectedIndexChanged(null, null);
                TXTGENSETSERIAL.Text = DS.Tables[0].Rows[0]["Genset"].ToString();
                DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["Date"].ToString());
                txtdate.Text = fecha1.ToString("yyyy-MM-dd");
                TXTSERIAL.Text = DS.Tables[0].Rows[0]["Genset_Serial"].ToString();

                TXTREFENCE2.Text = DS.Tables[0].Rows[0]["Reference"].ToString();
                TXTREFENCE3.Text = DS.Tables[0].Rows[0]["Honning_Hours"].ToString();
                Label2.Text = DS.Tables[0].Rows[0]["Use_Since"].ToString();
                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["Notas"].ToString();
                save.Enabled = false;
                Button4.Enabled = true;
                Button5.Enabled = true;


            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        protected void TXTREFENCE3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int runnign = Convert.ToInt32(TXTREFENCE3.Text);
                int use1 = Convert.ToInt32(use);
                if (use1 == 0)
                {
                    Label2.Text = "0";

                }
                else
                {

                    int usefinal = runnign - use1;
                    Label2.Text = usefinal.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        protected void TXTSearch0_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;

                if (TXTREFENCE1.Text == "")
                {
                    string COMANDO = string.Format("SELECT  DISTINCT      TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.TBLOG.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset   where (TBLOG.Date >= '" + TXTDESDE.Text + "') and (TBLOG.Date <= '" + TXTHASTA.Text + "')  order by TBLOG.id desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                }
                else
                {



                    string COMANDO = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN 'YES' ELSE 'NO' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.TBLOG.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset   where TBLOG." + DropDownList1.Text + " like '%" + TXTREFENCE1.Text + "%'  and (TBLOG.Date >= '" + TXTDESDE.Text + "') and (TBLOG.Date <= '" + TXTHASTA.Text + "')   order by TBLOG.id desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                }




            }
            catch (Exception)
            {


            }
        }
        public static string IDGENSET, GENSET, nombre = "";
        protected void save0_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i < Context.Request.Files.Count; i++)
                {
                    //FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                    HttpPostedFile file = Context.Request.Files[i];

                    nombre = String.Format("{0}_{1:yyyyMMdd_hhmm}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                    //ruta1 = Server.MapPath("canezpdf");
                    file.SaveAs(Server.MapPath(".") + "/canezpdf/" + nombre);
                    //string rutacompleta = Path.Combine(ruta1, nombre);
                    string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + id + "','" + GridView1.SelectedRow.Cells[5].Text + "','" + "http://canezpowerdivision.com/canezpdf/" + nombre + "',GETDATE(),'" + GetTime() + "','" + "log" + "')");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[5].Text;

                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "log");

                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;

                }

            }
        }
    }
}