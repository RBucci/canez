﻿using System;
using System.Web.UI;
using System.Data;

namespace CanezPower
{
    public partial class GENSETUNIT : System.Web.UI.Page
    {

        public static string comando = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                ver_NEW_GENSET_();
            }
            //TextBox1.Attributes.Add("onkeypress", "cambiaFoco('btnbuscar_Click')");
            Panel1.DefaultButton = btnbuscar.ID;
        }
        void ver_NEW_GENSET_()
        {
            try
            {

                string COMANDO = string.Format("select * from gensetuniot");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception )
            {


            }

        }


        void NEW_GENSET()
        {
            try
            {

                string COMANDO = string.Format("insert into gensetuniot(GENSET)values('" + TextBox1.Text + "')");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                ver_NEW_GENSET_();
                Response.Redirect("~/GENSETUNIT.aspx");

            }
            catch (Exception )
            {


            }



        }

        protected void BTNEXPO_Click(object sender, EventArgs e)
        {



            string coman = string.Format("select * from gensetuniot where GENSET = '" + TextBox1.Text + "' ");
                DataSet ds = CLASS_CONECTAR.CONECTAR(coman);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //LBLESTADO.Text = "ESTE SITE YA EXISTE";
                   
                }
                else
                {
            NEW_GENSET();
                }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("select  * FROM gensetuniot WHERE id='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                TextBox1.Text = DS.Tables[0].Rows[0]["GENSET"].ToString();

            }
            catch (Exception )
            {


            }
        }

        protected void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {


                string CADENA23 = string.Format("select * FROM gensetuniot WHERE id = '" + comando+ "'");
                    DataSet DS23 = CLASS_CONECTAR.CONECTAR(CADENA23);
                    string CON = DS23.Tables[0].Rows[0]["GENSET"].ToString();
                    if (DS23.Tables[0].Rows.Count > 0)
                    {
                        string CADENA = string.Format("update gensetuniot set GENSET='" + TextBox1.Text + "' WHERE id='" + comando + "'");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);



                        string CADENA2 = string.Format("update gensetfinal set GENSET='" + TextBox1.Text + "' WHERE GENSET = '" + CON + "'");
                        DataSet DS2 = CLASS_CONECTAR.CONECTAR(CADENA2);
                    
                    
                    }




                //comando = GridView1.SelectedRow.Cells[2].Text;


                    Response.Redirect("~/GENSETUNIT.aspx");
                ver_NEW_GENSET_();

            }
            catch (Exception )
            {


            }
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                //comando = GridView1.SelectedRow.Cells[2].Text;
                string CADENA = string.Format("delete from gensetuniot WHERE id='" + comando + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(CADENA);
                ver_NEW_GENSET_();
                Response.Redirect("~/GENSETUNIT.aspx");
            }
            catch (Exception )
            {


            }
        }



        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string COMANDO = string.Format("select * from gensetuniot where GENSET like'%" + TextBox1.Text + "%'  ORDER BY id asc");
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