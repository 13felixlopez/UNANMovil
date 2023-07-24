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
                Conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Login", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario);
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

        public void ObtenerIdProfesor(ref int Idprofesor, string Usuario)
        {
            try
            {
                Conexion.Abrir();
                SqlCommand cmd = new SqlCommand("ObtenerIdProfesor", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                Idprofesor = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexion.Cerrar();
            }
        }
        #endregion
    }
}
