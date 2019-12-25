using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
   public class CustomArray<T>
    {
        private T[] arr;
        private int size;
        public CustomArray(int sizeOfArray,T defaultValue)
        {
            arr = new T[sizeOfArray];
            size = sizeOfArray;
            if (!defaultValue.Equals(default(T)))
            {

            }
        }

        public void Traverse()
        {
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"element at {i} is {arr[i]} ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Array no longer exists");
                
            }
        }

        public void InsertAt(int location,T valueToBeInserted)
        {
            try
            {
                if (arr[location].Equals(default(T)))
                {
                    arr[location] = valueToBeInserted;
                }
                else
                {
                    Console.WriteLine("location is already occupied");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Invalid index to access array");
            }
        }

        public T AccessCell(int location)
        {
            T cellValue = default(T);
            try
            {
                cellValue = arr[location];
                Console.WriteLine($"Value at location {location} is {cellValue}");
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index to access array");
            }
            return cellValue;
        }

        public int Search(T value)
        {
            int location = -1;
            try
            {
                for (int i = 0; i < size; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        location = i;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Array no longer exists");
            }
            return location;
        }

        public void Delete(int location)
        {
            try
            {
                arr[location] = default(T);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index for array");
                
            }
        }
    }
}
