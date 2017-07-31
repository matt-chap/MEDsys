using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MEDsys.Models;
using MEDsys.ViewModels;

namespace MEDsys.Controllers
{
    public class AppointmentsController : Controller
    {
        private ApplicationDbContext _context;

        public AppointmentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var appointments = _context.Appointment.Include(m => m.Client).ToList();
            appointments = _context.Appointment.Include(m => m.Employee).ToList();
            appointments = _context.Appointment.Include(m => m.ServiceLine).ToList();

            return View(appointments);    
        }

        public ViewResult New()
        {
            var client = _context.Client.ToList();
            var employee = _context.Employee.ToList();
            var serviceLine = _context.ServiceLine.ToList();

            var viewModel = new AppointmentFormViewModel
            {
                Client = client,
                Employee = employee,
                ServiceLine = serviceLine
            };

            return View("AppointmentForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var appointment = _context.Appointment.SingleOrDefault(c => c.Id == id);
            var client = _context.Client.SingleOrDefault(c => c.Id == id);

            if (appointment == null)
                return HttpNotFound();

            var viewModel = new AppointmentFormViewModel(appointment)
            {
                Client = _context.Client.ToList(),
                Employee = _context.Employee.ToList(),
                ServiceLine = _context.ServiceLine.ToList()
            };

            return View("AppointmentForm", viewModel);
        }


        //public ActionResult Details(int id)
        //{
        //   var appointments = _context.Appointment.Include(m => m.Client).ToList();
        //   appointments = _context.Appointment.Include(m => m.Employee).ToList();
        //   appointments = _context.Appointment.Include(m => m.ServiceLine).ToList();

        //    if (appointments == null)
        //        return HttpNotFound();

        //    return View(appointments);

        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new AppointmentFormViewModel(appointment)
                {
                    Client = _context.Client.ToList(),
                    Employee = _context.Employee.ToList(),
                    ServiceLine = _context.ServiceLine.ToList()
                
                };

                return View("AppointmentForm", viewModel);
            }

            if (appointment.Id == 0)
            {
                appointment.DateAdded = DateTime.Now;
                _context.Appointment.Add(appointment);
            }
            else
            {
                var appointmentInDb = _context.Appointment.Single(m => m.Id == appointment.Id);
                appointmentInDb.Id = appointment.Id;
                appointmentInDb.ClientId = appointment.ClientId;
                appointmentInDb.EmployeeId = appointment.EmployeeId;
                appointmentInDb.ServiceLineId = appointment.ServiceLineId;
                appointmentInDb.StartTime = appointment.StartTime;
                appointmentInDb.EndTime = appointment.EndTime;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Appointments");
        }
    }
}