using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMAvance:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMAvance(INavigation navigation)
        {
            Navigation = navigation;
            Logincomamd = new Command(async () => await proceso());
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
        private async Task proceso()
        {

        }
        #endregion
        #region COMANDOS
        public Command Logincomamd { get; }
        #endregion
    }
}
