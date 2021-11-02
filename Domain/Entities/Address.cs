using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Address { get; set; }
        public Person Person { get; set; }
    }
}