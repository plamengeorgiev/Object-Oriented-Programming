using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestClass
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>(5);
            intList.AddElement(4);
            intList.AddElement(6);
            intList.AddElement(7);
            intList.AddElement(-3);
            intList.AddElement(0);
            intList.AddElement(22);  //adding elements to test the auto-grow functionality
            
            Console.WriteLine("The elements of the list:");
            for (int i = 0; i < intList.Counter; i++)
            {
                Console.Write("{0} ", intList.AccessElement(i));    //testing the access by index method
            }
            Console.WriteLine();
            
            intList.InsertElement(666, 2);  //testing the insert at index method
            Console.WriteLine("The elements of the list after inserting an element:");
            for (int i = 0; i < intList.Counter; i++)
            {
                Console.Write("{0} ", intList.AccessElement(i));    //testing the access by index
            }
            Console.WriteLine();
            
            intList.RemoveElement(4);
            Console.WriteLine("The elements of the list after removing an element:");
            for (int i = 0; i < intList.Counter; i++)
            {
                Console.Write("{0} ", intList.AccessElement(i));    //testing the access by index
            }
            Console.WriteLine();

            Console.WriteLine("The index of the searched element: {0}", intList.FindElement(666));  //testing the searching

            Console.WriteLine("The smallest element in the list is: {0}", intList.Min<int>()); //texting Min<T>

            Console.WriteLine("The biggest element in the list is: {0}", intList.Max<int>());   //testing Max<T>

        }
    }
}
