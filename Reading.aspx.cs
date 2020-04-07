using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class Reading : System.Web.UI.Page
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

        private  class datos
        {
            
        
        }


        void SUMARY()
        {
            try
            {
                int i= 0;
                int ii = 0;

                List<string> listaHORAS = new List<string>();
                List<string> listaENERGIA = new List<string>();
                List<string> listaEVERANGE = new List<string>();
                DataTable table = new DataTable();


                foreach (GridViewRow Hours in GridView1.Rows)
                {

                    TextBox horas = (TextBox)Hours.FindControl("txthoras");
                    TextBox energy = (TextBox)Hours.FindControl("txtenergy");
                    TextBox rate = (TextBox)Hours.FindControl("txtrate");

                    if (GridView1.Rows[i].Cells[1].Text.ToUpper() == GridView2.Rows[ii].Cells[2].Text.ToUpper())
                    {
                        Int64 horas1 = Convert.ToInt64(horas.Text);
                        Int64 horas2 = Convert.ToInt64(GridView2.Rows[ii].Cells[3].Text);
                        Int64 totalhoras = horas1 - horas2;

                        listaHORAS.Add(totalhoras.ToString());
                                       

                      
                        ii++;
                        i++;
                    }

                    
                }

               
                GridView3.DataSource = listaHORAS;
                GridView3.DataBind();

               

                 i = 0;
                 ii = 0;




                foreach (GridViewRow Energy in GridView1.Rows)
                {

                    TextBox horas = (TextBox)Energy.FindControl("txthoras");
                    TextBox energy = (TextBox)Energy.FindControl("txtenergy");
                    TextBox rate = (TextBox)Energy.FindControl("txtrate");

                    if (GridView1.Rows[i].Cells[1].Text.ToUpper() == GridView2.Rows[ii].Cells[2].Text.ToUpper())
                    {
                        Int64 ener1 = Convert.ToInt64(energy.Text);
                        Int64 ener2 = Convert.ToInt64(GridView2.Rows[ii].Cells[4].Text);
                        Int64 totalenerg = ener1 - ener2;

                        listaENERGIA.Add(totalenerg.ToString());

                        i++;
                        ii++;
                    }

               
                }


                GridView5.DataSource = listaENERGIA;
                GridView5.DataBind();











                i = 0;
                ii = 0;




                foreach (GridViewRow Energy in GridView3.Rows)
                {
                    Int64 load1 = Convert.ToInt64(GridView3.Rows[ii].Cells[0].Text);
                    Int64 load2 = Convert.ToInt64(GridView5.Rows[ii].Cells[0].Text);

                    Int64 ener2 = load2/ load1;

                    listaEVERANGE.Add(ener2.ToString());
                    ii++;
                }


                GridView6.DataSource = listaEVERANGE;
                GridView6.DataBind();





            }
            catch (Exception error)
            {
                LBLESTADO0.Text = error.Message;
            
            }


        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string COMANDO = string.Format("select site from site");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                CBSITE.DataSource = DS.Tables[0];
                CBSITE.DataTextField = "site";
                CBSITE.DataBind();


                //string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //DROPCLIEN.DataSource = DS1.Tables[0];
                //DROPCLIEN.DataTextField = "COMPANY_NAME";
                //DROPCLIEN.DataBind();
                GridView1.DataSourceID = null;
                //GridView2.DataSourceID = null;
                //GridView3.DataSourceID = null;
                MOSTRAL_CODIGO();
                CBSITE_SelectedIndexChanged(null, null);
                GridView2.DataSource = null;
                GridView2.DataBind();
            }

            GridView2.DataSourceID = null;
        }

        void mostra()
        {
            try
            {





            }
            catch (Exception)
            {


            }

        }

        void MOSTRAL_CODIGO()
        {

            try
            {
                string COMANDO = string.Format("SELECT * FROM CODE_FACT WHERE TIPO='" + "INFO" + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = DS.Tables[0].Rows[0]["CODEC"].ToString();

            }
            catch (Exception )
            {


            }
        }
        public static int VA = 0;
        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                //GridView2.DataSourceID = null;
                string COMANDO12 = string.Format("select SITE,GENSET_MODEL AS GENSET from gensetfinal where SITE='" + CBSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);


                GridView1.DataSource = DS12.Tables[0];
                GridView1.DataBind();

                 VA = GridView1.Rows.Count;
                LBLESTADO0.Text = VA.ToString();

                txtmesreading.Text = "";

                GridView2.DataSourceID = null;
                GridView2.DataSource = null;
                GridView2.DataBind();

                GridView3.DataSourceID = null;
                GridView3.DataSource = null;
                GridView3.DataBind();

                GridView4.DataSourceID = null;
                GridView4.DataSource = null;
                GridView4.DataBind();
                //string COMAN = string.Format("SELECT * FROM READING WHERE SITE1='" + CBSITE.Text + "'");
                //DataSet DS34 = CLASS_CONECTAR.CONECTAR(COMAN);





                GridView5.DataSourceID = null;
                GridView5.DataSource = null;
                GridView5.DataBind();





                GridView6.DataSourceID = null;
                GridView6.DataSource = null;
                GridView6.DataBind();




                //foreach (GridViewRow ROW in GridView1.Rows)
                //{
                //    GridView1.DataSource = DS12.Tables[0];
                //    GridView1.DataBind();
                //    TextBox horas = (TextBox)ROW.FindControl("txthoras");
                //    horas.Text = DS34.Tables[0].Rows[0]["LAST_RUNNIN_HOURS"].ToString();
                //}

                //GridView2.DataSource = DS12.Tables[0];
                //GridView2.DataBind();

                //GridView3.DataSource = DS12.Tables[0];
                //GridView3.DataBind();
            }
            catch (Exception )
            {


            }
        }

        public static string grid = "";
        //private string cadena;
        protected void BTNSAVE_Click(object sender, EventArgs e)
        { 
            try
            {

                
                //int  ver= 0;
                //int iI = 0;
                //    foreach (GridViewRow row in GridView1.Rows)
                //    {

                //        TextBox horas = (TextBox)row.FindControl("txthoras");
                //        TextBox energy = (TextBox)row.FindControl("txtenergy");
                //        TextBox rate = (TextBox)row.FindControl("txtrate");
                //        string CONFIRMAR = string.Format("SELECT  * FROM TBREADING where site ='" + CBSITE.Text + "' and genset='" + GridView1.Rows[iI].Cells[1].Text + "' and RUNNING_HOURS >CONVERT(INT,'" + horas.Text + "') ORDER BY ID DESC");
                //        DataSet DS0 = CLASS_CONECTAR.CONECTAR(CONFIRMAR);

                //        string CONFIRMAR1 = string.Format("SELECT  * FROM TBREADING where site ='" + CBSITE.Text + "' and genset='" + GridView1.Rows[iI].Cells[1].Text + "' AND ENERGY>CONVERT(INT,'" + energy.Text + "') ORDER BY ID DESC");
                //        DataSet DS01 = CLASS_CONECTAR.CONECTAR(CONFIRMAR1);

                //        if (DS0.Tables[0].Rows.Count > 0 || DS01.Tables[0].Rows.Count > 0)
                //        {
                //                    ver = 1;
                //        //Response.Redirect("~/Reading.aspx");
                        
                //        }
                //    iI++;
                //    }

                //if (ver==1)
                //{
                //    Response.Write("<script> alert('The data is not saved because it tries to enter values smaller than the existing ones in the system that belong to these generators');</script>");


                //}
                //else
                //{
                    int i = 0;
                    foreach (GridViewRow row in GridView1.Rows)
                    {

                        TextBox horas = (TextBox)row.FindControl("txthoras");
                        TextBox energy = (TextBox)row.FindControl("txtenergy");
                        TextBox rate = (TextBox)row.FindControl("txtrate");
                        //TextBox horasdiferencai = (TextBox)GridView3.FindControl("txthoras1");
                        DateTime fecha = Convert.ToDateTime(txtmesreading.Text);

                        string COMANDO = string.Format("EXEC new_redin '" + row.Cells[0].Text + "','" + GridView1.Rows[i].Cells[1].Text + "','" + horas.Text + "','" + energy.Text + "','" + rate.Text + "','" + fecha.ToString("yyyy-MM-dd") + "','" + GetTime() + "'");
                        DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                        i++;
                    }

                    Response.Redirect("~/Reading.aspx");
                //}

               

            }
            catch (Exception error)
            {

                LBLESTADO0.Text = error.Message;
            }





        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TextBox txthoras01 = (TextBox)GridView1.FindControl("txthoras0");

            //TextBox txtenergy01 = (TextBox)GridView1.FindControl("txtenergy0");
            //TextBox txtrate0 = (TextBox)GridView1.FindControl("txtrate0");
            //TextBox txthoras = (TextBox)GridView2.FindControl("txthoras");
            //TextBox txtenergy = (TextBox)GridView2.FindControl("txtenergy");
            //TextBox txtrate = (TextBox)GridView2.FindControl("txtrate");
         
           
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ////{
            //TextBox txthoras0 = (TextBox)GridView1.FindControl("txthoras0");
            //TextBox txtenergy0 = (TextBox)GridView1.FindControl("txtenergy0");
            //TextBox txtrate0 = (TextBox)GridView1.FindControl("txtrate0");
            //TextBox txthoras = (TextBox)GridView2.FindControl("txthoras");
            //TextBox txtenergy = (TextBox)GridView2.FindControl("txtenergy");
            //TextBox txtrate = (TextBox)GridView2.FindControl("txtrate");




            //string COMANDO = string.Format("EXEC NEW_READING '" + LBLESTADO.Text + "','" + CBSITE.Text + "','"+cadena+"','" + DROPCLIEN.Text + "','" + txthoras0 + "','" + txtenergy0 + "','" + txtrate0 + "','" + txthoras + "','" + txtenergy + "','" + txtrate + "','" + txtmesreading.Text + "','" + txtmeslasreading.Text + "','" + txtnotas.Text + "','" + GetTime() + "'");
            //DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);

            //for (int i = 0; i < row; i++)
            //{
            //    string COMANDO = string.Format("EXEC NEW_READING '" + LBLESTADO.Text + "','" + CBSITE.Text + "','" + GridView1.SelectedRow.Cells[i].Text + "','" + DROPCLIEN.Text + "','" + GridView2.SelectedRow.Cells[i].Text + "','" + GridView2.SelectedRow.Cells[i].Text + "','" + GridView2.SelectedRow.Cells[i].Text + "','" + GridView1.SelectedRow.Cells[i].Text + "','" + GridView1.SelectedRow.Cells[i].Text + "','" + GridView1.SelectedRow.Cells[i].Text + "','" + txtmesreading.Text + "','" + txtmeslasreading.Text + "','" + txtnotas.Text + "','" + GetTime() + "'");
            //    DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
            //}






            //nueva estructura


            //try
            //{
            int valor = Convert.ToInt32(e.CommandArgument);

            //    //IDGENSET = GridView1.Rows[valor].Cells[2].Text;
            //    //GENSET = GridView1.Rows[valor].Cells[5].Text;

            //    int row = Convert.ToInt32(GridView1.Rows.Count);
            //    for (int i = 0; i < row; i++)
            //    {
            //        string COMANDO = string.Format("EXEC NEW_READING '" + LBLESTADO.Text + "','" + CBSITE.Text + "','" + GridView1.Rows[valor].Cells[i].Text + "','" + DROPCLIEN.Text + "','" + GridView2.Rows[valor].Cells[i].Text + "','" + GridView2.Rows[valor].Cells[i].Text + "','" + GridView2.Rows[valor].Cells[i].Text + "','" + GridView1.Rows[valor].Cells[i].Text + "','" + GridView1.Rows[valor].Cells[i].Text + "','" + GridView1.Rows[valor].Cells[i].Text + "','" + txtmesreading.Text + "','" + txtmeslasreading.Text + "','" + txtnotas.Text + "','" + GetTime() + "'");
            //        DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
            //    }
            //}
            //catch (Exception ERROR)
            //{
            //    //LBLESTADO.Text = ERROR.Message;

            //}
            try
            {
                foreach (GridViewRow row in GridView1.Rows)
                {

                    TextBox horas = (TextBox)row.FindControl("txthoras");
                    //TextBox horasdiferencai = (TextBox)GridView3.FindControl("txthoras1");
                    //string COMANDO = string.Format("EXEC NEW_READING '" + LBLESTADO.Text + "','" + CBSITE.Text + "','" + row.Cells[1].Text + "','" + DROPCLIEN.Text + "','" + horas.Text + "','" + GridView3.Rows[valor].Cells[2].Text + "','" + horasdiferencai.Text + "','" + "" + "','" + "" + "','" + "" + "','" + txtmesreading.Text + "','" + txtmeslasreading.Text + "','" + txtnotas.Text + "','" + GetTime() + "'");
                    //DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO);
                }


            }
            catch (Exception)
            {

                
            }



        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    // TextBox with an ID of "sumTextBox" is in column #0 of the Grid...
            //    TextBox sumTextBox = (TextBox)e.Row.Cells[0].FindControl("sumTextBox");

            //    // TextBox with an ID of "weightageTextBox" is in column #1 of the Grid...
            //    TextBox weightageTextBox = (TextBox)e.Row.Cells[1].FindControl("weightageTextBox");

            //    // TextBox with an ID of "totalTextBox" is in column #2 of the Grid...
            //    TextBox totalTextBox = (TextBox)e.Row.Cells[2].FindControl("totalTextBox");

            //    if ((sumTextBox != null) && (weightageTextBox != null) && (totalTextBox != null))
            //    {
            //        string eventHandler = string.Format(
            //         "gridTextBoxOnChange('{0}', '{1}', '{2}');",
            //         sumTextBox.ClientID, weightageTextBox.ClientID, totalTextBox.ClientID);

            //        sumTextBox.Attributes.Add("onchange", eventHandler);
            //        weightageTextBox.Attributes.Add("onchange", eventHandler);
            //    }


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //TextBox horasfinal = (TextBox)e.Row.FindControl("txthoras");
                //int row = Convert.ToInt32(GridView1.Rows.Count);
                //for (int i = 0; i < row; i++)
                //{
                  
                //}
            }


        }

        protected void txtmesreading_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime datev = Convert.ToDateTime(txtmesreading.Text);
                string COMANDO = string.Format("exec mostrarantes'"+CBSITE.Text+"','"+ datev.ToString("yyyy-MM-dd")+"'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                GridView2.DataSource = DS.Tables[0];
                GridView2.DataBind();

                string COMANDO1 = string.Format("exec mostrarantes_ACTUAL'" + CBSITE.Text + "','" + datev.ToString("yyyy-MM-dd") + "'");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                if (DS1.Tables[0].Rows.Count > 0 )
                {
                    //BTNSAVE.Enabled = false;
                    Response.Write("<script> alert('THIS MONTH OF THIS SITE IS ALREADY DIGITED CAN NOT ENTER ANOTHER SAME AS THIS MONTH');</script>");
                    Label1.Visible = true;
                    GridView4.DataSource = DS1.Tables[0];
                    GridView4.DataBind();

                }
                else
                {
                    Label1.Visible = false;
                    GridView4.DataSourceID = null;
                    GridView4.DataSource = null;
                    GridView4.DataBind();
                    //BTNSAVE.Enabled = true;
                }







            }
            catch (Exception error)
            {

                LBLESTADO0.Text = error.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {




            SUMARY();

            //try
            //{
            //    DateTime datev = Convert.ToDateTime(txtmesreading.Text);
            //    string COMANDO = string.Format("exec mostrarantes'" + CBSITE.Text + "','" + txtmesreading.Text + "'");
            //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //    GridView2.DataSource = DS.Tables[0];
            //    GridView2.DataBind();



            //}
            //catch (Exception error)
            //{

            //    LBLESTADO0.Text = error.Message;
            //}
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            SUMARY();
            BTNSAVE.Enabled = true;
        }
    }
}