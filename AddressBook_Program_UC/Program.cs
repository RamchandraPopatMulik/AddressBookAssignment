using AddressBook_Program_UC.Model;
using AddressBook_Program_UC.Repository;

namespace AddressBook_Program_UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome AddressBook !!!!!\n");
            

                Console.WriteLine("Enter First Name : ");
                string? firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name :");
                string? lastName = Console.ReadLine();

                Console.WriteLine("Enter Mobile Number :");
                long mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Email ID : ");
                string? email = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                string? address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                string? city = Console.ReadLine();

                Console.WriteLine("Enter State : ");
                string? state = Console.ReadLine();

                Console.WriteLine("Enter Zip Code : ");
                int zip = Convert.ToInt32(Console.ReadLine());
            ContactDetails contact = null;
                 contact = new ContactDetails()
                {
                    First_Name = firstName,
                    Last_Name = lastName,
                    MobileNumber = mobileNumber,
                    Email = email,
                    Address = address,
                    State = state,
                    City = city,
                    ZipCode = zip

                };

            ContactRepository contactDetailsRepository = new ContactRepository();
            contactDetailsRepository.AddContactDetails(contact);
            contactDetailsRepository.DisplayContact();
        }
    }
}