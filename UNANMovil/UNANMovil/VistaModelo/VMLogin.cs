using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMLogin:BaseViewModel
    {
        #region VARIABLES
        int i = 0, cant = 3;
        public string nombre;
        public string pass;
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
            if (i < cant)
            {
                if (nombre == "Felix" && pass == "1316")
                {
                    await Navigation.PushAsync(new MainPage());
                }
                i++;
                if (i == 3)
                {
                    await DisplayAlert("ERROR", "Ya excedio los intentos permitidos", "OK");
                    Process.GetCurrentProcess().Kill();
                }
                else if (nombre != "Felix" && pass != "1316")
                {
                    await DisplayAlert("Datos Erroneos", "Los datos ingresados son incorrectos", "OK");
                }
            }
        }
        #endregion
        #region COMANDOS
        public Command Logincomamd { get; }
        #endregion
    }
}
