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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            BindingContext = new VMFrmMenu(Navigation);
        }

        private async void btnAsistencia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void btnAvance_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnCerrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}