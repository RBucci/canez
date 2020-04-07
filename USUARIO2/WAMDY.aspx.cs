using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CanezPower.USUARIO2 
{
    public partial class WAMDY : System.Web.UI.Page
    {

        public System.Security.Principal.IPrincipal User
        {
            get;
            [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, ControlPrincipal = true)]
            set;
        }
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

                MOSTRAR();

            }
        }

        void MOSTRAR()
        {

            try
            {
                
                    string COMANDO = string.Format("SELECT        ID, DATEIN AS [DATE IN], CLIENT, SITE, MOTOR_REFF AS [MOTOR REFF], CAPACITY, MOTOR_SERIAL AS [MOTOR SERIAL #], JOB_DESCRIPTION AS [JOB DESCRIPTION], DATEOUT AS [DATE OUT], INVOICE,                          TOTAL, STATUS, WARRANTY_TAG AS [WARRANTY TAG], CPD_INV AS [CPD INV], CPD_TOTAL AS [CPD TOTAL], CPD_INV_STATUS AS [CPD INV STATUS], COMMENT, USER1 FROM            edgar2211.WANDY");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
              
               
            }
            catch (Exception)
            {
                
                
            }


        }




        void MOSTRAR_DOS()
        {

            try
            {

                string COMANDO = string.Format("SELECT        ID, DATEIN AS [DATE IN], CLIENT, SITE, MOTOR_REFF AS [MOTOR REFF], CAPACITY, MOTOR_SERIAL AS [MOTOR SERIAL #], JOB_DESCRIPTION AS [JOB DESCRIPTION], DATEOUT AS [DATE OUT], INVOICE,                          TOTAL, STATUS, WARRANTY_TAG AS [WARRANTY TAG], CPD_INV AS [CPD INV], CPD_TOTAL AS [CPD TOTAL], CPD_INV_STATUS AS [CPD INV STATUS], COMMENT, USER1 FROM            edgar2211.WANDY WHERE "+DropDownList1.Text+" LIKE '%"+TXTUSUARIO.Text+"%'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
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
                string COMANDO = string.Format("insert into WANDY values ('" + TXTDATE.Text + "','" + txtcliente.Text + "','" + txtsite.Text + "','" + txtmotorreff.Text + "','" + txtcapacity.Text + "','" + txtmotorserial.Text + "','" + txtdescripcion.Text + "','" + txtdateout.Text + "','" + txtinvoice.Text + "','" + txttotal.Text + "','" + txtestatus.Text + "','" + txtmarray.Text + "','" + txtcpdinv.Text + "','" + txtcpdtotal.Text + "','" + txtcpdinvstatus.Text + "','" + TXTNOTAS.Text + "','" + GetTime() + "')");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE RELIZO CORRECTAMENTE";
                MOSTRAR();
            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;
                
            }
        }
        public static string ID = "";
        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("EXEC  ACTUALIZA_WANDY'" + ID + "','" + TXTDATE.Text + "','" + txtcliente.Text + "','" + txtsite.Text + "','" + txtmotorreff.Text + "','" + txtcapacity.Text + "','" + txtmotorserial.Text + "','" + txtdescripcion.Text + "','" + txtdateout.Text + "','" + txtinvoice.Text + "','" + txttotal.Text + "','" + txtestatus.Text + "','" + txtmarray.Text + "','" + txtcpdinv.Text + "','" + txtcpdtotal.Text + "','" + txtcpdinvstatus.Text + "','" + TXTNOTAS.Text + "','" + GetTime() + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE RELIZO CORRECTAMENTE";
                MOSTRAR();
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
                string COMANDO = string.Format("DELETE FROM WANDY WHERE ID = '" + ID + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";

                MOSTRAR();
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
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("SELECT * FROM WANDY WHERE ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                
                ID = COMANDO;

               TXTDATE.Text = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATEIN"]).ToString("yyyy-MM-dd");

              txtcliente.Text = DS.Tables[0].Rows[0]["CLIENT"].ToString();
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
            catch (Exception E)
            {



            }
        }
    }
}