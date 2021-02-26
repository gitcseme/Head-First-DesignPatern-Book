using DecoratorPattern.CoffeItems;

namespace DecoratorPattern.Condiments
{
    public class Soya : Coffe
    {
        private readonly Coffe Coffe;

        public Soya(Coffe coffe)
        {
            Price = 7.00;
            Coffe = coffe;
        }

        public override double Cost()
        {
            return Price + Coffe.Cost();
        }

        public override string GetDescription()
        {
            return Coffe.GetDescription() + $"Milk {Price}";
        }
    }
}
