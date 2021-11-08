using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    [Index("PersonId", "ContactId", IsUnique = true)]
    public class PersonContact 
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int ContactId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
    }
}