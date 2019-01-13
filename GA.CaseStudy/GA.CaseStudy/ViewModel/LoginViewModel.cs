using GA.CaseStudy.Connection;
using GA.CaseStudy.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GA.CaseStudy.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private static SQLiteClient _client = null;
        private static SQLiteClient GetConnection()
        {
            if (_client == null)
                _client = new SQLiteClient();
            return _client;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private IEnumerable<LoginUserPassModel> _login;

        public IEnumerable<LoginUserPassModel> Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public LoginViewModel()
        {
            Login = GetConnection().GetAll();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
