using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("Products")]
    public class Product /*: TheBase<int>*/
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ürün adı 2 ile 50 karakter aralığında olmalıdır!")]
        public string ProductName { get; set; }
        [StringLength(500, ErrorMessage = "Ürün açıklaması en fazla 500 karakter olmalıdır!")]
        public string Description { get; set; }

        [StringLength(8, ErrorMessage = "Ürün kodu en fazla 8 karakter olmalıdır!")]
        
        public string ProductCode { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual List<ProductPicture> ProductPictureList { get; set; }
    }
}
