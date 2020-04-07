using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CanezPower
{
    public partial class NEWPLAN : System.Web.UI.Page
    {



        public System.Security.Principal.IPrincipal User
        {
            get;
            [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, ControlPrincipal = true)]
            set;
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






        public  string SERIAL = "";
      
        public string model = "";
        public string site = "";
        public int palo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ver_NEW_site_();
                //SERIAL = (string)(Session["LK"]);
                SERIAL = Request.QueryString.Get("MyVar");
                LBLESTADO.Text = SERIAL;
                //SERIAL = Request.QueryString.Get("id");
                //LBLESTADO.Text = (string)(Session["LK"]); ;

                //LBLESTADO.Text = SERIAL.ToString();
            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;
               
            }
          


            if (string.IsNullOrEmpty(SERIAL) )
            {
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;

            }
            else
            {
                if (!Page.IsPostBack)
                {
                    MOSTRAL1();
                }  
            }
       
         
        }

        public static string SIT,GEN,GENSERIAL;
     public void MOSTRAL1()
        {       


                try
                {

                   

                    BTNGUARDAR.Enabled = false;
                    BTNDELETE.Enabled = true;
                    BTNEDIT.Enabled = true;
                    string comando = string.Format("exec bus'" + Request.QueryString.Get("MyVar") + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(comando);

                    //if (DS.Tables[0].Rows.Count > 0)
                    //{
                    DROPGENSET.SelectedValue = DS.Tables[0].Rows[0]["GENSET"].ToString();
                    TXTGENSETID.Text = DS.Tables[0].Rows[0]["GENSETID"].ToString();
                    TXTGENSETSERIAL.Text = DS.Tables[0].Rows[0]["GENSETSERIAL"].ToString();
                GENSERIAL = DS.Tables[0].Rows[0]["GENSETSERIAL"].ToString();

                TXTGENSETMODEL.Text = DS.Tables[0].Rows[0]["GENSET_MODEL"].ToString();
                    GEN = DS.Tables[0].Rows[0]["GENSET_MODEL"].ToString();
                    TXTMODEL.Text = DS.Tables[0].Rows[0]["ENERGIE_MODEL"].ToString();
                    TXTSERIAL.Text = DS.Tables[0].Rows[0]["ENIGIEL_SERIAL"].ToString();
                    TXTPANERLMODEL.Text = DS.Tables[0].Rows[0]["PANEL_MODEL"].ToString();
                    TXTBREACKCAPACITY.Text = DS.Tables[0].Rows[0]["BREAKER_CAPACYTY"].ToString();
                    DROPSITE.Text = DS.Tables[0].Rows[0]["SITE"].ToString();
                    SIT = DS.Tables[0].Rows[0]["SITE"].ToString();
                    DROPCONTRACT.Text = DS.Tables[0].Rows[0]["CONTRACT"].ToString();
                    DROPCLIEN.Text = DS.Tables[0].Rows[0]["CLIENT"].ToString();
                    CBASING.Text = DS.Tables[0].Rows[0]["TEAM"].ToString();
                    TXTNOTE.Text = DS.Tables[0].Rows[0]["NOTE"].ToString();
               
                    TXTNOTE2.Text = DS.Tables[0].Rows[0]["NOTE2"].ToString();
                 



                   



                }
                catch (Exception error)
                {



                    LBLESTADO.Text = error.Message;


                }



        }



        void NEW_GENSET()
        {
            try
            {
                try
                {
                    string COMANDO1 = string.Format("SELECT * FROM site where ='"+DROPSITE.Text+"'");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    site = ds.Tables[0].Rows[0][""].ToString();



                }
                catch (Exception error)
                {

                    LBLESTADO.Text = error.Message;
                }










                string VALIDADR = string.Format("SELECT * FROM gensetfinal WHERE GENSETSERIAL ='"+TXTGENSETSERIAL.Text+"'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(VALIDADR);
                if (DS12.Tables[0].Rows.Count > 0)
                {
                    LBLESTADO.Text="YA ESTE GENSET ESTA AGREGADO";
                }
                else
                {
                    SERIAL = "";
                  

                    string COMANDO = string.Format("EXEC  NEW_GENSET'" + DROPSITE.Text + "','" + DROPCLIEN.Text + "','" + DROPGENSET.Text + "','" + DROPCONTRACT.Text + "','" + TXTGENSETID.Text + "','" + TXTGENSETSERIAL.Text + "','" + TXTGENSETMODEL.Text + "','" + TXTMODEL.Text + "','" + TXTSERIAL.Text + "','" + TXTPANERLMODEL.Text + "','" + TXTBREACKCAPACITY.Text + "','" + CBASING.Text + "','" + TXTNOTE.Text + "','" + GetTime() + "','" + TXTNOTE2.Text + "'");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                    Response.Redirect("~/PLANTAS.aspx");
                }

                


            }
            catch (Exception ERROR)
            {
                LBLESTADO.Text = "ERROR EN LA OPERACION  " + ERROR.Message;

            }

        }


        void ver_NEW_site_()
        {
            try
            {

                if (!Page.IsPostBack)
                {

                    string COMANDO = string.Format("select site from site");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    DROPSITE.DataSource = DS.Tables[0];
                    DROPSITE.DataTextField = "site";
                    DROPSITE.DataBind();


                    string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    DROPCLIEN.DataSource = DS1.Tables[0];
                    DROPCLIEN.DataTextField = "COMPANY_NAME";
                    DROPCLIEN.DataBind();


                    string COMANDO12 = string.Format("select GENSET from gensetuniot");
                    DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    DROPGENSET.DataSource = DS12.Tables[0];
                    DROPGENSET.DataTextField = "GENSET";
                    DROPGENSET.DataBind();

                    string COMANDO123 = string.Format("select NICK_NAME from employeet");
                    DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                    CBASING.DataSource = DS123.Tables[0];
                    CBASING.DataTextField = "NICK_NAME";
                    CBASING.DataBind();


                }


            }
            catch (Exception error)
            {
                LBLESTADO.Text = error.Message;

            }

        }

        protected void BTNGUARDAR_Click(object sender, EventArgs e)
        {


            try
            {
                string COMANDO1 = string.Format("INSERT INTO GENSET_MOVEMENT VALUES (GETDATE(),'" + "" + "','" + TXTGENSETMODEL.Text + "','" + TXTGENSETSERIAL.Text + "','" + DROPSITE.Text + "','" + TXTNOTE2.Text + "','" + GetTime() + "')");
                DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);

            }
            catch (Exception error)
            {

                LBLESTADO.Text = error.Message;
            }



            NEW_GENSET();
        }

 
        protected void BTNEDIT_Click(object sender, EventArgs e)
        {


            ACTUALIZAR_GENSET();
         
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
           // palo = palo + 7;
           //MOSTRAL1();
           
        }

        void ACTUALIZAR_GENSET()
        {

            try
            {

                if (DROPSITE.Text != SIT)
                {
                    string COMANDO1 = string.Format("INSERT INTO GENSET_MOVEMENT VALUES (GETDATE(),'" + SIT + "','" + TXTGENSETMODEL.Text + "','" + TXTGENSETSERIAL.Text + "','" + DROPSITE.Text + "','" + TXTNOTE2.Text + "','"+GetTime()+"')");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);


                }


                palo = palo + 7;
                int id = Convert.ToInt32(Request.QueryString.Get("MyVar"));
                LBLESTADO.Text = id.ToString();
                string COMANDO = string.Format("exec ACTULIZAR_GENSET'" + LBLESTADO.Text + "','" + TXTGENSETSERIAL.Text + "','" + DROPSITE.Text + "','" + DROPCLIEN.Text + "','" + DROPGENSET.Text + "','" + DROPCONTRACT.Text + "','" + TXTGENSETID.Text + "','" + TXTGENSETMODEL.Text + "','" + TXTMODEL.Text + "','" + TXTSERIAL.Text + "','" + TXTPANERLMODEL.Text + "','" + TXTBREACKCAPACITY.Text + "','" + CBASING.Text + "','" + TXTNOTE.Text + "','" + TXTNOTE2.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                if (TXTGENSETSERIAL.Text == GENSERIAL)
                {
                    //ESTA PARTE AFECTA EL SERIAL
                    //SHOP
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE shop SET Genset_Serial='" + TXTGENSETSERIAL.Text + "' WHERE Genset_Serial='" + GENSERIAL.ToString() + "' ");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    }
                    catch (Exception)
                    {

                    }

                    //SHOP
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE shop SET Genset_Serial='" + TXTGENSETSERIAL.Text + "' WHERE Genset_Serial='" + GENSERIAL.ToString() + "' ");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    }
                    catch (Exception)
                    {

                    }



                }


                if (TXTGENSETMODEL.Text != GEN)
                {
                   


                    //ESTA PARTE AFECTA EL GENSET
                    //SERVICE
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE technical SET GENSET='"+TXTGENSETMODEL.Text+"' WHERE GENSET='"+GEN.ToString()+"' AND SITE='"+DROPSITE.Text+"' ");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    }
                    catch (Exception)
                    {

                        
                    }

                    //CM
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE cm2 SET Genset='" + TXTGENSETMODEL.Text + "' WHERE Genset='" + GEN.ToString() + "' AND Site='" + DROPSITE.Text + "'");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    }
                    catch (Exception)
                    {

                        
                    }

                    //CMFF
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE CM SET GENSET='" + TXTGENSETMODEL.Text + "' WHERE GENSET='" + GEN.ToString() + "' AND SITE='" + DROPSITE.Text + "'");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);

                    }
                    catch (Exception)
                    {

                       
                    }
                    //LOP

                    try
                    {
                        string COMANDO12 = string.Format("UPDATE TBLOG SET GENSET='" + TXTGENSETMODEL.Text + "' WHERE GENSET='" + GEN.ToString() + "' AND SITE='" + DROPSITE.Text + "'");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);

                    }
                    catch (Exception)
                    {


                    }
                    //READING
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE TBREADING SET GENSET='" + TXTGENSETMODEL.Text + "' WHERE GENSET='" + GEN.ToString() + "' AND SITE='" + DROPSITE.Text + "'");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);

                    }
                    catch (Exception)
                    {


                    }


                    //READING
                    try
                    {
                        string COMANDO12 = string.Format("UPDATE TBREADING SET GENSET='" + TXTGENSETMODEL.Text + "' WHERE GENSET='" + GEN.ToString() + "' AND SITE='" + DROPSITE.Text + "'");
                        DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);

                    }
                    catch (Exception)
                    {


                    }



                }



                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                Response.Redirect("~/PLANTAS.aspx");




               
            }
            catch (Exception EROR)
            {
                LBLESTADO.Text = EROR.Message;
            }

        }


        void DELETE_GENSET()
        {

           try
            {
                string COMANDO = string.Format("DELETE FROM gensetfinal WHERE GENSETSERIAL='" + TXTGENSETSERIAL.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                LBLESTADO.Text = "SE REALIZO CORRECTAMENTE";
                SERIAL = "";
                Response.Redirect("~/PLANTAS.aspx");
            }
            catch (Exception)
            {
                
            }
        

        }





        protected void BTNVER_Click(object sender, EventArgs e)
        {
         
        }

        protected void BTNDELETE_Click(object sender, EventArgs e)
        {
            DELETE_GENSET();
        }


    }
}