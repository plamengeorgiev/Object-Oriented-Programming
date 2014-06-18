using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt(Math.Pow(point1.CoordX - point2.CoordX, 2) + Math.Pow(point1.CoordY - point2.CoordY, 2) + Math.Pow(point1.CoordZ - point2.CoordZ, 2));
            return distance;
        }
    }
}
