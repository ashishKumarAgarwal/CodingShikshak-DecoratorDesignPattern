using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    internal class SunroofDecorator : CarDecorator
    {
        public SunroofDecorator(ICar car) : base(car)
        {
        }

        public override int GetPrice()
        {
            return Car.GetPrice() + 20000;
        }
    }
}