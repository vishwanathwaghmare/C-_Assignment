using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstract_Interface
{
    public interface IContact
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
    }

    public abstract class PhoneBook
    {
        protected List<IContact> contacts = new List<IContact>();

        // Add a contact to the phone book
        public abstract void AddContact(IContact contact);

        // Search for a contact by name
        public abstract IContact SearchContact(string name);

        // Display all contacts in the phone book
        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
            }
        }
    }
    // Implement the IContact interface with a concrete class
    public class Contact : IContact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    // Implement the PhoneBook abstract class
    public class MyPhoneBook : PhoneBook
    {
        // Add a contact to the phone book
        public override void AddContact(IContact contact)
        {
            contacts.Add(contact);
        }

        // Search for a contact by name
        public override IContact SearchContact(string name)
        {
            return contacts.Find(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

    class PhoneBook1
    {
        static void Main(string[] args)
        {
            MyPhoneBook phoneBook = new MyPhoneBook();

            // Add contacts
            phoneBook.AddContact(new Contact { Name = "Vishwanath", PhoneNumber = "7875090559" });
            phoneBook.AddContact(new Contact { Name = "sagar", PhoneNumber = "9552258012" });

            // Search for a contact
            string searchName = "sagar";
            IContact foundContact = phoneBook.SearchContact(searchName);
            if (foundContact != null)
            {
                Console.WriteLine($"Contact found: Name: {foundContact.Name}, Phone Number: {foundContact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine($"Contact with name '{searchName}' not found.");
            }

            // Display all contacts
            Console.WriteLine("\nAll Contacts:");
            phoneBook.DisplayContacts();
        }
    }

}
