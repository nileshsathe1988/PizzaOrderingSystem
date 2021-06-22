using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
    public class CustomPizza
    {
        public int custPizzaId;
        public bool isExtraCheesNeeded;
        public CustSize custSize { get; set; }
        public Sauses sauses { get; set; }
        public Toppings topping { get; set; }

    }
}
