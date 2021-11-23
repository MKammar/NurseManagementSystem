using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NurseManagmentSystem.DAL.Contracts;
using NurseManagmentSystem.Models;

namespace NurseManagmentSystem.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        IRepositoryBase<Patient> _patients;
        
        public PatientController(IRepositoryBase<Patient> patients)
        {
            _patients = patients;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult PatientList()
        {
            var model = _patients.GetAll();
            return View(model);
        }

        public ActionResult CreatePatient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePatient([Bind("id,fullname,email,phonenumber,age,gender,nurseId")] Patient patient)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            patient.nurseId = userId;
            if (ModelState.IsValid)
            {
                _patients.Create(patient);
            }
            
            return RedirectToAction(nameof(PatientList));

        }

        public ActionResult EditPatient(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var patient =  _patients.GetById(id);
            if(patient == null)
            {
                return NotFound();
            }
            return View(patient);

        }
        [HttpPost]
        public ActionResult EditPatient(int id, [Bind("id,fullname,email,phonenumber,age,gender,nurseId")] Patient patient)
        {
            if(id != patient.id)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            patient.nurseId = userId;
            if (ModelState.IsValid)
            {
                _patients.Update(patient);
            }
           
            return RedirectToAction(nameof(PatientList));
        }

        public ActionResult DeletePatient(int id) 
        {
            if(id == null)
            {
                return NotFound();
            }
            var patient = _patients.GetById(id);
            if(patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var patient = _patients.GetById(id);
            _patients.Delete(patient);

            return RedirectToAction(nameof(PatientList));

        }


    }
}
