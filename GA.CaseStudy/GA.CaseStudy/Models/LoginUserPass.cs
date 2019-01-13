using SQLite;
namespace GA.CaseStudy.Models
{
    public class LoginUserPassModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
      
    }
}
