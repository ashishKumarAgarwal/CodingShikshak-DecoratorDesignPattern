using System;
using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            ICar car = new SUV();
            car=new AlloywheelsDecorator(car);
            car=new LeatherworkDecorator(car);
            car=new SunroofDecorator(car);
            Console.WriteLine($"Price : {car.GetPrice()}");
            Console.ReadLine();
        }
    }
}
