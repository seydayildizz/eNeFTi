using eNeFTi_EL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        public OrderDetail OrderDetail { get; set; }
        public Customer Customer { get; set; }
        
    }
}
