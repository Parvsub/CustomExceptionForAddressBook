namespace CustomExceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            AddressBookProblem addressBookProblem = new AddressBookProblem();


            while (true)
            {
                Console.WriteLine("Address Book Menu");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Edit Entry");
                Console.WriteLine("3. View All Entries");
                Console.WriteLine("4. Delete Entry");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice (1-5):");

                try
                {

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 6)
                    {
                        throw new CustomException("Invalid Input");
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name");
                            string firstName = Console.ReadLine();

                            Console.WriteLine("Enter last name:");
                            string lastName = Console.ReadLine();

                            Console.WriteLine("Enter ContactNumber");
                            string contactnumber = Console.ReadLine();

                            Console.WriteLine("Enter Email");
                            string email = Console.ReadLine();

                            Console.WriteLine("Enter City");
                            string city = Console.ReadLine();

                            Console.WriteLine("Enter State");
                            string state = Console.ReadLine();

                            Console.WriteLine("Enter ZipCode");
                            string zipcode = Console.ReadLine();


                            AddressBook entry = new AddressBook
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                ContactNumber = contactnumber,
                                Email = email,
                                City = city,
                                State = state,
                                ZipCode = zipcode
                            };
                            addressBookProblem.AddDetail(entry);
                            break;
                        case 2:
                            Console.WriteLine("Enter first name of the entry to edit:");
                            string editFirstName = Console.ReadLine();
                            addressBookProblem.EditEntry(editFirstName);
                            break;

                        case 3:
                            addressBookProblem.ViewAllEntries();
                            break;

                        case 4:
                            Console.WriteLine("Enter first name of the entry to delete:");
                            string deleteFirstName = Console.ReadLine();
                            addressBookProblem.DeleteEntry(deleteFirstName);
                            break;

                        case 5:
                            Console.WriteLine("Exiting program.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }

                catch (CustomException ex)
                {
                    Console.WriteLine("Invalid Input please enter between 1-5 ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception caught:" + ex.Message);
                }

                Console.WriteLine();
            }
        }
    }
}