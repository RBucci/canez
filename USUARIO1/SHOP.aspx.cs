using System;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO1
{
    public partial class SHOP : System.Web.UI.Page
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
            Button4.Enabled = false;
            Button5.Enabled = false;

           
            if (!IsPostBack)
            {
                mostral();
                string COMANDO = string.Format("SELECT GENSET_MODEL  from  gensetfinal where  SITE = '" + "SHOP-D2" + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                TXTGENSETSERIAL.DataSource = DS.Tables[0];
                
                TXTGENSETSERIAL.DataTextField = "GENSET_MODEL";
                TXTGENSETSERIAL.DataBind();
                DATOS();
            }
            DATOS();
            // TXTREFENCE1.Attributes.Add("onkeypress", "cambiaFoco('TXTSearch_Click')");
            Panel1.DefaultButton = TXTSearch.ID;
        }

        void LIMPIAR()
        {
            TXTDATE.Text = "";
            TXTREFENCE.Text = "";
            TXTREFENCE0.Text = "";
            TXTREFENCE1.Text = "";
        }
        public static string  nombre;
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
               

                //if (File.Exists(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName))
                //{
                //    LBLESTADO.Text = "There is a file with this name, change the name to be able to upload it to server";
                //}
                //else
                //{

                //    if (checkemail.Checked == true)
                //    {
                //        correos();
                //    }

                //    FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                //    LBLESTADO.Text = "se realizo correctamente";
                //    nombre = "http://canezpowerdivision.com/canezpdf/" + FileUpload1.FileName;


                    string CADENA = string.Format("exec new_shop'" + TXTDATE.Text + "','" + TXTREFENCE.Text + "','" + TXTREFENCE0.Text + "','" + TXTESTATUS.Text + "','" + TXTDESCRIPTION.Text + "','" + "" + "','" + GetTime() + "'");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(CADENA);

                    mostral();
                    LIMPIAR();
                    Response.Redirect("~/SHOP.aspx");

                //}



              
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;
            }
        }

        void elimian()
        {
            if (System.IO.File.Exists(file1))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    System.IO.File.Delete(file1);
                }
                catch (System.IO.IOException e)
                {
                    LBLESTADO.Text = e.Message;
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
                message.To.Add("team@canezgeneration.com");
                message.Subject = "NEW TEAM";
                message.IsBodyHtml = true;
                //message.Body = TXTNOTA.Text;
                string mensaje = " Hello   TEAM,\n" +
                       "<br/>" +
                        GetTime() + " Want you to check the following information<br/>  " +
                        "<br/>" +
                        "Shop :" +
                        "<br/>" +

                        "<table border=1    margin: 15px;  padding: 15px; >" +
                        "<tr>" +
                        "<td class=auto - style4>Date:</td>" +
                        " <td class=auto - style2>" + TXTDATE.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td class=auto - style4>Refference:</td>" +
                        "<td class=auto - style2>" + TXTREFENCE.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        "<td class=auto - style6>Status:</td>" +
                        " <td class=auto - style7>" + TXTESTATUS.Text + "</td>" +
                        " </tr>" +
                        " <tr>" +
                        " <td class=auto - style8>Genset:</td>" +
                        " <td class=auto - style9>" + TXTGENSETSERIAL.Text + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "  <td class=auto - style5>Genset Serial:</td>" +
                        "  <td class=auto - style3>" + TXTREFENCE0.Text + "</td>" +
                        " </tr>" +
                         "<tr>" +
                        "  <td class=auto - style5>Description:</td>" +
                        "  <td class=auto - style3>" + TXTREFENCE1.Text + "</td>" +
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




        void mostral()
        {

            try
            {
                //string comando = string.Format("SELECT Shop.Id AS [System ID],Shop.Date,Shop.Refference, edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#],Shop.Status1 AS [Status],Shop.Description,Shop.File1,Shop.User_Login AS [User]FROM  edgar2211.gensetfinal INNER JOIN                         edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial  ORDER BY Shop.Id DESC");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();


            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }


        }

        public static string id = "";
        public static string file1;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                string VALOR = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM Shop  WHERE ID='" + VALOR + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);

                id = GridView1.SelectedRow.Cells[2].Text;
                TXTREFENCE.Text = DS.Tables[0].Rows[0]["Refference"].ToString();
                DateTime FECHA = Convert.ToDateTime(DS.Tables[0].Rows[0]["Date"].ToString());
                TXTDATE.Text = FECHA.ToString("yyyy-MM-dd");
                TXTESTATUS.Text = DS.Tables[0].Rows[0]["Status1"].ToString();
                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["Description"].ToString();
                TXTREFENCE0.Text = DS.Tables[0].Rows[0]["Genset_Serial"].ToString();

               
                Button4.Enabled = true;
                Button5.Enabled = true;
                save.Enabled = false;

            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {



            try
            {


                //if (FileUpload1.FileName == "")
                //{
                //    if (checkemail.Checked == true)
                //    {
                //        correos();
                //    }


                //    string CADENA = string.Format("exec edit_shop'" + id + "','" + TXTDATE.Text + "','" + TXTREFENCE.Text + "','" + TXTREFENCE0.Text + "','" + TXTESTATUS.Text + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                //    DataSet ds = CLASS_CONECTAR.CONECTAR(CADENA);
                //    Button4.Enabled = false;
                //    Button5.Enabled = false;
                //    save.Enabled = true;
                //    LIMPIAR();

                //    mostral();
                //    Response.Redirect("~/SHOP.aspx");
                //}
                //else
                //{

                    //if (File.Exists(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName))
                    //{
                    //    LBLESTADO.Text = "There is a file with this name, change the name to be able to upload it to server";
                    //}
                    //else
                    //{

                        if (checkemail.Checked == true)
                        {
                            correos();
                        }

                        //FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                        //LBLESTADO.Text = "se realizo correctamente";
                        //nombre = "http://canezpowerdivision.com/canezpdf/" + FileUpload1.FileName;

                        string CADENA = string.Format("exec edit_shopnotnull'" + id + "','" + TXTDATE.Text + "','" + TXTREFENCE.Text + "','" + TXTREFENCE0.Text + "','" + TXTESTATUS.Text + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "','" + "" + "'");
                        DataSet ds = CLASS_CONECTAR.CONECTAR(CADENA);
                        Button4.Enabled = false;
                        Button5.Enabled = false;
                        save.Enabled = true;
                        LIMPIAR();

                        mostral();
                        Response.Redirect("~/SHOP.aspx");
                        LBLESTADO.Text = "se realizo correctamente";
                 
                //}


            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;
            }








        }

        protected void Button5_Click(object sender, EventArgs e)
        {


            try
            {
                if (checkemail.Checked == true)
                {
                    correos();
                }

                string CADENA = string.Format("DELETE FROM Shop WHERE Id='" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                Button4.Enabled = false;
                Button5.Enabled = false;
                save.Enabled = true;
                mostral();
                LIMPIAR();
                Response.Redirect("~/SHOP.aspx");
            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }


        }

        protected void TXTGENSETSERIAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
               
            }
                string COMANDO = string.Format("SELECT *  from gensetfinal where GENSET_MODEL='"+TXTGENSETSERIAL.Text+"' AND SITE = '" + "SHOP-D2" + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                TXTGENSETSERIAL.DataSource = DS.Tables[0];
              TXTREFENCE0.Text = DS.Tables[0].Rows[0]["GENSETSERIAL"].ToString();
               
           
        }

        protected void TXTSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string comando = string.Format("SELECT DISTINCT edgar2211.Shop.id AS [System ID], edgar2211.Shop.Date, edgar2211.Shop.Refference, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.Shop.Genset_Serial AS [Genset Serial#], edgar2211.Shop.Status1 AS Status, CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'shop') THEN '1' ELSE '0' END AS Attachment, edgar2211.Shop.Description, edgar2211.Shop.User_Login AS [User] FROM            edgar2211.gensetfinal INNER JOIN   edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id   WHERE gensetfinal.SITE LIKE '%" + TXTREFENCE1.Text + "%' ORDER BY Shop.Id DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(comando);

                if (DS.Tables[0].Rows.Count<=0)
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

        protected void TXTSearch0_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;


                if (TXTREFENCE1.Text == "")
                {
                    string comando = string.Format("SELECT DISTINCT edgar2211.Shop.id AS [System ID], edgar2211.Shop.Date, edgar2211.Shop.Refference, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.Shop.Genset_Serial AS [Genset Serial#], edgar2211.Shop.Status1 AS Status, CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'shop') THEN '1' ELSE '0' END AS Attachment, edgar2211.Shop.Description, edgar2211.Shop.User_Login AS [User] FROM            edgar2211.gensetfinal INNER JOIN   edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id   WHERE (Shop.Date >= '" + TXTDESDE.Text + "') and (Shop.Date <= '" + TXTHASTA.Text + "')   ORDER BY Shop.Id DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }
                else
                {
                    string comando = string.Format("SELECT DISTINCT edgar2211.Shop.id AS [System ID], edgar2211.Shop.Date, edgar2211.Shop.Refference, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.Shop.Genset_Serial AS [Genset Serial#], edgar2211.Shop.Status1 AS Status, CASE WHEN (DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'shop') THEN '1' ELSE '0' END AS Attachment, edgar2211.Shop.Description, edgar2211.Shop.User_Login AS [User] FROM            edgar2211.gensetfinal INNER JOIN   edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id   WHERE   gensetfinal.SITE LIKE '%" + TXTREFENCE1.Text + "%'   and  (Shop.Date >= '" + TXTDESDE.Text + "') and (Shop.Date <= '" + TXTHASTA.Text + "')  ORDER BY Shop.Id DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }

               


            }
            catch (Exception )
            {

                
            }
        }


        void DATOS()
        {

            try
            {
                //string ID1 = GridView1.SelectedRow.Cells[2].Text;
                //string GENSET = GridView1.SelectedRow.Cells[5].Text;
                //string COMANDO = string.Format("SELECT * FROM DOCUMENT_SHOP WHERE ID_GENSET LIKE'%" + ID1 + "%' AND GENSET LIKE '%" + GENSET + "%'");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //if (DS.Tables[0].Rows.Count > 0)
                //{
                //    LBLCANTI.Text = "FALSE";
                //}
                //else
                //{
                //    LBLCANTI.Text = "TRUE";
                //}
                
            }
            catch (Exception)
            {
                
               
            }

        }


        void mm()
        {
            try
            {

                string VALOR = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM Shop  WHERE ID='" + VALOR + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);

                id = GridView1.SelectedRow.Cells[2].Text;
               

            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }
        }
        public static string IDGENSET, GENSET = "";
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="btver")
            {

                try
                {
                      int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[5].Text;


                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString()+"&page="+"shop");
                  
                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;
                   
                }
                
            }

            //if (e.CommandName == "btSUBIR")
            //{


            //}

            if (e.CommandName == "btcanti")
            {

                Label txtName = (Label)GridView1.FooterRow.FindControl("btncanti");
                int valor = Convert.ToInt32(e.CommandArgument);
                //string ID1 = GridView1.SelectedRow.Cells[2].Text;
                //string GENSET = GridView1.SelectedRow.Cells[5].Text;

                string COMANDO = string.Format("SELECT * FROM DOCUMENT_SHOP WHERE ID_GENSET LIKE'%" + GridView1.Rows[valor].Cells[2].Text + "%' AND GENSET LIKE '%" + GridView1.Rows[valor].Cells[5].Text + "%'");
                System.Data.DataSet DS = CanezPower.CLASS_CONECTAR.CONECTAR(COMANDO);

                txtName.Text = DS.Tables[0].Rows.Count.ToString();
               

            }


        }



      


        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //try
            //{

            FileUpload fileUpload = GridView1.Rows[e.RowIndex].FindControl("FileUpload01") as FileUpload;

            if (fileUpload.HasFile)
            {
                fileUpload.SaveAs(Server.MapPath(".") + "/canezpdf/" + fileUpload.FileName);

                LBLESTADO.Text = "se realizo correctamente";
                nombre = "http://canezpowerdivision.com/canezpdf/" + fileUpload.FileName;

                string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + GridView1.SelectedRow.Cells[5].Text + "','" + nombre + "',GETDATE(),'" + GetTime() + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
            }

            //}
            //catch (Exception ERROR)
            //{
            //    LBLESTADO.Text = ERROR.Message;

            //}
        }

        protected void save0_Click(object sender, EventArgs e)
        {
            try
            {

          
            if (File.Exists(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName))
            {
                LBLESTADO.Text = "There is a file with this name, change the name to be able to upload it to server";
            }
            else
            {               
                FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                LBLESTADO.Text = "se realizo correctamente";
                nombre = "http://canezpowerdivision.com/canezpdf/" + FileUpload1.FileName;
                string CADENA = string.Format("insert into DOCUMENT_SHOP values('"+id+"','" + GridView1.SelectedRow.Cells[5].Text + "','" + nombre + "',GETDATE(),'" + GetTime() + "','"+"shop"+"')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    Response.Redirect("~/SHOP.aspx");
                    DATOS();
            }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }
    }
}