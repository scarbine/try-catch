using System;
using System.Collections.Generic;
using System.Linq;

namespace try_catch
{
    public class Contact
    {
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Address {get; set;}

        public string Email {get; set;}

        public string FullName 
        {
            get
            {
               return FirstName + LastName;
            }
        }

        // public Contact(string firstName, string lastName, string address, string email) 
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     Address = address;
        //     Email = email;

        // }
    }
}