using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.IdentityModels
{
    public class AppRole : IdentityRole
    {
        [StringLength(400, ErrorMessage = "Açıklama alanına en fazla 400 karakter girebilirsiniz! ")]
        public string Description { get; set; }
    }
}
