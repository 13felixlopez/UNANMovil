﻿using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UNANMovil.Vistas;
using Xamarin.Forms;

namespace UNANMovil.VistaModelo
{
    public class VMMenuPrincipal:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMMenuPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            NavegarRegistrocomamd = new Command(async () => await NavegarRegistro());
            NavegarAsistenciacomamd = new Command(async () => await NavegarAsistencia());
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
        private async Task NavegarRegistro()
        {
            await Navigation.PushAsync(new Registro());
        }
        private async Task NavegarAsistencia()
        {
            await Navigation.PushAsync(new Asistencia());
        }
        #endregion
        #region COMANDOS
        public Command NavegarRegistrocomamd { get; }
        public Command NavegarAsistenciacomamd { get; }
        #endregion
    }
}
