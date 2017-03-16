using System.Data.Entity;
using EF.Models;

namespace EF.DatabaseContext
{
    public class SqlContext : DbContext
    {
        public SqlContext() : base("name=SqlServerConnection") { }

        public DbSet<MSreplicationOptions> MSreplicationOptions { get; set; }
    }
}
