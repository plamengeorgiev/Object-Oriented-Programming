using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < path.listOfPoints.Count; i++)
                {
                    writer.WriteLine("{0} {1} {2}", path.listOfPoints[i].CoordX, path.listOfPoints[i].CoordY, path.listOfPoints[i].CoordZ);
                }
            }

        }
        public static Path LoadPath(string filename)
        {
            Path newPath = new Path();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadLine();
                while (line != null)
                {

                    string[] arr = line.Split();
                    Point3D point = new Point3D(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
                    newPath.AddPoint(point);
                    line = reader.ReadLine();
                }

            }
            return newPath;
        }
    }
}
