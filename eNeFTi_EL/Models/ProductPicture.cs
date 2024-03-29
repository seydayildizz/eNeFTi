﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("ProductPictures")]
    public class ProductPicture : Base<int>
    {
        public int ProductId { get; set; }
        [StringLength(400, ErrorMessage = "Ürüne ait resim bilgisi en fazla 400 karakter uzunluğunda olabilir!")]
        public string ProductPicture1 { get; set; }
        [StringLength(400, ErrorMessage = "Ürüne ait resim bilgisi en fazla 400 karakter uzunluğunda olabilir!")]
        public string ProductPicture2 { get; set; }
        [StringLength(400, ErrorMessage = "Ürüne ait resim bilgisi en fazla 400 karakter uzunluğunda olabilir!")]

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
