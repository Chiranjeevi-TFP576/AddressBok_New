using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_New
{
    public class Person
    {
        public List<Contact> personDetails = new List<Contact>();
        //UC1_Create Contact
        public void AddPerson()
        {
            Contact person = new Contact();

            Console.WriteLine("Enter first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter address name");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city name");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state name");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zip name");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email id");
            person.email = Console.ReadLine();
            personDetails.Add(person);
        }
        //Adding another contact
        public void MultiPersons()
        {
            AddPerson();
            Console.Write("\n Do You Want To Add Another Contact (Y/N) :  ");
            string choice = Console.ReadLine();
            while (choice == "Y" || choice == "y")
            {
                AddPerson();
                Console.Write("\nDo You Want To Add Another Contact (Y/N) :  ");
                choice = Console.ReadLine();
            }

        }
        //Printing the address book details 
        public void Display()
        {
            foreach (Contact person in personDetails)
            {
                Console.WriteLine("---Address book details----");
                Console.WriteLine("First Name:" + person.firstName);
                Console.WriteLine("Last Name:" + person.lastName);
                Console.WriteLine("Address:" + person.address);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("State:" + person.state);
                Console.WriteLine("Zip:" + person.zip);
                Console.WriteLine("Phone Number:" + person.phoneNumber);
                Console.WriteLine("Email:" + person.email);
            }
        }
    }
}
