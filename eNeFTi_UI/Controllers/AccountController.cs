using eNeFTi_EL.Enums;
using eNeFTi_EL.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eNeFTi_UI.Controllers
{
    public class AccountController : Controller
    {
        //Solid prensiplerine uygun bağımlıklıklardan kurtulmaya yönelik yapı oluşturulur.

        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;

        private readonly RoleManager<AppRole> _roleManager;

        public AccountController(

            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            CheckRoles();
        }
        //Global.asax dosyası olmadığı için roller burada oluşturulur
        private void CheckRoles()
        {
            var allRoles = Enum.GetNames(typeof(RoleNames));
            foreach (var item in allRoles)
            {
                if (!_roleManager.RoleExistsAsync(item).Result)
                {
                    var result = _roleManager.CreateAsync(new AppRole()
                    {
                        Name = item,
                        Description = item
                    }).Result;
                }
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


    }


}

