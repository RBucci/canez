using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO1
{
    public partial class GAIA : System.Web.UI.Page
    {

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
                try
                {
                    string COMANDO1 = string.Format("select ENEGIE from ENERGIE");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    DROPENGINE.DataSource = DS1.Tables[0];
                    DROPENGINE.DataTextField = "ENEGIE";
                    DROPENGINE.DataBind();



                    string COMANDO = string.Format("select CATEGORY from CXATEGORY_GAIA");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    CATEGORY.DataSource = DS.Tables[0];
                    CATEGORY.DataTextField = "CATEGORY";
                    CATEGORY.DataBind();

                    //MOTRAL_GENSET();
                    BTNGUARDAR.Enabled = true;
                    BTNEDIT.Enabled = false;
                    BTNDELETE.Enabled = false;
                }
                catch (Exception)
                {

                  
                }

            }

            //TXTUSUARIO.Attributes.Add("onkeypress", "cambiaFoco('BTNBUSCAR_Click')");
            Panel1.DefaultButton = BTNBUSCAR.ID;
        }



        public static string nombre, id, file1;
        protected void BTNGUARDAR_Click1(object sender, EventArgs e)
        {
            try
            {


                if (File.Exists(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName))
                {
                    LBLESTADO.Text = "There is a file with this name, already exist, please change the name to be able to upload it to server";
                }
                else
                {
                    FileUpload1.SaveAs(Server.MapPath(".") + "/canezpdf/" + FileUpload1.FileName);

                    LBLESTADO.Text = "se realizo correctamente";
                    nombre = "http://canezpowerdivision.com/canezpdf/" + FileUpload1.FileName;
                    string CADENA = string.Format("EXEC NEW_GAIA'"+TXTSECTION.Text+"','"+CATEGORY.Text+"','"+ DROPENGINE.Text+ "','"+TXTDESCRIPTION.Text+"','"+ GetTime()+"','"+nombre.ToString()+"'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    Response.Redirect("~/GAIA.aspx");
                    //DATOS();
                }
            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = ERROR.Message;

            }
        }

        protected void TXTEDIT_Click(object sender, EventArgs e)
        {
            try
            {
               
                string CADENA = string.Format("EXEC EDIT_GAIA'"+id+"','" + TXTSECTION.Text + "','" + CATEGORY.Text + "','" + DROPENGINE.Text + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/GAIA.aspx");
            }
            catch (Exception)
            {

                
            }

        }

        protected void TXTDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string CADENA = string.Format("DELETE FROM TBGAIA  WHERE ID='" + GridView1.SelectedRow.Cells[2].Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                Response.Redirect("~/GAIA.aspx");
            }
            catch (Exception)
            {

                
            }
        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string CADENA = string.Format("SELECT * FROM TBGAIA  WHERE " + DROPENGINE1.Text+" like '%" + TXTUSUARIO.Text + "%' order by id desc ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {

              
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "btver")
            {

                try
                {

                    int valor = Convert.ToInt32(e.CommandArgument);
                    string CADENA = string.Format("SELECT * FROM TBGAIA  WHERE ID='" + GridView1.Rows[valor].Cells[2].Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    file1 = DS.Tables[0].Rows[0]["DOCUMENT"].ToString();
                    Response.Write("<script>window.open('" +file1+ "' )</script>");


                }
                catch (Exception)
                {


                }
            }
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

         
            BTNGUARDAR.Enabled = false;
            BTNEDIT.Enabled = true;
            BTNDELETE.Enabled = true;

            string COMANDO = GridView1.SelectedRow.Cells[2].Text;

            string COMANDO12 = string.Format("select * from TBGAIA where ID='" + COMANDO + "'order by ID desc");

            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
            id = COMANDO;
            TXTSECTION.Text = DS.Tables[0].Rows[0]["SECTION"].ToString();

            CATEGORY.Text = DS.Tables[0].Rows[0]["CATEGORY"].ToString();

            DROPENGINE.Text = DS.Tables[0].Rows[0]["ENGINE"].ToString();

            TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}