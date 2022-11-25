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

    public class OurTeamController : Controller
	{
        #region ctor

        private readonly IOurTeamRep ourTeamRep;
        private readonly IMapper mapper;


        public IMapper Mapper { get; }

        public OurTeamController(IOurTeamRep ourTeamRep, IMapper mapper)
        {
            this.ourTeamRep = ourTeamRep;
            this.mapper = mapper;
        }
        #endregion
        [Authorize]

        #region Get Dashboard
        public IActionResult Index()
        {

            var data = ourTeamRep.Get();
            var model = mapper.Map<IEnumerable<OurTeamVM>>(data);
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
        public IActionResult Create(OurTeamVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);



                    var data = mapper.Map<OurTeam>(model);
                    ourTeamRep.Create(data);
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
            var data = ourTeamRep.GetById(id);
            var model = mapper.Map<OurTeamVM>(data);

            return View(model);

        }
        #endregion
        [Authorize]

        #region Edit 
        public IActionResult Edit(int id)
        {
            var data = ourTeamRep.GetById(id);
            var model = mapper.Map<OurTeamVM>(data);

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(OurTeamVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
 
                    model.PhotoName = FileUpload.UploadFile("/wwwroot/Imgs", model.Photo);
                    var data = mapper.Map<OurTeam>(model);
                    ourTeamRep.Edit(data);
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

            var data = ourTeamRep.Get();
            var model = mapper.Map<IEnumerable<OurTeamVM>>(data);
            return View(model);
        }
        #endregion

        [Authorize]

        #region Delete
        public IActionResult Delete(int id)
        {
            var data = ourTeamRep.GetById(id);
            var model = mapper.Map<OurTeamVM>(data);
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(OurTeamVM model)
        {
            try
            {
                var data = mapper.Map<OurTeam>(model);
                ourTeamRep.Delete(data);
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
