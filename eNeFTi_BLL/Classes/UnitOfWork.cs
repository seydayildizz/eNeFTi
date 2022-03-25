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
            AdminRepo = new AdminRepo(_myContext);
            CategoryRepo = new CategoryRepo(_myContext);
            CustomerRepo = new CustomerRepo(_myContext);
            OrderRepo = new OrderRepo(_myContext);
            OrderDetailRepo = new OrderDetailRepo(_myContext);
            PassiveUserRepo = new PassiveUserRepo(_myContext);
            ProductPictureRepo = new ProductPictureRepo(_myContext);
            ProductRepo = new ProductRepo(_myContext);
        }
        public IAdminRepo AdminRepo { get; private set; }
        public ICategoryRepo CategoryRepo { get; private set; }
        public ICustomerRepo CustomerRepo { get; private set; }
        public IOrderRepo OrderRepo { get; private set; }
        public IOrderDetailRepo OrderDetailRepo { get; private set; }
        public IPassiveUserRepo PassiveUserRepo { get; private set; }
        public IProductPictureRepo ProductPictureRepo { get; private set; }
        public IProductRepo ProductRepo { get; private set; }


        public IAdminRepo IAdminRepo => throw new NotImplementedException();
        public ICategoryRepo ICategoryRepo => throw new NotImplementedException();
        public ICustomerRepo ICustomerRepo => throw new NotImplementedException();
        public IOrderDetailRepo IOrderDetailRepo => throw new NotImplementedException();
        public IOrderRepo IOrderRepo => throw new NotImplementedException();
        public IPassiveUserRepo IPassiveUserRepo => throw new NotImplementedException();
        public IProductPictureRepo IProductPictureRepo => throw new NotImplementedException();
        public IProductRepo IProductRepo => throw new NotImplementedException();
        public void Dispose()
        {
            _myContext.Dispose();
        }
    }
}