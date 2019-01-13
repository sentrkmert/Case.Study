using GA.CaseStudy.Models;
using System.Collections.ObjectModel;

namespace GA.CaseStudy.Data
{
    public class DetailDataBinding
    {
        public static ObservableCollection<DetailModel> BindMenu()
        {
            return new ObservableCollection<DetailModel>
            {
                new DetailModel { Bakiye=+2100.40,SubTitle="Sub Title",Title="Title 1",YetkiliKisi="Yetkili Kişi"},
                new DetailModel { Bakiye=-2100.22,SubTitle="Sub Title",Title="Title 2",YetkiliKisi="Yetkili Kişi"},
                new DetailModel { Bakiye=+2100.40,SubTitle="Sub Title",Title="Title 3",YetkiliKisi="Yetkili Kişi"},
                new DetailModel { Bakiye=-2100.42,SubTitle="Sub Title",Title="Title 4",YetkiliKisi="Yetkili Kişi"}
            };
        }
    }
}
