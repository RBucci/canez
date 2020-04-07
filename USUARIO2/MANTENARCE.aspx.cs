using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;
using System.IO;

namespace CanezPower.USUARIO2
{
    public partial class MANTENARCE : System.Web.UI.Page
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
            // TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");

            Panel1.DefaultButton = BTNBUSCAR.ID;

            if (!Page.IsPostBack)
            {

                ver_NEW_site_1();
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                ver_NEW_site_();

            }
        }
        void ver_NEW_site_()
        {
            try
            {

                if (!Page.IsPostBack)
                {

                    string COMANDO = string.Format("SELECT DISTINCT edgar2211.site.site FROM edgar2211.site INNER JOIN edgar2211.gensetfinal ON edgar2211.site.site = edgar2211.gensetfinal.SITE");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    CBSITE.DataSource = DS.Tables[0];
                    CBSITE.DataTextField = "site";
                    CBSITE.DataBind();


                    //string COMANDO1 = string.Format("select COMPANY_NAME from CLIENST");
                    //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    //CBTEAM.DataSource = DS1.Tables[0];
                    //CBTEAM.DataTextField = "COMPANY_NAME";
                    //CBTEAM.DataBind();

                    string COMANDO123 = string.Format("select NICK_NAME from employeet");
                    DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                    CBTEAM.DataSource = DS123.Tables[0];
                    CBTEAM.DataTextField = "NICK_NAME";
                    CBTEAM.DataBind();




                }

                //string COMANDO12 = string.Format("select GENSET from gensetuniot");
                //DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                //CBGENSET.DataSource = DS12.Tables[0];
                //CBGENSET.DataTextField = "GENSET";
                //CBGENSET.DataBind();
            }
            catch (Exception)
            {


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
                        "Service :" +
                        "<br/>" +

                        "<table border=1    margin: 15px;  padding: 15px; >" +
                        "<tr>" +
                        "<td class=auto - style4>Date:</td>" +
                        " <td class=auto - style2>" + TXTDATE.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Site</td>" +
                        "<td class=auto - style2>" + CBSITE.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        "<td class=auto - style6>Genset:</td>" +
                        " <td class=auto - style7>" + CBGENSET.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        " <td class=auto - style8>Remainder:</td>" +
                        " <td class=auto - style9>" + txtremainder.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "  <td class=auto - style5>Team:</td>" +
                        "  <td class=auto - style3>" + CBTEAM.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Reading Hour:</td>" +
                        "  <td class=auto - style3>" + TXTORDMASATER.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil Running:</td>" +
                        "  <td class=auto - style3>" + TXTRUNING.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil:</td>" +
                        "  <td class=auto - style3>" + CBENGIERREPLACE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil Qty Removed</td>" +
                        "  <td class=auto - style3>" + TXTQTYREMOVEDOIL.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil Add:</td>" +
                        "  <td class=auto - style3>" + TXTGL.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil Different:</td>" +
                        "  <td class=auto - style3>" + YXYDIFERENT.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Oil Filter:</td>" +
                        "  <td class=auto - style3>" + CBFILTERREPLACE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Tank Decanter:</td>" +
                        "  <td class=auto - style3>" + CBDECANTERFILTER.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Pre-Fuel Filter:</td>" +
                        "  <td class=auto - style3>" + CBRPRE_FILTERREPLACE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Fuel Filter:</td>" +
                        "  <td class=auto - style3>" + CBFUELFILTERREPLACE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Inner Air Filter:</td>" +
                        "  <td class=auto - style3>" + CBINNERAIRFILTERREPLACE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Outer Air Filter:</td>" +
                        "  <td class=auto - style3>" + CBAIRFILTEROUTERCHANGE.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Need a Review?:</td>" +
                        "  <td class=auto - style3>" + TXTVERIFICATION.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Comments:</td>" +
                        "  <td class=auto - style3>" + TXTNOTAS.Text + "</td>" +
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



        void ver_NEW_site_1()
        {
            try
            {

                //string COMANDO = string.Format("EXEC  VER_SERVICE");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();




            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;

            }
        }

        public static string SER = "";


        protected void BTNSAVE_Click(object sender, EventArgs e)
        {
            if (checkemail.Checked == true)
            {
                correos();
            }

            NEW_GENSET();
            LIMPIAR();
        }



        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                for (int i = 6; i < e.Row.Cells.Count; i++)
                {
                    e.Row.Cells[i].Text = "<div class=\"vertical-text\">" + e.Row.Cells[i].Text + "</div>";
                }
            }

        }

        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + CBSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                CBGENSET.DataSource = DS12.Tables[0];
                CBGENSET.DataTextField = "GENSET_MODEL";
                CBGENSET.DataValueField = "GENSET_MODEL";
                CBGENSET.DataBind();
                CBGENSET_SelectedIndexChanged(null, null);
            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }


        }
        public static string USERT = "";
        public static string id = "";



        void LIMPIAR()
        {
            TXTDATE.Text = "";
            txtremainder.Text = "";
            TXTORDMASATER.Text = "";
            TXTQTYREMOVEDOIL.Text = "";
            TXTRUNING.Text = "";
            TXTGL.Text = "";
            YXYDIFERENT.Text = "";
            TXTNOTAS.Text = "";
            ver_NEW_site_1();

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                BTNSAVE.Enabled = false;
                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;

                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM technical WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE1"].ToString());
                id = COMANDO;
                TXTDATE.Text = fecha1.ToString("yyyy-MM-dd");
                CBSITE.Text = DS.Tables[0].Rows[0]["SITE"].ToString();
                txtremainder.Text = GridView1.SelectedRow.Cells[4].Text;
                //CBSITE_SelectedIndexChanged(null, null);
                CBGENSET.Text = DS.Tables[0].Rows[0]["GENSET"].ToString();

                TXTVERIFICATION.Text = DS.Tables[0].Rows[0]["VERIFICATION"].ToString();

                CBTEAM.Text = DS.Tables[0].Rows[0]["TEAM"].ToString();
                TXTRUNING.Text = DS.Tables[0].Rows[0]["QIL_RUMMING_HR"].ToString();
                TXTORDMASATER.Text = DS.Tables[0].Rows[0]["HOUR_MASTER_READING"].ToString();
                CBENGIERREPLACE.Text = DS.Tables[0].Rows[0]["OIL_ENGINE_REPLACE"].ToString();
                TXTNOTAS.Text = DS.Tables[0].Rows[0]["NOTA"].ToString();
                TXTQTYREMOVEDOIL.Text = DS.Tables[0].Rows[0]["OIL_QTY_REMOVED"].ToString();
                TXTGL.Text = DS.Tables[0].Rows[0]["OIL_QTY_GL"].ToString();
                YXYDIFERENT.Text = DS.Tables[0].Rows[0]["OIL_DIFERENT"].ToString();
                CBFILTERREPLACE.Text = DS.Tables[0].Rows[0]["OIL_FILTER_REPLACE"].ToString();
                CBDECANTERFILTER.Text = DS.Tables[0].Rows[0]["ANK_DECARTER_FILTER_REPLACE"].ToString();
                CBRPRE_FILTERREPLACE.Text = DS.Tables[0].Rows[0]["PRE_FUEL_FILTER_REPLACE"].ToString();
                CBFUELFILTERREPLACE.Text = DS.Tables[0].Rows[0]["FUEL_FILTER_REPLACE"].ToString();
                CBINNERAIRFILTERREPLACE.Text = DS.Tables[0].Rows[0]["NNERT_A_IR_FILTER_REPLACE"].ToString();
                CBAIRFILTEROUTERCHANGE.Text = DS.Tables[0].Rows[0]["OUTER_AIR_FILTER_CHANGE"].ToString();


                USERT = DS.Tables[0].Rows[0]["USER_LOG"].ToString();

                //DateTime fecha = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE_STATING"].ToString());
                //TXTSTARTING.Text = fecha.ToString("yyyy-MM-dd");





            }
            catch (Exception)
            {



            }
        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                for (int i = 6; i < e.Row.Cells.Count; i++)
                {
                    e.Row.Cells[i].Text = "<div class=\"vertical-text\">" + e.Row.Cells[i].Text + "</div>";
                }
            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkemail.Checked == true)
                {
                    correos();
                }

                string COMANDO = string.Format("DELETE FROM technical WHERE ID = ('" + id + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                ver_NEW_site_1();
                LIMPIAR();
                Response.Redirect("~/MANTENARCE.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }



        }

        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkemail.Checked == true)
                {
                    correos();
                }


                DateTime fechainicio = Convert.ToDateTime(TXTDATE.Text);
                int dia = Convert.ToInt32(txtremainder.Text);
                fechainicio = fechainicio.AddDays(dia);
                LBLESTADO.Text = fechainicio.ToString("yyyy-MM-dd");

                string COMANDO = string.Format("exec EDIT_MAINTENES  '" + id + "','" + TXTDATE.Text + "','" + CBSITE.Text + "','" + CBGENSET.Text + "','" + CBTEAM.Text + "','" + TXTRUNING.Text + "','" + TXTORDMASATER.Text + "','" + CBENGIERREPLACE.Text + "','" + TXTQTYREMOVEDOIL.Text + "','" + TXTGL.Text + "','" + YXYDIFERENT.Text + "','" + CBFILTERREPLACE.Text + "','" + CBDECANTERFILTER.Text + "','" + CBRPRE_FILTERREPLACE.Text + "','" + CBFUELFILTERREPLACE.Text + "','" + CBINNERAIRFILTERREPLACE.Text + "','" + CBAIRFILTEROUTERCHANGE.Text + "','" + TXTVERIFICATION.Text + "','" + TXTNOTAS.Text + "','" + LBLESTADO.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";

                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;

                ver_NEW_site_1();
                LIMPIAR();
                Response.Redirect("~/MANTENARCE.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }
        }
        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;

                string COMANDO = string.Format("EXEC VER_SERVICE_SITE'%" + TXTUSUARIO.Text + "%'");
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
                LBLESTADO.Text = error.Message;

            }
        }

        protected void txtremainder_TextChanged(object sender, EventArgs e)
        {
            //DateTime fechainicio = Convert.ToDateTime(TXTDATE.Text);
            //int dia = Convert.ToInt32(txtremainder.Text);
            //fechainicio = fechainicio.AddDays(dia);
            //LBLESTADO.Text = fechainicio.ToString();
        }
        protected void CBINNERAIRFILTERREPLACE0_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        protected void CBINNERAIRFILTERREPLACE0_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT  DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date,replace(convert(Varchar ,case when(DATEDIFF(DAY, getdate(), DATE_FINICH)< 1 )then 0 else DATEDIFF(DAY, getdate(), DATE_FINICH)  end),'0','Done')  AS [Next Service],  edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]FROM            edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET  WHERE  technical." + CBINNERAIRFILTERREPLACE1.Text + " = '" + CBINNERAIRFILTERREPLACE0.Text + "'  order by technical.ID desc");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            catch (Exception mm)
            {
                LBLESTADO.Text = mm.Message;

            }
        }
        protected void BTNBUSCAR0_Click(object sender, EventArgs e)
        {


            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("exec filtre_services '" + txtdesde.Text + "','" + txthasta.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            catch (Exception mm)
            {
                LBLESTADO.Text = mm.Message;

            }




        }
        protected void CBGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT gensetserial FROM gensetfinal WHERE  gensetfinal.SITE  = '" + CBSITE.Text + "'AND  gensetfinal.GENSET_MODEL='" + CBGENSET.Text + "'    ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                string serial = DS.Tables[0].Rows[0]["gensetserial"].ToString();
                SER = serial;


                string COMANDO23 = string.Format("SELECT DISTINCT edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date,replace(convert(Varchar ,case when(DATEDIFF(DAY, getdate(), DATE_FINICH)< 1 )then 0 else DATEDIFF(DAY, getdate(), DATE_FINICH)  end),'0','Done')  AS[Next Service],                         edgar2211.technical.VERIFICATION AS[Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team,                         edgar2211.technical.HOUR_MASTER_READING AS[Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS[Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS[Oil Engine Replace],                         edgar2211.technical.OIL_QTY_REMOVED AS[Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS[Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS[Oil Different],                         edgar2211.technical.OIL_FILTER_REPLACE AS[Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS[Tank Decarter Filter Replace],                         edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS[Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS[Fuel Filter Replace],                         edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS[Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS[Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,                         CASE WHEN(DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN 'YES' ELSE 'NO' END AS Attachment, edgar2211.technical.USER_LOG AS[User Login] FROM            edgar2211.technical LEFT OUTER JOIN                         edgar2211.gensetfinal ON edgar2211.technical.GENSET = edgar2211.gensetfinal.GENSET_MODEL LEFT OUTER JOIN                         edgar2211.DOCUMENT_SHOP ON edgar2211.technical.GENSET = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET   WHERE    edgar2211.gensetfinal.gensetserial='" + serial.ToString() + "'  order by technical.ID desc ");
                DataSet DS23 = CLASS_CONECTAR.CONECTAR(COMANDO23);

                GridView1.DataSource = DS23.Tables[0];
                GridView1.DataBind();




            }
            catch (Exception eror)
            {
                LBLESTADO.Text = eror.Message;

            }
        }



        void NEW_GENSET()
        {

            try
            {
                int valor_reading = 0;

                string coman = string.Format("select * from technical where SITE ='" + CBSITE.Text + "' and GENSET='" + CBGENSET.Text + "' order by QIL_RUMMING_HR desc");
                DataSet ds2 = CLASS_CONECTAR.CONECTAR(coman);
                if (ds2.Tables[0].Rows.Count <= 0)
                {
                    valor_reading = 0;
                }
                else
                {
                    valor_reading = Convert.ToInt32(ds2.Tables[0].Rows[0]["HOUR_MASTER_READING"]);
                }

                int valor_new = Convert.ToInt32(TXTORDMASATER.Text);
                if (valor_reading > valor_new)
                {
                    Response.Write("<script>alert('The hours that this introducing is less than the last hours of work of this generated');</script>");
                }
                else
                {

                    DateTime fechainicio = Convert.ToDateTime(TXTDATE.Text);
                    int dia = Convert.ToInt32(txtremainder.Text);
                    fechainicio = fechainicio.AddDays(dia);
                    LBLESTADO.Text = fechainicio.ToString("yyyy-MM-dd");
                    string COMANDO = string.Format("exec TEACHY'" + TXTDATE.Text + "','" + CBSITE.Text + "','" + CBGENSET.Text + "','" + CBTEAM.Text + "','" + TXTRUNING.Text + "','" + TXTORDMASATER.Text + "','" + CBENGIERREPLACE.Text + "','" + TXTQTYREMOVEDOIL.Text + "','" + TXTGL.Text + "','" + YXYDIFERENT.Text + "','" + CBFILTERREPLACE.Text + "','" + CBDECANTERFILTER.Text + "','" + CBRPRE_FILTERREPLACE.Text + "','" + CBFUELFILTERREPLACE.Text + "','" + CBINNERAIRFILTERREPLACE.Text + "','" + CBAIRFILTEROUTERCHANGE.Text + "','" + TXTVERIFICATION.Text + "','" + TXTNOTAS.Text + "','" + LBLESTADO.Text + "','" + GetTime() + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    ver_NEW_site_1();
                    Response.Redirect("~/MANTENARCE.aspx");
                }

            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }
        public static string nombre;
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
                    string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + id + "','" + GridView1.SelectedRow.Cells[8].Text + "','" + "http://canezpowerdivision.com/USUARIO2/canezpdf/" + nombre + "',GETDATE(),'" + GetTime() + "','" + "service" + "')");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                }
                Response.Redirect("~/USUARIO2/MANTENARCE.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }



        }


        public static string IDGENSET, GENSET = "";
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[8].Text;



                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "service");


                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;

                }

            }
        }
    }
}