using NewsFeed.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed.DataAcces.Contexts
{
    public class NewsFeedContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public NewsFeedContext() : base(Properties.Settings.Default.DbConnectionString)
        {
            
        }
    }
}
