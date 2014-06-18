using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        private T[] array;
        private int counter = 0;

        public GenericList(int capacity)
        {
            this.array = new T[capacity];
        }

        public int Counter
        {
            get { return counter; }
        }

        public void ValidateIndex(int index)
        {
            if (!(index >= 0 && index < array.Length))
            {
                throw new IndexOutOfRangeException("Index out of range!!!");
            }
        }

        public void ArrayGrow()
        {
            T[] tempArray = new T[array.Length * 2];
            Array.Copy(array, 0, tempArray, 0, array.Length);
            array = tempArray;
        }

        public void AddElement(T element)
        {
            if (counter < array.Length)
            {
                array[counter] = element;
                counter++;
            }
            else
            {
                ArrayGrow();
                array[counter] = element;
                counter++;
            }
        }
        public T AccessElement(int index)
        {
            ValidateIndex(index);
            return this.array[index];
        }
        public void RemoveElement(int index)
        {
            ValidateIndex(index);
            counter--;
            T[] tempArray = new T[counter];
            Array.Copy(array, 0, tempArray, 0, index);
            Array.Copy(array, index + 1, tempArray, index, counter - index);
            array = tempArray;
        }
        public void InsertElement(T element, int index)
        {
            if (counter+1>=array.Length)
            {
                ArrayGrow();
            }
            ValidateIndex(index);
            T[] tempArray = new T[counter+1];
            Array.Copy(array, 0, tempArray, 0, index);
            tempArray[index] = element;
            Array.Copy(array, index, tempArray, index + 1, counter - index);
            array = tempArray;

        }
        public void ClearList()
        {
            T[] tempArray = new T[array.Length];
            array = tempArray;
        }
        public int FindElement(T element)
        {
            int index = Array.IndexOf(array, element);
            return index;
        }
        public override string ToString()
        {
            StringBuilder allElements = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                allElements.AppendFormat("{0,10} is the {1} element of the array", array[i].ToString(), (i + 1));
                allElements.AppendLine();
            }
            string final = allElements.ToString();
            return final;
        }

        public T  Max<T>() where T : System.IComparable<T>, IComparable
        {
            dynamic max = array[0];
            for (int i = 0; i < counter; i++)
            {
                T tempValue = (dynamic)this.array[i];
                if (tempValue.CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public T Min<T>() where T : System.IComparable<T>, IComparable
        {
            dynamic min = array[0];
            for (int i = 0; i < counter; i++)
            {
                T tempValue = (dynamic)this.array[i];
                if (tempValue.CompareTo(min) < 0)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
