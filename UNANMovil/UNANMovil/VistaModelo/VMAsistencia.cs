using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UNANMovil.Conexion;

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

        public void MostrarModalidades(Picker combo)
        {
            Conexion.Conexion.Abrir();
            SqlCommand da = new SqlCommand("MostrarModalidad", Conexion.Conexion.conectar);
            da.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter cb = new SqlDataAdapter(da);
            DataTable dt = new DataTable();
            cb.Fill(dt);
            combo.ItemsSource= (System.Collections.IList)dt;
        }
        #endregion
        #region COMANDOS
        public Command Volvercomamd { get; }
        #endregion
    }
}
