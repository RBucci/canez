using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CanezPower
{
    public partial class NEW_SITE : System.Web.UI.Page
    {
        public static string comando = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.DefaultButton = btnbuscar.ID;
            ver_NEW_site_();
           // TextBox1.Attributes.Add("onkeypress", "cambiaFoco('btnbuscar_Click')");
        }


        void NEW_site()
        {
            try
            {

                string COMANDO = string.Format("INSERT INTO site  VALUES('" + TextBox1.Text + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                ver_NEW_site_();
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/NEW_SITE.aspx");
            }
            catch (Exception )
            {


            }

        }


        void ver_NEW_site_()
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    string COMANDO = string.Format("select * from site ORDER BY id asc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }


            }
            catch (Exception )
            {


            }

        }

        protected void BTNEXPO_Click(object sender, EventArgs e)
        {

            try
            {
                string coman = string.Format("select * from site where site = '"+TextBox1.Text+"' ");
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
                 string CADENA = string.Format("select  * FROM site WHERE id='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
               TextBox1.Text= DS.Tables[0].Rows[0]["site"].ToString();
               TextBox2.Text = DS.Tables[0].Rows[0]["site"].ToString();
                
            }
            catch (Exception )
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




                    string CADENA23 = string.Format("select  * FROM site WHERE site = '" + TextBox2.Text + "'");
                    DataSet DS23 = CLASS_CONECTAR.CONECTAR(CADENA23);
                    string CON = DS23.Tables[0].Rows[0]["site"].ToString();
                    if (DS23.Tables[0].Rows.Count > 0)
                    {
                        //comando = GridView1.SelectedRow.Cells[2].Text;
                        string CADENA = string.Format("update site set site='" + TextBox1.Text + "' WHERE site = '" + CON + "'");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);

                        string CADENA2 = string.Format("update gensetfinal set SITE='" + TextBox1.Text + "' WHERE SITE = '" + CON + "'");
                        DataSet DS2 = CLASS_CONECTAR.CONECTAR(CADENA2);

                        string CADENA1 = string.Format("update ttn set SITE='" + TextBox1.Text + "' WHERE SITE = '" + CON + "'");
                        DataSet DS1 = CLASS_CONECTAR.CONECTAR(CADENA1);




                      



                        //string CADENA3 = string.Format("update technical set SITE ='" + TextBox1.Text + "' WHERE SITE LIKE '%" + site + "%'");
                        //DataSet DS3 = CLASS_CONECTAR.CONECTAR(CADENA3);
                        ver_NEW_site_();
                        LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    }
                    else
                    {
                        LBLESTADO.Text = "NO EXISTE PARA EDITARLO";
                    }
                    
                }

                Response.Redirect("~/NEW_SITE.aspx");

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
                 string CADENA = string.Format("delete from site WHERE id ='"+ comando+ "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                ver_NEW_site_();
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/NEW_SITE.aspx");
            }
            catch (Exception )
            {


            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
              

                    string COMANDO = string.Format("select * from site where site like'%" + TextBox1.Text + "%'  ORDER BY id asc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                    
              


            }
            catch (Exception )
            {


            }
        }
        }
    }
