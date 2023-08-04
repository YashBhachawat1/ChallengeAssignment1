using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface IBall
    {

        public void SetSurface(Surface surface);
        public void SetInitialVelocity(double Vi);
        public void SetHorizontalDistance(double horizontalDistance);
        public double GetInitialVelocity();
        public double GetHorizontalDistance();
        public double GetTime();


        //Compares the two balls and returns which ball will travel faster
        public string Compare(Ball ballA, Ball ballB);


        //gives gravity constant value
        public double GetG();


        //Calculates the time taken for ball to move to finish line
        public double CalculateTime();


        //Calculates the sum of all slope distances
        public double CalculateSlope(double initialVelocity, double slopeDistanceOfOneSlope);
    }
}
