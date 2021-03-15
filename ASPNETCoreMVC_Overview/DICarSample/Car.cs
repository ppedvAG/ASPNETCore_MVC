using System;

namespace DICarSample
{
    public interface ICar
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public DateTime ConstructYear { get; set; }
    }

    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public DateTime ConstructYear { get; set; }
    }
}
