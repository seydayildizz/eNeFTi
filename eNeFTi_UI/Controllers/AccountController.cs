using eNeFTi_BLL.Interfaces;
using eNeFTi_EL.Enums;
using eNeFTi_EL.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eNeFTi_UI.Controllers
{
    public class AccountController : BaseController
    {
        //Global Alan
        //Solid prensiplerine uygun bağımlıklıklardan kurtulmaya yönelik yapı oluşturulur.
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        //private readonly IEmailSender _emailSender;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        //Dependency Injection
        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            //IEmailSender emailSender,
            IUnitOfWork unitOfWork,
            IConfiguration configuration)
        {
            //_userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            //_emailSender = emailSender;
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }

}

