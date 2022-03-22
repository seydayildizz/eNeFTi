using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eNeFTi_UI.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Ad alanı boş geçilemez!")]
        [Display(Name = "Ad")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez!")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "EMail alanı boş geçilemez!.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı zorunludur!")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

    }
}
