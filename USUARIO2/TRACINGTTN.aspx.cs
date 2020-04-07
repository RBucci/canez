using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class TRACINGTTN : System.Web.UI.Page
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
        public static string SERIAL;
        protected void Page_Load(object sender, EventArgs e)
        {

            // TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('Button1_Click')");
            Panel1.DefaultButton = Button1.ID;
            //ver_NEW_site_();
            //MOSTRAL();
            //BTNGUARDAR.Enabled = true;
            //BTNGUARDAR0.Enabled = false;
            //BTNGUARDAR1.Enabled = false;
            SERIAL = Request.QueryString.Get("MyVar");
            if (!Page.IsPostBack)
            {
                SELEC();
                CBSITE_SelectedIndexChanged(null, null);
                colores();
                try
                {
                    string COMANDO123 = string.Format("select NICK_NAME from employeet");
                    DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                    CBASING0.DataSource = DS123.Tables[0];
                    CBASING0.DataTextField = "NICK_NAME";
                    CBASING0.DataBind();
                }
                catch (Exception)
                {


                }
            }

            GridView1_SelectedIndexChanged(null, null);
        }


        void colores()
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site,edgar2211.ttn.GENSET as Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   where edgar2211.ttn.STATUS1 !='" + "CLOSED" + "' order by ttn.TTN_ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();




            }
            catch (Exception)
            {


            }
        }









        protected void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            //Enviar("jose el mejos","jose diaz","josedo2218@gmail.com","jajajajajajaj");
            //NEW_YYN();
            //correos();
            //limpiar();
        }

        protected void EDIT(object sender, EventArgs e)
        {
            //Enviar("jose el mejos","jose diaz","josedo2218@gmail.com","jajajajajajaj");
            //correos();
            //EDIT1();
            //limpiar();
            //BTNGUARDAR.Enabled = true;
            //BTNGUARDAR0.Enabled = false;
            //BTNGUARDAR1.Enabled = false;
        }





        protected void SendEmail()
        {
            //const string SERVER = "relay-hosting.secureserver.net";
            //MailMessage oMail = new MailMessage();
            //oMail.From = "emailaddress@domainname";
            //oMail.To = "emailaddress@domainname";
            //oMail.Subject = "Test email subject";
            //oMail.BodyFormat = MailFormat.Html;	// enumeration
            //oMail.Priority = MailPriority.High;	// enumeration
            //oMail.Body = "Sent at: " + DateTime.Now;
            //SmtpMail.SmtpServer = SERVER;
            //SmtpMail.Send(oMail);
            //oMail = null;	// free up resources
        }


        public static string idID = "";
        public static string user1 = "";
        void SELEC()
        {
            try
            {
                string CADENA = string.Format("SELECT * FROM ttn WHERE TTN_ID='" + Request.QueryString.Get("MyVar") + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                //CBSITE.Text = DS.Tables[0].Rows[0]["SITE"].ToString();



                //DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["TARGET_DATE"].ToString());
                //TXTTAEGET.Text = fecha1.ToString("yyyy-MM-dd");
                //TXTTAXK.Text = DS.Tables[0].Rows[0]["TASK"].ToString();
                //CBASING.Text = DS.Tables[0].Rows[0]["ASSIN_TO"].ToString();
                //CBSTATUS.Text = DS.Tables[0].Rows[0]["STATUS1"].ToString();
                //TXTNOTA.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();
                //TXTNOTA2.Text = DS.Tables[0].Rows[0]["NOTE2"].ToString();
                idID = DS.Tables[0].Rows[0]["TTN_ID"].ToString();
                user1 = DS.Tables[0].Rows[0]["CREATE_BY"].ToString();
                if (DS.Tables[0].Rows[0]["GENSET"].ToString() == "SITE")
                {
                    //CBGENSET.Items.Insert(0, new ListItem("SITE"));

                }
                else
                {
                    //CBGENSET.Text = DS.Tables[0].Rows[0]["GENSET"].ToString();
                }


                //BTNGUARDAR.Enabled = false;
                //BTNGUARDAR0.Enabled = true;
                //BTNGUARDAR1.Enabled = true;
            }
            catch (Exception)
            {


            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                //if (COMANDO == string.Empty)
                //{

                //}
                //else
                //{
                //    Response.Redirect("TTN.aspx?MyVar=" + COMANDO.ToString());
                //}



            }
            catch (Exception E)
            {

                //LBLESTADO.Text = E.Message;
            }
        }


        protected void DELETE(object SENDER, EventArgs e)
        {

            try
            {

                string login = GetTime();
                //string user1 = GridView1.SelectedRow.Cells[3].Text;
                if (user1.ToUpper() == login.ToUpper())
                {
                    //string CADENA = string.Format("DELETE  FROM ttn WHERE TTN_ID='" + SERIAL + "'");
                    //DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    //LBLESTADO.Text = "Was successful";
                    //MOSTRAL();
                    //limpiar();

                    //BTNGUARDAR.Enabled = true;
                    //BTNGUARDAR0.Enabled = false;
                    //BTNGUARDAR1.Enabled = false;
                    //Response.Redirect("~/TTN.aspx");
                }
                else
                {
                    Response.Write("<script>alert('THIS TTN DOES NOT BELONG TO ELIMINATE IT, CONFIRM YOUR TTN');</script>");

                }


            }
            catch (Exception E)
            {

                //LBLESTADO.Text = E.Message;
            }


        }




        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //GridView1.PageIndex = e.NewPageIndex;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //int i = GridView1.PageIndex + 1;

            //if (i <= GridView1.PageCount)
            //{

            //    GridView1.PageIndex = i;
            //}
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //int i = GridView1.PageIndex + 1;

            //if (i <= GridView1.PageCount)
            //{

            //    GridView1.PageIndex = i;
            //}
        }
        protected void BTNGUARDAR0_Click(object sender, EventArgs e)
        {

        }


        protected void CBASING0_SelectedIndexChanged(object sender, EventArgs e)
        {



            try
            {
                //if (CBASING0.Text == "All")
                //{
                //    MOSTRAL();
                //}
                //else
                //{
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site,edgar2211.ttn.GENSET as Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   where ttn.ASSIN_TO = '" + CBASING0.Text + "' order by ttn.TTN_ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();



            }
            catch (Exception)
            {


            }

        }

        protected void CBSTATUS0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //    if (CBASING0.Text == "All")
                //    {

                //    }
                //    else
                //    {
                //        string COMANDO = string.Format("SELECT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM  FROM ttn where ttn.ASSIN_TO = '" + CBASING0.SelectedValue + "' and  ttn.STATUS1 ='" + CBSTATUS0.SelectedValue + "' order by ttn.TTN_ID desc");

                //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //        if (DS.Tables[0].Rows.Count <= 0)
                //        {
                //            Response.Write("<script>alert('This item was not found');</script>");
                //        }
                //        GridView1.DataSource = DS.Tables[0];
                //        GridView1.DataBind();

                //    }


                if (CBASING0.SelectedItem.ToString() == "ALL")
                {
                    GridView1.DataSourceID = null;
                    string COMANDO = string.Format("SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site,edgar2211.ttn.GENSET as Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   where   ttn.STATUS1 ='" + CBSTATUS0.Text + "' order by ttn.TTN_ID desc");

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
                    GridView1.DataSourceID = null;
                    string COMANDO = string.Format("SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site,edgar2211.ttn.GENSET as Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   where     edgar2211.ttn.ASSIN_TO='" + CBASING0.Text + "'  and  ttn.STATUS1 ='" + CBSTATUS0.Text + "' order by ttn.TTN_ID desc");

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT  DISTINCT  edgar2211.ttn.TTN_ID AS TTN, edgar2211.ttn.CREATE_BY AS [Create By], edgar2211.ttn.SITE AS Site,edgar2211.ttn.GENSET as Genset, edgar2211.ttn.TASK AS Task, edgar2211.ttn.ASSIN_TO AS [Assing To], edgar2211.ttn.NOTE AS [Jod Description], edgar2211.ttn.NOTE2 AS [Feedback Description], CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'ttn') THEN '1' ELSE '0' END AS Attachment, edgar2211.ttn.USER1, edgar2211.ttn.TARGET_DATE AS [Target date], edgar2211.ttn.STATUS1 AS Status, edgar2211.ttn.DATE_FINISH AS [Date Finish] FROM edgar2211.ttn LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.ttn.TTN_ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   where  edgar2211.ttn." + cbcampo.Text + " like '%" + TXTUSUARIO.Text + "%' order by ttn.TTN_ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception error)
            {
                //LBLESTADO.Text = error.Message;

            }
        }
        public static string IDGENSET, GENSET, nombre = "";

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[4].Text;



                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "ttn");





                }
                catch (Exception ERROR)
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }
        protected void save0_Click(object sender, EventArgs e)
        {
            try
            {


                //if (File.Exists(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName))
                //{
                //    LBLESTADO.Text = "There is a file with this name, change the name to be able to upload it to server";
                //}
                //else
                //{
                //    FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                //    LBLESTADO.Text = "se realizo correctamente";
                //    nombre = "http://canezpowerdivision.com/canezpdf/" + FileUpload1.FileName;
                //    string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + idID + "','" + GridView1.SelectedRow.Cells[4].Text + "','" + nombre + "',GETDATE(),'" + GetTime() + "','" + "ttn" + "')");
                //    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                //    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                //    Response.Redirect("~/TTN.aspx");
                //}
            }
            catch (Exception ERROR)
            {
                //LBLESTADO.Text = ERROR.Message;

            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[14].Text.CompareTo("OPEN") == 0)
                {
                    e.Row.BackColor = Color.FromName("#f16059");
                }

                if (e.Row.Cells[14].Text.CompareTo("ON GOING") == 0)
                {
                    e.Row.BackColor = Color.FromName("#ece198");
                }

                if (e.Row.Cells[14].Text.CompareTo("CLOSED") == 0)
                {
                    e.Row.BackColor = Color.FromName("#32CD32");
                }
            }
        }

        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + CBSITE.SelectedValue + "'");
                //DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                //CBGENSET.DataSource = DS12.Tables[0];
                //CBGENSET.DataTextField = "GENSET_MODEL";
                //CBGENSET.DataValueField = "GENSET_MODEL";
                //CBGENSET.DataBind();
                //CBGENSET.Items.Insert(0, new ListItem("SITE"));
            }
            catch (Exception)
            {


            }
        }
    }
}