using GA.CaseStudy.Models;
using System.Collections.ObjectModel;

namespace GA.CaseStudy.Data
{
    public class MenuDataBinding
    {
        public static ObservableCollection<MenuModels> BindMenu()
        {
            return new ObservableCollection<MenuModels>
            {
                new MenuModels { Id = 1, Name = "Menu Item 1",ImageValue = "menuItemImg.png" },
                new MenuModels { Id = 2, Name = "Menu Item 2",ImageValue = "menuItemImg.png" },
                new MenuModels { Id = 3, Name = "Menu Item 3" ,ImageValue = "menuItemImg.png"},
                new MenuModels { Id = 4, Name = "Menu Item 4",ImageValue = "menuItemImg.png" },
                new MenuModels { Id = 5, Name = "Menu Item 5" ,ImageValue = "menuItemImg.png"},
                new MenuModels { Id = 6, Name = "Menu Item 6",ImageValue = "menuItemImg.png" },
            };
        }
    }
}
