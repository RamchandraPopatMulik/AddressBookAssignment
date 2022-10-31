using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Program_UC.Model
{
    internal class ContactDetails
    {   
        public string? Unique_Name { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public long? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }
    }
}
