namespace DecoratorPattern.CoffeItems
{
    public class Capachino : Coffe
    {
        public Capachino()
        {
            Price = 15.00;
            Description = $"\nCapachino coffe {Price}\n";
        }

        public override double Cost()
        {
            return Price;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
