using FacotyMethodPattern.Products;
using FacotyMethodPattern.Products.ConcreteProducts;

namespace FacotyMethodPattern.Creators.ConcreteCreators
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "Cheese")
                return new ChicagoStyleCheesePizza("Chicago Style Deep Dish Cheese Pizza", "Marianara Souce");
            else if (type == "Veggie")
                return new ChicagoStyleVeggiePizza("Chicago Style Vuri Less Veggie Pizza", "Tomato Souce");
            else
                return null;
        }
    }
}
