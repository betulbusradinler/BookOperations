using System.Data;

namespace BookOperations.Entities
{
    public class Author
    {
        public int Id {get; set;}
        public int BookId {get; set;}
        public string Name {get; set;}
        public string LastName  {get; set;}
        public DateTime BirthDate {get; set;}
        public List<Book> Books {get; set;}
    }
}