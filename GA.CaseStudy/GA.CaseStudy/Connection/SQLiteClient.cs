using GA.CaseStudy.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace GA.CaseStudy.Connection
{
    public class SQLiteClient
    {
        static object locker = new object();

        SQLiteConnection _sqlconnection;

        public SQLiteClient()
        {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<LoginUserPassModel>();
        }

        public int Insert(LoginUserPassModel DB)
        {
            lock (locker)
            {
                return _sqlconnection.Insert(DB);
            }
        }
        public IEnumerable<LoginUserPassModel> GetAll()
        {
            lock (locker)
            {
                return (from i in _sqlconnection.Table<LoginUserPassModel>() select i).ToList();
            }
        }

        public LoginUserPassModel Get(int id)
        {
            lock (locker)
            {
                return _sqlconnection.Table<LoginUserPassModel>().FirstOrDefault(t => t.Id == id);
            }
        }

        public void Dispose()
        {
            _sqlconnection.Dispose();
        }
    }
}
