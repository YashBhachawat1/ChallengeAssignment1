using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    //Surface class for two different surface types on same ball type
    public class Surface
    {
        public Surface(bool slopeExists)
        {
            if (!this.SlopeExists)
            {
                NoOfSlopes = 0;
                SlopeDistance = 0;
                SlopeVerticalDistance = 0;
                SlopeHorizontalDistance = 0;
                SlopeAngle = 0;
            }
        }

        public bool SlopeExists;
        public int NoOfSlopes;
        public double SlopeDistance;
        public double SlopeVerticalDistance;
        public double SlopeHorizontalDistance;
        public double SlopeAngle;
    }
}
