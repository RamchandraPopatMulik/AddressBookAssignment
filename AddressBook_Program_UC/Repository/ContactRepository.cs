using AddressBook_Program_UC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Program_UC.Repository
{
    internal class ContactRepository
    {
        public Dictionary<long, ContactDetails> contactDetailDictionary = new Dictionary<long, ContactDetails>();
        public void AddContactDetails(ContactDetails contactDetails)
        {
            contactDetailDictionary.Add(Convert.ToInt64(contactDetails.MobileNumber), contactDetails);
        }
        public void DisplayContact()
        {
            foreach (var item in contactDetailDictionary)
            {
                Console.WriteLine("First Name is : " + item.Value.First_Name);
                Console.WriteLine("Last Name is : " + item.Value.Last_Name);
                Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine("Email ID is : " + item.Value.Email);
                Console.WriteLine("Address is " + item.Value.Address);
                Console.WriteLine("City is : " + item.Value.City);
                Console.WriteLine("State is : " + item.Value.State);
                Console.WriteLine("ZipCode is : " + item.Value.ZipCode);
                Console.WriteLine();
            }
        }
    }
}
