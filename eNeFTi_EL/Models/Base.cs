using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    public class Base<T>:IBase
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Kayıt Tarihi")]
        public DateTime RegisterDate { get; set; }
    }
}
