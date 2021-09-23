using System;

namespace CarSimulator
{
    class Program2
    {
        /* static void Main(string[] args)
         {
             State car=new State();

             Console.WriteLine("Car position:{0}", car.position);
             Console.WriteLine("Car velocity:{0}", car.velocity);
             Console.WriteLine("Car acceleration:{0}", car.acceleration);
             Console.WriteLine("Car time:{0}", car.time);

             car.set(1.0, 2.0, 3.0, 4.0);
             Console.WriteLine("Car position:{0}", car.position);
             Console.WriteLine("Car velocity:{0}", car.velocity);
             Console.WriteLine("Car acceleration:{0}", car.acceleration);
             Console.WriteLine("Car time:{0}", car.time);



             /*  // read in car position
               Console.WriteLine("Enter the position of the car");
               double pos;
               pos = Convert.ToDouble(Console.ReadLine());

               // read in car velocity
               Console.WriteLine("Enter the velocity of the engine (N): ");
               double engine_force;
               engine_force = Convert.ToDouble(Console.ReadLine());

               // read in drag area coefficient
               Console.WriteLine("Enter the car's drag area (m^2): ");
               double drag_area;
               drag_area = Convert.ToDouble(Console.ReadLine());

               // read in time step
               Console.WriteLine("Enter the simulation time step (s): ");
               double dt;
               dt = Convert.ToDouble(Console.ReadLine());

               // read in total number of simulation steps
               Console.WriteLine("Enter the number of time steps (int): ");
               int N;
               N = Convert.ToInt32(Console.ReadLine());

               // initialize the car's state
               double x0 = 0;  // initial position
               double v = 0;  // initial velocity
               double t = 0;  // initial time
               double fd, x1, a; // drag force and secondary position and acceleration
               double rho = 1.225;// kg / m3
               double cd =0.58;  //SI

               // run the simulation
               for (int i = 0; i < N; ++i)
               {
                   // TODO: COMPUTE UPDATED STATE HERE
                   fd = (1.0/2.0)*rho*v*v*cd;
                   a = CarSimulator.Physics1D.compute_acceleration(engine_force-fd, mass);
                   x1 = CarSimulator.Physics1D.compute_position(x0, v, dt);
                   v = CarSimulator.Physics1D.compute_velocity(v, a, dt);
                   x0 = x1;
                   t += dt;  // increment time

                   // print the time and current state
                   Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}, fd:{4} ", t, a, v, x1, fd);
               }
             */
    
    }
}
