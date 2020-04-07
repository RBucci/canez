using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class CATEGORY_GAIA : System.Web.UI.Page
    {
        public static string comando = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                ver_NEW_site_();
            }
            //TextBox1.Attributes.Add("onkeypress", "cambiaFoco('btnbuscar_Click')");
            Panel1.DefaultButton = btnbuscar.ID;
        }


        void NEW_site()
        {
            try
            {

                string COMANDO = string.Format("INSERT INTO CXATEGORY_GAIA  VALUES('" + TextBox1.Text + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                ver_NEW_site_();
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/CATEGORY_GAIA.aspx");
            }
            catch (Exception)
            {


            }

        }


        void ver_NEW_site_()
        {
            try
            {
                string COMANDO = string.Format("select * from CXATEGORY_GAIA ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();



            }
            catch (Exception)
            {


            }

        }

        protected void BTNEXPO_Click(object sender, EventArgs e)
        {

            try
            {
                string coman = string.Format("select * from CXATEGORY_GAIA where CATEGORY = '" + TextBox1.Text + "' ");
                DataSet ds = CLASS_CONECTAR.CONECTAR(coman);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    LBLESTADO.Text = "ESTE SITE YA EXISTE";
                }
                else
                {
                    NEW_site();
                }


            }
            catch (Exception E)
            {

                LBLESTADO.Text = E.Message;

            }



        }
        public string site = "";
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {




                comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("select  * FROM CXATEGORY_GAIA WHERE ID='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                TextBox1.Text = DS.Tables[0].Rows[0]["CATEGORY"].ToString();
                TextBox2.Text = DS.Tables[0].Rows[0]["CATEGORY"].ToString();

            }
            catch (Exception)
            {


            }
        }

        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {


                if (TextBox2.Text == "")
                {
                    LBLESTADO.Text = "TIENE QUE SELECCIONAR UN SITE PARA EDITARLO";
                }
                else
                {




                    string CADENA23 = string.Format("select  * FROM CXATEGORY_GAIA WHERE CATEGORY = '" + TextBox2.Text + "'");
                    DataSet DS23 = CLASS_CONECTAR.CONECTAR(CADENA23);
                    string CON = DS23.Tables[0].Rows[0]["CATEGORY"].ToString();
                    if (DS23.Tables[0].Rows.Count > 0)
                    {
                        //comando = GridView1.SelectedRow.Cells[2].Text;
                        string CADENA = string.Format("update CXATEGORY_GAIA set CATEGORY='" + TextBox1.Text + "' WHERE CATEGORY = '" + CON + "'");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);

                        //string CADENA2 = string.Format("update SPARTPART set CATEGORY='" + TextBox1.Text + "' WHERE CATEGORY = '" + CON + "'");
                        //DataSet DS2 = CLASS_CONECTAR.CONECTAR(CADENA2);









                        ver_NEW_site_();
                        LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    }
                    else
                    {
                        LBLESTADO.Text = "NO EXISTE PARA EDITARLO";
                    }

                }
                Response.Redirect("~/CATEGORY_GAIA.aspx");


            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                //comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("delete from CXATEGORY_GAIA WHERE ID ='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                ver_NEW_site_();
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/CATEGORY_GAIA.aspx");
            }
            catch (Exception)
            {


            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string COMANDO = string.Format("select * from CXATEGORY_GAIA where CATEGORY like'%" + TextBox1.Text + "%'  ORDER BY id asc");
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
    }
}