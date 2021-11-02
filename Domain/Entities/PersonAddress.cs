using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Index(nameof(PersonId, AddressId), IsUnique = true)]
    public class PersonAddress
    {

        public int PersonId { get; set; }
        public int AddressId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } 
    }
}