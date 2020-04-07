using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;
using System.Data;

namespace CanezPower
{
    public partial class MASTERLOGIN : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            

        }
        int no = 0;

        string hora = "";
        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString();

            no++;
            if (no==10)
            {
              
                try
                {
                    string comando = string.Format("UPDATE  prueba_time SET cantidad = cantidad-1 ");
                    DataSet ds = CLASS_CONECTAR.CONECTAR(comando);

                }
                catch (Exception)
                {
                    
                   
                }
                no = 0;
            }
           
        }
}
}