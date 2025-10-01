namespace ADcomp2
{
    // Base class for all patrons (Students and Staff)
    public class Person
    {
        // Encapsulated Properties
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string ID { get; private set; }

        // Constructor
        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }

        // Method for displaying basic info
        public virtual string GetDetails()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}