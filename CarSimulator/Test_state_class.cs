using System;

namespace CarSimulator
{
    class TestStateClass
    {
        static void Main(string[] args)
        {
            State car = new State();

            Console.WriteLine("Car position:{0}", car.position);
            Console.WriteLine("Car velocity:{0}", car.velocity);
            Console.WriteLine("Car acceleration:{0}", car.acceleration);
            Console.WriteLine("Car time:{0}", car.time);

            car.set(1.0, 2.0, 3.0, 4.0);
            Console.WriteLine("Car position:{0}", car.position);
            Console.WriteLine("Car velocity:{0}", car.velocity);
            Console.WriteLine("Car acceleration:{0}", car.acceleration);
            Console.WriteLine("Car time:{0}", car.time);
        }
    
    }
}
