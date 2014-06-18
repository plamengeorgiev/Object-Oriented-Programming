using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        public List<Point3D> listOfPoints = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.listOfPoints.Add(point);
        }

    }
}
