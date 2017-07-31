using System;
using System.ComponentModel.DataAnnotations;


namespace MEDsys.Models
{
    public class Client
    {
        public int Id { get; set; }

        //[Required]
        //[StringLength(255)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }
        
    }
}