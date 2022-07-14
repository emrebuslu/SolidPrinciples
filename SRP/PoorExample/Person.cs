using System;

namespace SRP.PoorExample
{
    class Person
    {
        public string Email { get; }
        public string FirstName { get; }
        public string Surname { get; }
        
        public Person(string email, string firstName, string surname)
        {

            /* <<< Single Responsibility Principle VIOLATE */
            if (ValidateEmail(email))
            {
                this.Email = email;
            }
            else
            {
                throw new Exception("Invalid mail address!");
            }
            /* Single Responsibility Principle VIOLATE >>> */

            this.FirstName = firstName;
            this.Surname = surname;
        }

        private bool ValidateEmail(string email)//representative email validations...
        {
            return email.Contains("@");
        }

    }
}
