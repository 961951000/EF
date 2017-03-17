using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Models;

namespace EF.DatabaseContext
{
    public class OracleContext : DbContext
    {
        public OracleContext() : base("name=OracleConnection") { }

        public DbSet<AlertQt> AlertQt { get; set; }

    }
}
