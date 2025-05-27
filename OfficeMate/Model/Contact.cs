using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeMate.Model
{
    public class Contact
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhonePersonal { get; set; }
        public string PhoneInternal { get; set; }
    }
}
