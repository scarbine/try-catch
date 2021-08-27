using System;
using System.Collections.Generic;
using System.Linq;

namespace try_catch
{
    public class AddressBook
    {
       public Dictionary<string, Contact> addressBook;

       public AddressBook()
       {
           addressBook = new Dictionary<string, Contact>();
       }



    public void AddContact(Contact contact)
    {   
        try
        {
        addressBook.Add(contact.Email, contact);
        }
        catch
        {
        Console.WriteLine($" Excption! You tried to add a Key value pair that has already been added.{contact.Email}");
        }
    }

    public Contact GetByEmail(string email)
    {
        
        return addressBook[email];
    }

    }

}