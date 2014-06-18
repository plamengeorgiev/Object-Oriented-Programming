using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        public static readonly Point3D point0 = new Point3D(0, 0, 0);


        private int coordX;
        private int coordY;
        private int coordZ;
        
        public Point3D(int x, int y, int z)
        {
            coordX = x;
            coordY = y;
            coordZ = z;
        }

        public int CoordX
        {
            get { return this.coordX; }
            set { this.coordX = value; }

        }
        
        public int CoordY
        {
            get { return this.coordY; }
            set { this.coordY = value; }

        }
        
        public int CoordZ
        {
            get { return this.coordZ; }
            set { this.coordZ = value; }

        }
        
        public static Point3D GetCenter()
        {
            return point0;
        }
        
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", coordX, coordY, coordZ);
        }
    }
}
