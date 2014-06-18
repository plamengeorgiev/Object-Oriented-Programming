using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatrix = new Matrix<int>(2, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 2);

            firstMatrix[0, 0] = 1; firstMatrix[0, 1] = 0; firstMatrix[0, 2] = -2;   //testing the implementation of "this"
            firstMatrix[1, 0] = 0; firstMatrix[1, 1] = 3; firstMatrix[1, 2] = -1;

            secondMatrix[0, 0] = 0; secondMatrix[0, 1] = 3;
            secondMatrix[1, 0] = -2; secondMatrix[1, 1] = -1;
            secondMatrix[2, 0] = 0; secondMatrix[2, 1] = 4;
            Console.WriteLine("The first matrix: ");
            for (int i = 0; i < firstMatrix.Cols; i++)
            {
                for (int j = 0; j < firstMatrix.Rows; j++)
                {
                    Console.Write("{0,3} ", firstMatrix[j, i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix: ");
            for (int i = 0; i < secondMatrix.Cols; i++)
            {
                for (int j = 0; j < secondMatrix.Rows; j++)
                {
                    Console.Write("{0,3} ", secondMatrix[j, i]);
                }
                Console.WriteLine();
            }

            Matrix<int> resultMatrix = firstMatrix * secondMatrix;  //testing the multiplication
            Console.WriteLine("The result matrix (firstMatrix*secondMatrix): ");
            for (int i = 0; i < resultMatrix.Cols; i++)
            {
                for (int j = 0; j < resultMatrix.Rows; j++)
                {
                    Console.Write("{0,3} ",resultMatrix[i,j]);
                }
                Console.WriteLine();
            }
            if (firstMatrix)    //check for non-zero element
            {
                Console.WriteLine("true");
            }
            Console.WriteLine();
        }
    }
}
