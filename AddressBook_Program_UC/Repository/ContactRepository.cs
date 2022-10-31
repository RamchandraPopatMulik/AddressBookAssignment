using AddressBook_Program_UC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook_Program_UC.Repository
{
    internal class ContactRepository
    {
        public Dictionary<string, ContactDetails> contactDetailDictionary = new Dictionary<string, ContactDetails>();
        public void AddContactDetails(ContactDetails contactDetails)
        {
            contactDetailDictionary.Add(contactDetails.Unique_Name, contactDetails);
        }
        public void EditContactDetails( string Unique_Name )
        {
            var obj = contactDetailDictionary[Unique_Name];
            contactDetailDictionary.Remove(Unique_Name);
            Console.WriteLine("Select Details Which You Want to Edit : \n1 First Name \n2 Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            int EditDetails = Convert.ToInt32(Console.ReadLine());
            switch(EditDetails)
            {
                case 1:
                    Console.WriteLine("Enter Your First Name to Update : ");
                    string? firstname=Console.ReadLine();
                    obj.First_Name = firstname;
                    contactDetailDictionary.Add(obj.Unique_Name,obj);
                    break;

                    case 2:
                    Console.WriteLine("Enter Your Last Name to Update : ");
                    string? lastname = Console.ReadLine();
                    obj.Last_Name = lastname;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;

                    case 3:
                    Console.WriteLine("Enter Your Mobile Number to Update : ");
                    long mobileNumber =Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobileNumber;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
                    case 4:
                    Console.WriteLine("Enter Your Email ID to Update : ");
                    string? email = Console.ReadLine();
                    obj.Email = email;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
                    case 5:
                    Console.WriteLine("Enter Your Address to Update : ");
                    string? address = Console.ReadLine();
                    obj.Address = address;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
                    case 6:
                    Console.WriteLine("Enter Your City to Update : ");
                    string? city = Console.ReadLine();
                    obj.City = city;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
                    case 7:
                    Console.WriteLine("Enter Your State to Update : ");
                    string? state = Console.ReadLine();
                    obj.State = state;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
                    case 8:
                    Console.WriteLine("Enter Your ZipCode to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    obj.ZipCode = zipcode;
                    contactDetailDictionary.Add(obj.Unique_Name, obj);
                    break;
            }
        }
        public void EditContactDetailsByFirstName(string fname)
        {
            var persiondetail = GetUsingFirstNameDetail(fname);
            contactDetailDictionary.Remove(persiondetail.Unique_Name);
            Console.WriteLine("Select Details Which You Want to Edit : \n1 First Name \n2 Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            int EditDetails = Convert.ToInt32(Console.ReadLine());
            switch (EditDetails)
            {
                case 1:
                    Console.WriteLine("Enter Your First Name to Update : ");
                    string? firstname = Console.ReadLine();
                    persiondetail.First_Name = firstname;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;

                case 2:
                    Console.WriteLine("Enter Your Last Name to Update : ");
                    string? lastname = Console.ReadLine();
                    persiondetail.Last_Name = lastname;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;

                case 3:
                    Console.WriteLine("Enter Your Mobile Number to Update : ");
                    long mobileNumber = Convert.ToInt64(Console.ReadLine());
                    persiondetail.MobileNumber = mobileNumber;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
                case 4:
                    Console.WriteLine("Enter Your Email ID to Update : ");
                    string? email = Console.ReadLine();
                    persiondetail.Email = email;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
                case 5:
                    Console.WriteLine("Enter Your Address to Update : ");
                    string? address = Console.ReadLine();
                    persiondetail.Address = address;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
                case 6:
                    Console.WriteLine("Enter Your City to Update : ");
                    string? city = Console.ReadLine();
                    persiondetail.City = city;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
                case 7:
                    Console.WriteLine("Enter Your State to Update : ");
                    string? state = Console.ReadLine();
                    persiondetail.State = state;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
                case 8:
                    Console.WriteLine("Enter Your ZipCode to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    persiondetail.ZipCode = zipcode;
                    contactDetailDictionary.Add(persiondetail.Unique_Name, persiondetail);
                    break;
            }
        }
        public ContactDetails GetUsingFirstNameDetail(string firstName)
        {
            foreach (var item in contactDetailDictionary)
            {
                if(item.Value.First_Name.Contains(firstName))
                {
                    return item.Value;
                }
            }
            return null;
        }
        public void GetUsingFirstName(string firstname)
        {
            foreach (var item in contactDetailDictionary)
            {
                if (item.Value.First_Name==firstname)
                {
                    item.Value.First_Name.Contains(firstname);
                    Console.WriteLine(" First Name is : " + item.Value.First_Name);
                    Console.WriteLine(" Last Name is : " + item.Value.Last_Name);
                    Console.WriteLine(" Mobile Number is : " + item.Value.MobileNumber);
                    Console.WriteLine(" Email ID is : " + item.Value.Email);
                    Console.WriteLine(" Address is " + item.Value.Address);
                    Console.WriteLine(" City is : " + item.Value.City);
                    Console.WriteLine(" State is : " + item.Value.State);
                    Console.WriteLine(" ZipCode is : " + item.Value.ZipCode);
                    Console.WriteLine();
                }
            }
        }
        public void DeleteContact(string Unique_Name)
        {
            contactDetailDictionary.Remove(Unique_Name);
        }
        public void DisplayContact()
        {
            foreach (var item in contactDetailDictionary)
            {
                Console.WriteLine(" First Name is : " + item.Value.First_Name);
                Console.WriteLine(" Last Name is : " + item.Value.Last_Name);
                Console.WriteLine(" Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine(" Email ID is : " + item.Value.Email);
                Console.WriteLine(" Address is " + item.Value.Address);
                Console.WriteLine(" City is : " + item.Value.City);
                Console.WriteLine(" State is : " + item.Value.State);
                Console.WriteLine(" ZipCode is : " + item.Value.ZipCode);
                Console.WriteLine();
            }
        }
    }
}
