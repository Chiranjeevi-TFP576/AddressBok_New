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
                Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-View the AddressBook ");
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
                }
            }
           
                   
        }
    }
}