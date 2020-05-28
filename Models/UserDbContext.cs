using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diksha.Models
{
    public class UserDbContext: DbContext
    {
        public UserDbContext():base("CustomerDetailsDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserDbContext, Diksha.Migrations.Configuration>());
        }
        public DbSet<Customer> Customers { get; set; }
    }
}