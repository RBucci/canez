using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class STOCKENTER : System.Web.UI.Page
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
            //TextBox1.Attributes.Add("onkeypress", "cambiaFoco('Button6_Click')");
            Panel1.DefaultButton = Button1.ID;
            if (!Page.IsPostBack)
            {
                string COMANDO = string.Format("select PART from SPARTPART");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                DROPPART.DataSource = DS.Tables[0];
                DROPPART.DataTextField = "PART";
                DROPPART.DataBind();

                DROPPART_SelectedIndexChanged(null,null);
                //string COMANDO1 = string.Format("select ACCPAC from SPARTPART");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //DROPACCP.DataSource = DS1.Tables[0];
                //DROPACCP.DataTextField = "ACCPAC";
                //DROPACCP.DataBind();
                //DROPACCP_SelectedIndexChanged(null,null);
                MOSTRAR();


                string COMANDO12 = string.Format("select PROVIDER from PROVIDER");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                TXTPROVIDER.DataSource = DS12.Tables[0];
                TXTPROVIDER.DataTextField = "PROVIDER";
                TXTPROVIDER.DataBind();

            }
            VER12();
        }

        void VER12()
        {
            try
            {
                string COMANDO = string.Format("SELECT   DISTINCT     '$'+convert(varchar,SUM(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float))) AS TOTAL FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART         WHERE       EOMONTH(edgar2211.STOCK_ENTER.DATE)  = EOMONTH(GETDATE())");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO0.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
            }
            catch (Exception)
            {


            }
        }


        void MOSTRAR()
        {
            try
            {
                string COMANDO = string.Format("EXEC MOSTRA_STOCKENTER");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {
                
                
            }


        }

        void LIMPIAR(){

           
            TXTINV.Text = "";
            TXTQTY.Text = "";
            TXTNONE.Text = "";
        
        
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                DROPACCP_SelectedIndexChanged(null, null);
                int CANTI = Convert.ToInt32(TXTCANTI.Text);
                int NEWCANTI = Convert.ToInt32(TXTQTY.Text);
                int CANTIFIN = CANTI + NEWCANTI;

                string COMAN1 = string.Format("SELECT * FROM SPARTPART  WHERE ACCPAC='" + TXTACCPAC.Text + "'");
                DataSet DS21 = CLASS_CONECTAR.CONECTAR(COMAN1);
                double VALOR =Convert.ToDouble( DS21.Tables[0].Rows[0]["NEXT_COST"].ToString());
               
                double final = CANTIFIN * VALOR;

              



                string COMAN = string.Format("UPDATE SPARTPART SET STOCK ='"+CANTIFIN.ToString()+"',GRANT_TOTAL='"+final.ToString()+"' WHERE ACCPAC='"+TXTACCPAC.Text+"'");
                DataSet DS2 = CLASS_CONECTAR.CONECTAR(COMAN);






                string comando = string.Format("EXEC NEW_STOCKENTER '" + DROPPART.Text + "','" + TXTACCPAC.Text + "','" + TXTPROVIDER.Text + "','" + TXTINV.Text + "','" + TXTQTY.Text + "','" + TXTNONE.Text + "','" + GetTime() + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                MOSTRAR();
                LIMPIAR();
                Response.Redirect("~/STOCKENTER.aspx");
             }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        protected void DROPACCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //try
            //{
            //    string COMANDO1 = string.Format("select * from SPARTPART WHERE ACCPAC='" + DROPACCP.SelectedValue + "'");
            //    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
            //    DROPACCP.DataSource = DS1.Tables[0];
            //    TXTCOST.Text = DS1.Tables[0].Rows[0]["COST"].ToString();
            //    TXTDESCRIPTION.Text = DS1.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            //    TXTCANTI.Text = DS1.Tables[0].Rows[0]["STOCK"].ToString();
            //}
            //catch (Exception E)
            //{
            //    LBLESTADO.Text = E.Message;
              
            //}

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
           

            try
            {

                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_ENTER.ID, edgar2211.STOCK_ENTER.DATE, edgar2211.STOCK_ENTER.PART, edgar2211.STOCK_ENTER.ACCPAC,SPARTPART.CATEGORY, edgar2211.SPARTPART.DESCRIPTION,                  edgar2211.STOCK_ENTER.PROVIDER, edgar2211.STOCK_ENTER.INV,'$'+edgar2211.SPARTPART.NEXT_COST AS COST,edgar2211.STOCK_ENTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float)) as TOTAL, edgar2211.STOCK_ENTER.NONE, edgar2211.STOCK_ENTER.USER1 FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART    WHERE edgar2211.STOCK_ENTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%'						 ORDER BY edgar2211.STOCK_ENTER.ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

                string COMANDO1 = string.Format("SELECT   DISTINCT     '$'+convert(varchar,SUM(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float))) AS TOTAL FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART         WHERE      edgar2211.STOCK_ENTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%'");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();




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
                string part = GridView1.SelectedRow.Cells[5].Text;
                string QTY = GridView1.SelectedRow.Cells[11].Text;
                string CADENA = string.Format("SELECT * FROM SPARTPART WHERE ACCPAC='" + part + "'");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(CADENA);
                string STOCK= DS1.Tables[0].Rows[0]["STOCK"].ToString();
                int INTQTY = Convert.ToInt32(QTY);
                int INTSTOCK = Convert.ToInt32(STOCK);
                int TOTAL = INTSTOCK - INTQTY;



                string COMAN1 = string.Format("SELECT * FROM SPARTPART  WHERE ACCPAC='" + part + "'");
                DataSet DS21 = CLASS_CONECTAR.CONECTAR(COMAN1);
                double VALOR = Convert.ToDouble(DS21.Tables[0].Rows[0]["NEXT_COST"].ToString());

                double final = TOTAL * VALOR;





                string CADENA1 = string.Format("UPDATE SPARTPART SET STOCK ='" + TOTAL.ToString() + "',GRANT_TOTAL='" + final.ToString() + "' WHERE ACCPAC='" + part + "'");
                DataSet DS11 = CLASS_CONECTAR.CONECTAR(CADENA1);



                string coman = string.Format("delete from STOCK_ENTER WHERE  ID='" + COMANDO + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(coman);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                MOSTRAR();
                LIMPIAR();


                Response.Redirect("~/STOCKENTER.aspx");
                
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }



        protected void DROPPART_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO1 = string.Format("select * from SPARTPART WHERE PART='" +DROPPART.SelectedValue + "'");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                TXTACCPAC.Text = DS1.Tables[0].Rows[0]["ACCPAC"].ToString();
                TXTCOST.Text = DS1.Tables[0].Rows[0]["COST"].ToString();
                TXTCATEGORY.Text = DS1.Tables[0].Rows[0]["CATEGORY"].ToString();
                TXTDESCRIPTION.Text = DS1.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                TXTCANTI.Text = DS1.Tables[0].Rows[0]["STOCK"].ToString();
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }

        }
        protected void Button6_Click1(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text =="")
                {

                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_ENTER.ID, edgar2211.STOCK_ENTER.DATE, edgar2211.STOCK_ENTER.PART, edgar2211.STOCK_ENTER.ACCPAC,SPARTPART.CATEGORY, edgar2211.SPARTPART.DESCRIPTION,                  edgar2211.STOCK_ENTER.PROVIDER, edgar2211.STOCK_ENTER.INV,'$'+edgar2211.SPARTPART.NEXT_COST AS COST,edgar2211.STOCK_ENTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float)) as TOTAL, edgar2211.STOCK_ENTER.NONE, edgar2211.STOCK_ENTER.USER1 FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART    WHERE  ( edgar2211.STOCK_ENTER.DATE>='" + TXTDESDE.Text + "')AND( edgar2211.STOCK_ENTER.DATE<='" + TXTHASTA.Text + "') ORDER BY STOCK_ENTER.ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();


                    string COMANDO1 = string.Format("SELECT   DISTINCT     '$'+convert(varchar,SUM(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float))) AS TOTAL FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART         WHERE      ( edgar2211.STOCK_ENTER.DATE>='" + TXTDESDE.Text + "')AND( edgar2211.STOCK_ENTER.DATE<='" + TXTHASTA.Text + "')");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();


                }
                else
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_ENTER.ID, edgar2211.STOCK_ENTER.DATE, edgar2211.STOCK_ENTER.PART, edgar2211.STOCK_ENTER.ACCPAC,SPARTPART.CATEGORY, edgar2211.SPARTPART.DESCRIPTION,                  edgar2211.STOCK_ENTER.PROVIDER, edgar2211.STOCK_ENTER.INV,'$'+edgar2211.SPARTPART.NEXT_COST AS COST,edgar2211.STOCK_ENTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float)) as TOTAL, edgar2211.STOCK_ENTER.NONE, edgar2211.STOCK_ENTER.USER1 FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART   WHERE  edgar2211.STOCK_ENTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%'	AND  ( edgar2211.STOCK_ENTER.DATE>='" + TXTDESDE.Text + "')AND( edgar2211.STOCK_ENTER.DATE<='" + TXTHASTA.Text + "') ORDER BY STOCK_ENTER.ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                    string COMANDO1 = string.Format("SELECT   DISTINCT     '$'+convert(varchar,SUM(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_ENTER.QTY as float))) AS TOTAL FROM             edgar2211.STOCK_ENTER left outer JOIN edgar2211.SPARTPART ON edgar2211.STOCK_ENTER.PART = edgar2211.SPARTPART.PART         WHERE     edgar2211.STOCK_ENTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%'	AND      ( edgar2211.STOCK_ENTER.DATE>='" + TXTDESDE.Text + "')AND( edgar2211.STOCK_ENTER.DATE<='" + TXTHASTA.Text + "')");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();
                }

               

            }
            catch (Exception)
            {


            }
        }
       
}
}