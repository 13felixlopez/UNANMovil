using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMAsistencia:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMAsistencia(INavigation navigation)
        {
            Navigation = navigation;
            Volvercomamd = new Command(async () => await Volver());
        }
        #endregion
        #region OBJETOS 
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }

        #endregion
        #region PROCESOS
        private async Task Volver()
        {
            await Navigation.PopAsync();
        }
        #endregion
        #region COMANDOS
        public Command Volvercomamd { get; }
        #endregion
    }
}
