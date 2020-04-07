using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO1
{
    public partial class WAMDY : System.Web.UI.Page
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
            GridView1.DataSourceID = null;
            //TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");
            Panel1.DefaultButton = BTNBUSCAR.ID;
            if (!Page.IsPostBack)
            {

                MOSTRAR();

            }
            VEVR_TOTAL();
            BTNSAVE.Enabled = true;
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
           
        }

        void MOSTRAR()
        {

            try
            {

                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.WANDY.ID,edgar2211.WANDY.DATEIN AS [DATE IN], edgar2211.WANDY.SITE AS CLIENT, edgar2211.WANDY.MOTOR_REFF AS [MOTOR REFF], edgar2211.WANDY.CAPACITY,                          edgar2211.WANDY.MOTOR_SERIAL AS[MOTOR SERIAL #], edgar2211.WANDY.JOB_DESCRIPTION AS [JOB DESCRIPTION], edgar2211.WANDY.DATEOUT AS [DATE OUT], edgar2211.WANDY.INVOICE,                          '$' + edgar2211.WANDY.TOTAL + '.00' AS[WANDY TOTAL], edgar2211.WANDY.STATUS, edgar2211.WANDY.WARRANTY_TAG AS[WARRANTY TAG], edgar2211.WANDY.CPD_INV AS[CPD INV],                         '$' + edgar2211.WANDY.CPD_TOTAL + '.00' AS[CPD TOTAL], CASE WHEN((CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL))) <= 0 THEN 0 ELSE(CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL))                         END AS[CPD PROFIT], edgar2211.WANDY.CPD_INV_STATUS AS[CPD INV STATUS], edgar2211.WANDY.COMMENT, edgar2211.WANDY.USER1 AS[LOADED BY], CASE WHEN(DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'WANDY') THEN '1' ELSE '0' END AS Attachment FROM            edgar2211.WANDY LEFT OUTER JOIN                         edgar2211.DOCUMENT_SHOP ON edgar2211.WANDY.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET AND edgar2211.WANDY.SITE = edgar2211.DOCUMENT_SHOP.GENSET  ORDER BY WANDY.ID DESC");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception)
            {


            }


        }



        void VEVR_TOTAL() {

            try
            {
                string VALOR = string.Format("EXEC VER_TOTAL_WANDY");
                DataSet DS = CLASS_CONECTAR.CONECTAR(VALOR);
                LBLESTADO0.Text = DS.Tables[0].Rows[0]["PROFIT"].ToString();

            }
            catch (Exception)
            {
                
                
            }
        }




        void MOSTRAR_DOS()
        {

            try
            {

                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.WANDY.ID,edgar2211.WANDY.DATEIN AS [DATE IN], edgar2211.WANDY.SITE AS CLIENT, edgar2211.WANDY.MOTOR_REFF AS [MOTOR REFF], edgar2211.WANDY.CAPACITY,                          edgar2211.WANDY.MOTOR_SERIAL AS[MOTOR SERIAL #], edgar2211.WANDY.JOB_DESCRIPTION AS [JOB DESCRIPTION], edgar2211.WANDY.DATEOUT AS [DATE OUT], edgar2211.WANDY.INVOICE,                          '$' + edgar2211.WANDY.TOTAL + '.00' AS[WANDY TOTAL], edgar2211.WANDY.STATUS, edgar2211.WANDY.WARRANTY_TAG AS[WARRANTY TAG], edgar2211.WANDY.CPD_INV AS[CPD INV],                         '$' + edgar2211.WANDY.CPD_TOTAL + '.00' AS[CPD TOTAL], CASE WHEN((CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL))) <= 0 THEN 0 ELSE(CONVERT(INT, CPD_TOTAL) - CONVERT(INT, TOTAL))                         END AS[CPD PROFIT], edgar2211.WANDY.CPD_INV_STATUS AS[CPD INV STATUS], edgar2211.WANDY.COMMENT, edgar2211.WANDY.USER1 AS[LOADED BY], CASE WHEN(DOCUMENT_SHOP.id_genset <> '' AND DOCUMENT_SHOP.tipo = 'WANDY') THEN '1' ELSE '0' END AS Attachment FROM            edgar2211.WANDY LEFT OUTER JOIN                         edgar2211.DOCUMENT_SHOP ON edgar2211.WANDY.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET AND edgar2211.WANDY.SITE = edgar2211.DOCUMENT_SHOP.GENSET  WHERE WANDY." + DropDownList1.Text + " LIKE '%" + TXTUSUARIO.Text + "%' ORDER BY WANDY.ID DESC");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception)
            {


            }


        }





        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            MOSTRAR_DOS();

        }

        protected void BTNSAVE_Click(object sender, EventArgs e)
        {
            try
            {

                if (txttotal.Text== "")
                {
                    txttotal.Text = "0";
                }

                if (txtcpdtotal.Text == "")
                {
                    txtcpdtotal.Text = "0";
                }
                string COMANDO = string.Format("insert into WANDY values ('" + TXTDATE.Text + "','" + "" + "','" + txtsite.Text + "','" + txtmotorreff.Text + "','" + txtcapacity.Text + "','" + txtmotorserial.Text + "','" + txtdescripcion.Text + "','" + txtdateout.Text + "','" + txtinvoice.Text + "','" + txttotal.Text + "','" + txtestatus.Text + "','" + txtmarray.Text + "','" + txtcpdinv.Text + "','" + txtcpdtotal.Text + "','" + txtcpdinvstatus.Text + "','" + TXTNOTAS.Text + "','" + GetTime() + "')");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE RELIZO CORRECTAMENTE";
                MOSTRAR();
                Response.Redirect("~/WAMDY.aspx");
            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;

            }
        }
        public static string id = "";
        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                if (txttotal.Text == "")
                {
                    txttotal.Text = "0";
                }

                if (txtcpdtotal.Text == "")
                {
                    txtcpdtotal.Text = "0";
                }
                string COMANDO = string.Format("EXEC  ACTUALIZA_WANDY'" + id + "','" + TXTDATE.Text + "','" + "" + "','" + txtsite.Text + "','" + txtmotorreff.Text + "','" + txtcapacity.Text + "','" + txtmotorserial.Text + "','" + txtdescripcion.Text + "','" + txtdateout.Text + "','" + txtinvoice.Text + "','" + txttotal.Text + "','" + txtestatus.Text + "','" + txtmarray.Text + "','" + txtcpdinv.Text + "','" + txtcpdtotal.Text + "','" + txtcpdinvstatus.Text + "','" + TXTNOTAS.Text + "','" + GetTime() + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE RELIZO CORRECTAMENTE";
                MOSTRAR();
                Response.Redirect("~/WAMDY.aspx");
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;

            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("DELETE FROM WANDY WHERE ID = '" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/WAMDY.aspx");
                MOSTRAR();
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }
        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BTNSAVE.Enabled = false;
                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM WANDY WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);

                id = COMANDO;

                TXTDATE.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATEIN"]).ToString("yyyy-MM-dd");

                //txtcliente.Text = DS.Tables[0].Rows[0]["CLIENT"].ToString();
                txtsite.Text = DS.Tables[0].Rows[0]["SITE"].ToString();
                txtmotorreff.Text = DS.Tables[0].Rows[0]["MOTOR_REFF"].ToString();
                txtcapacity.Text = DS.Tables[0].Rows[0]["CAPACITY"].ToString();
                txtmotorserial.Text = DS.Tables[0].Rows[0]["MOTOR_SERIAL"].ToString();
                txtdescripcion.Text = DS.Tables[0].Rows[0]["JOB_DESCRIPTION"].ToString();

                txtdateout.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATEOUT"]).ToString("yyyy-MM-dd");
                txtinvoice.Text = DS.Tables[0].Rows[0]["INVOICE"].ToString();
                txttotal.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
                txtestatus.Text = DS.Tables[0].Rows[0]["STATUS"].ToString();
                txtmarray.Text = DS.Tables[0].Rows[0]["WARRANTY_TAG"].ToString();
                txtcpdinv.Text = DS.Tables[0].Rows[0]["CPD_INV"].ToString();
                txtcpdtotal.Text = DS.Tables[0].Rows[0]["CPD_TOTAL"].ToString();
                txtcpdinvstatus.Text = DS.Tables[0].Rows[0]["CPD_INV_STATUS"].ToString();
                TXTNOTAS.Text = DS.Tables[0].Rows[0]["COMMENT"].ToString();

                //DateTime fecha = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE_STATING"].ToString());
                //TXTSTARTING.Text = fecha.ToString("yyyy-MM-dd");

           



            }
            catch (Exception )
            {



            }
        }

        public static string nombre;
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
                    string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + id + "','" + GridView1.SelectedRow.Cells[4].Text + "','" + nombre + "',GETDATE(),'" + GetTime() + "','" + "WANDY" + "')");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    Response.Redirect("~/MANTENARCE.aspx");
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    //DATOS();
                }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }
        public static string IDGENSET,GENSET;
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[4].Text;



                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "WANDY");


                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;

                }

            }
        }
    }
}