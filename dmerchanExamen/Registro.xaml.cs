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
    public partial class Registro : ContentPage
    {
        public Registro(string n, string a)
        {
            InitializeComponent();
            lblTexto.Text = "Bienvenido" + n + " " + a;
        }

        private void btnCalcularpago_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMontoinicial.Text))
            {
                var MontoIniicial = double.Parse(txtMontoinicial.Text);

                var resultado = (3000- MontoIniicial)/3;
                var total = resultado +150;

                txtPagomensual.Text = total.ToString();
            }
        
        }
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string PagoMensual = txtPagomensual.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new Resumen(Nombre , PagoMensual));

        }
    }
}
