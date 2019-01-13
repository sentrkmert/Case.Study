using GA.CaseStudy.Models;
using GA.CaseStudy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GA.CaseStudy
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new MenuViewModel();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Detail)));
            LblMenuUserName.Text = Globals.UserName;
            //lstMenu.ItemsSource = new MenuViewModel();
        }
        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(ExamplePage)));
            IsPresented = false;

        }
    }
}

