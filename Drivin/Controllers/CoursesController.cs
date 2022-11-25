using AutoMapper;
using Drivin.BL.Interfaces;
using Drivin.BL.ViewModels;
using Drivin.DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.BL.Helper;
using System;
using System.Collections.Generic;

namespace Drivin.Controllers
{

    public class CoursesController : Controller
    {
        #region ctor

        private readonly ICoursesRep coursesRep;
        private readonly IMapper mapper;



        public CoursesController(ICoursesRep coursesRep, IMapper mapper)
        {
            this.coursesRep = coursesRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult Index()
        {

            var data = coursesRep.Get();
            var model = mapper.Map<IEnumerable<CoursesVM>>(data);
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
        public IActionResult Create(CoursesVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);
                   


                    var data = mapper.Map<Courses>(model);
                    coursesRep.Create(data);
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
            var data = coursesRep.GetById(id);
            var model = mapper.Map<CoursesVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = coursesRep.GetById(id);
            var model = mapper.Map<CoursesVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(CoursesVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);
                
                    var data = mapper.Map<Courses>(model);
                    coursesRep.Edit(data);
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

            var data = coursesRep.Get();
            var model = mapper.Map<IEnumerable<CoursesVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = coursesRep.GetById(id);
            var model = mapper.Map<CoursesVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(CoursesVM model)
        {
            try
            {
                var data = mapper.Map<Courses>(model);
                coursesRep.Delete(data);
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
