using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dmerchanExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string Nombre , string PagoMensual)
        {
            InitializeComponent();
            txtNombre1.Text = Nombre;
            txtPagototal.Text = PagoMensual;


        }

        private void btnGuardar1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Elemento guardado con exito", "Cerrar");
            
        }
    }
}