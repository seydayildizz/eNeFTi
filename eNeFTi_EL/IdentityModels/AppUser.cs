using eNeFTi_EL.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.IdentityModels
{
    public class AppUser : IdentityUser
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsminiz en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "İsim alanı zorunludur!")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyisminiz en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "Soyisim alanı zorunludur!")]
        public string Surname { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string Picture { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [Required(ErrorMessage = "Cinsiyet seçimi zorunludur!")]
        public Genders Gender { get; set; }
    }
}
