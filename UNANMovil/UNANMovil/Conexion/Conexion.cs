using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace UNANMovil.Conexion
{
    public class Conexion
    {
        public static string conexion = ("Data Source= 192.168.174.84; Initial Catalog=UNAN; Integrated Security=False;User Id=Fermin;Password=13Fermin");
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
