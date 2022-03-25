using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAdminRepo IAdminRepo { get; }
        ICategoryRepo ICategoryRepo { get; }
        ICustomerRepo ICustomerRepo { get; }
        IOrderDetailRepo IOrderDetailRepo { get; }
        IOrderRepo IOrderRepo { get; }
        IPassiveUserRepo IPassiveUserRepo { get; }
        IProductPictureRepo IProductPictureRepo { get; }
        IProductRepo IProductRepo { get; }
    }
}
