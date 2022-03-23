using eNeFTi_EL.Enums;
using eNeFTi_EL.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("PassiveUsers")]
    public class PassiveUser : PersonBase
    {
        public RoleNames TargetRole { get; set; }
        public string UserId { get; set; } //Identity Model'in ID değeri burada Foreign Key olacaktır.
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
    }
}
