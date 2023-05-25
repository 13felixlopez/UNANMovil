using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMDetalleAsistencia:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMDetalleAsistencia(INavigation navigation)
        {
            Navigation = navigation;
            volvercomamd = new Command(async () => await Volver());
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
        public Command volvercomamd { get; }
        #endregion
    }
}
