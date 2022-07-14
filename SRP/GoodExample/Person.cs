namespace SRP.GoodExample
{
    class Person
    {
        public Email Email { get; }
        public string FirstName { get; }
        public string Surname { get; }
        public Person(Email email, string firstName, string surname)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.Surname = surname;
        }
    }
}
