using PizaaOrderingLib;
using DataModel.Interface;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaOrderingSystem.Controllers
{
    [RoutePrefix("api/pizza")]
    public class PizzaController : ApiController
    {
        IAbstractPizza _pizza = new PizzaFactory();
        PizzaClient client;

        public PizzaController()
        {
            this.client = new PizzaClient(_pizza);
        }

        // GET api/values
        [Route("GetPizzaCustSize")]
        [HttpGet]
        public List<CustSize> GetPizzaCustSize()
        {
            return this.client.getPizzaCustSize();
        }

        [Route("GetSauses")]
        [HttpGet]
        public List<Sauses> GetSauses()
        {
            return this.client.getSauses();
        }

        [Route("GetToppings")]
        [HttpGet]
        public List<Toppings> GetToppings()
        {
            return this.client.getToppings();
        }

        [Route("GetAllOrders")]
        [HttpGet]
        public List<Orders> GetAllOrders()
        {
            return this.client.getOrders();
        }

        [Route("SaveOrder")]
        [HttpPost]
        // POST api/values
        public Orders Post([FromBody] Orders orders)
        {
            return this.client.addOrders(orders);
        }
    }
}
