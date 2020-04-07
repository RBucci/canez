using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower
{
    public partial class Training : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        public static string nombre, id, file1;
        protected void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {


                //if (File.Exists(Server.MapPath(".") + "/VIDEO/" + FileUpload1.FileName))
                //{
                //    LBLESTADO.Text = "There is a file with this name, already exist, please change the name to be able to upload it to server";
                //}
                //else
                //{
                    //for (int i = 0; i < Context.Request.Files.Count; i++)
                    //{

                        LBLESTADO.Text = "se realizo correctamente";

                        //HttpPostedFile file = Context.Request.Files[i];
                        //nombre = String.Format("{0}_{1:yyyyMMdd_hhmm}.{2}", DateTime.Now);
                        nombre = String.Format("{0}_{1:yyyyMMdd_hhmm}.{2}", Path.GetFileNameWithoutExtension(FileUpload1.FileName), DateTime.Now, Path.GetExtension(FileUpload1.FileName));
                  
                        //ruta1 = Server.MapPath("canezpdf");
                        FileUpload1.SaveAs(Server.MapPath(".") + "/VIDEO/" + nombre);
                        //nombre = "http://canezpowerdivision.com/VIDEO/" + FileUpload1.FileName;
                        string CADENA = string.Format("EXEC NEW_TRAINING'" + TXTSECTION.Text + "','" + TXTDESCRIPTION.Text + "','" + GetTime() + "','" + "http://canezpowerdivision.com/VIDEO/" + nombre.ToString() + "'");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                        LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                        Response.Redirect("~/SEE_TRAINING.aspx");
                        //DATOS();
                    //}
                //}
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
                    string CADENA = string.Format("SELECT * FROM TRAINING  WHERE ID='" + GridView1.Rows[valor].Cells[2].Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                    file1 = DS.Tables[0].Rows[0]["USER1"].ToString();
                    Response.Write("<script>window.open('" + file1 + "' )</script>");


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





                //verpdf();

                BTNGUARDAR.Enabled = false;
                //BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;

                string COMANDO = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO12 = string.Format("select * from TRAINING where ID='" + COMANDO + "'order by ID desc");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                id = COMANDO;
                TXTSECTION.Text = DS.Tables[0].Rows[0]["NAME"].ToString();

                

                TXTDESCRIPTION.Text = DS.Tables[0].Rows[0]["DESCRIPTION"].ToString();
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
                string CADENA = string.Format("select * from TRAINING where freetext(*, '" + TXTUSUARIO.Text + "' )order by id desc");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {





                //verpdf();

                BTNGUARDAR.Enabled = false;
                //BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;

                string COMANDO = GridView1.SelectedRow.Cells[2].Text;

                string COMANDO12 = string.Format("DELETE from TRAINING where ID='" + COMANDO + "'");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
                Response.Redirect("~/SEE_TRAINING.aspx");
            }
            catch (Exception)
            {

            }
        }
}
}