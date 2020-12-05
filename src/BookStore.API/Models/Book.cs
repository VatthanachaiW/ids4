namespace BookStore.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatalogId { get; set; }
        public Catalog Catalog { get; set; }
    }
}