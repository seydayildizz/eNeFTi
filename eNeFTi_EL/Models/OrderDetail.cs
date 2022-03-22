using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Models
{
    [Table("OrderDetails")]
    public class OrderDetail /*: TheBase<int>*/
    {
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
        [Required]
        public double Discount { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
    }
}
