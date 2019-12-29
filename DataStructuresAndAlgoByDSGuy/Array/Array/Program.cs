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

    #region Array Info
    /*
     When to use:
     1. When have large number of values of same type and number is known in advanced
     2. Lot of random access operations     
     When not to use:
     1. When we have heterogenous values
     2. When number of values is not known in advanced
     Function           time complexity    space complexity
     create array           o(1)               o(n) or o(mn)
     insert                 o(1)               o(1)
     traverse               o(n) or o(mn)      o(1)
     search                 o(n) or o(mn)      o(1)
     delete                 o(1)               o(1)
     access                 o(1)               o(1)
         */
    #endregion
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
            #region Custom array testing
            //CustomArray<int> customArray = new CustomArray<int>(10, int.MinValue);
            //customArray.InsertAt(1, 90);
            //customArray.Traverse();
            //customArray.Delete(1);
            //customArray.Traverse();
            //customArray.InsertAt(9, 112);
            //customArray.AccessCell(9);
            //customArray.Search(112);
            //customArray.Search(11);
            #endregion
            #region Custom2DArray testing
            Custom2DArray<int> custom2DArray = new Custom2DArray<int>(3, 6, int.MinValue);
            custom2DArray.Traverse();
            custom2DArray.Insert(0, 3,200) ;
            custom2DArray.Traverse();
            custom2DArray.Access(2, 3);
            custom2DArray.Access(2, 7);
            custom2DArray.Access(3, 3);
            custom2DArray.Insert(0, 7, 100);
            custom2DArray.Insert(3, 7, 100);
            custom2DArray.Search(200);
            custom2DArray.Search(300);
            custom2DArray.Delete(0, 3);
            custom2DArray.Traverse();
            custom2DArray.DeleteArray();
            custom2DArray.Traverse();
            custom2DArray.Insert(2, 3, 22);
            custom2DArray.Delete(2, 3);
            custom2DArray.Search(22);
            custom2DArray.Access(2, 3);
            #endregion
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
