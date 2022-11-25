using AutoMapper;
using Drivin.BL.Interfaces;
using Drivin.BL.ViewModels;
using Drivin.DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Drivin.Controllers
{

    public class ContactController : Controller
    {
        #region ctor

        private readonly IContactRep contactRep;
        private readonly IMapper mapper;


        public IMapper Mapper { get; }

        public ContactController(IContactRep contactRep, IMapper mapper)
        {
            this.contactRep = contactRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult DashboardIndex()
        {

            var data = contactRep.Get();
            var model = mapper.Map<IEnumerable<ContactVM>>(data);
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
        public IActionResult Create(ContactVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    var data = mapper.Map<Contact>(model);
                    contactRep.Create(data);
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
            var data = contactRep.GetById(id);
            var model = mapper.Map<ContactVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = contactRep.GetById(id);
            var model = mapper.Map<ContactVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(ContactVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var data = mapper.Map<Contact>(model);
                    contactRep.Edit(data);
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
        public IActionResult Index()
        {

            var data = contactRep.Get();
            var model = mapper.Map<IEnumerable<ContactVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = contactRep.GetById(id);
            var model = mapper.Map<ContactVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(ContactVM model)
        {
            try
            {
                var data = mapper.Map<Contact>(model);
                contactRep.Delete(data);
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
