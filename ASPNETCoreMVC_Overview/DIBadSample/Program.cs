using System;

namespace DIBadSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Car // 8 Wochen Entwicklungszeit
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public DateTime ConstructionYear { get; set; }
    }

    public class CarService // 2 Wochen
    {
        public void Repair (Car car) // Datentyp Car ist fest mit Repair verdrahtet -> Wird später ein Monolith werden 
        {
            //Repariere das Auto 
        }
    }
}
