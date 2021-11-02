using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactInfo { get; set; }
    }
}