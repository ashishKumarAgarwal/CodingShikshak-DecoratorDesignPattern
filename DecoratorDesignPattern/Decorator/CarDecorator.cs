using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class CarDecorator : ICar
    {
        protected readonly ICar Car;

        protected CarDecorator(ICar car)
        {
            Car = car;
        }

        public virtual int GetPrice()
        {
            return Car.GetPrice();
        }
    }
}