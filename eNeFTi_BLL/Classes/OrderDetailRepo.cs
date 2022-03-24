using eNeFTi_BLL.Interfaces;
using eNeFTi_DAL;
using eNeFTi_EL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_BLL.Classes
{
    public class OrderDetailRepo:Repository<OrderDetail>,IOrderDetailRepo
    {
        public OrderDetailRepo(MyContext myContext): base(myContext)
        {

        }
    }
}
