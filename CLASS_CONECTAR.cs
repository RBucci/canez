using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace CanezPower
{
    public class CLASS_CONECTAR
    {

        //public MySqlConnection CONECT1 = new MySqlConnection("server=localhost;user id=root;password=12345678;persistsecurityinfo=True;database=localcanez");

        //public static DataSet CONECTAR(string CADENA)
        //{

        //    MySqlConnection CONECT = new MySqlConnection("server=localhost;user id=root;password=12345678;persistsecurityinfo=True;database=localcanez");
        //    MySqlCommand COMAN = new MySqlCommand(CADENA, CONECT);
        //    MySqlDataAdapter ADA = new MySqlDataAdapter(COMAN);
        //    DataSet DS = new DataSet();
        //    ADA.Fill(DS);
        //    return DS;


        //}






        public SqlConnection CONECT1 = new SqlConnection("Data Source=184.168.47.13;Initial Catalog=Edgarpower_;User ID=edgar2211;Password=joseluis2211");

        public static DataSet CONECTAR(string CADENA)
        {

            SqlConnection CONECT = new SqlConnection("Data Source=184.168.47.13;Initial Catalog=Edgarpower_;User ID=edgar2211;Password=joseluis2211");
            SqlCommand COMAN = new SqlCommand(CADENA, CONECT);
            SqlDataAdapter ADA = new SqlDataAdapter(COMAN);
            DataSet DS = new DataSet();
            ADA.Fill(DS);
            return DS;


        }
        
    }
}