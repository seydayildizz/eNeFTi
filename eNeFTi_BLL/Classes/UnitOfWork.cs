using eNeFTi_BLL.Interfaces;
using eNeFTi_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_BLL.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;
        //private readonly IMapper _mapper;
        //private readonly UserManager<AppUser> _userManager;
        public UnitOfWork(MyContext myContext)
            //IMapper mapper,
            //UserManager<AppUser> userManager)
        {
            _myContext = myContext;
            //_mapper = mapper;
            //_userManager = userManager;
            //UnitOfWork tüm repositoryleri oluşturacak.

            
        }
        public void Dispose()
        {
            _myContext.Dispose();
        }
    }
