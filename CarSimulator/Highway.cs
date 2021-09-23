using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            double dt = 1;


            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states
            // create fleets
           
            /* Commenting out the other method of declaring the array of cars that works
            Tesla[] myTeslas= Enumerable.Range(0, fleetNumberPerType-1).Select(x => new Tesla()).ToArray(); //suggestion given in lab manual did not work for me
            Prius[] myPriuses = Enumerable.Range(0, fleetNumberPerType - 1).Select(x => new Prius()).ToArray();
            Mazda[] myMazdas = Enumerable.Range(0, fleetNumberPerType - 1).Select(x => new Mazda()).ToArray();
            Herbie[] myHerbies = Enumerable.Range(0, fleetNumberPerType - 1).Select(x => new Herbie()).ToArray();
            */

            //Step 2: implement all the fleet in one list and compute states
            var myCars = new List<Car>();

            for (int i = 0; i < fleetNumberPerType; i++)
            {
                myCars.Add(new CarSimulator.Tesla());
                myCars.Add(new CarSimulator.Prius());
                myCars.Add(new CarSimulator.Mazda());
                myCars.Add(new CarSimulator.Herbie());
            }

            // loop through the time and list to drive all the vehicles
            for (double t = 0; t < 60; t += dt)
            {
                for (int i = 0; i < fleetNumberPerType*4; i++)
                {
                    // TO DO: Drive myCars list and Display the cars states acceleration, speed, position, etc
                    myCars[i].drive(dt);
                    Console.WriteLine("Car{0}: Model:{1:F3}, time:{2:F3}, acceleration:{3:F3}, velocity:{4:F3}, position:{5:F3} ", i+1, myCars[i].getModel(), t, myCars[i].myCarState.acceleration, myCars[i].myCarState.velocity, myCars[i].myCarState.position);
                }
            }
        }

    }
}
