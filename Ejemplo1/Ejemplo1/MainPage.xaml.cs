using Xamarin.Forms;
using System.Diagnostics;
namespace Ejemplo1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Clicked(object sender, System.EventArgs e)
        {
            string sUsuario = txtUsuario.Text;
            string sPassword = txtPassword.Text;

            if(string.IsNullOrWhiteSpace(sUsuario) || string.IsNullOrWhiteSpace(sPassword))
            {
              DisplayAlert("Alerta", "Por Favor Introduzca Ingrese Los Datos. ", "OK");
           }

            if ((sUsuario == "Jensley") && (sPassword == "101627")) 
                {
                Navigation.PushAsync(new Sistema());
                }
            else 
            {
                DisplayAlert("Alerta", "El Usuario o El Password Son Incorrectos", "OK");
            }
        }

        private void Btn_No_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}