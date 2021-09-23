using System;
namespace CarSimulator
{
    public class Car
    {
        protected double mass;
        protected string model;
        protected double dragArea; // typo: the user enters A*C_d , dragAre=area * drag coefficient
        //protected double dragCoef;
        protected double engineForce;

        public State myCarState= new State();  
        /// implement constructor and methods
        public Car()
        {
            //this.rho = 1.225; 
            myCarState.velocity = 0.0;
            myCarState.time = 0.0;
            myCarState.position = 0.0;
            myCarState.acceleration = 0.0;
        }
        public Car(string model, double mass, double engineForce, double dragArea)
        {
            this.mass = mass;
            this.model = model;
            this.dragArea = dragArea;
            this.engineForce = engineForce;
          //  this.dragCoef = dragCoef;
        }
        public string getModel()
        {
            return this.model;
        }
        public double getMass()
        {
            return this.mass;
        }
        public State getState()
        {
            return this.myCarState;
        }
        public void accelerate(bool on)
        {

        }
        public virtual void drive(double dt)
        {
            // TODO: COMPUTE UPDATED STATE HERE
                double fd;
                double rho = 1.225;
                myCarState.time += dt;
                fd = (1.0 / 2.0) * rho * (myCarState.velocity) * (myCarState.velocity)*dragArea;
                myCarState.acceleration = CarSimulator.Physics1D.compute_acceleration(engineForce - fd,mass);

                double a0 = myCarState.acceleration;
                double v0 = myCarState.velocity;
                double x0 = myCarState.position;
                myCarState.position = CarSimulator.Physics1D.compute_position(x0, v0, dt);
                myCarState.velocity = CarSimulator.Physics1D.compute_velocity(v0, a0, dt);
        }

        //implement inheritence
        

    }

    public class Prius : Car
    {
        public Prius() : base()
        {
            model = "Prius";
            mass = 1000;
            engineForce = 750;
            dragArea = 0.43;
           // dragCoef = 1;
            //base class constructor sould be called automatically when object of class prius is made
        }
        public Prius(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
          //  this.dragCoef = dragCoef;
        }
    }

    public class Tesla : Car
    {
        public Tesla() : base()
        {
            model = "Tesla";
            mass = 1500;
            engineForce = 1000; 
            dragArea=0.51;
           // dragCoef = 1;

            /*myCarState.velocity =0.0;
            myCarState.time = 0.0;
            myCarState.position = 0.0;
            myCarState.acceleration = 0.0;*/
            //base class constructor sould be called automatically when object of class prius is made
        }
        public Tesla(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
           // this.dragCoef = dragCoef;
        }
    }

    public class Mazda : Car
    {
        public Mazda() : base()
        {
            model = "Mazda";
            mass = 1400;
            engineForce = 755;
            dragArea = 0.4;
           // dragCoef = 1;
            /*myCarState.velocity =0.0;
            myCarState.time = 0.0;
            myCarState.position = 0.0;
            myCarState.acceleration = 0.0;*/
            //base class constructor sould be called automatically when object of class prius is made
        }
        public Mazda(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
            //this.dragCoef = dragCoef;
        }
    }

    public class Herbie : Car
    {
        public Herbie() : base()
        {
            model = "Herbie";
            mass = 1400;
            engineForce = 1000;
            dragArea = 0;
          //  dragCoef = 0;
            /*myCarState.velocity =0.0;
            myCarState.time = 0.0;
            myCarState.position = 0.0;
            myCarState.acceleration = 0.0;*/
            //base class constructor sould be called automatically when object of class prius is made
        }
        public Herbie(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
            //this.dragCoef = dragCoef;
        }

        public override void drive(double dt)
        {
            // TODO: COMPUTE UPDATED STATE HERE
            double fd, x1;
            //double rho = 1.225;

            fd = 0;//no drag fir herbie
            myCarState.acceleration = CarSimulator.Physics1D.compute_acceleration(engineForce - fd, mass);
            x1 = CarSimulator.Physics1D.compute_position(myCarState.position, myCarState.velocity, dt);
            myCarState.velocity = CarSimulator.Physics1D.compute_velocity(myCarState.velocity, myCarState.acceleration, dt);
            myCarState.position = x1;
            myCarState.time += dt;
        }
    }
}
