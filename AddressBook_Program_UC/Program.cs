using AddressBook_Program_UC.Model;
using AddressBook_Program_UC.Repository;

namespace AddressBook_Program_UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome AddressBook !!!!!");
            ContactDetails contact = new ContactDetails()
            {
                First_Name = "Ramchandra",
                Last_Name = "Mulik",
                MobileNumber = 9604340676,
                Email = "mulikram2016@gmail.com",
                Address = "At Post Revangoan",
                City = "Vita",
                State = "Maharashtra",
                ZipCode = 415311
            };
            ContactDetails contact1 = new ContactDetails()
            {
                First_Name = "Shrikant",
                Last_Name = "Rabade",
                MobileNumber = 9096848446,
                Email = "rabadeshrikant1511@gmail.com",
                Address = "At Post Bambawade",
                City = "Kolhapur",
                State = "Maharashtra",
                ZipCode = 565565
            };
            ContactRepository contactDetailsRepository = new ContactRepository();
            contactDetailsRepository.AddContactDetails(contact);
            contactDetailsRepository.AddContactDetails(contact1);
            contactDetailsRepository.DisplayContact();
        }
    }
}