using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Data
{
    public static class DataStore
    {
        public static  List<CustSize> custSizes = new List<CustSize>();
        public static List<Sauses> sauses = new List<Sauses>();
        public static List<Toppings> toppings = new List<Toppings>();
        public static List<CustomPizza> customePizza = new List<CustomPizza>();
        public static List<Orders> orders = new List<Orders>();

        static DataStore()
        {
            DataStore.custSizes.Add(new CustSize() { crustSizeId = 1, crustSizeType = "Small", price = 100 });
            DataStore.custSizes.Add(new CustSize() { crustSizeId = 2, crustSizeType = "Medium", price = 200 });
            DataStore.custSizes.Add(new CustSize() { crustSizeId = 3, crustSizeType = "Large", price = 300 });

            DataStore.sauses.Add(new Sauses() { sausesId = 1, sausesType = "Marinara", price = 50 });
            DataStore.sauses.Add(new Sauses() { sausesId = 2, sausesType = "Chees", price = 90 });
            DataStore.sauses.Add(new Sauses() { sausesId = 3, sausesType = "Ranch", price = 150 });

            DataStore.toppings.Add(new Toppings() { toppingId = 1, toppingType = "Pepperoni", price = 150 });
            DataStore.toppings.Add(new Toppings() { toppingId = 2, toppingType = "Mushrooms", price = 100 });
            DataStore.toppings.Add(new Toppings() { toppingId = 3, toppingType = "Onions", price = 30 });
            DataStore.toppings.Add(new Toppings() { toppingId = 4, toppingType = "Sausage", price = 50 });
            DataStore.toppings.Add(new Toppings() { toppingId = 5, toppingType = "Bacon", price = 80 });
            DataStore.toppings.Add(new Toppings() { toppingId = 6, toppingType = "Extra cheese", price = 150 });
            DataStore.toppings.Add(new Toppings() { toppingId = 7, toppingType = "Black olives", price = 125 });
            DataStore.toppings.Add(new Toppings() { toppingId = 8, toppingType = "Green peppers", price = 105 });
        }
    }
}
