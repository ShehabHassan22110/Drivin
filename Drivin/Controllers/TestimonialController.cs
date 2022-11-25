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

    public class TestimonialController : Controller
	{
        #region ctor

        private readonly ITestimonialRep testimonialRep;
        private readonly IMapper mapper;


        public IMapper Mapper { get; }

        public TestimonialController(ITestimonialRep testimonialRep, IMapper mapper)
        {
            this.testimonialRep = testimonialRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult Index()
        {

            var data = testimonialRep.Get();
            var model = mapper.Map<IEnumerable<TestimonialVM>>(data);
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
        public IActionResult Create(TestimonialVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);


                    var data = mapper.Map<Testimonial>(model);
                    testimonialRep.Create(data);
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
            var data = testimonialRep.GetById(id);
            var model = mapper.Map<TestimonialVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = testimonialRep.GetById(id);
            var model = mapper.Map<TestimonialVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(TestimonialVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);

                    var data = mapper.Map<Testimonial>(model);
                    testimonialRep.Edit(data);
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


        #region Get Website
        public IActionResult WebsiteIndex()
        {

            var data = testimonialRep.Get();
            var model = mapper.Map<IEnumerable<TestimonialVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = testimonialRep.GetById(id);
            var model = mapper.Map<TestimonialVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(TestimonialVM model)
        {
            try
            {
                var data = mapper.Map<Testimonial>(model);
                testimonialRep.Delete(data);
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
