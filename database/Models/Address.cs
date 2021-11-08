using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace database.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressDescr { get; set; }
    }
}