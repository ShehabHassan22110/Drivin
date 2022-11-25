using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;



namespace Drivin.Controllers
{
    public class UsersController : Controller
    {


        private readonly UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        //[Authorize]
        public IActionResult Index()
        {
            var users = userManager.Users;
            return View(users);
        }

      

        

    }
}
