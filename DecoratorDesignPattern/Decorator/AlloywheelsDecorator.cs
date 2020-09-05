using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    internal class AlloywheelsDecorator : CarDecorator
    {
        public AlloywheelsDecorator(ICar car) : base(car)
        {
        }

        public override int GetPrice()
        {
            return Car.GetPrice() + 5000;
        }
    }
}