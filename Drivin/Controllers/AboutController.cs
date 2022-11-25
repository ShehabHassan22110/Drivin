using AutoMapper;
using Drivin.BL.Interfaces;
using Drivin.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Drivin.DAL.Entity;
using Store.BL.Helper;
using Microsoft.AspNetCore.Authorization;

namespace Drivin.Controllers
{

    public class AboutController : Controller
    {
        #region ctor

        private readonly IAboutRep aboutRep;
        private readonly IMapper mapper;


        public IMapper Mapper { get; }

        public AboutController(IAboutRep aboutRep, IMapper mapper)
        {
            this.aboutRep = aboutRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult Index()
        {

            var data = aboutRep.Get();
            var model = mapper.Map<IEnumerable<AboutVM>>(data);
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
        public IActionResult Create(AboutVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);


                    var data = mapper.Map<About>(model);
                    aboutRep.Create(data);
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
            var data = aboutRep.GetById(id);
            var model = mapper.Map<AboutVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = aboutRep.GetById(id);
            var model = mapper.Map<AboutVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(AboutVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);

                    var data = mapper.Map<About>(model);
                    aboutRep.Edit(data);
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

            var data = aboutRep.Get();
            var model = mapper.Map<IEnumerable<AboutVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = aboutRep.GetById(id);
            var model = mapper.Map<AboutVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(AboutVM model)
        {
            try
            {
                var data = mapper.Map<About>(model);
                aboutRep.Delete(data);
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
