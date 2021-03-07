using FacotyMethodPattern.Products;
using FacotyMethodPattern.Products.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.Creators.ConcreteCreators
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "Cheese")
                return new NYStyleCheesePizza("NY Garlic Kusti Cheese Pizza", "Marianara Souce");
            else if (type == "Veggie")
                return new NYStyleVeggiePizza("NY Kikri Katu Kutu Veggie Pizza", "Tomato Souce");
            else
                return null;
        }
    }
}
