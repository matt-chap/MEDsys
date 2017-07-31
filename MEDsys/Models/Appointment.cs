using System;

namespace MEDsys.Models
{
    public class Appointment
    {
        public int Id { get; set; }


        public Client Client { get; set; }
        public int ClientId { get; set; }


        //[ZZruleClientOver70GeriatricsSpecialty]
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public ServiceLine ServiceLine { get; set; }
        public int ServiceLineId { get; set; }

        

        public DateTime DateAdded { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        

    }
}