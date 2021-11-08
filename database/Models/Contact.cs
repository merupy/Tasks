using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace database.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactInfo { get; set; }
    }
}