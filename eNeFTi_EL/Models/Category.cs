using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("Categories")]
    public class Category /*: TheBase<int>*/
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Kategori adının uzuluğu 2 ile 50 karakter arasında olmalıdır!")]
        public string CategoryName { get; set; }
        [StringLength(500, ErrorMessage = "Kategori açıklamasının uzunluğu en fazla 500 karakter olmalıdır!")]
        public string CategoryDescription { get; set; }

        public int? BaseCategoryId { get; set; }
        [ForeignKey("BaseCategoryId")]
        public virtual Category BaseCategory { get; set; }
        //public virtual List<Product> ProductList { get; set; }
        public virtual List<Category> CategoryList { get; set; }
    }
}
