namespace day19_WebApplication7.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
    }
}
