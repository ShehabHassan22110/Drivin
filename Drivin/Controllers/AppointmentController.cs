using AutoMapper;
using Drivin.BL.Interfaces;
using Drivin.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Store.BL.Helper;
using System.Collections.Generic;
using System;
using Drivin.DAL.Entity;
using Microsoft.AspNetCore.Authorization;

namespace Drivin.Controllers
{

    public class AppointmentController : Controller
    {
        #region ctor

        private readonly IAppointmentRep appointmentRep;
        private readonly IMapper mapper;


        public IMapper Mapper { get; }

        public AppointmentController(IAppointmentRep appointmentRep, IMapper mapper)
        {
            this.appointmentRep = appointmentRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult Index()
        {

            var data = appointmentRep.Get();
            var model = mapper.Map<IEnumerable<AppointmentVM>>(data);
            return View(model);
        }
        #endregion
        [Authorize]

        #region Create 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AppointmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    var data = mapper.Map<Appointment>(model);
                    appointmentRep.Create(data);
                    return RedirectToAction("Index");
                }
                return View(model);

            }
            catch (Exception)
            {
                return RedirectToAction("Error404");

            }



        }
        #endregion
        [Authorize]

        #region Details
        public IActionResult Details(int id)
        {
            var data = appointmentRep.GetById(id);
            var model = mapper.Map<AppointmentVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = appointmentRep.GetById(id);
            var model = mapper.Map<AppointmentVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(AppointmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var data = mapper.Map<Appointment>(model);
                    appointmentRep.Edit(data);
                    return RedirectToAction("Index");
                }
                return View(model);

            }
            catch (Exception)
            {
                return View(model);
            }

        }
        #endregion


        #region Get 
        public IActionResult WebsiteIndex()
        {

            var data = appointmentRep.Get();
            var model = mapper.Map<IEnumerable<AppointmentVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = appointmentRep.GetById(id);
            var model = mapper.Map<AppointmentVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(AppointmentVM model)
        {
            try
            {
                var data = mapper.Map<Appointment>(model);
                appointmentRep.Delete(data);
                return RedirectToAction("Index");


            }
            catch (Exception)
            {
                return View(model);
            }

        }
        #endregion

    }
}
