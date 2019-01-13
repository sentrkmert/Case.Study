using GA.CaseStudy.Connection;
using GA.CaseStudy.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GA.CaseStudy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        private void LoginEvent(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(NameEntry.Text))
            {
                UyariMesaji("Ad boş geçilemez");
                return;
            }
            if (string.IsNullOrEmpty(PasswordEntry.Text))
            {
                UyariMesaji("Şifre boş geçilemez");
                return;
            }
            LoginUserPassModel loginuser = new LoginUserPassModel();
            loginuser.Name = NameEntry.Text;
            loginuser.Password = PasswordEntry.Text;
            SQLiteClient _client = new SQLiteClient();
            var result = _client.Insert(loginuser);
            if (result <= 0)
            {
                UyariMesaji("Giriş Başarısız!");
            }
            else
            {
                Globals.UserName = NameEntry.Text;
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }

        }
        private void UyariMesaji(string error)
        {
            DisplayAlert("Uyarı!", error, "Tamam");
        }

    }
}