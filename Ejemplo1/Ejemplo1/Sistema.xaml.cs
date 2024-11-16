using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sistema : ContentPage
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private async void Btn_Ir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }
    }
}