using DecoratorPattern.CoffeItems;

namespace DecoratorPattern.Condiments
{
    public class Milk : Coffe
    {
        private Coffe Coffe;

        public Milk(Coffe coffe)
        {
            Price = 5.00;
            Coffe = coffe;
        }

        public override double Cost()
        {
            return Price + Coffe.Cost();
        }

        public override string GetDescription()
        {
            return Coffe.GetDescription() + $"Milk {Price}\n";
        }
    }
}
