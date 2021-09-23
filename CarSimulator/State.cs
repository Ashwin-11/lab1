using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)
        public State()
        {
            this.position = 0.0;
            this.velocity = 0.0;
            this.acceleration = 0.0;
            this.time = 0.0;
        }

        public State(double position, double velocity, double acceleration, double time)
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;
        }

        public void set (double position, double velocity, double acceleration, double time)
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;
        }
    }
}
