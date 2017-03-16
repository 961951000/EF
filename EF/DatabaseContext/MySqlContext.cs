using System.Data.Entity;

namespace EF.DatabaseContext
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() : base("name=DefaultConnection") { }
    }
}
