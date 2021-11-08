using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    [Index(nameof(CustomerCode), IsUnique = true)]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int PersonId { get; set; } //fk
        public string CustomerCode { get; set; }
        public string PurchaseHistory { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}