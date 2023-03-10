using System.Runtime.InteropServices;

namespace AddressBook_New
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Problem");

            Person person = new Person();
            while(true)
            {
                Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-View the AddressBook \n 3-Edit the Address Book  \n 4-Delete the Contact Details \n 5-Multiple Contacts\n 6-NewAdressBook\n 8-SearchingCityOrState\n 9-SortingCityOrState");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        person.AddPerson();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 2:
                        person.Display();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 3:
                        person.EditContact();
                        Console.WriteLine("Enter any key to exit");
                        break;
                        
                    case 4:
                        person.DeleteContact();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 5:
                        person.MultiPleContacts();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 6:
                        person.CreateAddressBook();
                        person.Display();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    
                    case 8:
                        person.SearchByCityOrState();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 9:
                        person.SortingListcity();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    



                }
            }
           
                   
        }
    }
}