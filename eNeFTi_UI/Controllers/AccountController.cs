using eNeFTi_BLL.Interfaces;
using eNeFTi_EL;
using eNeFTi_EL.Enums;
using eNeFTi_EL.IdentityModels;
using eNeFTi_EL.Models;
using eNeFTi_UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eNeFTi_UI.Controllers
{
    public class AccountController : BaseController
    {
        //Global Alan
        //Solid prensiplerine uygun bağımlıklıklardan kurtulmaya yönelik yapı oluşturulur.
        private readonly UserManager<AppUser> _userManager;
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
            _userManager = userManager;
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

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var checkUserForUserName = await _userManager.FindByNameAsync(model.TCNumber);
                if (checkUserForUserName != null)
                {
                    ModelState.AddModelError(nameof(model.TCNumber), "Bu TC Kimlik ile daha önce sisteme kayıt olunmuştur!");
                    return View(model);
                }
                var checkUserForEmail = await _userManager.FindByEmailAsync(model.Email);
                if (checkUserForEmail != null)
                {
                    ModelState.AddModelError(nameof(model.Email), "Bu Email adresi ile daha önce sisteme kayıt olunmuştur!");
                    return View(model);
                }
                // Yeni kullanıcı oluşturalım
                AppUser newUser = new AppUser()
                {
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.TCNumber,
                    Gender = model.Gender
                    //TODO: Birthdate?
                    //TODO: Phone Number?
                };
                var result = await _userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(newUser, RoleNames.Passive.ToString());

                    //email gönderilmelidir
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callBackUrl = Url.Action("ConfirmEmail", "Account", new { userId = newUser.Id, code = code }, protocol: Request.Scheme);

                    var emailMessage = new EMailMessage()
                    {
                        Contacts = new string[] { newUser.Email },
                        Subject = "eNeFTi | NFT Digital Marketplace , EMail Aktivasyon",
                        Body = $"Merhaba {newUser.Name} {newUser.Surname}, <br/>Hesabınızı aktifleştirmek için <a href='{HtmlEncoder.Default.Encode(callBackUrl)}'></a> tıklayınız."
                    };

                    await _emailSender.SendAsync(emailMessage);

                    //patient tablosuna ekleme yapılmalıdır.
                    Customer newCustomer = new Customer()
                    {
                        TCNumber = model.TCNumber,
                        UserId = newUser.Id
                    };
                    if (_unitOfWork.CustomerRepo.Add(newCustomer) == false)
                    {
                        var emailMessageToAdmin = new EMailMessage()
                        {
                            Contacts = new string[]
                        { _configuration.GetSection("ManagerEmails:Email").Value },
                            CC = new string[] { _configuration.GetSection("ManagerEmails:EmailToCC").Value },
                            Subject = "MHRSLITE - HATA! Patient Tablosu",
                            Body = $"Aşağıdaki bilgilere sahip kişi eklenirken hata olmuş. Patient Tablosuna bilgileri ekleyiniz. <br/> Bilgiler: TcNumber:{model.TCNumber} <br/> UserId:{newUser.Id}"
                        };
                        await _emailSender.SendAsync(emailMessageToAdmin);
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Beklenmedik bir hata oluştu!");
                    return View(model);
                }
            }
            catch (Exception ex)
            {

                return View();
            }

        }

    }

}

