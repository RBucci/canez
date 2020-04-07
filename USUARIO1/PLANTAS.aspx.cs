using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CanezPower.USUARIO1
{
    public partial class PLANTAS : System.Web.UI.Page
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

            ModelState.AddModelError("", "bien");

            MOTRAL_GENSET();

            ver_NEW_site_();
            HORAS();
            //TextBox1.Attributes.Add("onkeypress", "cambiaFoco('btnbuscar_Click')");
            Panel1.DefaultButton = btnbuscar.ID;
        }


        void HORAS()
        {

            //try
            //{
            //    string COMANDO = string.Format("SELECT DISTINCT SITE, GENSET, MAX(HOUR_MASTER_READING) AS [HOUR MASTER READING] FROM            edgar2211.technical GROUP BY SITE, GENSET ");
            //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //    GridView2.DataSource = DS.Tables[0];
            //    GridView2.DataBind();
            //}
            //catch (Exception)
            //{
                
                
            //}


        }



        void ver_NEW_site_()
        {
            try
            {

                if (!Page.IsPostBack)
                {
                    MOSTRALCADENA();

                    //string COMANDO = string.Format("select site from site");
                    //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    //DROPSITE.DataSource = DS.Tables[0];
                    //DROPSITE.DataTextField = "site";
                    //DROPSITE.DataBind();


                    //string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                    //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    //DROPCLIEN.DataSource = DS1.Tables[0];
                    //DROPCLIEN.DataTextField = "COMPANY_NAME";
                    //DROPCLIEN.DataBind();


                    //string COMANDO12 = string.Format("select GENSET from gensetuniot");
                    //DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                    //DROPGENSET.DataSource = DS12.Tables[0];
                    //DROPGENSET.DataTextField = "GENSET";
                    //DROPGENSET.DataBind();

                    //string COMANDO123 = string.Format("select NICK_NAME from employeet");
                    //DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                    //CBASING.DataSource = DS123.Tables[0];
                    //CBASING.DataTextField = "NICK_NAME";
                    //CBASING.DataBind();
                }


            }
            catch (Exception)
            {


            }

        }

        void MOSTRALCADENA()
        {

            if (!Page.IsPostBack)
            {

                //string COMANDO = string.Format("select site from site");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //DROPSITE0.DataSource = DS.Tables[0];
                //DROPSITE0.DataTextField = "site";
                //DROPSITE0.DataBind();


                //string COMANDO1 = string.Format("select COMPANY_NAME from clienst");
                //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //DROPCLIEN.DataSource = DS1.Tables[0];
                //DROPCLIEN.DataTextField = "COMPANY_NAME";
                //DROPCLIEN.DataBind();


                //string COMANDO12 = string.Format("select GENSET from gensetuniot");
                //DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                //DROPGENSET0.DataSource = DS12.Tables[0];
                //DROPGENSET0.DataTextField = "GENSET";
                //DROPGENSET0.DataBind();

                //string COMANDO123 = string.Format("select NICK_NAME from employeet");
                //DataSet DS123 = CLASS_CONECTAR.CONECTAR(COMANDO123);
                //CBASING0.DataSource = DS123.Tables[0];
                //CBASING0.DataTextField = "NICK_NAME";
                //CBASING0.DataBind();
            }

        }




        protected void BTNEXPO_Click(object sender, EventArgs e)
        {

        }
        void MOTRAL_GENSET()
        {

            try
            {
                if (!Page.IsPostBack)
                {
                    string COMANDO = String.Format("EXEC MOSTRAR_PLANTAS");



                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }
            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }



        }
        protected void BTNEXPO_Click1(object sender, EventArgs e)
        {

        }

        void contract()
        {


                 try
            {

                if (checleasing.Checked)
            {

                string COMANDO = String.Format("EXEC MOSTRAR_PLANTAS_CONTRAC'" + checleasing.Text + "'");



                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

            }
            else if (checrentail.Checked)
            {
                string COMANDO = String.Format("EXEC MOSTRAR_PLANTAS_CONTRAC'" + checrentail.Text + "'");



                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            else if (checoym.Checked)
            {
                string COMANDO = String.Format("EXEC MOSTRAR_PLANTAS_CONTRAC'" + checoym.Text + "'");



                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
                 }catch(Exception error){

                     LBLESTADO.Text = error.Message;


                 }
        }



        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
        public string COMANDO = "";

        protected void BTNGUARDAR_Click(object sender, EventArgs e)
        {

        }




    

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

             //if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "MATRICULA")
             //   {


            COMANDO = GridView1.SelectedRow.Cells[11].Text.ToString();

            //string cmd = "NEWPLAN.aspx?id=" + COMANDO;
            //Session.Add("LK", COMANDO);

            //Server.Transfer("NEWPLAN.aspx");
            //Response.Redirect("NEWPLAN.aspx?id=" + COMANDO);
            //NEWPLAN NE = new NEWPLAN();
         






//            A) Pasarlo por la querystring. 

            Response.Redirect("NEWPLAN.aspx?MyVar=" + COMANDO.ToString()); 

//Y para recuperarlo en la siguiente pagina 



//B) Usar Variables de session 

//Session.Add("MySessionVar", MyTextBox.Text); 

//Y para recuperarlo en la siguiente pagina 

//String myVar = Session["MyVar"].ToString();


        


            //try
            //{








        }

        protected void DROPCONTRACT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (DROPCONTRACT.Text == "All")
                //{
                //    MOTRAL_GENSET();
                //    string COMANDO = string.Format("select site from site");
                //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //    DROPSITE.DataSource = DS.Tables[0];
                //    DROPSITE.DataTextField = "site";
                //    DROPSITE.DataBind();
                //}
                //else
                //{

                //    string COMANDO = String.Format("SELECT gensetfinal.GENSETID as `Genset ID` ,gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CONTRACT='" + DROPCONTRACT.SelectedValue + "' order by ID desc");



                //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //    GridView1.DataSource = DS.Tables[0];
                //    GridView1.DataBind();


                //    string COMANDO1 = string.Format("select distinct SITE from gensetfinal WHERE CONTRACT='" + DROPCONTRACT.SelectedValue + "'");
                //    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //    DROPSITE.DataSource = DS1.Tables[0];
                //    DROPSITE.DataTextField = "SITE";
                //    DROPSITE.DataValueField = "SITE";
                //    DROPSITE.DataBind();


                //}
            }
            catch (Exception)
            {


            }
        }

        protected void DROPGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //string COMANDO = String.Format("SELECT gensetfinal.GENSETID as `Genset ID` ,gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where GENSET='" + DROPGENSET.SelectedValue + "' order by ID desc");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();

            }
            catch (Exception)
            {


            }
        }

        protected void DROPSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    string COMANDO = String.Format("SELECT gensetfinal.GENSETID as `Genset ID` ,gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where SITE='" + DROPSITE.SelectedValue + "' order by ID desc");
            //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //    GridView1.DataSource = DS.Tables[0];
            //    GridView1.DataBind();

            //}
            //catch (Exception)
            //{


            //}
        }

        protected void CBASING_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //string COMANDO = String.Format("SELECT gensetfinal.GENSETID as `Genset ID` ,gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where TEAM='" + CBASING.SelectedValue + "' order by ID desc");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //GridView1.DataSource = DS.Tables[0];
                //GridView1.DataBind();

            }
            catch (Exception)
            {


            }
        }

        protected void DROPCLIEN_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{

            //    string COMANDO = String.Format("SELECT gensetfinal.GENSETID as `Genset ID` ,,gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CLIENT='" + DROPCLIEN.SelectedValue + "' order by ID desc");
            //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //    GridView1.DataSource = DS.Tables[0];
            //    GridView1.DataBind();

            //}
            //catch (Exception)
            //{


            //}
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (DROPCLIEN.Text== "Genset")
                {
                    string COMANDO = String.Format(" SELECT DISTINCT       edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.gensetfinal.GENSET AS [GENSET MODEL], edgar2211.gensetfinal.GENSETSERIAL AS [GENSET SERIAL],   MAX(edgar2211.technical.HOUR_MASTER_READING) AS [HOUR MASTER READING],   edgar2211.gensetfinal.ENERGIE_MODEL AS [ENERGIE MODEL], edgar2211.gensetfinal.TEAM, edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE AS CONSUMABLES, edgar2211.gensetfinal.ID AS [SYSTEM ID]   FROM   edgar2211.gensetfinal LEFT OUTER JOIN edgar2211.technical ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.technical.GENSET  where edgar2211.gensetfinal.GENSET_MODEL like '%" + TextBox1.Text + "%'  GROUP BY edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL, edgar2211.gensetfinal.GENSETSERIAL, edgar2211.gensetfinal.GENSET, edgar2211.gensetfinal.GENSETID, edgar2211.gensetfinal.TEAM,     edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE,edgar2211.gensetfinal.ID,     edgar2211.gensetfinal.ENERGIE_MODEL");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();

                }
                else
                {
                    string COMANDO = String.Format(" SELECT DISTINCT       edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL AS Genset, edgar2211.gensetfinal.GENSET AS [GENSET MODEL], edgar2211.gensetfinal.GENSETSERIAL AS [GENSET SERIAL],   MAX(edgar2211.technical.HOUR_MASTER_READING) AS [HOUR MASTER READING],   edgar2211.gensetfinal.ENERGIE_MODEL AS [ENERGIE MODEL], edgar2211.gensetfinal.TEAM, edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE AS CONSUMABLES, edgar2211.gensetfinal.ID AS [SYSTEM ID]   FROM   edgar2211.gensetfinal LEFT OUTER JOIN edgar2211.technical ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.technical.GENSET  where edgar2211.gensetfinal." + DROPCLIEN.Text + " like '%" + TextBox1.Text + "%'  GROUP BY edgar2211.gensetfinal.SITE, edgar2211.gensetfinal.GENSET_MODEL, edgar2211.gensetfinal.GENSETSERIAL, edgar2211.gensetfinal.GENSET, edgar2211.gensetfinal.GENSETID, edgar2211.gensetfinal.TEAM,     edgar2211.gensetfinal.CONTRACT, edgar2211.gensetfinal.NOTE,edgar2211.gensetfinal.ID,     edgar2211.gensetfinal.ENERGIE_MODEL");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    if (DS.Tables[0].Rows.Count <= 0)
                    {
                        Response.Write("<script>alert('This item was not found');</script>");
                    }
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind();
                }


               

            }
            catch (Exception E)
            {
                LBLESTADO.Text = E.Message;

            }
        }

        protected void DROPSITE0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (DROPCONTRACT0.Text == "All")
                //{
                //    string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where SITE='" + DROPSITE0.SelectedValue + "' order by ID desc");



                //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //    GridView1.DataSource = DS.Tables[0];
                //    GridView1.DataBind();
                //}
                //else
                //{

                //    string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CONTRACT='" + DROPCONTRACT0.SelectedValue + "' AND    SITE='" + DROPSITE0.SelectedValue + "' order by ID desc");



                //    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //    GridView1.DataSource = DS.Tables[0];
                //    GridView1.DataBind();


                //    //string COMANDO1 = string.Format("select distinct SITE from gensetfinal WHERE CONTRACT='" + DROPCONTRACT.SelectedValue + "'");
                //    //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                //    //DROPSITE.DataSource = DS1.Tables[0];
                //    //DROPSITE.DataTextField = "SITE";
                //    //DROPSITE.DataValueField = "SITE";
                //    //DROPSITE.DataBind();


                //}
            }
            catch (Exception)
            {


            }
        }

        protected void DROPCONTRACT0_SelectedIndexChanged(object sender, EventArgs e)
        {

       
            //try{

            //    if (DROPCONTRACT0.Text == "All")
            //    {
            //        string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal  order by ID desc");



            //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        GridView1.DataSource = DS.Tables[0];
            //        GridView1.DataBind();

            //    }
            //    else
            //    {

            //        //string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CONTRACT='" + DROPCONTRACT0.SelectedValue + "' order by ID desc");



            //        //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        //GridView1.DataSource = DS.Tables[0];
            //        //GridView1.DataBind();





            //    }
            //}
            //catch (Exception)
            //{


            //}
        }

        protected void DROPGENSET0_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (DROPCONTRACT0.Text == "All")
            //    {
            //        string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where SITE='" + DROPSITE0.SelectedValue + "'and GENSET='" + DROPGENSET0.SelectedValue + "'  order by ID desc");



            //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        GridView1.DataSource = DS.Tables[0];
            //        GridView1.DataBind();
            //    }
            //    else
            //    {

            //        string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CONTRACT='" + DROPCONTRACT0.SelectedValue + "' AND    SITE='" + DROPSITE0.SelectedValue + "'and GENSET='" + DROPGENSET0.SelectedValue + "'  order by ID desc");



            //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        GridView1.DataSource = DS.Tables[0];
            //        GridView1.DataBind();


            //        //string COMANDO1 = string.Format("select distinct SITE from gensetfinal WHERE CONTRACT='" + DROPCONTRACT.SelectedValue + "'");
            //        //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
            //        //DROPSITE.DataSource = DS1.Tables[0];
            //        //DROPSITE.DataTextField = "SITE";
            //        //DROPSITE.DataValueField = "SITE";
            //        //DROPSITE.DataBind();


            //    }
            //}
            //catch (Exception)
            //{


            //}
        }

        protected void CBASING0_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    if (DROPCONTRACT0.Text == "All")
            //    {
            //        string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where SITE='" + DROPSITE0.SelectedValue + "'and GENSET='" + DROPGENSET0.SelectedValue + "'and  TEAM='" + CBASING0.SelectedValue + "'  order by ID desc");



            //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        GridView1.DataSource = DS.Tables[0];
            //        GridView1.DataBind();
            //    }
            //    else
            //    {

            //        string COMANDO = String.Format("SELECT gensetfinal.SITE AS `SITE NAME`,gensetfinal.GENSET_MODEL as `GENSET` ,gensetfinal.GENSET AS `Genset Model`,gensetfinal.GENSETSERIAL AS `Genset serial #`,gensetfinal.ENERGIE_MODEL AS `Engine Model`,gensetfinal.TEAM AS Team,gensetfinal.CONTRACT AS Contract,gensetfinal.NOTE AS Comsumables,gensetfinal.ID as `SYSTEM ID`  FROM gensetfinal where CONTRACT='" + DROPCONTRACT0.SelectedValue + "' AND    SITE='" + DROPSITE0.SelectedValue + "'and GENSET='" + DROPGENSET0.SelectedValue + "'and  TEAM='" + CBASING0.SelectedValue + "'  order by ID desc");



            //        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
            //        GridView1.DataSource = DS.Tables[0];
            //        GridView1.DataBind();


            //        //string COMANDO1 = string.Format("select distinct SITE from gensetfinal WHERE CONTRACT='" + DROPCONTRACT.SelectedValue + "'");
            //        //DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
            //        //DROPSITE.DataSource = DS1.Tables[0];
            //        //DROPSITE.DataTextField = "SITE";
            //        //DROPSITE.DataValueField = "SITE";
            //        //DROPSITE.DataBind();


            //    }
            //}
            //catch (Exception)
            //{


            //}
        }

        protected void btnbuscar0_Click(object sender, EventArgs e)
        {
            contract();
        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {

        }

        protected void HyperLink1_Load(object sender, EventArgs e)
        {
            COMANDO = "---";
            Session.Add("LK", COMANDO);
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
          

              

         


        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowIndex == 0)
                    e.Row.Style.Add("height", "50px");
            }
        }

      

       
    }
}