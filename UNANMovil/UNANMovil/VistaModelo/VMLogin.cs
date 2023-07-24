using Android.Content.Res;
using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using UNANMovil.Conexion;
using UNANMovil.Modelo;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMLogin:BaseViewModel
    {
        #region VARIABLES
        int i = 0, cant = 3;
        public string nombre;
        public string pass;
        public static string nombreprofe;
        public static byte[] Icono;
        public static int idprofesor;
        public static string correo;
        public static string Tusuario;
        #endregion
        #region CONSTRUCTOR
        public VMLogin(INavigation navigation)
        {
            Navigation = navigation;
            Logincomamd = new Command(async () => await Login());
        }
        #endregion
        #region OBJETOS 
        public string Nombre
        {
            get { return nombre; }
            set { SetValue(ref nombre, value); }
        }
        public string Pass
        {
            get { return pass; }
            set { SetValue(ref pass, value); }
        }

        #endregion
        #region PROCESOS
        private async Task Login()
        {
            MProfes mProfes = new MProfes();
            Nprofes nprofes = new Nprofes();

            DataTable dt = new DataTable();
            mProfes.Usuario = nombre;
            mProfes.Password = Encrip.Encriptar(Encrip.Encriptar(pass));

            try
            {
                dt = nprofes.Nprofe(mProfes);

                if (dt.Rows.Count > 0)
                {
                    idprofesor = Convert.ToInt32(dt.Rows[0][0]);
                    nombreprofe = dt.Rows[0][1].ToString();
                    Icono = (byte[])dt.Rows[0][2];
                    correo = dt.Rows[0][5].ToString();
                    Tusuario = dt.Rows[0][6].ToString();
                    await Navigation.PushAsync(new MainPage());
                    nombre = "";
                    pass = "";
                }
                else
                {
                    await DisplayAlert("Error", "Usuario o Contraseña incorrectos", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                Conexion.Conexion.Cerrar();
            }
        }
        #endregion
        #region COMANDOS
        public Command Logincomamd { get; }
        #endregion
    }
}
