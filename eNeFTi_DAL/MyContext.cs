using eNeFTi_EL.IdentityModels;
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
        {

        }
    }
}
