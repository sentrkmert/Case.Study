using GA.CaseStudy.Models;
using GA.CaseStudy.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GA.CaseStudy.Data
{
    public class ExamplePageBinding
    {
        public static ObservableCollection<ExamplePageModel> BindMenu()
        {
            return new ObservableCollection<ExamplePageModel>
            {
                new ExamplePageModel { Title="Label Title 1",SubTitle = "Descreption 1" },
                new ExamplePageModel { Title="Label Title 2",SubTitle = "12345"},
                new ExamplePageModel { Title="Label Title 3",SubTitle = "test@apsiyon"},
                new ExamplePageModel { Title="Label Title 4",SubTitle = "555 878 57 81"},
                new ExamplePageModel { Title="Label Title 5",SubTitle = "Descreption 2"}
            };
        }
    }
}
