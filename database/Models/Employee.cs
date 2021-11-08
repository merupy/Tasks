using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    [Index("PersonId","EmployeeCode", IsUnique = true)]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int PersonId { get; set; } 
        //fk and uk
        public string EmployeeCode { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinedDate { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; } 
    }
}