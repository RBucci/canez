using System;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CanezPower.otheruser
{
    public partial class iniciouserother : System.Web.UI.Page
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

        public static string SERIAL="";
        protected void Page_Load(object sender, EventArgs e)
        {

            SERIAL = Request.QueryString.Get("MyVar");
            if (!Page.IsPostBack)
            {

                //string COMANDO = string.Format("select site from site");
                //DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                //CBSITE.DataSource = DS.Tables[0];
                //CBSITE.DataTextField = "site";
                //CBSITE.DataBind();
                CBSITE.Text = SERIAL;
                GridView6.DataSourceID = null;

                GridView5.DataSourceID = null;
                GridView5.DataSource = null;


                GridView2.DataSourceID = null;
                GridView2.DataSource = null;
                GridView4.DataSourceID = null;
                GridView4.DataSource = null;

                GridView3.DataSourceID = null;
                GridView3.DataSource = null;

                GridView9.DataSourceID = null;
                GridView9.DataSource = null;
                CBSITE_SelectedIndexChanged(null, null);

                CHECKALGENSET.Checked = true;
                chetall.Checked = true;
                BTNBUSCAR_Click(null, null);
            }

            if (GetTime()=="ADMIN")
            {
                BTNBUSCAR.Enabled = false;
                BTNBUSCAR0.Enabled = false;
                CBGENSET.Enabled = false;
                BTNBUSCAR1.Enabled = false;
            }


            CBSITE.Text = SERIAL;
        }

        protected void CBSITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO12 = string.Format("select GENSET_MODEL from gensetfinal where SITE='" + CBSITE.Text + "'");
                DataSet DS12 = CLASS_CONECTAR.CONECTAR(COMANDO12);
                CBGENSET.DataSource = DS12.Tables[0];
                CBGENSET.DataTextField = "GENSET_MODEL";
                CBGENSET.DataValueField = "GENSET_MODEL";
                CBGENSET.DataBind();
            }
            catch (Exception)
            {

                //LBLESTADO.Text = ERROR.Message;
            }

        }

        protected void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            if (CHECKALGENSET.Checked == true)
            {


                if (chetall.Checked == true)
                {
                    ////BUSQUEDA POR SITE
                    string COMANDO1 = string.Format("SELECT  DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service],  edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]FROM            edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET      where edgar2211.technical.SITE = '" + CBSITE.Text + "' order by technical.ID desc");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(COMANDO1);
                    GridView6.DataSource = DS1.Tables[0];
                    GridView6.DataBind();




                    string comando2 = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM    edgar2211.gensetfinal INNER JOIN   edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN                         edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id  WHERE gensetfinal.SITE = '" + CBSITE.Text + "'   ORDER BY Shop.Id DESC");
                    DataSet DS2 = CLASS_CONECTAR.CONECTAR(comando2);
                    GridView5.DataSource = DS2.Tables[0];
                    GridView5.DataBind();

                    string COMANDO4 = string.Format(" SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  cm.id = DOCUMENT_SHOP.id_genset  WHERE cm.SITE='" + CBSITE.Text + "'  order by cm.ID desc");
                    DataSet DS4 = CLASS_CONECTAR.CONECTAR(COMANDO4);

                    GridView4.DataSource = DS4.Tables[0];
                    GridView4.DataBind();




                    string COMANDO5 = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "'  order by ttn.TTN_ID desc");

                    DataSet DS5 = CLASS_CONECTAR.CONECTAR(COMANDO5);
                    GridView3.DataSource = DS5.Tables[0];
                    GridView3.DataBind();



                    string COMANDO6 = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm2.id = DOCUMENT_SHOP.id_genset    WHERE cm2.Site ='" + CBSITE.Text + "'   order by cm2.id desc");
                    DataSet DS6 = CLASS_CONECTAR.CONECTAR(COMANDO6);

                    GridView2.DataSource = DS6.Tables[0];
                    GridView2.DataBind();


                    string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE TBLOG.Site ='" + CBSITE.Text + "'  order by TBLOG.id desc");
                    DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                    GridView9.DataSource = DS7.Tables[0];
                    GridView9.DataBind();




                    ///////////////////////



                }
                else
                {

                    if (checkmaintenance.Checked == true)
                    {


                        ///BUSQUEDA POR SITE INDIVIDUAL
                        try
                        {

                            string COMANDO = string.Format("SELECT  DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service],  edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]FROM            edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET               where edgar2211.technical.SITE = '" + CBSITE.Text + "'  order by technical.ID desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView6.DataSource = DS.Tables[0];
                            GridView6.DataBind();


                        }
                        catch (Exception)
                        {
                            //lblshop.Text = error.Message;

                        }


                    }
                    else
                    {
                        GridView6.DataSource = null;
                        GridView6.DataBind();
                    }
                    if (CHECKLOG.Checked == true)
                    {
                        try
                        {
                            string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on    edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and    TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE TBLOG.Site ='" + CBSITE.Text + "'   order by TBLOG.id desc");
                            DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                            GridView9.DataSource = DS7.Tables[0];
                            GridView9.DataBind();
                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView9.DataSource = null;
                        GridView9.DataBind();

                    }
                    if (CHECKSHOP.Checked == true)
                    {
                        try
                        {
                            string comando = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User]  FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id WHERE gensetfinal.SITE = '" + CBSITE.Text + "'  ORDER BY Shop.Id DESC");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                            GridView5.DataSource = DS.Tables[0];
                            GridView5.DataBind();


                        }
                        catch (Exception)
                        {

                            //lblshop.Text = ERROR.Message;
                        }
                    }
                    else
                    {
                        GridView5.DataSource = null;
                        GridView5.DataBind();
                    }

                    if (CHECKCM.Checked == true)
                    {
                        try
                        {
                            string COMANDO = string.Format(" SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm.id = DOCUMENT_SHOP.id_genset  WHERE cm.SITE='" + CBSITE.Text + "'  order by cm.ID desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView4.DataSource = DS.Tables[0];
                            GridView4.DataBind();

                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView4.DataSource = null;
                        GridView4.DataBind();

                    }




                    if (CEHPTTN.Checked == true)
                    {
                        try
                        {

                            string COMANDO = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and  ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "'  order by ttn.TTN_ID desc");

                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                            GridView3.DataSource = DS.Tables[0];
                            GridView3.DataBind();


                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView3.DataSource = null;
                        GridView3.DataBind();

                    }

                    if (CHECKFFCM.Checked == true)
                    {

                        try
                        {
                            string COMANDO = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  cm2.id = DOCUMENT_SHOP.id_genset      WHERE cm1.Site ='" + CBSITE.Text + "'  order by cm2.id desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView2.DataSource = DS.Tables[0];
                            GridView2.DataBind();



                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView2.DataSource = null;
                        GridView2.DataBind();
                    }






                }
                ////////FINAL DE BUSQUEDA POR SITE
            }
            else

            {
                if (chetall.Checked == true)
                {


                    ////BUSQUEDA POR SITE Y GENSET HAY QUE HACER EL CAMBIO A SERIAL LA RELACION


                    string COMANDO = string.Format("SELECT  DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service],  edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]FROM            edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET               where SITE = '" + CBSITE.Text + "' AND  GENSET='" + CBGENSET.Text + "'   order by technical.ID desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    GridView6.DataSource = DS.Tables[0];
                    GridView6.DataBind();




                    string comando1 = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id  WHERE gensetfinal.SITE = '" + CBSITE.Text + "'  AND gensetfinal.GENSET_MODEL='" + CBGENSET.Text + "'  ORDER BY Shop.Id DESC");
                    DataSet DS1 = CLASS_CONECTAR.CONECTAR(comando1);
                    GridView5.DataSource = DS1.Tables[0];
                    GridView5.DataBind();


                    string COMANDO1 = string.Format("SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset  where cm.SITE='" + CBSITE.Text + "' AND cm.GENSET='" + CBGENSET.Text + "'  order by cm.ID desc");
                    DataSet DS2 = CLASS_CONECTAR.CONECTAR(COMANDO1);

                    GridView4.DataSource = DS2.Tables[0];
                    GridView4.DataBind();



                    string COMANDO3 = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and   ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "'    order by ttn.TTN_ID desc");

                    DataSet DS3 = CLASS_CONECTAR.CONECTAR(COMANDO3);
                    GridView3.DataSource = DS3.Tables[0];
                    GridView3.DataBind();



                    string COMANDO4 = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm2.id = DOCUMENT_SHOP.id_genset  WHERE cm2.Site ='" + CBSITE.Text + "' AND  cm2.Genset='" + CBGENSET.Text + "'    order by cm2.id desc");
                    DataSet DS4 = CLASS_CONECTAR.CONECTAR(COMANDO4);

                    GridView2.DataSource = DS4.Tables[0];
                    GridView2.DataBind();




                    string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE TBLOG.Site ='" + CBSITE.Text + "' AND TBLOG.Genset='" + CBGENSET.Text + "'   order by TBLOG.id desc");
                    DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                    GridView9.DataSource = DS7.Tables[0];
                    GridView9.DataBind();




                }
                else
                {

                    if (checkmaintenance.Checked == true)
                    {
                        try
                        {
                            string COMANDO = string.Format(" SELECT DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN(DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS[Next Service], edgar2211.technical.VERIFICATION AS[Need a Review ?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS[Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS[Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS[Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS[Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS[Oil Qty(gl)], edgar2211.technical.OIL_DIFERENT AS[Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS[Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS[Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS[Pre - fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS[Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS[Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS[Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN(DOCUMENT_SHOP.id_genset<> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS[User Login]FROM edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET                where SITE = '" + CBSITE.Text + "' AND  GENSET='" + CBGENSET.Text + "'  order by technical.ID desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView6.DataSource = DS.Tables[0];
                            GridView6.DataBind();


                        }
                        catch (Exception)
                        {


                        }


                    }
                    else
                    {
                        GridView6.DataSource = null;
                        GridView6.DataBind();
                    }

                    if (CHECKLOG.Checked == true)
                    {
                        try
                        {
                            string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE TBLOG.Site ='" + CBSITE.Text + "' and TBLOG.Genset='" + CBGENSET.Text + "'     order by TBLOG.id desc");
                            DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                            GridView9.DataSource = DS7.Tables[0];
                            GridView9.DataBind();
                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView9.DataSource = null;
                        GridView9.DataBind();

                    }



                    if (CHECKSHOP.Checked == true)
                    {
                        try
                        {
                            string comando = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id  WHERE gensetfinal.SITE = '" + CBSITE.Text + "'  AND gensetfinal.GENSET_MODEL='" + CBGENSET.Text + "' ORDER BY Shop.Id DESC");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                            GridView5.DataSource = DS.Tables[0];
                            GridView5.DataBind();


                        }
                        catch (Exception)
                        {

                            //lblshop.Text = ERROR.Message;
                        }
                    }
                    else
                    {
                        GridView5.DataSource = null;
                        GridView5.DataBind();
                    }

                    if (CHECKCM.Checked == true)
                    {
                        try
                        {
                            string COMANDO = string.Format("SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm.id = DOCUMENT_SHOP.id_genset WHERE cm.SITE='" + CBSITE.Text + "' AND cm.GENSET='" + CBGENSET.Text + "'  order by cm.ID desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView4.DataSource = DS.Tables[0];
                            GridView4.DataBind();

                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView4.DataSource = null;
                        GridView4.DataBind();

                    }




                    if (CEHPTTN.Checked == true)
                    {
                        try
                        {

                            string COMANDO = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and   ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "'  order by ttn.TTN_ID desc");

                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                            GridView3.DataSource = DS.Tables[0];
                            GridView3.DataBind();


                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView3.DataSource = null;
                        GridView3.DataBind();

                    }

                    if (CHECKFFCM.Checked == true)
                    {

                        try
                        {
                            string COMANDO = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on   edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm2.id = DOCUMENT_SHOP.id_genset WHERE cm2.Site ='" + CBSITE.Text + "' AND  cm2.Genset='" + CBGENSET.Text + "'   order by cm2.id desc");
                            DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                            GridView2.DataSource = DS.Tables[0];
                            GridView2.DataBind();



                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {
                        GridView2.DataSource = null;
                        GridView2.DataBind();
                    }

                }





            }


        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PLANTAS.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MANTENARCE.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SHOP.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CM.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CM2.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WAMDY.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PANEL_CODES.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SPARRPART.aspx");
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/SPENDINGTRANCK.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/INVOICES.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TTN.aspx");
        }

        protected void BTNBUSCAR0_Click(object sender, EventArgs e)
        {
            if (chekonlydate.Checked == true)
            {
                /////////////

                try
                {


                    string COMANDO45 = string.Format("SELECT  DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN (DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS [Next Service],  edgar2211.technical.VERIFICATION AS [Need a Review?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS [Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS [Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS [Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS [Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS [Oil Qty (gl)], edgar2211.technical.OIL_DIFERENT AS [Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS [Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS [Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS [Pre-fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS [Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS [Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS [Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS [User Login]FROM            edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET       where (technical.DATE1>='" + TXTDESDE.Text + "') AND (technical.DATE1<='" + TXTHASTA.Text + "')  order by technical.DATE1 desc");
                    DataSet DS45 = CLASS_CONECTAR.CONECTAR(COMANDO45);

                    GridView6.DataSource = DS45.Tables[0];
                    GridView6.DataBind();


                }
                catch (Exception)
                {
                    GridView6.DataSource = null;
                    GridView6.DataBind();

                }





                try
                {
                    string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE (TBLOG.Date>='" + TXTDESDE.Text + "') and (TBLOG.Date<='" + TXTHASTA.Text + "')  order by TBLOG.Date desc");
                    DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                    GridView9.DataSource = DS7.Tables[0];
                    GridView9.DataBind();
                }
                catch (Exception)
                {
                    GridView9.DataSource = null;
                    GridView9.DataBind();

                }



                try
                {
                    string comando = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id WHERE  (shop.Date>='" + TXTDESDE.Text + "')AND(shop.Date<='" + TXTHASTA.Text + "')   ORDER BY Shop.Id DESC");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                    GridView5.DataSource = DS.Tables[0];
                    GridView5.DataBind();


                }
                catch (Exception)
                {
                    GridView5.DataSource = null;
                    GridView5.DataBind();
                }


                try
                {
                    string COMANDO = string.Format("SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and cm.id = DOCUMENT_SHOP.id_genset WHERE  (CM.DATE1>='" + TXTDESDE.Text + "')AND(CM.DATE1<='" + TXTHASTA.Text + "')  order by cm.ID desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    GridView4.DataSource = DS.Tables[0];
                    GridView4.DataBind();

                }
                catch (Exception)
                {
                    GridView4.DataSource = null;
                    GridView4.DataBind();

                }





                try
                {

                    string COMANDO = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on  edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and   ttn.ttn_id = DOCUMENT_SHOP.id_genset  where  (ttn.TARGET_DATE>='" + TXTDESDE.Text + "')AND(ttn.TARGET_DATE<='" + TXTHASTA.Text + "')   order by ttn.TTN_ID desc");

                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                    GridView3.DataSource = DS.Tables[0];
                    GridView3.DataBind();


                }
                catch (Exception)
                {
                    GridView3.DataSource = null;
                    GridView3.DataBind();

                }



                try
                {
                    string COMANDO = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and cm2.id = DOCUMENT_SHOP.id_genset  WHERE  (cm2.Date>='" + TXTDESDE.Text + "')AND(cm2.Date<='" + TXTHASTA.Text + "')  order by cm2.id desc");
                    DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                    GridView2.DataSource = DS.Tables[0];
                    GridView2.DataBind();



                }
                catch (Exception)
                {
                    GridView2.DataSource = null;
                    GridView2.DataBind();

                }












                /////////////

            }
            else if (CHECKALGENSET.Checked == true)
            {


                if (checkmaintenance.Checked == true)
                {
                    try
                    {

                        string COMANDO = string.Format(" SELECT DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN(DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS[Next Service], edgar2211.technical.VERIFICATION AS[Need a Review ?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS[Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS[Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS[Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS[Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS[Oil Qty(gl)], edgar2211.technical.OIL_DIFERENT AS[Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS[Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS[Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS[Pre - fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS[Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS[Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS[Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN(DOCUMENT_SHOP.id_genset<> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS[User Login]FROM edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON  edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and  edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET                where edgar2211.technical.SITE = '" + CBSITE.Text + "'AND (technical.DATE1>='" + TXTDESDE.Text + "')AND(technical.DATE1<='" + TXTHASTA.Text + "') order by ID desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView6.DataSource = DS.Tables[0];
                        GridView6.DataBind();


                    }
                    catch (Exception)
                    {
                        //lblshop.Text = error.Message;

                    }


                }
                else
                {
                    GridView6.DataSource = null;
                    GridView6.DataBind();
                }


                if (CHECKLOG.Checked == true)
                {
                    try
                    {
                        string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE (TBLOG.Date>='" + TXTDESDE.Text + "')and(TBLOG.Date<='" + TXTHASTA.Text + "')   order by TBLOG.id desc");
                        DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                        GridView9.DataSource = DS7.Tables[0];
                        GridView9.DataBind();
                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView9.DataSource = null;
                    GridView9.DataBind();

                }

                if (CHECKSHOP.Checked == true)
                {
                    try
                    {
                        string comando = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id  WHERE    gensetfinal.SITE = '" + CBSITE.Text + "'AND (shop.Date>='" + TXTDESDE.Text + "')AND(shop.Date<='" + TXTHASTA.Text + "')   ORDER BY Shop.Id DESC");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                        GridView5.DataSource = DS.Tables[0];
                        GridView5.DataBind();


                    }
                    catch (Exception)
                    {

                        //lblshop.Text = ERROR.Message;
                    }
                }
                else
                {
                    GridView5.DataSource = null;
                    GridView5.DataBind();
                }

                if (CHECKCM.Checked == true)
                {
                    try
                    {
                        string COMANDO = string.Format("SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm.id = DOCUMENT_SHOP.id_genset WHERE cm.SITE='" + CBSITE.Text + "'AND (CM.DATE1>='" + TXTDESDE.Text + "')AND(CM.DATE1<='" + TXTHASTA.Text + "')   order by cm.ID desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView4.DataSource = DS.Tables[0];
                        GridView4.DataBind();

                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView4.DataSource = null;
                    GridView4.DataBind();

                }




                if (CEHPTTN.Checked == true)
                {
                    try
                    {

                        string COMANDO = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on   edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and   ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "'AND (ttn.TARGET_DATE>='" + TXTDESDE.Text + "')AND(ttn.TARGET_DATE<='" + TXTHASTA.Text + "')    order by ttn.TTN_ID desc");

                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                        GridView3.DataSource = DS.Tables[0];
                        GridView3.DataBind();


                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView3.DataSource = null;
                    GridView3.DataBind();

                }

                if (CHECKFFCM.Checked == true)
                {

                    try
                    {
                        string COMANDO = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on    edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and   cm2.id = DOCUMENT_SHOP.id_genset  WHERE cm2.Site ='" + CBSITE.Text + "' AND (cm2.Date>='" + TXTDESDE.Text + "')AND(cm2.Date<='" + TXTHASTA.Text + "')  order by cm2.id desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView2.DataSource = DS.Tables[0];
                        GridView2.DataBind();



                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView2.DataSource = null;
                    GridView2.DataBind();
                }







            }
            else
            {

                if (checkmaintenance.Checked == true)
                {
                    try
                    {

                        string COMANDO = string.Format(" SELECT DISTINCT      edgar2211.technical.ID AS Id, edgar2211.technical.DATE1 AS Date, CASE WHEN(DATEDIFF(DAY, getdate(), DATE_FINICH) < 0) THEN 0 ELSE DATEDIFF(DAY, getdate(), DATE_FINICH) END AS[Next Service], edgar2211.technical.VERIFICATION AS[Need a Review ?], edgar2211.technical.DATE_FINICH, edgar2211.technical.SITE AS Site, edgar2211.technical.GENSET AS Genset, edgar2211.technical.TEAM AS Team, edgar2211.technical.HOUR_MASTER_READING AS[Hour Master Reading], edgar2211.technical.QIL_RUMMING_HR AS[Oil Running Hr], edgar2211.technical.OIL_ENGINE_REPLACE AS[Oil Engine Replace], edgar2211.technical.OIL_QTY_REMOVED AS[Oil Qty Removed], edgar2211.technical.OIL_QTY_GL AS[Oil Qty(gl)], edgar2211.technical.OIL_DIFERENT AS[Oil Different], edgar2211.technical.OIL_FILTER_REPLACE AS[Oil Filter Replace], edgar2211.technical.TANK_DECARTER_FILTER_REPLACE AS[Tank Decarter Filter Replace], edgar2211.technical.PRE_FUEL_FILTER_REPLACE AS[Pre - fuel Filter Replace], edgar2211.technical.FUEL_FILTER_REPLACE AS[Fuel Filter Replace], edgar2211.technical.INNERT_A_IR_FILTER_REPLACE AS[Inner Air Filter Replace], edgar2211.technical.OUTER_AIR_FILTER_CHANGE AS[Outer Air Filter Cheange], edgar2211.technical.NOTA AS Decription,CASE WHEN(DOCUMENT_SHOP.id_genset<> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'service') THEN '1' ELSE '0' END AS Attachment, edgar2211.technical.USER_LOG AS[User Login]FROM edgar2211.technical LEFT OUTER JOIN edgar2211.DOCUMENT_SHOP ON edgar2211.technical.Genset = edgar2211.DOCUMENT_SHOP.GENSET and edgar2211.technical.ID = edgar2211.DOCUMENT_SHOP.ID_GENSET                where SITE = '" + CBSITE.Text + "' AND  GENSET='" + CBGENSET.Text + "' 'AND (technical.DATE1>='" + TXTDESDE.Text + "')AND(technical.DATE1<='" + TXTHASTA.Text + "') order by ID desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView6.DataSource = DS.Tables[0];
                        GridView6.DataBind();


                    }
                    catch (Exception)
                    {


                    }


                }
                else
                {
                    GridView6.DataSource = null;
                    GridView6.DataBind();
                }



                if (CHECKLOG.Checked == true)
                {
                    try
                    {
                        string COMANDO7 = string.Format("SELECT DISTINCT       TBLOG.id, Date, Site, TBLOG.Genset, Genset_Serial AS [Genset Serial], Reference, honning_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'log') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.TBLOG  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.TBLOG.Genset = edgar2211.DOCUMENT_SHOP.GENSET and TBLOG.id = DOCUMENT_SHOP.id_genset     WHERE TBGOG.Genset='" + CBGENSET.Text + "' AND(TBLOG.Date>='" + TXTDESDE.Text + "')and(TBLOG.Date<='" + TXTHASTA.Text + "')   order by TBLOG.id desc");
                        DataSet DS7 = CLASS_CONECTAR.CONECTAR(COMANDO7);

                        GridView9.DataSource = DS7.Tables[0];
                        GridView9.DataBind();
                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView9.DataSource = null;
                    GridView9.DataBind();

                }

                if (CHECKSHOP.Checked == true)
                {
                    try
                    {
                        string comando = string.Format("SELECT  DISTINCT Shop.Id AS [System ID],Shop.Date,Shop.Refference,edgar2211.gensetfinal.GENSET_MODEL as [Genset],Shop.Genset_Serial AS [Genset Serial#], Shop.Status1 AS [Status],case when(DOCUMENT_SHOP.id_genset <>'' and DOCUMENT_SHOP.tipo='shop') then '1'else '0'end as Attachment ,Shop.Description,Shop.User_Login AS [User] FROM   edgar2211.gensetfinal INNER JOIN edgar2211.Shop ON edgar2211.gensetfinal.GENSETSERIAL = edgar2211.Shop.Genset_Serial LEFT OUTER JOIN  edgar2211.DOCUMENT_SHOP ON edgar2211.gensetfinal.GENSET_MODEL = edgar2211.DOCUMENT_SHOP.GENSET AND edgar2211.DOCUMENT_SHOP.ID_GENSET = edgar2211.Shop.id   WHERE gensetfinal.SITE = '" + CBSITE.Text + "'  AND gensetfinal.GENSET_MODEL='" + CBGENSET.Text + "' AND (shop.Date>='" + TXTDESDE.Text + "')AND(shop.Date<='" + TXTHASTA.Text + "')  ORDER BY Shop.Id DESC");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(comando);
                        GridView5.DataSource = DS.Tables[0];
                        GridView5.DataBind();


                    }
                    catch (Exception)
                    {

                        //lblshop.Text = ERROR.Message;
                    }
                }
                else
                {
                    GridView5.DataSource = null;
                    GridView5.DataBind();
                }

                if (CHECKCM.Checked == true)
                {
                    try
                    {
                        string COMANDO = string.Format("SELECT  DISTINCT      cm.ID, cm.DATE1 AS DATE, cm.SITE, cm.GENSET, cm.FILTER, cm.QTY, cm.RUNNING_HOURS AS [RUNNING HOURS], cm.HOURS_USE AS [HOURS USE], cm.NOTE,CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'FFCM') THEN '1' ELSE '0' END AS Attachment,cm.USER1 FROM            edgar2211.CM LEFT OUTER JOIN DOCUMENT_SHOP on   edgar2211.cm.Genset = edgar2211.DOCUMENT_SHOP.GENSET and    cm.id = DOCUMENT_SHOP.id_genset WHERE cm.SITE='" + CBSITE.Text + "' AND cm.GENSET='" + CBGENSET.Text + "'and (CM.DATE1>='" + TXTDESDE.Text + "')AND(CM.DATE1<='" + TXTHASTA.Text + "') order by cm.ID desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView4.DataSource = DS.Tables[0];
                        GridView4.DataBind();

                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView4.DataSource = null;
                    GridView4.DataBind();

                }




                if (CEHPTTN.Checked == true)
                {
                    try
                    {

                        string COMANDO = string.Format("SELECT  DISTINCT ttn.TTN_ID AS TTN,ttn.CREATE_BY AS [Create By],ttn.SITE AS [Site],ttn.TASK AS Task, ttn.ASSIN_TO AS [Assing To],ttn.NOTE AS [Jod Description], NOTE2 AS [Feedback Description],case when(DOCUMENT_SHOP.id_genset <>'' and  DOCUMENT_SHOP.tipo  ='ttn') then '1'else '0'end as Attachment,ttn.USER1,ttn.TARGET_DATE AS [Target date],ttn.STATUS1 AS [Status],ttn.DATE_FINISH AS [Date Finish]  FROM   ttn left outer join DOCUMENT_SHOP on   edgar2211.TTN.Site = edgar2211.DOCUMENT_SHOP.GENSET and    ttn.ttn_id = DOCUMENT_SHOP.id_genset  where ttn.SITE = '" + CBSITE.Text + "' 'AND (ttn.TARGET_DATE>='" + TXTDESDE.Text + "')AND(ttn.TARGET_DATE<='" + TXTHASTA.Text + "')  order by ttn.TTN_ID desc");

                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);
                        GridView3.DataSource = DS.Tables[0];
                        GridView3.DataBind();


                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView3.DataSource = null;
                    GridView3.DataBind();

                }

                if (CHECKFFCM.Checked == true)
                {

                    try
                    {
                        string COMANDO = string.Format("SELECT DISTINCT        cm2.id, cm2.Date, cm2.Site, cm2.Genset, Genset_Serial AS [Genset Serial], Reference, Running_Hours AS [Running Hours], Notas AS [Description],CASE WHEN (DOCUMENT_SHOP.id_genset <> '" + "" + "' AND DOCUMENT_SHOP.tipo = 'CM') THEN '1' ELSE '0' END AS Attachment, User_Login as [User] FROM            edgar2211.cm2  LEFT OUTER JOIN DOCUMENT_SHOP on  edgar2211.cm2.Genset = edgar2211.DOCUMENT_SHOP.GENSET and    cm2.id = DOCUMENT_SHOP.id_genset           WHERE cm2.Site ='" + CBSITE.Text + "' AND  cm2.Genset='" + CBGENSET.Text + "'  AND (cm2.Date>='" + TXTDESDE.Text + "')AND(cm2.Date<='" + TXTHASTA.Text + "')   order by cm2.id desc");
                        DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                        GridView2.DataSource = DS.Tables[0];
                        GridView2.DataBind();



                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    GridView2.DataSource = null;
                    GridView2.DataBind();
                }





            }
        }


        protected void BTNBUSCAR1_Click(object sender, EventArgs e)
        {
            try
            {




                HttpResponse response = Response;
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                Page pageToRender = new Page();
                HtmlForm form = new HtmlForm();

                //Image imagen = new Image();

                //imagen.ImageUrl = "~/imagenes/canez1.jpg";

                //form.Controls.Add(imagen);

                //TableCell cell = new TableCell();
                //cell.Text = "<img src=imagenes/canez1.jpg />";
                //response.Write("<img src=E:/trabajo actuales/PROYECTOS EN ASP/CONEZ/CanezPower/imagenes/canez1.jpg />");
                //form.Controls.Add(cell);
                //TableCell cell0 = new TableCell();
                //cell0.Text = "<H1>Canez Power Division</H1>";
                //form.Controls.Add(cell0);
                TableCell cell2 = new TableCell();
                cell2.Text = "<H1>Service</H1>";
                form.Controls.Add(cell2);
                form.Controls.Add(GridView6);
                //TableCell cell3 = new TableCell();
                //cell3.Text = "<H1>Shop</H1>";
                //form.Controls.Add(cell3);
                //form.Controls.Add(GridView5);
                //TableCell cell4 = new TableCell();
                //cell4.Text = "<H1>CM</H1>";
                //form.Controls.Add(cell4);
                //form.Controls.Add(GridView2);
                //TableCell cell5 = new TableCell();
                //cell5.Text = "<H1>FF-CM</H1>";
                //form.Controls.Add(cell5);
                //form.Controls.Add(GridView4);

                //TableCell cell6 = new TableCell();
                //cell6.Text = "<H1>TTN</H1>";
                //form.Controls.Add(cell6);
                //form.Controls.Add(GridView3);
                //TableCell cell7 = new TableCell();
                //cell7.Text = "<H1>LOG</H1>";
                //form.Controls.Add(cell7);
                //form.Controls.Add(GridView9);

                pageToRender.Controls.Add(form);
                response.Clear();
                response.Buffer = true;
                response.ContentType = "application/vnd.ms-excel";
                response.AddHeader("Content-Disposition", "attachment;filename=" + "Extracting_Report.xls");
                response.Charset = "UTF-8";
                response.ContentEncoding = Encoding.Default;
                pageToRender.RenderControl(htw);
                response.Write(sw.ToString());
                response.End();






            }
            catch (Exception)
            {
                //Label7.Text = error.Message;

            }
        }
        public static string IDGENSET, GENSET;

        protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView5.Rows[valor].Cells[2].Text;
                    GENSET = GridView5.Rows[valor].Cells[5].Text;

                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "shop" + "')</script>");

                    // Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "shop");

                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView2.Rows[valor].Cells[2].Text;
                    GENSET = GridView2.Rows[valor].Cells[5].Text;
                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "CM" + "')</script>");

                    // Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "CM");

                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }
            }
        }

        protected void GridView4_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView4.Rows[valor].Cells[2].Text;
                    GENSET = GridView4.Rows[valor].Cells[5].Text;
                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "FFCM" + "')</script>");

                    // Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "FFCM");

                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }

        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView3.Rows[valor].Cells[2].Text;
                    GENSET = GridView3.Rows[valor].Cells[4].Text;


                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "ttn" + "')</script>");

                    //Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "ttn");





                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btver")
            {

                try
                {
                    int valor = Convert.ToInt32(e.CommandArgument);

                    IDGENSET = GridView9.Rows[valor].Cells[2].Text;
                    GENSET = GridView9.Rows[valor].Cells[5].Text;
                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "log" + "')</script>");

                    /// Response.Redirect("DOCUMENT_SHOP.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "log");

                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }
        public static string SER = "";
        protected void CBGENSET_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string COMANDO = string.Format("SELECT gensetserial FROM gensetfinal WHERE  gensetfinal.SITE  = '" + CBSITE.Text + "'AND  gensetfinal.GENSET_MODEL='" + CBGENSET.Text + "'    ");
                DataSet DS = CLASS_CONECTAR.CONECTAR(COMANDO);

                string serial = DS.Tables[0].Rows[0]["gensetserial"].ToString();
                SER = serial;
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

                    IDGENSET = GridView6.Rows[valor].Cells[2].Text;
                    GENSET = GridView6.Rows[valor].Cells[8].Text;


                    //Response.Write("<script>window.open('" +file1+ "' )</script>");
                    Response.Write("<script>window.open('DOCUMENTO.aspx?ID=" + IDGENSET.ToString() + "&GENSET=" + GENSET.ToString() + "&page=" + "service" + "')</script>");


                }
                catch (Exception )
                {
                    //LBLESTADO.Text = ERROR.Message;

                }

            }
        }

        protected void CBSITE_TextChanged(object sender, EventArgs e)
        {
            CBSITE_SelectedIndexChanged(null, null);
        }
    }
}