using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class SPENDINGTRANCK : System.Web.UI.Page
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
                MOTRAL_GENSET();



                string COMANDO = string.Format("select PROVIDER from PROVIDER");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    TXTPROVIDER.DataSource = DS.Tables[0];
                    TXTPROVIDER.DataTextField = "PROVIDER";
                    TXTPROVIDER.DataBind();
            

            }
            GridView1.DataSourceID = null;
            BTNGUARDAR.Enabled = true;
            TXTEDIT.Enabled = false;
            TXTDELETE.Enabled = false;

        }

        void limpiar()
        {
            txtdate.Text = "";
           
            TXTINV.Text = "";
            TXTPO.Text = "";
            TXTTOTAL.Text = "";
            TXTDECRIPCION.Text = "";

        }

        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            try
            {
                string COMAN = string.Format("SELECT * FROM SPENDING WHERE INV = '"+TXTINV.Text+"' ");
                DataSet DS2 = CLASS_CONECTAR.CONECTAR(COMAN);
                if (DS2.Tables[0].Rows.Count > 0 )
                {
                    Response.Write("<script>alert('This invoice number already exists' )</script>");
                }
                else
                {
                    string COMANDO = string.Format("exec NEW_SPENDING '" + txtdate.Text + "','" + TXTPROVIDER.Text + "','" + TXTINV.Text + "','" + TXTPO.Text + "','" + TXTDECRIPCION.Text + "','" + TXTTOTAL.Text + "','" + GetTime() + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    MOTRAL_GENSET();
                    limpiar();
                    Response.Redirect("~/SPENDINGTRANCK.aspx");
                }


               
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }
        }

        void MOTRAL_GENSET()
        {

            try
            {
                string COMANDO = String.Format("SELECT    ID,    DATE1 AS Date, PROVIDER AS Provider, INV AS Inv, PO AS Po, DESCRIPTION1 AS Description, '$'+TOTAL AS Total, USER1 AS [User] FROM            edgar2211.SPENDING  order by ID DESC ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                string COMANDO1 = String.Format("SELECT   SUM(cast(TOTAL AS FLOAT) )AS Total  FROM            edgar2211.SPENDING   ");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                LBLESTADO0.Text = DS1.Tables[0].Rows[0]["Total"].ToString();
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }



        }

        public static string id = "";

        public static string USER = "";
        protected void TXTEDIT_Click(object sender, EventArgs e)
        {
            try
            {


                //string COMAN = string.Format("SELECT * FROM SPENDING WHERE INV = '" + TXTINV.Text + "' ");
                //DataSet DS2 = CLASS_CONECTAR.CONECTAR(COMAN);
                //if (DS2.Tables[0].Rows.Count > 0)
                //{
                //    Response.Write("<script>window.open('You can not edit the invoice number because another invoice already exists with this number' )</script>");
                //}
                //else
                //{

                    string COMANDO = string.Format("exec EDIT_SPENDING '" + id + "','" + txtdate.Text + "','" + TXTPROVIDER.SelectedValue.ToString() + "','" + TXTPO.Text + "','" + TXTDECRIPCION.Text + "','" + TXTTOTAL.Text + "','" + GetTime() + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    MOTRAL_GENSET();
                    limpiar();
                    BTNGUARDAR.Enabled = true;
                    TXTEDIT.Enabled = false;
                    TXTDELETE.Enabled = false;
                    Response.Redirect("~/SPENDINGTRANCK.aspx");
                //}


                

            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO12 = string.Format("select * from SPENDING where ID='" + COMANDO + "'order by ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = COMANDO;
                  DateTime fecha1 = Convert.ToDateTime(DS.Tables[0].Rows[0]["DATE1"].ToString());

                  txtdate.Text = fecha1.ToString("yyyy-MM-dd");

              TXTPROVIDER.Text = DS.Tables[0].Rows[0]["PROVIDER"].ToString();

          TXTINV.Text = DS.Tables[0].Rows[0]["INV"].ToString();

              TXTPO.Text = DS.Tables[0].Rows[0]["PO"].ToString();
                TXTDECRIPCION.Text = DS.Tables[0].Rows[0]["DESCRIPTION1"].ToString();
             TXTTOTAL.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
           
                USER = DS.Tables[0].Rows[0]["USER1"].ToString();
                BTNGUARDAR.Enabled = false;
                TXTEDIT.Enabled = true;
                TXTDELETE.Enabled = true;


            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        protected void TXTDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("DELETE  from SPENDING where ID='" + id + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                MOTRAL_GENSET();
                BTNGUARDAR.Enabled = true;
                TXTEDIT.Enabled = false;
                TXTDELETE.Enabled = false;
                limpiar();
                Response.Redirect("~/SPENDINGTRANCK.aspx");
            }
            catch (Exception)
            {


            }
        }

        protected void BTNBUSCAR0_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTUSUARIO.Text =="")
                {
                    string COMANDO = String.Format("SELECT    ID,    DATE1 AS Date, PROVIDER AS Provider, INV AS Inv, PO AS Po, DESCRIPTION1 AS Description,'$'+TOTAL AS Total, USER1 AS [User] FROM            edgar2211.SPENDING WHERE (DATE1 >= '" + TXTDESDE.Text + "') AND (DATE1 <= '" + TXTHASTA.Text + "')    order by ID DESC ");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    string COMANDO1 = String.Format("SELECT   SUM(cast(TOTAL AS FLOAT) )AS Total  FROM            edgar2211.SPENDING WHERE     (DATE1 >= '" + TXTDESDE.Text + "')AND (DATE1 <= '" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO0.Text = DS1.Tables[0].Rows[0]["Total"].ToString();

                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }
                else
                {
                    string COMANDO = String.Format("SELECT    ID,    DATE1 AS Date, PROVIDER AS Provider, INV AS Inv, PO AS Po, DESCRIPTION1 AS Description,'$'+TOTAL AS Total, USER1 AS [User] FROM            edgar2211.SPENDING WHERE    " + DropDownList1.Text + " LIKE '%" + TXTUSUARIO.Text + "%' AND   (DATE1 >= '" + TXTDESDE.Text + "') AND (DATE1 <= '" + TXTHASTA.Text + "')    order by ID DESC ");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    string COMANDO1 = String.Format("SELECT   SUM(cast(TOTAL AS FLOAT) )AS Total  FROM            edgar2211.SPENDING WHERE  PROVIDER LIKE '%" + TXTUSUARIO.Text + "%'  AND (DATE1 >= '" + TXTDESDE.Text + "')AND (DATE1 <= '" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO0.Text = DS1.Tables[0].Rows[0]["Total"].ToString();

                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }
             
            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }
        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {

              

                    string COMANDO = String.Format("SELECT    ID,    DATE1 AS Date, PROVIDER AS Provider, INV AS Inv, PO AS Po, DESCRIPTION1 AS Description,'$'+TOTAL AS Total, USER1 AS [User] FROM            edgar2211.SPENDING WHERE "+DropDownList1.Text+" LIKE '%" + TXTUSUARIO.Text + "%'    order by ID DESC ");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    string COMANDO1 = String.Format("SELECT   SUM(cast(TOTAL AS FLOAT) )AS Total  FROM            edgar2211.SPENDING WHERE PROVIDER LIKE '%" + TXTUSUARIO.Text + "%' ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);



                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    LBLESTADO0.Text = DS1.Tables[0].Rows[0]["Total"].ToString();
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
          

            }
            catch (Exception)
            {


            }
        }





    }
}