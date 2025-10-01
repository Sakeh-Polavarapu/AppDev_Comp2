namespace ADcomp2
{
    public class Library
    {
        // Lists to hold the collections
        private List<Book> Books { get; } = new List<Book>();
        private List<Person> Patrons { get; } = new List<Person>();

        // Method to add a book
        public void AddBook(Book book) => Books.Add(book);

        // Method to add a patron (Student or Staff)
        public void AddPatron(Person patron) => Patrons.Add(patron);

        // Method to find a book by title
        public Book FindBook(string title) => Books.FirstOrDefault(b => b.Title == title);

        // Method to display all books
        public void DisplayBooks(string header)
        {
            System.Console.WriteLine($"\n{header}");
            foreach (var book in Books)
            {
                System.Console.WriteLine(book.GetBookDetails());
            }
        }

        // Method to display all patrons
        public void DisplayPatrons()
        {
            System.Console.WriteLine("\nPatrons in Library:");
            foreach (var patron in Patrons)
            {
                System.Console.WriteLine(patron.GetDetails());
            }
        }
    }
}