using eNeFTi_EL.IdentityModels;
using eNeFTi_EL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_DAL
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PassiveUser> PassiveUsers { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPicture> ProductPictures { get; set; }
    }
}

