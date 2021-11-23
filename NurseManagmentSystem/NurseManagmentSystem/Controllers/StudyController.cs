using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NurseManagmentSystem.DAL.Contracts;
using NurseManagmentSystem.Mappers;
using NurseManagmentSystem.Models;


namespace NurseManagmentSystem.Controllers
{
    [Authorize]
    public class StudyController : Controller
    {
        IRepositoryBase<Patient> _patients;
        IRepositoryBase<Device> _devices;
        IRepositoryBase<Study> _studies;
        IRepositoryBase<HeartRate> _heartRates;
        IRepositoryBase<Comment> _comments;
        IRepositoryBase<Notification> _notifications;
        private readonly IHostingEnvironment _ih;

        
        public StudyController(IRepositoryBase<Patient> patients, IRepositoryBase<Device> devices, IRepositoryBase<Study> studies, IRepositoryBase<HeartRate> heartRates, IRepositoryBase<Comment> comments, IRepositoryBase<Notification> notifications, IHostingEnvironment ih)
        {
            _patients = patients;
            _devices = devices;
            _studies = studies;
            _heartRates = heartRates;
            _comments = comments;
            _notifications = notifications;
            _ih = ih;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult StudyList()
        {
            var studies = _studies.GetAll();
            DateTime localDate = DateTime.Now;
            foreach (var item in studies)
            {
               if (item.startTime.AddSeconds(item.duration) < localDate)
                {
                    item.duration = 0;
                }
                else
                {
                    item.duration = 1;
                }
            }
            
            return View(studies);
        }

        public IActionResult CreateStudy()
        {
            var patients = _patients.GetAll();
            var devices = _devices.GetFiltered();

            ViewBag.patients = patients;
            ViewBag.devices = devices;
            

            return View();
        }

        public List<Double> ReadCSVFile(string location)
        {
            List<Double> rates = new List<double>();
                using(var reader = new StreamReader(location))
                using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        csv.Context.RegisterClassMap<HeartRateMapper>();
                        var rate = csv.GetRecord<HeartRate>();
                        rates.Add(rate.HR);
                        //Debug.WriteLine(rate.HR);
                    }
                }
            return rates;
        }

        public Boolean isInteger(string val)
        {
            int outVal = Int32.Parse(val);
            if(int.TryParse(val, out outVal))
            {
                return true;
            }
            return false;
        }

        [HttpPost]
        public IActionResult CreateStudy([Bind("id,patientId,deviceId,startTime,duration")] Study study, IFormCollection form, IFormFile csvfile)
        {
            List<Double> rates = new List<double>();
            string d = form["duration"];
            string[] s = d.Split(":");
            var patientName = _patients.GetById(study.patientId);

            if (d!=null && isInteger(s[0]) && isInteger(s[1]) && isInteger(s[2]))
            {
                int newDuration = Int32.Parse(s[0]) * 3600 + Int32.Parse(s[1]) * 60 + Int32.Parse(s[2]);
                study.duration = newDuration;
               
                _studies.Create(study);

                if (csvfile != null)
                {
                    var name = Path.Combine(_ih.WebRootPath + "/files", Path.GetFileName(csvfile.FileName));

                    using (FileStream fs = System.IO.File.Create(name))
                    {
                        csvfile.CopyTo(fs);
                        fs.Flush();
                    }



                    rates = ReadCSVFile(name);
                    var notification = new Notification();
                    notification.message = patientName.fullname +" sends data that is out of range";
                    var isfound = rates.Find(x => x > 100 || x < 50);
                    Debug.WriteLine(isfound);

                    if(isfound != null)
                    {
                        _notifications.Create(notification);
                    }
                    

                    foreach (var r in rates)
                    {
                        HeartRate heart = new HeartRate();
                        heart.studyId = study.id;
                        heart.HR = r;
                        _heartRates.Create(heart);
                    }
                }
            }
            

            

            
            
            return RedirectToAction(nameof(StudyList));
        }

        public ActionResult ChartHeartRate(int id)
        {
           var rates =  _heartRates.GetFilteredById(id);
           return Json(rates);
           
        }

        public ActionResult AddComment(IFormCollection form)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Comment comment = new Comment();
            comment.studyId =Int32.Parse(form["sId"]);
            comment.cmnt = form["comment"];
            comment.nurseId = userId;

            if (comment.cmnt != null)
            {
                _comments.Create(comment);
            }
           

            return RedirectToAction(nameof(StudyList));
        }
    }
}
