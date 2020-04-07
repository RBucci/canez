using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO2
{
    public partial class SEE_TRAINING : System.Web.UI.Page
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
        public static string nombre, id, file1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public static string resul = "";
        //void verpdf()
        //{
        //    //GAIA gai = new GAIA();
        //    //try
        //    //{


        //    string COMANDO = GridView1.SelectedRow.Cells[2].Text;

        //    string COMANDO12 = string.Format("select * from TBGAIA where ID='" + COMANDO + "'order by ID desc");

        //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
        //    resul = DS.Tables[0].Rows[0]["DOCUMENT"].ToString();
        //    //Nuevo control HTML y Buscamos dentro del ContentPlaceHolder del sitio llamado "contenido"
        //    //  HtmlControl frame1 = (HtmlControl)gai.FindControl("MyIframe");
        //    ////Asignamos a la propiedad "src" la ruta donde se genero el archivo
        //    //  frame1.Attributes["src"] = DS.Tables[0].Rows[0]["DOCUMENT"].ToString();
        //    //}
        //    //catch (Exception)
        //    //{


        //    //}
        //}

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
        public static string resul = "";
        void verpdf()
        {
            GAIA gai = new GAIA();
            //try
            //{


            string COMANDO = GridView1.SelectedRow.Cells[2].Text;

            string COMANDO12 = string.Format("select * from TRAINING where ID='" + COMANDO + "'order by ID desc");

            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO12);
            resul = DS.Tables[0].Rows[0]["USER1"].ToString();
            //Nuevo control HTML y Buscamos dentro del ContentPlaceHolder del sitio llamado "contenido"
            //  HtmlControl frame1 = (HtmlControl)gai.FindControl("MyIframe");
            ////Asignamos a la propiedad "src" la ruta donde se genero el archivo
            //  frame1.Attributes["src"] = DS.Tables[0].Rows[0]["DOCUMENT"].ToString();
            //}
            //catch (Exception)
            //{


            //}
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verpdf();
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
    }
}