using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Index(nameof(PersonId, EmployeeCode), IsUnique = true)]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonId { get; set; } 
        //fk and uk
        public string EmployeeCode { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinedDate { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; } 
    }
}