using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO1
{
    public partial class SPARRPART : System.Web.UI.Page
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





           
            if (!Page.IsPostBack)
            {


                string COMANDO1 = string.Format("select CATEGORY from CATEGORY");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                DROPCATEGORY.DataSource = DS1.Tables[0];
                DROPCATEGORY.DataTextField = "CATEGORY";
                DROPCATEGORY.DataBind();

                mostral();
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;

            }
            ver1();
            //TXTHASTA.Attributes.Add("onkeypress", "cambiaFoco('Button6_Click')");
            Panel1.DefaultButton = Button6.ID;
        }


        void ver1()
        {

            try
            {

                string COMAN1 = string.Format("exec sumar_wherhouse");
                DataSet DS21 = CLASS_CONECTAR.CONECTAR(COMAN1);
                LBLESTADO1.Text = DS21.Tables[0].Rows[0]["valos"].ToString();
            }
            catch (Exception)
            {

               
            }
        }



        void mostral()
        {

            try
            {
                //string comando = string.Format("EXEC VER_SPARE_PART");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();
                SUMAR();

            }
            catch (Exception )
            {

                //LBLESTADO.Text = ERROR.Message;
            }


        }

        void LIMPIAR()
        {
            TXTPART.Text = "";
            TXTACCPAC.Text = "";
            TXTCOST.Text = "";
            TXTDESCRIPTION.Text = "";
           


        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                double cost = Convert.ToDouble(TXTCOST.Text);
                double descuentos = Convert.ToDouble(TXTDISCOUNT.Text);
                double final = cost * descuentos / 100;

                double nextcosto = cost - final;





                double FINAL12 = final * nextcosto;

                string CADENA = string.Format("exec NEW_SPARTPAST'"+TXTPART.Text+"','"+TXTACCPAC.Text+"','"+DROPCATEGORY.Text+"','"+"0"+"','"+TXTCOST.Text+"','"+TXTDISCOUNT.Text+"','"+final.ToString()+"','"+nextcosto.ToString()+"','"+"0"+"','"+TXTDESCRIPTION.Text+"','"+GetTime()+"'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(CADENA);

                mostral();
                LIMPIAR();
                SUMAR();
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/SPARRPART.aspx");
            }
            catch (Exception )
            {
                //LBLESTADO.Text = ERROR.Message;
            }
        }
        public static int id = 0;
        public static int STOCK = 0;
        public string ACCPAC1, PART1;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                BTNSAVE.Enabled = false;
                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;
               string VALOR = GridView1.SelectedRow.Cells[2].Text;

               id = Convert.ToInt32(VALOR);
               string CADENA = string.Format("SELECT * FROM SPARTPART WHERE ID='" + VALOR + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                TXTPART.Text = DS.Tables[0].Rows[0]["PART"].ToString();
                TXTACCPAC.Text = DS.Tables[0].Rows[0]["ACCPAC"].ToString();
                PART1 = DS.Tables[0].Rows[0]["PART"].ToString();
                ACCPAC1 = DS.Tables[0].Rows[0]["ACCPAC"].ToString();
                TXTCOST.Text = DS.Tables[0].Rows[0]["COST"].ToString();
                TXTDISCOUNT.Text = DS.Tables[0].Rows[0]["DISCOUNT"].ToString();

                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION"].ToString();

             
                DROPCATEGORY.Text = DS.Tables[0].Rows[0]["CATEGORY"].ToString();
                STOCK = Convert.ToInt32(DS.Tables[0].Rows[0]["STOCK"].ToString());
          
            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;
            }


        }


        void SUMAR()
        {
            //double TOTAL = 0;
            //int VALOR = GridView1.Rows.Count;
            //for (int i = 0; i < VALOR ; i++)
            //{
            //    TOTAL = TOTAL + Convert.ToDouble(GridView1.Rows[i].Cells[11].Text);
            //}
            ////LBLESTADO1.Text = GridView1.Rows.Count.ToString();
            ////LBLESTADO1.Text = "$" + TOTAL.ToString();
        }


        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {


                string CADENA3 = string.Format("SELECT *  FROM SPARTPART WHERE ACCPAC = '" + ACCPAC1 + "'");
                DataSet DS34 = CLASS_CONECTAR.CONECTAR(CADENA3);
                if (DS34.Tables[0].Rows.Count > 0)
                {
                    string CADENA1 = string.Format("UPDATE STOCK_OUTER SET ACCPAC='" + ACCPAC1 + "' WHERE ACCPAC='" + ACCPAC1 + "'");
                    DataSet ds1 = CLASS_CONECTAR.CONECTAR(CADENA1);

                }


                string CADENA34 = string.Format("SELECT *  FROM SPARTPART WHERE PART = '" + PART1 + "'");
                DataSet DS344 = CLASS_CONECTAR.CONECTAR(CADENA34);
                if (DS344.Tables[0].Rows.Count > 0)
                {
                    string CADENA2 = string.Format("UPDATE STOCK_OUTER SET PART='" + ACCPAC1 + "' WHERE PART='" + ACCPAC1 + "'");
                    DataSet ds2 = CLASS_CONECTAR.CONECTAR(CADENA2);
                }

            }
            catch (Exception)
            {

               
            }

            try
            {


                double cost = Convert.ToDouble(TXTCOST.Text);
                double descuentos = Convert.ToDouble(TXTDISCOUNT.Text);
                double final = cost * descuentos / 100;

                double nextcosto = cost - final;
                
                double FINAL12 = STOCK * nextcosto;

                string CADENA3 = string.Format("SELECT *  FROM SPARTPART WHERE ACCPAC = '"+ACCPAC1+"'");
                DataSet DS34 = CLASS_CONECTAR.CONECTAR(CADENA3);
                if (DS34.Tables[0].Rows.Count>0)
                {
                    string CADENA1 = string.Format("UPDATE STOCK_ENTER SET ACCPAC='"+ACCPAC1+"' WHERE ACCPAC='"+ACCPAC1+"'");
                    DataSet ds1 = CLASS_CONECTAR.CONECTAR(CADENA1);

                }


                string CADENA34 = string.Format("SELECT *  FROM SPARTPART WHERE PART = '" + PART1 + "'");
                DataSet DS344 = CLASS_CONECTAR.CONECTAR(CADENA34);
                if (DS344.Tables[0].Rows.Count > 0)
                {
                    string CADENA2 = string.Format("UPDATE STOCK_ENTER SET PART='" + ACCPAC1 + "' WHERE PART='" + ACCPAC1 + "'");
                    DataSet ds2 = CLASS_CONECTAR.CONECTAR(CADENA2);
                }




                string CADENA = string.Format("exec EDIT_SPARTPAST'" + id + "','"+TXTACCPAC.Text+"','" + TXTPART.Text + "','" + DROPCATEGORY.Text + "','" + TXTCOST.Text + "','" + TXTDISCOUNT.Text + "','" + final.ToString() + "','" + nextcosto.ToString() + "','"+FINAL12.ToString()+"','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                DataSet ds = CLASS_CONECTAR.CONECTAR(CADENA);
                mostral();
                SUMAR();
              
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                Response.Redirect("~/SPARRPART.aspx");
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

                
                string CADENA = string.Format("DELETE FROM SPARTPART WHERE ID='" + id + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                mostral();
                BTNSAVE.Enabled = true;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                LIMPIAR();
                Response.Redirect("~/SPARRPART.aspx");
            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }

        }
        public static string IDGENSET, GENSET, nombre = "";

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;

                string comando = string.Format("SELECT   distinct           SPARTPART.ID, PART, ACCPAC, CATEGORY, STOCK, '$'+format(convert(money,replace(COST,',','.')),'n','de-de') AS [UNIT COST], DISCOUNT+''+'%' AS [%],'$'+DISCOUNT1 AS DISCOUNT,'$'+ format(convert(money,replace(NEXT_COST,',','.')),'n','de-de') AS [NEXT COST],'$'+format(convert(money,replace(GRANT_TOTAL,',','.')),'n','de-de') AS [GRANT TOTAL] , DESCRIPTION,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'SP') THEN '1' ELSE '0' END AS [Attachment QTY], USER_LOGIN FROM            edgar2211.SPARTPART LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.SPARTPART.accpac = edgar2211.DOCUMENT_SHOP.GENSET and SPARTPART.accpac = DOCUMENT_SHOP.GENSET  WHERE SPARTPART." + DROPCAMPO.Text + " like '%" + TXTHASTA.Text + "%'  order by ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
                SUMAR();

            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }

        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView1.Rows[valor].Cells[2].Text;
                    GENSET = GridView1.Rows[valor].Cells[4].Text;

                    Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "SP");
                    Response.Redirect("~/SPARRPART.aspx");
                }
                catch (Exception ERROR)
                {
                    LBLESTADO.Text = ERROR.Message;

                }

            }

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
                    string CADENA = string.Format("insert into DOCUMENT_SHOP values('" + id + "','" + GridView1.SelectedRow.Cells[4].Text + "','" + nombre + "',GETDATE(),'" + GetTime() + "','" + "SP" + "')");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    //DATOS();
                }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }

}
}