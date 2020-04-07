using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CanezPower
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string DS2 ="";
        public static string DS3 = "";
        //int cn = 1;


        Label lbl = new Label();
        public static string DSSITE, VC="";
        protected void BTNLOGIN_Click(object sender, EventArgs e)
        {


            try
            {



                if (TXTUSUARIO.Text.ToLower() == "admin" && TXTCLAVE.Text.ToLower() == "admin")
                {
                    this.Session["OTROS"] = TXTUSUARIO.Text.ToString().ToUpper();
                    this.Session["OTROSID"] = TXTUSUARIO.Text;
                    //DS2 = this.Session["OTROS2"].ToString();
                    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(TXTUSUARIO.Text.ToString().ToUpper(), false);

                    Response.Redirect("~/otheruser/iniciouserother.aspx?MyVar=" + DSSITE);


                }




            }
            catch (Exception ERROR)
            {

                //LBLESTADO.Text = "USER AND PASS INCORRECT >" + ERROR.Message;
            }





            try
            {
                string COMANDO = string.Format("exec LOGIN'" + TXTUSUARIO.Text + "','" + TXTCLAVE.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                TextBox txt = new TextBox();
                string USER = DS.Tables[0].Rows[0]["NAME1"].ToString().ToLower();
                string PASS = DS.Tables[0].Rows[0]["PASSWORD1"].ToString().ToLower();
                DS2 = DS.Tables[0].Rows[0]["NAME1"].ToString();
                string tipo = DS.Tables[0].Rows[0]["USER1"].ToString();
                string LEVEL = DS.Tables[0].Rows[0]["LEVEL1"].ToString();
                VC = DS.Tables[0].Rows[0]["VC"].ToString();
                if (TXTUSUARIO.Text.ToLower() == USER && TXTCLAVE.Text.ToLower() == PASS)
                {
                    if (tipo == "YES")
                    {

                        if (LEVEL == "3")
                        {


                            if(VC=="YES"){
                            
                            this.Session["usuario"] = USER.ToString().ToUpper();
                            this.Session["usuarioid"] = PASS;
                            DS2 = this.Session["usuario"].ToString();
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);
                            Response.Redirect("~/ValerioCanez/ValerioCanezGenset.aspx?user=" + USER.ToString().ToUpper());

                            }else{
                            
                            
                            this.Session["usuario"] = USER.ToString().ToUpper();
                            this.Session["usuarioid"] = PASS;
                            DS2 = this.Session["usuario"].ToString();
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);
                            Response.Redirect("~/INICIO.aspx?user=" + USER.ToString().ToUpper());

                            }


                            //this.Session["usuario"] = USER.ToString().ToUpper();
                            //this.Session["usuarioid"] = PASS;
                            //DS2 = this.Session["usuario"].ToString();
                            //System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);
                            //Response.Redirect("~/INICIO.aspx?user=" + USER.ToString().ToUpper());



                            //LBLESTADO.Text = "bien";

                        }
                        else if (LEVEL == "2")
                        {


                            this.Session["usuario"] = USER.ToString().ToUpper();
                            this.Session["usuarioid"] = PASS;
                            DS2 = this.Session["usuario"].ToString();
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);
                            Response.Redirect("~/USUARIO2/INICIO1.aspx");

                        
                            //LBLESTADO.Text = "bien";
                        }
                        else if (LEVEL == "1")
                        {


                            this.Session["usuario"] = USER.ToString().ToUpper();
                            this.Session["usuarioid"] = PASS;
                            DS2 = this.Session["usuario"].ToString();
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);

                            Response.Redirect("~/USUARIO1/INICIO1.aspx");
                            //LBLESTADO.Text = "bien";
                        }



                    }
                    else
                    {
                        LBLESTADO.Text = "DOES NOT HAVE ACCESS TO THE SYSTEM ASK THE ADMINISTRATOR";


                    }

                }



                else
                {

                    LBLESTADO.Text = "DOES NOT HAVE ACCESS TO THE SYSTEM ASK THE ADMINISTRATOR";

                }





            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = "USER AND PASS INCORRECT >" + ERROR.Message;
            }




            ///////otros usuarios



            try
            {
                string COMANDO = string.Format("SELECT * FROM otheruser WHERE USERNAME='" + TXTUSUARIO.Text + "' AND PASS='" + TXTCLAVE.Text + "'");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                TextBox txt = new TextBox();
                string USER = DS.Tables[0].Rows[0]["USERNAME"].ToString().ToLower();
                string PASS = DS.Tables[0].Rows[0]["PASS"].ToString().ToLower();
                DSSITE = DS.Tables[0].Rows[0]["SITE"].ToString();
               

                if (TXTUSUARIO.Text.ToLower() == USER && TXTCLAVE.Text.ToLower() == PASS)
                {
                    this.Session["OTROS"] = USER.ToString().ToUpper();
                    this.Session["OTROSID"] = PASS;
                    //DS2 = this.Session["OTROS2"].ToString();
                    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(USER.ToString().ToUpper(), false);

                    Response.Redirect("~/otheruser/iniciouserother.aspx?MyVar=" + DSSITE);


                }




            }
            catch (Exception ERROR)
            {

                LBLESTADO.Text = "USER AND PASS INCORRECT >" + ERROR.Message;
            }







            











        }



        private  void  consultar(string user, string pass)
        {


        }








       
        protected void Timer2_Tick(object sender, EventArgs e)
        {
            
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            
            

        }
}
}