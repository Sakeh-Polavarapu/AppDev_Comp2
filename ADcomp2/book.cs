namespace ADcomp2
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int AvailableCopies { get; private set; }

        // Constructor
        public Book(string title, string author, string isbn, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
        }

        // Method to handle borrowing with validation
        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--; // Decrement available copies
                return true;
            }
            return false; // Book is not available
        }
        
        // Optional: Implement ReturnBook() if you extend the scope
        public void ReturnBook()
        {
            AvailableCopies++;
        }

        public string GetBookDetails()
        {
            return $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
        }
    }
}