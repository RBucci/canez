using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.ValerioCanez
{
    public partial class NewValerioCanez : System.Web.UI.Page
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




        public string SERIAL = "";

        public string model = "";
        public string site = "";
        public int palo = 1;
        public static string SIT, GEN, GENSERIAL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    //ver_NEW_site_();
                    //SERIAL = (string)(Session["LK"]);
                    SERIAL = Request.QueryString.Get("MyVar");
                    LBLESTADO.Text = SERIAL;
                    //SERIAL = Request.QueryString.Get("id");
                    //LBLESTADO.Text = (string)(Session["LK"]); ;

                    //LBLESTADO.Text = SERIAL.ToString();
                }
                catch (Exception error)
                {
                    LBLESTADO.Text = error.Message;

                }
                  
                if (string.IsNullOrEmpty(SERIAL))
            {
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;

            }
            else
            {
                try
                {



                    BTNGUARDAR.Enabled = false;
                    BTNDELETE.Enabled = true;
                    BTNEDIT.Enabled = true;
                    string comando = string.Format("SELECT * FROM Genset_Venta WHERE genset_serial='" + Request.QueryString.Get("MyVar") + "'");
                    DataSet DS =  CLASS_CONECTAR.CONECTAR(comando);

                    //if (DS.Tables[0].Rows.Count > 0)
                    //{
                    txtuser.Text = DS.Tables[0].Rows[0]["user1"].ToString();
                    txtaddessuser.Text = DS.Tables[0].Rows[0]["addressuser"].ToString();
                    txtgeneration.Text = DS.Tables[0].Rows[0]["genset"].ToString();
                    txtgensetserial.Text = DS.Tables[0].Rows[0]["genset_serial"].ToString();
                    GENSERIAL = DS.Tables[0].Rows[0]["genset_serial"].ToString();

                    txtengine.Text = DS.Tables[0].Rows[0]["engine"].ToString();
                    txtengineserial.Text = DS.Tables[0].Rows[0]["engine_serial"].ToString();
                    txtaltenado.Text = DS.Tables[0].Rows[0]["altenator"].ToString();
                    txtserialaltenador.Text = DS.Tables[0].Rows[0]["altenator_serial"].ToString();
                    txtsoiddealer.Text = DS.Tables[0].Rows[0]["soid"].ToString();
                    txtserialdealer.Text = DS.Tables[0].Rows[0]["soid_serial"].ToString();
                    cbpanelcontrol.Text = DS.Tables[0].Rows[0]["contro_panel"].ToString();
                    cbenclosure.Text = DS.Tables[0].Rows[0]["enclosure"].ToString();
                    cbapplication.Text = DS.Tables[0].Rows[0]["application1"].ToString();
                    cbfrequecy.Text = DS.Tables[0].Rows[0]["frequency"].ToString();
                    cbconection.Text = DS.Tables[0].Rows[0]["connection"].ToString();
                    cbvoltage.Text = DS.Tables[0].Rows[0]["voltage"].ToString();
                    txtnote.Text = DS.Tables[0].Rows[0]["note"].ToString();
                    DateTime fechadelivery = Convert.ToDateTime(DS.Tables[0].Rows[0]["Date_Delivery"].ToString());
                    cbdelivery.Text = fechadelivery.ToString("yyyy-MM-dd");
                    DateTime fechacusu = Convert.ToDateTime(DS.Tables[0].Rows[0]["Date_Commssioning"].ToString());
                    txtdatecommissioning.Text = fechacusu.ToString("yyyy-MM-dd");











                }
                catch (Exception error)
                {



                    LBLESTADO.Text = error.Message;


                }

            }
           
            
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
                message.To.Add("vcservice@canezgeneration.com");
               // message.To.Add("josedo2218@gmail.com");
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
                        "<td class=auto - style4>SDMO Distributor/Dealer:</td>" +
                        " <td class=auto - style2>" + txtdealer.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Address</td>" +
                        "<td class=auto - style2>" + txtaddressdealer.Text + "</td>" +
                        " </tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Job Order:</td>" +
                        " <td class=auto - style2>" + txtuser.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>End User</td>" +
                        "<td class=auto - style2>" + txtaddessuser.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        "<td class=auto - style6>Genset:</td>" +
                        " <td class=auto - style7>" + txtgeneration.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        " <td class=auto - style8>Genset Serial:</td>" +
                        " <td class=auto - style9>" + txtgensetserial.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "  <td class=auto - style5>Engine:</td>" +
                        "  <td class=auto - style3>" + txtengine.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Engine Serial:</td>" +
                        "  <td class=auto - style3>" + txtengineserial.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Altenator:</td>" +
                        "  <td class=auto - style3>" + txtserialaltenador.Text + "</td>" +
                        " </tr>" +
                        // "<tr>" +
                        //"  <td class=auto - style5>ATS (if sold by SDMO)::</td>" +
                        //"  <td class=auto - style3>" + txtsoiddealer.Text + "</td>" +
                        //" </tr>" +
                        // "<tr>" +
                        //"  <td class=auto - style5>ATS (if sold by SDMO) serial:</td>" +
                        //"  <td class=auto - style3>" + txtserialdealer.Text + "</td>" +
                        //" </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Control Panel:</td>" +
                        "  <td class=auto - style3>" + cbpanelcontrol.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Enclosure:</td>" +
                        "  <td class=auto - style3>" + cbenclosure.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Application:</td>" +
                        "  <td class=auto - style3>" + cbapplication.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Frequency:</td>" +
                        "  <td class=auto - style3>" + cbfrequecy.Text+ "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Connetion:</td>" +
                        "  <td class=auto - style3>" + cbconection.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Voltage:</td>" +
                        "  <td class=auto - style3>" + cbvoltage.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Date Delivery:</td>" +
                        "  <td class=auto - style3>" + cbdelivery.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Date of Commissioning:</td>" +
                        "  <td class=auto - style3>" + txtdatecommissioning.Text + "</td>" +
                        " </tr>" +

                          "<tr>" +
                        "  <td class=auto - style5>Note:</td>" +
                        "  <td class=auto - style3>" + txtnote.Text + "</td>" +
                        " </tr>" +
                       
                       

                        " </table>" +

                        "<br/>   This email been generate automatically by VC DataBase." +
                        "<br/>" +

                        "<br/>  Please DO NOT Replay this email.  \n" +
                        "<br/>" +
                        "<br/>Best Regards," +
                         "<br/>" +
                        "<br/>   \n VALERIO CANEZ S.A \n" +
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

        protected void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            NEW_GENSET();
            if (checkemail.Checked)
            {
                correos();
            }
        }
        void NEW_GENSET()
        {
            try
            {

                string VALIDADR = string.Format("SELECT * FROM Genset_Venta WHERE genset_serial ='" + txtgensetserial.Text + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(VALIDADR);
                if (DS12.Tables[0].Rows.Count > 0)
                {
                    LBLESTADO.Text = "A generator with this serial number already exists";
                }
                else
                {
                    SERIAL = "";


                    string COMANDO = string.Format("EXEC  NewGenset_Venta'" + txtdealer.Text + "','" + txtaddressdealer.Text + "','" + txtuser.Text + "','" + txtaddessuser.Text + "','" + txtgeneration.Text + "','" + txtgensetserial.Text + "','" + txtengine.Text + "','" + txtengineserial.Text + "','" + txtaltenado.Text + "','" + txtserialaltenador.Text + "','" + txtsoiddealer.Text + "','" + txtserialdealer.Text + "','" + cbpanelcontrol.Text + "','" + cbenclosure.Text + "','" + cbapplication.Text + "','" + cbfrequecy.Text + "','" + cbconection.Text + "','" + cbvoltage.Text + "','" + Convert.ToDateTime(cbdelivery.Text).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(txtdatecommissioning.Text).ToString("yyyy-MM-dd") + "','" + GetTime() + "','"+txtnote.Text+"'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "It was done correctly";
                    Response.Redirect("~/ValerioCanez/ValerioCanezGenset.aspx");
                }




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
                if (checkemail.Checked)
                {
                    correos();
                }


                if (txtgensetserial.Text == GENSERIAL)
                {

                    string id = Request.QueryString.Get("MyVar");
                    string COMANDO = string.Format("EXEC  UpdateGenset_Venta  '"+id.ToString()+"','" + txtdealer.Text + "','" + txtaddressdealer.Text + "','" + txtuser.Text + "','" + txtaddessuser.Text + "','" + txtgeneration.Text + "','" + txtgensetserial.Text + "','" + txtengine.Text + "','" + txtengineserial.Text + "','" + txtaltenado.Text + "','" + txtserialaltenador.Text + "','" + txtsoiddealer.Text + "','" + txtserialdealer.Text + "','" + cbpanelcontrol.Text + "','" + cbenclosure.Text + "','" + cbapplication.Text + "','" + cbfrequecy.Text + "','" + cbconection.Text + "','" + cbvoltage.Text + "','" + Convert.ToDateTime(cbdelivery.Text).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(txtdatecommissioning.Text).ToString("yyyy-MM-dd") + "','" + GetTime() + "','"+txtnote.Text+"'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "It was done correctly";
                    Response.Redirect("~/ValerioCanez/ValerioCanezGenset.aspx");

                }
                else
                {
                    string VALIDADR = string.Format("SELECT * FROM Genset_Venta WHERE genset_serial ='" + txtgensetserial.Text + "'");
                    DataSet DS12 = CLASS_CONECTAR.CONECTAR(VALIDADR);
                    if (DS12.Tables[0].Rows.Count > 0)
                    {
                        LBLESTADO.Text = "A generator with this serial number already exists";
                    }
                    else
                    {
                        SERIAL = "";
                        string id = Request.QueryString.Get("MyVar");

                        string COMANDO = string.Format("EXEC  UpdateGenset_Venta  '" + id.ToString() + "','" + txtdealer.Text + "','" + txtaddressdealer.Text + "','" + txtuser.Text + "','" + txtaddessuser.Text + "','" + txtgeneration.Text + "','" + txtgensetserial.Text + "','" + txtengine.Text + "','" + txtengineserial.Text + "','" + txtaltenado.Text + "','" + txtserialaltenador.Text + "','" + txtsoiddealer.Text + "','" + txtserialdealer.Text + "','" + cbpanelcontrol.Text + "','" + cbenclosure.Text + "','" + cbapplication.Text + "','" + cbfrequecy.Text + "','" + cbconection.Text + "','" + cbvoltage.Text + "','" + Convert.ToDateTime(cbdelivery.Text).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(txtdatecommissioning.Text).ToString("yyyy-MM-dd") + "','" + GetTime() + "','"+txtnote.Text+"'");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                        LBLESTADO.Text = "It was done correctly";
                        Response.Redirect("~/ValerioCanez/ValerioCanezGenset.aspx");
                    }
                }

              

            }
            catch (Exception)
            {
                
                
            }
        }
        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("DELETE FROM Genset_Venta WHERE genset_serial='" + txtgensetserial.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                SERIAL = "";
                Response.Redirect("~/ValerioCanez/ValerioCanezGenset.aspx");
            }
            catch (Exception)
            {

            }
        }
}
}