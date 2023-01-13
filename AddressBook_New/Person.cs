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
        //Uc3..creating method for editting existing contact in address book
        public void EditContact()
        {
            if (personDetails.Count != 0)
            {
                Console.WriteLine("Enter contact to modify:");
                string edit = Console.ReadLine();
                foreach (var person in personDetails)
                {
                    //ToUpper used to convert to uppercase 
                    if (person.firstName.ToUpper() == edit.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");

                            int Option = Convert.ToInt32(Console.ReadLine());
                            
                            //Switch case statement taken to choose desired operation
                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.phoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.city = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.zip = Console.ReadLine();
                                    break;
                                case 8:
                                    return;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact does not exist");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
            
        
    }
}
