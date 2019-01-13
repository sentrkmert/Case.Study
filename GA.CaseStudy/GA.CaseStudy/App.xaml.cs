using GA.CaseStudy.Connection;
using GA.CaseStudy.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GA.CaseStudy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            SQLiteClient _client = new SQLiteClient();
            LoginUserPassModel Loginusername = _client.Get(1);
            if (Loginusername == null)
            {
                MainPage = new LoginPage();
            }
            else
            {
                Globals.UserName = Loginusername.Name;
                MainPage = new MainPage();
                
            }
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
