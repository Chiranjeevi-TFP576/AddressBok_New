using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_New
{
    public class Person
    {
        public  List<Contact> personDetails = new List<Contact>();
        public Dictionary<string, Dictionary<string, string>> AddressBook;
        public static Dictionary<string, List<Contact>> addressBookSystem = new Dictionary<string, List<Contact>>();
        Dictionary<String, Dictionary<String, Dictionary<String, String>>> AddressBookCollection = new Dictionary<string, Dictionary<String, Dictionary<String, String>>>();
        String CurrentAddressBookName = "default";
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
        //UC4_method for deleating or remove a existing contact
        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name to remove persone :");
            string delete = Console.ReadLine();

            foreach (Contact person in personDetails)
            {
                if (person.firstName.ToLower() == delete.ToLower())
                {
                    Console.WriteLine("Are you sure you want to delete this contact?(Y/N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        personDetails.Remove(person);
                        Console.WriteLine("\nContact is deleted");
                    }
                    Console.WriteLine("\n\nContact Deleted from the List !");
                    return;
                }
                else
                {
                    Console.WriteLine("Contact not Found ! ");

                }
            }


        }
        //UC5_Adding another contact
        public void MultiPleContacts()
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
        public void CreateAddressBook()
        {
            AddressBook= new Dictionary<string, Dictionary<string, string>>();
            Console.WriteLine("Address Book Name: ");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
                Console.WriteLine("Address Book already exist");
            else
            {
                AddressBookCollection.Add(addressBookName, AddressBook);
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book created");
            }
        }
        public void ChangeAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
            {
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book changed");
            }
            else
                Console.WriteLine("Address Book doesn't exist");
        }
        

        //UC8_SearchPersonCityOrState
        public  void SearchByCityOrState()
        {

            Console.WriteLine("Do you want to search city or state for contact then press 1 or press 2 for exit ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num == 1)
            {
                List<Contact> tempcontacts = new List<Contact>();
                Console.WriteLine("Enter the city or state to search :");
                string iCity = Console.ReadLine();
                foreach (var kv in addressBookSystem)
                {
                    var list = kv.Value.Where(x => x.city.Equals(iCity)).ToList();
                    tempcontacts.AddRange(list);
                }
                Console.WriteLine("Here are found persons : ");
                foreach (Contact contact in tempcontacts)
                {
                    Console.WriteLine(contact.firstName);
                }
                Console.WriteLine("Do you want to search city or state for contact then press 1 or press 2 for exit ");
                num = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void SortingListcity()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = personDetails.OrderBy(s => s.city).ToList();
            SortedList = personDetails.OrderBy(s => s.state).ToList();
            foreach (var data in SortedList)
            {
                if (personDetails.Contains(data))
                {
                    Console.WriteLine("*************Contact Details****************");
                    Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                    Console.WriteLine($"Address of person is     : {data.address}");
                    Console.WriteLine($"State                    : {data.state}");
                    Console.WriteLine($"City                     : {data.city}");
                    Console.WriteLine($"Zip                      : {data.zip}");
                    Console.WriteLine($"Email of person          : {data.email}");
                    Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                    Console.WriteLine();
                }
            }
        }


    }

        
    
}
