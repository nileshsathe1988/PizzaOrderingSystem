using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Interface
{
    public interface IAbstractPizza
    {
        IPizzaCrustSize pizza();
        ISauses sauses();
        IToppings toppings();
        IOrder orders();
    }
}
