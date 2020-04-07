using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class CM : System.Web.UI.Page
    {

        //public new System.Security.Principal.IPrincipal User

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
                mostrar();
            }
            //VERCM();

            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            Panel1.DefaultButton = BTNBUSCAR.ID;
        }

        void LIMPIAR()
        {
            TXTFILTER.Text = "";
            TXTQTY.Text = "";
            TXTHOURS.Text = "";
            TXTGOURSUSE.Text = "";
            TXTNOTAS.Text = "";

            mostrar();
        }

        void mostrar() {
            try
            {

                if (!Page.IsPostBack)
                {

                    string COMANDO = string.Format("SELECT DISTINCT edgar2211.site.site FROM edgar2211.site INNER JOIN edgar2211.gensetfinal ON edgar2211.site.site = edgar2211.gensetfinal.SITE");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    DROPSITE.DataSource = DS.Tables[0];
                    DROPSITE.DataTextField = "site";
                    DROPSITE.DataBind();
                }

            }
            catch (Exception)
            {
                
                
            }
        
        }

        protected void DROPSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + DROPSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                DROPGENSET.DataSource = DS12.Tables[0];
                DROPGENSET.DataTextField = "GENSET_MODEL";
                DROPGENSET.DataValueField = "GENSET_MODEL";
                DROPGENSET.DataBind();
                DROPGENSET.Items.Insert(0, new ListItem("MAIN LINE"));
            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }
           
        }



        protected void BTNSAVE_Click(object sender, EventArgs e)
        {


            if (checkemail.Checked == true)
            {
                correos();
            }

            NEWCM();
            LIMPIAR();
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
                        "FF-CM:" +
                        "<br/>" +

                        "<table border=1    margin: 15px;  padding: 15px; >" +
                        "<tr>" +
                        "<td class=auto - style4>Site:</td>" +
                        " <td class=auto - style2>" + DROPSITE.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Genset:</td>" +
                        "<td class=auto - style2>" + DROPGENSET.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        "<td class=auto - style6>Filter:</td>" +
                        " <td class=auto - style7>" + TXTFILTER.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        " <td class=auto - style8>Qty:</td>" +
                        " <td class=auto - style9>" + TXTQTY.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "  <td class=auto - style5>Running Hours:</td>" +
                        "  <td class=auto - style3>" + TXTHOURS.Text  + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Hours Use:</td>" +
                        "  <td class=auto - style3>" + TXTGOURSUSE.Text + "</td>" +
                        " </tr>" +
                          "<tr>" +
                        "  <td class=auto - style5>Note:</td>" +
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




        void NEWCM()
        {
            try
            {
                string COMANDO = string.Format("exec NEW_CM'" + DROPSITE.Text + "','" + DROPGENSET.Text + "','" + TXTFILTER.Text + "','" + TXTQTY.Text + "','" + TXTHOURS.Text + "','" + TXTGOURSUSE.Text + "','" + TXTNOTAS.Text + "','" +  GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                VERCM();
                //ver_NEW_site_1();
                Response.Redirect("~/CM.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }




        void ACTUCM()
        {
            try
            {
                string COMANDO = string.Format("exec ACTU_CM'" + DROPSITE.Text + "','" + DROPGENSET.Text + "','" + TXTFILTER.Text + "','" + TXTQTY.Text + "','" + TXTHOURS.Text + "','" + TXTGOURSUSE.Text + "','" + TXTNOTAS.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                VERCM();
                //ver_NEW_site_1();
                Response.Redirect("~/CM.aspx");
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }



        void VERCM()
        {
            try
            {
                
                    //string COMANDO = string.Format("SELECT        ID, DATE1 AS DATE, SITE, GENSET, FILTER, QTY, RUNNING_HOURS AS [RUNNING HOURS], HOURS_USE AS [HOURS USE], NOTE, USER1 FROM            edgar2211.CM order by ID desc");
                    //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    //GridView1.DataSource = DS.Tables[0];
                    //GridView1.DataBind();





            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;

            }
        }

        protected void BTNEDIT_Click(object sender, EventArgs e)
        {

            if (checkemail.Checked == true)
            {
                correos();
            }


            ACTUCM();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            BTNSAVE.Enabled = true;
            LIMPIAR();
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {


                if (checkemail.Checked == true)
                {
                    correos();
                }

                string CADENA = string.Format("DELETE  FROM CM WHERE ID='" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                VERCM();
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                BTNSAVE.Enabled = true;
                LIMPIAR();
                Response.Redirect("~/CM.aspx");

            }
            catch (Exception)
            {
                
                
            }
        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {

        }
        
        public static string USERT, id = "";
       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM CM WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                id = DS.Tables[0].Rows[0]["ID"].ToString();
                DROPSITE.Text = DS.Tables[0].Rows[0]["SITE"].ToString();
                DROPSITE_SelectedIndexChanged(null, null);
                DROPGENSET.Text = DS.Tables[0].Rows[0]["GENSET"].ToString();

                TXTFILTER.Text = DS.Tables[0].Rows[0]["FILTER"].ToString();

                TXTQTY.Text = DS.Tables[0].Rows[0]["QTY"].ToString();
                TXTHOURS.Text = DS.Tables[0].Rows[0]["RUNNING_HOURS"].ToString();
                TXTGOURSUSE.Text = DS.Tables[0].Rows[0]["HOURS_USE"].ToString();
                TXTNOTAS.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();


                USERT = DS.Tables[0].Rows[0]["USER1"].ToString();

                //DateTime fecha = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE_STATING"].ToString());
                //TXTSTARTING.Text = fecha.ToString("yyyy-MM-dd");


                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;
                BTNSAVE.Enabled = false;


            }
            catch (Exception )
            {



            }
        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMANDO = string.Format("SELECT DISTINCT       cm.ID, cm.DATE1 AS DATE, SITE, cm.GENSET, FILTER, QTY, RUNNING_HOURS AS [RUNNING HOURS], HOURS_USE AS [HOURS USE], NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN 'YES' ELSE 'NO' END AS Attachment,cm. USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset WHERE cm." + DropDownList1.Text + " LIKE '%" + TXTUSUARIO.Text + "%'  order by cm.ID desc");
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
        public static string use = "";
        protected void DROPGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("select * from CM where SITE='" +  DROPSITE.SelectedValue + "' and GENSET='" + DROPGENSET.SelectedValue + "' order by ID desc");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);


                if (DS12.Tables[0].Rows.Count > 0)
                {
                    use = DS12.Tables[0].Rows[0]["RUNNING_HOURS"].ToString();
                }
                else
                {
                    use = "0";
                }


            }
            catch (Exception)
            {


            }

        }

        protected void TXTHOURS_TextChanged(object sender, EventArgs e)
        {





            try
            {
                string COMANDO12 = string.Format("select * from CM where SITE='" + DROPSITE.SelectedValue + "' and GENSET='" + DROPGENSET.SelectedValue + "' order by ID desc");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);


                if (DS12.Tables[0].Rows.Count > 0)
                {
                    use = DS12.Tables[0].Rows[0]["RUNNING_HOURS"].ToString();
                }
                else
                {
                    use = "0";
                }


            }
            catch (Exception)
            {


            }













            try
            {
                int runnign = Convert.ToInt32(TXTHOURS.Text);
                int use1 = Convert.ToInt32(use);
                if (use1 == 0)
                {
                    TXTGOURSUSE.Text = "0";

                }
                else
                {

                    int usefinal = runnign - use1;
                    TXTGOURSUSE.Text = usefinal.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        protected void BTNBUSCAR0_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;



                if (TXTUSUARIO.Text=="")
                {

                    string COMANDO = string.Format(" SELECT   DISTINCT     cm.ID, cm.DATE1 AS DATE, SITE, cm.GENSET, FILTER, QTY, RUNNING_HOURS AS [RUNNING HOURS], HOURS_USE AS [HOURS USE], NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN 'YES' ELSE 'NO' END AS Attachment,cm. USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset WHERE (cm.DATE1 >='" + TXTDESDE.Text + "') and (cm.DATE1 <= '" + TXTHASTA.Text + "')   order by cm.ID desc");
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
                    string COMANDO = string.Format(" SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN 'YES' ELSE 'NO' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.GENSET = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset WHERE   cm." + DropDownList1.Text + " LIKE '%" + TXTUSUARIO.Text + "%'  and (cm.DATE1 >='" + TXTDESDE.Text + "') and (cm.DATE1 <= '" + TXTHASTA.Text + "')   order by cm.ID desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }

            }
            catch (Exception error)
            {
                Response.Write("<script>alert('"+error.Message+"');</script>");

            }
        }
        public static string nombre, ruta1;
        protected void save0_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < Context.Request.Files.Count; i++)
                {
                    //FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                    HttpPostedFile file  = Context.Request.Files[i];

                    nombre = String.Format("{0}_{1:yyyyMMdd_hhmm}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                     //ruta1 = Server.MapPath("canezpdf");
                     file.SaveAs(Server.MapPath(".") + "/canezpdf/" + nombre);
                    //string rutacompleta = Path.Combine(ruta1, nombre);
                     string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + id + "','" + GridView1.SelectedRow.Cells[5].Text + "','" + "http://canezpowerdivision.com/canezpdf/" + nombre + "',GETDATE(),'" + GetTime() + "','" + "FFCM" + "')");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                }
                
                       
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    Response.Redirect("~/CM.aspx");
                    //DATOS();
                
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
                    GENSET = GridView1.Rows[valor].Cells[5].Text;

                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "FFCM");

                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;

                }

            }
        }

    }
}