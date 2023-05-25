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
	public partial class Registro : ContentPage
	{
		public Registro ()
		{
			InitializeComponent ();
			BindingContext = new VMDetalleAsistencia(Navigation);
		}
	}
}