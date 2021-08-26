using System;
using System.Collections.Generic;
using System.Linq;

namespace try_catch
{
    public class AddressBook
    {
       public Dictionary<string, Contact> addressBook;



    public void AddContact(Contact contact)
    {
        addressBook.Add(contact.Email, contact);
    }

    public Contact GetByEmail(string email)
    {
        
        return addressBook[email];
    }

    }

}