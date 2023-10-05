using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using UNANMovil.Modelo;
using Android.Views;
using Xamarin;

namespace UNANMovil.Conexion
{
    public class DProfesor
    {
        #region Validar Usuarios Para login
        public DataTable D_Usuarios(MProfes parametros)
        {
            try
            {
                Conexion.Cerrar();
                SqlCommand cmd = new SqlCommand("Login", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@INSS", parametros.INSS);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }
        }

        #endregion
    }
}
