using SQLite;

namespace GA.CaseStudy.Connection
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
