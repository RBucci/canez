using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanezPower.USUARIO1
{
    public partial class STOCKOUT : System.Web.UI.Page
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
            // TextBox1.Attributes.Add("onkeypress", "cambiaFoco('Button6_Click')");
            Panel1.DefaultButton = Button1.ID;
            if (!Page.IsPostBack)
            {


                string COMANDO = string.Format("SELECT DISTINCT edgar2211.site.site FROM edgar2211.site INNER JOIN edgar2211.gensetfinal ON edgar2211.site.site = edgar2211.gensetfinal.SITE");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                DROPSITE.DataSource = DS.Tables[0];
                DROPSITE.DataTextField = "site";
                DROPSITE.DataBind();


                //string COMANDO1 = string.Format("select COMPANY_NAME from CLIENST");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //CBTEAM.DataSource = DS1.Tables[0];
                //CBTEAM.DataTextField = "COMPANY_NAME";
                //CBTEAM.DataBind();

                string COMANDO123 = string.Format("select NICK_NAME from employeet");
                DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                DROPTEAM.DataSource = DS123.Tables[0];
                DROPTEAM.DataTextField = "NICK_NAME";
                DROPTEAM.DataBind();
                DROPSITE_SelectedIndexChanged(null, null);

                DROPGENSET_SelectedIndexChanged(null, null);

                TXTACCPAC.Text = "";
                TXTQTY.Text = "";
                string COMANDO12 = string.Format("select PART from SPARTPART");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                DROPPART.DataSource = DS12.Tables[0];
                DROPPART.DataTextField = "PART";
                DROPPART.DataBind();

                DROPPART_SelectedIndexChanged(null, null);
                //string COMANDO1 = string.Format("select ACCPAC from SPARTPART");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //DROPA.DataSource = DS1.Tables[0];
                //DROPA.DataTextField = "ACCPAC";
                //DROPA.DataBind();
                //DROPA_SelectedIndexChanged(null, null);
                MOSTRAR();


                VER12();


            }
        }

        void VER12()
        {
            try
            {
                string COMANDO = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE       EOMONTH(edgar2211.SPARTPART.DATE)  = EOMONTH(GETDATE())");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO0.Text = DS.Tables[0].Rows[0]["TOTAL"].ToString();
            }
            catch (Exception)
            {


            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                int CANTI = Convert.ToInt32(TXTCANTI.Text);
                int NEWCANTI = Convert.ToInt32(TXTQTY.Text);
                DROPA_SelectedIndexChanged(null, null);

                if (TXTCANTI.Text == "0" || TXTCANTI.Text == "")
                {
                    LBLESTADO.Text = "THIS PRODUCT IS SOLD OUT I CAN NOT CHARGE IT";
                }
                else if (NEWCANTI <= 0)
                {
                    LBLESTADO.Text = "THE QUANTITY DOES NOT ADJUST WHAT'S IN WAREHOUSE";
                }
                else if (NEWCANTI > CANTI)
                {
                    LBLESTADO.Text = "THE QUANTITY DOES NOT ADJUST WHAT'S IN WAREHOUSE";
                }
                else
                {


                    int CANTIFIN = CANTI - NEWCANTI;



                    string COMAN1 = string.Format("SELECT * FROM SPARTPART  WHERE ACCPAC='" + TXTACCPAC.Text + "'");
                    DataSet DS21 = CLASS_CONECTAR.CONECTAR(COMAN1);
                    double VALOR = Convert.ToDouble(DS21.Tables[0].Rows[0]["NEXT_COST"].ToString());

                    double final = CANTIFIN * VALOR;





                    string COMAN = string.Format("UPDATE SPARTPART SET STOCK ='" + CANTIFIN.ToString() + "',GRANT_TOTAL='" + final.ToString() + "' WHERE ACCPAC='" + TXTACCPAC.Text + "'");
                    DataSet DS2 = CLASS_CONECTAR.CONECTAR(COMAN);


                    if (TXTSERIAL.Text == string.Empty)
                    {
                        string comando = string.Format("EXEC NEW_STOCK_OUTER '" + DROPTEAM.Text + "','" + "BACKUP=>" + DROPSITE.Text + "','" + DROPPART.Text + "','" + TXTACCPAC.Text + "','" + TXTQTY.Text + "','" + TXTDESCRIPTION0.Text + "','" + GetTime() + "'");
                        DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                        LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                        MOSTRAR();
                        LIMPIAR();
                        DROPA_SelectedIndexChanged(null, null);
                        Response.Redirect("~/STOCKOUT.aspx");
                    }
                    else
                    {
                        string comando = string.Format("EXEC NEW_STOCK_OUTER '" + DROPTEAM.Text + "','" + TXTSERIAL.Text + "','" + DROPPART.Text + "','" + TXTACCPAC.Text + "','" + TXTQTY.Text + "','" + TXTDESCRIPTION0.Text + "','" + GetTime() + "'");
                        DataSet ds = CLASS_CONECTAR.CONECTAR(comando);
                        LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                        MOSTRAR();
                        LIMPIAR();
                        DROPA_SelectedIndexChanged(null, null);
                        Response.Redirect("~/STOCKOUT.aspx");

                    }





                }

            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = ERROR.Message;
            }
        }
        protected void DROPSITE_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + DROPSITE.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                DROPGENSET.DataSource = DS12.Tables[0];
                DROPGENSET.DataTextField = "GENSET_MODEL";
                DROPGENSET.DataValueField = "GENSET_MODEL";
                DROPGENSET.DataBind();
                DROPGENSET_SelectedIndexChanged(null, null);
                DROPGENSET.Items.Insert(0, new ListItem("BACKUP"));
            }
            catch (Exception)
            {

                //LBLESTADO.Text = ERROR.Message;
            }

        }
        protected void DROPGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("select * from gensetfinal where SITE='" + DROPSITE.SelectedValue + "' and GENSET_MODEL='" + DROPGENSET.SelectedValue + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                if (DROPGENSET.Text == "BACKUP")
                {
                    TXTSERIAL.Text = "";
                }
                else
                {
                    TXTSERIAL.Text = DS12.Tables[0].Rows[0]["GENSETSERIAL"].ToString();
                }

            }
            catch (Exception)
            {

                //LBLESTADO.Text = ERROR.Message;
            }
        }
        void LIMPIAR()
        {

            TXTQTY.Text = "";
            TXTDESCRIPTION0.Text = "";

        }
        void MOSTRAR()
        {

            try
            {
                string COMANDO = string.Format("EXEC VER_MOSTRA_STOCK_OUTER");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {


            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string COMANDO = GridView1.SelectedRow.Cells[2].Text;
            string PART = GridView1.SelectedRow.Cells[9].Text;
            string QTY = GridView1.SelectedRow.Cells[12].Text;
            string CADENA = string.Format("SELECT * FROM SPARTPART WHERE ACCPAC='" + PART + "'");
            DataSet DS1 = CLASS_CONECTAR.CONECTAR(CADENA);
            string STOCK = DS1.Tables[0].Rows[0]["STOCK"].ToString();
            double INTQTY = Convert.ToInt32(QTY);
            double INTSTOCK = Convert.ToInt32(STOCK);
            double TOTAL = INTQTY + INTSTOCK;


            string COMAN1 = string.Format("SELECT * FROM SPARTPART  WHERE ACCPAC='" + PART + "'");
            DataSet DS21 = CLASS_CONECTAR.CONECTAR(COMAN1);
            double VALOR = Convert.ToDouble(DS21.Tables[0].Rows[0]["NEXT_COST"]);

            double final = VALOR * TOTAL;



            string CADENA1 = string.Format("UPDATE SPARTPART SET STOCK ='" + TOTAL.ToString() + "',GRANT_TOTAL='" + final.ToString() + "' WHERE ACCPAC='" + PART + "'");
            DataSet DS11 = CLASS_CONECTAR.CONECTAR(CADENA1);

            string coman = string.Format("delete from STOCK_OUTER WHERE  ID='" + COMANDO + "'");
            DataSet DS = CLASS_CONECTAR.CONECTAR(coman);
            LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
            MOSTRAR();
            LIMPIAR();
            final = 0;
            VALOR = 0;
            Response.Redirect("~/STOCKOUT.aspx");
        }
        protected void DROPA_SelectedIndexChanged(object sender, EventArgs e)
        {



            try
            {

                //string COMANDO1 = string.Format("select * from SPARTPART WHERE ACCPAC='" + DROPA.SelectedValue + "'");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);

                //TXTDESCRIPTION.Text = DS1.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                //TXTCANTI.Text = DS1.Tables[0].Rows[0]["STOCK"].ToString();

            }
            catch (Exception)
            {


            }
        }
        protected void DROPPART_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                string COMANDO1 = string.Format("select * from SPARTPART WHERE PART='" + DROPPART.SelectedValue + "'");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                TXTACCPAC.Text = DS1.Tables[0].Rows[0]["ACCPAC"].ToString();
                TXTDESCRIPTION.Text = DS1.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                TXTCANTI.Text = DS1.Tables[0].Rows[0]["STOCK"].ToString();
            }
            catch (Exception)
            {


            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {


                if (DROPCAMPO.Text == "GENSET")
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE edgar2211.gensetfinal.GENSET_MODEL like '%" + TextBox1.Text + "%' order by ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE edgar2211.gensetfinal.GENSET_MODEL like '%" + TextBox1.Text + "%'");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();


                }
                if (DROPCAMPO.Text == "SITE")
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                         edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE edgar2211.gensetfinal.site like '%" + TextBox1.Text + "%' order by ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE edgar2211.gensetfinal.site like '%" + TextBox1.Text + "%'");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();
                }
                else
                {

                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                         edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE STOCK_OUTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%' order by STOCK_OUTER.ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();


                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE STOCK_OUTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%'");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();

                }
            }
            catch (Exception)
            {


            }
        }
        protected void Button6_Click1(object sender, EventArgs e)
        {
            GridView1.DataSourceID = null;
            if (DROPCAMPO.Text == "SITE" && TextBox1.Text == "")
            {
                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                        edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') order by ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();



                string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE  (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();


            }
            else if (DROPCAMPO.Text != "SITE" && TextBox1.Text == "")
            {

                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                         edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') order by ID DESC");

                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();



                string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE  (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();


            }
            if (DROPCAMPO.Text == "SITE" && TextBox1.Text != "")
            {
                string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                       edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE edgar2211.gensetfinal.site like '%" + TextBox1.Text + "%' and  (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "')   order by ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                if (DS.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('This item was not found');</script>");
                }
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();




                string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE   edgar2211.gensetfinal.site like '%" + TextBox1.Text + "%' and   (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();




            }
            else

                if (DROPCAMPO.Text == "GENSET" && TextBox1.Text == "")
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,                     edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE      (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') order by ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE   (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();



                }
                else if (DROPCAMPO.Text != "GENSET" && TextBox1.Text == "")
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET, edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') order by ID DESC");

                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();


                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE   (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();



                }
                else if (DROPCAMPO.Text == "GENSET" && TextBox1.Text != "")
                {
                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,  edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE edgar2211.gensetfinal.GENSET_MODEL like '%" + TextBox1.Text + "%' and  (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "')   order by ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();


                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                      edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE   edgar2211.gensetfinal.GENSET_MODEL like '%" + TextBox1.Text + "%' and   (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();



                }
                else if (DROPCAMPO.Text != "GENSET" && TextBox1.Text != "")
                {

                    string COMANDO = string.Format("SELECT   DISTINCT     edgar2211.STOCK_OUTER.ID, edgar2211.STOCK_OUTER.DATE, edgar2211.STOCK_OUTER.TEAM, edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS GENSET,        edgar2211.STOCK_OUTER.GENSET_SERIAL, edgar2211.STOCK_OUTER.PART, edgar2211.STOCK_OUTER.ACCPAC,SPARTPART.CATEGORY,'$'+edgar2211.SPARTPART.NEXT_COST as COST, edgar2211.STOCK_OUTER.QTY,(cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float)) as TOTAL, edgar2211.STOCK_OUTER.NOTE,                          edgar2211.STOCK_OUTER.USER1 FROM  edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL LEFT OUTER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC  WHERE STOCK_OUTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%' and  (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "')   order by ID DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                    string COMANDO1 = string.Format("SELECT sum((cast(edgar2211.SPARTPART.NEXT_COST as float)*cast(edgar2211.STOCK_OUTER.QTY as float))) as TOTAL FROM edgar2211.gensetfinal RIGHT OUTER JOIN                         edgar2211.STOCK_OUTER ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.STOCK_OUTER.GENSET_SERIAL INNER JOIN                         edgar2211.SPARTPART ON edgar2211.STOCK_OUTER.ACCPAC = edgar2211.SPARTPART.ACCPAC    WHERE   STOCK_OUTER." + DROPCAMPO.Text + " like '%" + TextBox1.Text + "%' and    (edgar2211.STOCK_OUTER.DATE>='" + TXTDESDE.Text + "')AND(edgar2211.STOCK_OUTER.DATE<='" + TXTHASTA.Text + "') ");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    LBLESTADO1.Text = DS1.Tables[0].Rows[0]["TOTAL"].ToString();

                }


        }
    }
}