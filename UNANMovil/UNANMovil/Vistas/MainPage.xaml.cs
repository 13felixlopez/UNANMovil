using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNANMovil.VistaModelo;
using Xamarin.Forms;

namespace UNANMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VMMenuPrincipal(Navigation);
        }
    }
}
