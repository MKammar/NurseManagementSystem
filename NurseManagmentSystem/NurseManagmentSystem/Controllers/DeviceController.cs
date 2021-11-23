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
    public class DeviceController : Controller
    {
        IRepositoryBase<Device> _device;

        public DeviceController(IRepositoryBase<Device> device)
        {
            _device = device;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DeviceList()
        {
            var model = _device.GetAll();
            return View(model);
        }

        public ActionResult CreateDevice()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDevice([Bind("id,name,serialNumber,nurseId")] Device device)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            device.nurseId = userId;

            var isUnique = _device.UniqueData(device.serialNumber, device.id);
            if (ModelState.IsValid && isUnique)
            {
                _device.Create(device);
            }
           
            return RedirectToAction(nameof(DeviceList));

        }
        public ActionResult EditDevice(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var device = _device.GetById(id);
            if (device == null)
            {
                return NotFound();
            }
            return View(device);

        }
        [HttpPost]
        public ActionResult EditDevice(int id, [Bind("id,name,serialNumber,phonenumber,nurseId")] Device device)
        {
            if (id != device.id)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            device.nurseId = userId;

            var isUnique = _device.UniqueData(device.serialNumber, device.id);
            if (ModelState.IsValid && isUnique)
            {
                _device.Update(device);
            }
                
            return RedirectToAction(nameof(DeviceList));
        }
        public ActionResult DeleteDevice(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var device = _device.GetById(id);
            if (device == null)
            {
                return NotFound();
            }
            return View(device);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var device = _device.GetById(id);
            _device.Delete(device);

            return RedirectToAction(nameof(DeviceList));

        }
    }
}
