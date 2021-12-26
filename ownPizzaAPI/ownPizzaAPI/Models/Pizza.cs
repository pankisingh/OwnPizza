using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ownPizzaAPI.Models
{
    public class Pizza
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string quantity {get; set;}
        public string image { get; set; }


    }

    public class OwnPizza
    {

        public List<Pizza> data { get; set; }
    }

}