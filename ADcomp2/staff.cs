namespace ADcomp2
{
    // Staff inherits from Person
    public class Staff : Person
    {
        public string Position { get; private set; }
        public string Department { get; private set; }

        // Constructor calls the base class constructor (Person)
        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }
}