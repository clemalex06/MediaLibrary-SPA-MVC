using ApplicationServices.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ApplicationServices.Services
{
    public class MediaLibraryApplicationService
    {
        public static IList<Author> GetAuthors() 
        {
            using (var context = new BookStoreContext())
            {
                var test = context.Configuration;
                return context.Authors.Include(p => p.Books).ToList();
            }
        }
    }
}
