using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Interface
{
    public interface IOrder
    {
        List<Orders> GetOrders();
        Orders SaveOrders(Orders order);
    }
}
