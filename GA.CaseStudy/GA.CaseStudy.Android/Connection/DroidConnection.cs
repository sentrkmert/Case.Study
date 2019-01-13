using GA.CaseStudy.Connection;
using GA.CaseStudy.Droid.Connection;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DroidConnection))]
namespace GA.CaseStudy.Droid.Connection
{
    public class DroidConnection : ISQLite
    {
        public  SQLiteConnection GetConnection()
        {
            var sqliteDbName = "Study.db";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, sqliteDbName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}