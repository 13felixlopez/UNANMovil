using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNANMovil.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNANMovil.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Restablecer : ContentPage
    {
        public Restablecer()
        {
            InitializeComponent();
            BindingContext = new VMRestablecer(Navigation);
        }

        private void btnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}