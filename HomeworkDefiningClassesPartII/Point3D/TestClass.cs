using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(3, 6, 9);  //testing the constructor
            Console.WriteLine("Point" + point1);    //testing the "ToString" method
            Console.WriteLine("The start of the coordinate system is " + Point3D.GetCenter());  //testing the static property
            Point3D point2 = new Point3D(4, 6, 9);
            Point3D point3 = new Point3D(5, 6, 7);
            Point3D point4 = new Point3D(6, 6, 9);
            Point3D point5 = new Point3D(7, 6, 9);
            Point3D point6 = new Point3D(8, 6, 9);
            Path path = new Path();     //testing the "Path" class
            path.AddPoint(point1);
            path.AddPoint(point2);
            path.AddPoint(point3);
            path.AddPoint(point4);
            path.AddPoint(point5);
            Path path2 = new Path();
            path2.AddPoint(point1);
            path2.AddPoint(point2);
            path2.AddPoint(point3);
            PathStorage.SavePath(path, "file1.txt");    //testing the "PathStorage" class - saving the path
            Console.WriteLine("The distance between {0} and {1} is {2}",point1, point3, Distance.CalculateDistance(point1, point3));
            PathStorage.SavePath(path2, "file2.txt");   //testing the "PathStorage" class - saving the path
            Path loadedPath = PathStorage.LoadPath("file2.txt");    //testing the "PathStorage" class - loading the path
            for (int i = 0; i < loadedPath.listOfPoints.Count; i++)
            {
                Console.WriteLine(loadedPath.listOfPoints[i].ToString());
            }

        }
    }
}
