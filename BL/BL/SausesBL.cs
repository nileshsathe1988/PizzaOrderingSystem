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
    public class SausesBL : PizzaBase, ISauses
    {
        public List<Sauses> GetSauses()
        {
            try
            {
                //return this.data.sauses;
                return DataStore.sauses;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
