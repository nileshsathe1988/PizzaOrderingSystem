using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
    public class Orders
    {
        public int orderId;
        public List<CustomPizza> cutomePizzas = new List<CustomPizza>();
        public int totalAmount;
    }
}
