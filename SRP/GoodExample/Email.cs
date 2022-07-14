using System;

namespace SRP.GoodExample
{
    public class Email
    {
        public string EmailAddress { get; }

        public Email(string emailAddress)
        {
            if (ValidateEmailAddress(emailAddress))
            {
                this.EmailAddress = emailAddress;
            }
            else
            {
                throw new Exception("Invalid mail address!");
            }
        }

        private bool ValidateEmailAddress(string email)//representative email validations...
        {
            return email.Contains("@");
        }
    }

    
}
