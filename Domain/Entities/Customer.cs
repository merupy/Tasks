using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Index(nameof(PersonId, CustomerCode), IsUnique = true)]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int PersonId { get; set; } //fk
        public string CustomerCode { get; set; }
        public string PurchaseHistory { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
    }
}