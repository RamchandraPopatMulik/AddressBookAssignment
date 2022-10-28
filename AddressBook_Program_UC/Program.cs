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
            Console.Write("Enter 'f' to get Contact Details by First Name : ");
            var name = Console.ReadLine();
            while (name == "f")
            {
                Console.Write("Enter First Name : ");
                contactDetailsRepository.GetUsingFirstName(Console.ReadLine());
                Console.Write("Enter 'g' to get Contact Details by First Name otherwise Enter any key : ");
                name = Console.ReadLine();
            }
            Console.Write("Enter 'e' to edit contact using mobile number : ");
            var edit = Console.ReadLine();
            while (edit == "e")
            {
                Console.Write("Enter Mobile Number : ");
                contactDetailsRepository.EditContactDetails(Convert.ToInt64(Console.ReadLine()));

                Console.Write("Enter 'e' to edit contact using mobile number otherwise Enter any key : ");
                edit = Console.ReadLine();
            }
            Console.Write("Enter 'd' to delete contact using Mobile Number : ");
            var delete = Console.ReadLine();
            while (delete == "d")
            {
                Console.Write("Enter Mobile Number Which you want to Delete Contact : ");
                contactDetailsRepository.DeleteContact(Convert.ToInt64(Console.ReadLine()));
                Console.Write("Enter 'd' to Delete contact using mobile number otherwise Enter any key : ");
                delete = Console.ReadLine();
            }
            contactDetailsRepository.DisplayContact();
        }
    }
}