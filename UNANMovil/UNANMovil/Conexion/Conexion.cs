using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace UNANMovil.Conexion
{
    public class Conexion
    {
        public static string conexion = ("Data Source = 172.16.140.104; Initial Catalog=UNAN1; Integrated Security=False;User=Dixon;Password=1311");
        public static SqlConnection conectar=new SqlConnection(conexion);

        public static void Abrir()
        {
            if (conectar.State==ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (conectar.State==ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
