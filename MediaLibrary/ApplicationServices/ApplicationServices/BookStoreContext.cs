using ApplicationServices.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext() : base("BookStoreContext")
        {
        }

        private static DbConnection GetConnection()
        {
            var connection = ConfigurationManager.ConnectionStrings["BookStoreContext"];
            var factory = DbProviderFactories.GetFactory(connection.ProviderName);
            var dbCon = factory.CreateConnection();
            dbCon.ConnectionString = connection.ConnectionString;
            return dbCon;
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
