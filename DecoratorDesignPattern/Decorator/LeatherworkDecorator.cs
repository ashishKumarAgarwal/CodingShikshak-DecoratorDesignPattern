using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    internal class LeatherworkDecorator : CarDecorator
    {
        public LeatherworkDecorator(ICar car) : base(car)
        {
        }

        public override int GetPrice()
        {
            return Car.GetPrice() + 15000;
        }
    }
}