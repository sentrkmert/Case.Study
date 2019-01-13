using GA.CaseStudy.Models;

namespace GA.CaseStudy.Data
{
    public class ExamplePageDataBinding
    {
        public static ExamplePageDataModel BindMenu()
        {
            return new ExamplePageDataModel
            {
                Bakiye=1450.42,Borc=-1000.45,Alacak=1000.40
            };
        }
    }
}
