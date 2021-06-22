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
    public class PizzaCrustBL : PizzaBase, IPizzaCrustSize
    {
        public List<CustSize> GetPizzaCustSize()
        {
            try
            {
                //return this.data.custSizes;
                return DataStore.custSizes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
