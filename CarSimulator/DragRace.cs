using System;
namespace CarSimulator
{
    public class Dragrace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);     
            Car myPrius = new Car("Prius", 1000, 750, 0.43);
            string winner="";
            // drive for 60 seconds with delta time of 1s
            double dt = 1;

            for (double t = 0; t < 60; t += dt)
            {
                // print the time and current state
                myTesla.drive(dt);
                myPrius.drive(dt);
                Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}", t, myTesla.myCarState.acceleration, myTesla.myCarState.velocity, myTesla.myCarState.position);
                Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}", t, myPrius.myCarState.acceleration, myPrius.myCarState.velocity, myPrius.myCarState.position);

                // print who is in lead
                if (myTesla.myCarState.position > myPrius.myCarState.position)
                    Console.WriteLine("TESLA is ahead of PRIUS");
                else if (myTesla.myCarState.position==myPrius.myCarState.position)
                    Console.WriteLine("CARS are at SAME Position");
                else
                    Console.WriteLine("PRIUS is ahead of TESLA");

                if(myTesla.myCarState.position>402.3 && myPrius.myCarState.position > 402.3)
                {
                    if (myTesla.myCarState.position > myPrius.myCarState.position)
                        winner = myTesla.getModel();
                    else
                        winner = myPrius.getModel();

                    break;
                }
            }
            Console.WriteLine("Race Over, Winner of Race is: "+winner);
        }
    }
}
