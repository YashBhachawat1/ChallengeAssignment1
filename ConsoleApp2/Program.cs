using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ballA = new Ball();
            ballA.SetHorizontalDistance(20);
            Surface surface = new Surface(false);
            ballA.SetSurface(surface);
            ballA.SetInitialVelocity(5);
            ballA.CalculateTime();
            Ball ballB = new Ball();
            ballB.SetHorizontalDistance(20);
            ballB.SetInitialVelocity(5);
            Surface surfaceBallB = new Surface(true);
            surfaceBallB.SlopeExists = true;
            surfaceBallB.NoOfSlopes = 4;
            surfaceBallB.SlopeAngle = 45;
            surfaceBallB.SlopeHorizontalDistance = 2;
            surfaceBallB.SlopeVerticalDistance = 2;
            ballB.SetSurface(surfaceBallB);
            ballB.CalculateTime();
            Ball comparison = new Ball();
            Console.WriteLine(comparison.Compare(ballA,ballB));

            //Program shows that ball will travel faster when there are slopes as opposed to no slopes.
            //Based on results, can be concluded:  ball B's velocity increases at a greater amount as compared to effects of increased distance due to slopes
            //Causes Ball B to finish first
         

          
        }
    }
}
