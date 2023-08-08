using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationServices.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
