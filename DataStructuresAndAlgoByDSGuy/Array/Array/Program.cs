using System;
using System.Collections.Generic;
namespace Arrays
{
    class Animal
    {
    }
    class Mammoth : Animal
    {

    }
    class Giraffe : Animal
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Array<Animal> a = new Array<Animal>();
            //Mammoth[] mammoths = new Mammoth[10];
            // Animal[] animals = mammoths;
            // animals[1] = new Giraffe();

            // int [] arr;
            // arr = new int[10] ;
            // InsertForArray(arr, 2, 1);
            //InsertForArray(arr, 2, 1);
            // InsertForArray(arr, 10, 10);
            //  Console.WriteLine(AccessCell(arr,1));
            CustomArray<int> customArray = new CustomArray<int>(10, int.MinValue);
            customArray.InsertAt(1, 90);
            customArray.Traverse();
            customArray.Delete(1);
            customArray.Traverse();
            customArray.InsertAt(9, 112);
            customArray.AccessCell(9);
            customArray.Search(112);
            customArray.Search(11);
        }
        static void DeleteItem<T>(T[] arr, int location)
        {
            if (location < 0 || location >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
           else if (arr[location].Equals(default(T)))
            {
                throw new Exception("No value is present");
            }
            else
            {
                arr[location] = default(T);
            }
        }
        static int SearchArray<T>(T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        static T AccessCell<T>(T[] arr, int location)
        {
            if (location >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return arr[location];
            }
        }
        static void InsertForArray<T>(T[] arr, T value, int location)
        {
            if (location >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (!arr[location].Equals(default(T)))
            {
                throw new Exception("Item already Exists");
            }
            else
            {
                arr[location] = value;
            }
        }
    }
}
