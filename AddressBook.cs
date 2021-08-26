using System;
using System.Collections.Generic;
using System.Linq;

namespace try_catch
{
    public class AddressBook
    {
       public Dictionary<string, string> addressBook;



    public void AddContact(Contact contact)
    {
        addressBook.Add(contact.Email, contact.FullName);
    }

    public void GetByEmail(string email)
    {
        // Contact foundContact = addressBook. (e => email == e);
        
    }

    }

}