using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MEDsys.Models;

namespace MEDsys.ViewModels
{
    public class AppointmentFormViewModel
    {
        public IEnumerable<Employee> Employee { get; set; }
        public IEnumerable<Client> Client { get; set; }
        public IEnumerable<ServiceLine> ServiceLine { get; set; }

        public int? Id { get; set; }


        [Display(Name = "Client")]
        [Required]
        public int? ClientId { get; set; }




        [Display(Name = "Employee")]
        [Required]
        public int? EmployeeId { get; set; }

        [Display(Name = "Service Line")]
        [Required]
        public int? ServiceLineId { get; set; }


        [Display(Name = "Start Time")]
        [Required]
        public DateTime? StartTime { get; set; }

        [Display(Name = "End Time")]
        [Required]
        public DateTime? EndTime { get; set; }
        
        

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Appointment" : "New Appointment";
            }
        }

        public AppointmentFormViewModel()
        {
            Id = 0;
        }

        public AppointmentFormViewModel(Appointment appointment)
        {
            Id = appointment.Id;
            ClientId = appointment.ClientId;
            EmployeeId = appointment.EmployeeId;
            ServiceLineId = appointment.ServiceLineId;
            StartTime = appointment.StartTime;
            EndTime = appointment.EndTime;

        }
    }
}