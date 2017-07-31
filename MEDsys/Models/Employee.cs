using System;
using System.ComponentModel.DataAnnotations;

namespace MEDsys.Models
{
    public class Employee
    {
        public int Id { get; set; }

        //[Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Specialty { get; set; }

    }
}