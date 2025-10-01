namespace ADcomp2
{
    // Student inherits from Person
    public class Student : Person
    {
        public string Major { get; private set; }
        public int GraduationYear { get; private set; }

        // Constructor calls the base class constructor (Person) using : base(...)
        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }

        // Optional: Override GetDetails if needed for extended info, but keeping it simple for now.
    }
}