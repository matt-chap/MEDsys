using System;
using System.ComponentModel.DataAnnotations;

namespace MEDsys.Models
{
    public class ServiceLine
    {
        public int Id { get; set; }

        //[Required]
        [StringLength(255)]
        public string Service { get; set; }

        [StringLength(255)]
        public string ServiceType { get; set; }

        //[Display(Name = "Release Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
    }

}