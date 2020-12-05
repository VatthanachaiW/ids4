using System.Collections.Generic;

namespace BookStore.API.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}