using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    [Index("PersonId", "AddressId", IsUnique = true)]
    public class PersonAddress
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int AddressId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        // [ForeignKey("AddressId")]
        // public Address Address { get; set; } 
    }
}