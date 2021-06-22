using BL.Data;
using DataModel.Interface;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BL
{
    public class OrdersBL : PizzaBase, IOrder
    {
        public List<Orders> GetOrders()
        {
            try
            {
                //return this.data.orders;
                return DataStore.orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Orders SaveOrders(Orders order)
        {
            try
            {
                //this.data.orders.Add(order);
                DataStore.orders.Add(order);
                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
