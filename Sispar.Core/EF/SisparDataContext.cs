using Sispar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sispar.Core.Helpers;

namespace Sispar.Core.EF
{
    public class SisparDataContext : DbContext
    {
        public SisparDataContext()
            : base("")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tither> Tithers { get; set; }
    }

    internal class InitialLoad : CreateDatabaseIfNotExists<SisparDataContext>
    {
        protected override void Seed(SisparDataContext context)
        {
            var users = new List<User> {
                new User { UserName = "milton", Password = "123456".Encrypt() },
                new User { UserName = "flpsno", Password = "123456".Encrypt() }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
