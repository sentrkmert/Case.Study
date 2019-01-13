using GA.CaseStudy.Data;
using GA.CaseStudy.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GA.CaseStudy.ViewModel
{
    public class ExamplePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<ExamplePageModel> _example;
        public ObservableCollection<ExamplePageModel> Example
        {
            get
            {
                return _example;
            }
            set
            {
                _example = value;
                OnPropertyChanged();
            }
        }
        
        private ExamplePageDataModel _data;
        public ExamplePageDataModel Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }
        public ExamplePageViewModel()
        {
            Example = ExamplePageBinding.BindMenu();
            Data = ExamplePageDataBinding.BindMenu();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
