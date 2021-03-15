using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICarSample
{
    public interface ICarService
    {
        void Repair(ICar car);
    }

    public class CarService : ICarService
    {
        public void Repair(ICar car)
        {
            //Repariere Auto
        }
    }

    public class MockCarService : ICarService
    {
        public void Repair(ICar car)
        {
            //Repariere Auto
        }
    }

    public class MockCar : ICar
    {
        public string Brand { get; set; } = "BMW";
        public string Type { get; set; } = "Z8";
        public DateTime ConstructYear { get; set; } = DateTime.Now;
    }
}
