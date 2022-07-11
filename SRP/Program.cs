﻿using SRP.GoodExample;
using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            PoorExample();
            //GoodExample();
            Console.ReadKey();
        }

        static void PoorExample()
        {
            PoorExample.Person person = new PoorExample.Person("abc@def.com", "Orhan","Veli");
            Console.WriteLine("Person full name : {0} {1} , e-mail : {2}",person.FirstName,person.Surname,person.Email);
        }

        static void GoodExample()
        {
            Email email = new Email("abc@def.com");
            GoodExample.Person person = new GoodExample.Person(email, "Özdemir", "Asaf");
            Console.WriteLine("Person full name : {0} {1} , e-mail : {2}", person.FirstName, person.Surname, person.Email.EmailAddress);
        }

    }
}
