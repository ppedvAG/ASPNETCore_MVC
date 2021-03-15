using DICarSample;
using System;

namespace DICarSampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarService();

            carService.Repair(new MockCar());
            carService.Repair(new Car());


            ICarService mockService = new MockCarService();
            mockService.Repair(new MockCar());
            mockService.Repair(new Car());
        }
    }
}
