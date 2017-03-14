using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using EF.Models;

namespace EF.DatabaseContext
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() : base("name=DefaultConnection") { }

        public DbSet<User> User { get; set; }

        public DbSet<ProxiesPriv> ProxiesPriv { get; set; }
    }
}
