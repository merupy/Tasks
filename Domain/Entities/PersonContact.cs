using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Index(nameof(PersonId, ContactId), IsUnique = true)]
    public class PersonContact 
    {
        public int PersonId { get; set; }
        public int ContactId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }

        [ForeignKey(nameof(ContactId))]
        public Contact Contact { get; set; }
    }
}