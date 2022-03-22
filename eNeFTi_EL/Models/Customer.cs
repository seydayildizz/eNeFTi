using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("Customers")]
    public class Customer : PersonBase
    {
        [ForeignKey("UserId")]
        public string UserId { get; set; } //Identity Model'in ID değeri burada Foreign Key olacaktır.
        
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
