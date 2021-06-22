using DataModel.Model;
using DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Data;

namespace BL.BL
{
    public class ToppingBL : PizzaBase, IToppings
    {
        public List<Toppings> GetToppings()
        {
            try
            {
                //return this.data.toppings;
                return DataStore.toppings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
