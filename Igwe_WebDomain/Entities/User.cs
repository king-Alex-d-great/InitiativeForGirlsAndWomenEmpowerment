using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igwe.Domain.Enumerators;

namespace Igwe.Domain.Entities
{
    class User
    {

        public string FullName { get; set; }       
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte ProfilePicture { get; set; }      
        public State Location { get; set; }
        public AccountType AccountType { get; set; }
    }
}
