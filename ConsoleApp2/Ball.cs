using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
     class Ball 
    {

        //9.8 meters/second is constant for gravity 
        //Rest is dynamic and can be modified by user when setting values of parameters
        private readonly double G = 9.8;
        private double InitialVelocity;
        private double HorizontalDistance;
        private protected double TotalTime;
        private Surface SurfaceStructure;

        public void SetSurface(Surface surface)
        {
            this.SurfaceStructure = surface;
        }

        public void SetInitialVelocity(double Vi)
        {
            this.InitialVelocity = Vi;
        }

        public void SetHorizontalDistance(double horizontalDistance)
        {
            this.HorizontalDistance = horizontalDistance;
        }

        public double GetInitialVelocity()
        {
            return this.InitialVelocity;
        }

        public double GetHorizontalDistance()
        {
            return this.HorizontalDistance;
        }

        public double GetTime()
        {
            return this.TotalTime;
        }

        public string Compare(Ball ballA, Ball ballB)
        {
            try
            {
                string message;
                if (ballA.GetTime() < ballB.GetTime())
                {
                   message = "Ball A will pass the finish line first";
                }
                else
                {
                    message =  "Ball B will pass the finish line first";
                }
                return message;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public double GetG()
        {
            return this.G;
        }

        public double CalculateSlope(double initialVelocity, double slopeDistanceOfOneSlope)
        {
            double a = initialVelocity;
            double b = 0.5 * G;
            double c = -slopeDistanceOfOneSlope;
            double time = (-InitialVelocity + Math.Sqrt(Math.Pow(b, 2) + 4 * InitialVelocity * slopeDistanceOfOneSlope)) / (2 * a);
            //decimal count;
            
            return time * SurfaceStructure.NoOfSlopes;
        }

        public virtual double CalculateTime()
        {
            try
            {
                if (SurfaceStructure.SlopeExists)
                {
                    double finalVelocity = Math.Sqrt(Math.Pow(this.GetInitialVelocity(), 2) + 2 * this.GetG() * SurfaceStructure.SlopeVerticalDistance);
                    double totalLength = this.GetHorizontalDistance() - (SurfaceStructure.NoOfSlopes * SurfaceStructure.SlopeHorizontalDistance);
                    double slopeDistanceOfOneSlope = SurfaceStructure.SlopeHorizontalDistance / Math.Sin(SurfaceStructure.SlopeAngle);
                    double totalSlopeTime = CalculateSlope(this.InitialVelocity, slopeDistanceOfOneSlope);
                    double bottomLength;
                    if (SurfaceStructure.NoOfSlopes % 2 != 0)
                    {
                        bottomLength = totalLength * (0.5);
                    }
                    else
                    {
                        bottomLength = totalLength * (Convert.ToDouble(SurfaceStructure.NoOfSlopes / 2) / (SurfaceStructure.NoOfSlopes + 1));

                    }
                    double timeBottom = bottomLength / finalVelocity;
                    double timeTop = (totalLength - bottomLength) / this.GetInitialVelocity();
                    this.TotalTime =  timeBottom + timeTop + totalSlopeTime;
                }
                else
                {
                    this.TotalTime = this.HorizontalDistance / this.InitialVelocity;
                }

                return this.TotalTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return this.TotalTime;
            }

        }

    }
}
