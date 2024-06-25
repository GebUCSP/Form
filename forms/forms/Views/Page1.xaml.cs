using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void EnviarCV(object sender, EventArgs e)
        {
            string nombre = nombre_.Text;
            string apellido = apellido_.Text;
            string email = email_.Text;
            string telefono = numero_.Text;
            string experiencia = experencia_.Text;
            string habilidades = habilidades_.Text;


            DisplayAlert("Información", "Datos registrados.", "Cerrar");

        }
    }
}