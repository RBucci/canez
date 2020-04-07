using System;
using System.Data;
using System.Web.UI;

namespace CanezPower.USUARIO2
{
    public partial class GENSETMOVEMENT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                MOSTRAR();
            }
            Panel1.DefaultButton = btnbuscar.ID;
        }

        void MOSTRAR()
        {


            try
            {
                GridView1.DataSourceID = null;
                string COMAN = string.Format("select ID, DATE, SITE AS [FROM], GENSET, SERIAL,NEW_SITE AS [NEW SITE], NOTE, USER1 AS [CREATE BY] from  GENSET_MOVEMENT ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMAN);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            catch (Exception)
            {

                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    GridView1.DataSourceID = null;
                    string COMAN = string.Format("DELETE from  GENSET_MOVEMENT WHERE ID='"+GridView1.SelectedRow.Cells[2].Text+"'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMAN);
                    Response.Redirect("~/GENSETMOVEMENT.aspx");
                }
                catch (Exception)
                {


                }

            }
            catch (Exception)
            {

             
            }

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSourceID = null;
                string COMAN = string.Format("select ID, DATE, SITE AS [FROM], GENSET, SERIAL,NEW_SITE AS [NEW SITE], NOTE, USER1 AS [CREATE BY] from  GENSET_MOVEMENT WHERE "+DROPCLIEN.Text+" LIKE '%"+TextBox1.Text+"%' ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMAN);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {

              
            }
        }

        protected void btnbuscar0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                GridView1.DataSourceID = null;
                string COMAN = string.Format("select ID, DATE, SITE AS [FROM], GENSET, SERIAL,NEW_SITE AS [NEW SITE], NOTE, USER1 AS [CREATE BY] from  GENSET_MOVEMENT WHERE ( DATE >='"+ TextBox2.Text+"')AND (DATE <='"+TextBox3.Text+"') ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMAN);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSourceID = null;
                string COMAN = string.Format("select ID, DATE, SITE AS [FROM], GENSET, SERIAL,NEW_SITE AS [NEW SITE], NOTE, USER1 AS [CREATE BY] from  GENSET_MOVEMENT WHERE " + DROPCLIEN.Text + " LIKE '%" + TextBox1.Text + "%' AND ( DATE >='" + TextBox2.Text + "')AND (DATE <='" + TextBox3.Text + "') ORDER BY ID DESC");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMAN);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}