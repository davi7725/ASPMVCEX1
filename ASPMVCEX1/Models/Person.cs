using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVCEX1.Models
{
    [Serializable]
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
    }
}
