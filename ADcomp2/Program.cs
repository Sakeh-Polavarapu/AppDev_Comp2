namespace ADcomp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Setup the Library Manager
            Library usfLibrary = new Library();

            // 2. Create and Add Books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
            
            usfLibrary.AddBook(book1);
            usfLibrary.AddBook(book2);
            usfLibrary.AddBook(book3);

            // 3. Create and Add Patrons
            Student akhil = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student sandeep = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff grandon = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            
            usfLibrary.AddPatron(akhil);
            usfLibrary.AddPatron(sandeep);
            usfLibrary.AddPatron(grandon);

            // 4. Initial Display
            usfLibrary.DisplayBooks("Books in Library:");
            usfLibrary.DisplayPatrons();

            // 5. Borrowing Scenario
            System.Console.WriteLine("\nBorrowing Books...");
            
            // Sandeep borrows "Business Insights with AI"
            Book bookToBorrow1 = usfLibrary.FindBook("Business Insights with AI");
            if (bookToBorrow1 != null && bookToBorrow1.BorrowBook())
            {
                System.Console.WriteLine($"{sandeep.Name} borrowed '{bookToBorrow1.Title}'");
            }

            // Akhil borrows "Analytics in Action"
            Book bookToBorrow2 = usfLibrary.FindBook("Analytics in Action");
            if (bookToBorrow2 != null && bookToBorrow2.BorrowBook())
            {
                System.Console.WriteLine($"{akhil.Name} borrowed '{bookToBorrow2.Title}'");
            }

            // 6. Final Display
            usfLibrary.DisplayBooks("Books after borrowing:");
            
            // The output should now match the Sample Reference Output.
        }
    }
}