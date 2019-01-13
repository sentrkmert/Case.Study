using GA.CaseStudy.Data;
using GA.CaseStudy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GA.CaseStudy.ViewModel
{
    public class DetailViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<DetailModel> _detail;
        public ObservableCollection<DetailModel> Detail
        {
            get
            {
                return _detail;
            }
            set
            {
                _detail = value;
                OnPropertyChanged();
            }
        }
        public DetailViewModel()
        {
            Detail = DetailDataBinding.BindMenu();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
