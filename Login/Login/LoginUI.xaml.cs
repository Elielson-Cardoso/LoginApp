using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginUI : ContentPage
	{
		public LoginUI ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "elielson" && txtSenha.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
                DisplayAlert("Atenção", "Usuário ou senha incorreto!", "Ok");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrarPage());
        }
    }
}