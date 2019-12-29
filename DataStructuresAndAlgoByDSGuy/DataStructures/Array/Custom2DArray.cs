using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
   public class Custom2DArray<T>
    {
        private T[,] arr;
        private T defaultValue = default(T);
        private int numberOfColumns;
        private int numberOfRows;

        public Custom2DArray(int noOfRows, int noOfCols, T defaultValue = default(T))
        {
            Console.WriteLine($"Creating 2D array with Rows {noOfRows} and Columns {noOfCols} with default value {defaultValue}");
            arr = new T[noOfRows,noOfCols];
            numberOfColumns = noOfCols;
            numberOfRows = noOfRows;
            if (!defaultValue.Equals(default(T)))
            {
                this.defaultValue = defaultValue;
                for (int i = 0; i < noOfRows; i++)
                {
                    for (int j = 0; j < noOfCols; j++)
                    {
                        arr[i,j] = defaultValue;
                    }
                }
            }
        }
                        
        public void Traverse()
        {
            try
            {
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0;  j < numberOfColumns;  j++)
                    {
                        Console.Write(arr[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Array does not exists");
            }
        }

        public void Insert(int rowNumber, int colNumber, T value)
        {
            try
            {
                if (arr == null)
                {
                    throw new Exception("Array does not exist!!");
                }
                if (arr[rowNumber, colNumber].Equals(defaultValue))
                {
                    Console.WriteLine($"Setting cell rowNumber {rowNumber} colNumber {colNumber} to value {value}");
                    arr[rowNumber, colNumber] = value;
                }
                else
                {
                    throw new Exception($"value for cell rowNum {rowNumber} colNumber {colNumber} already exists");


                }

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine($"Invalid Index used for {( rowNumber >= this.numberOfRows ? "rowNumber" : "colNumber" )}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public T Access(int rowNumber, int colNumber)
        {
            T val = default(T);
            try
            {
                if (arr == null)
                {
                    throw new Exception("Array does not exist!!");
                }
                val = arr[rowNumber, colNumber];
                Console.WriteLine($"value at rowNumber {rowNumber} colNumber {colNumber} is value {val}");

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine($"Invalid Index used for {( rowNumber >= this.numberOfRows ? "rowNumber" : "colNumber" )}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return val;
        }

        public void Search(T value)
        {
            try
            {
                if (arr == null)
                {
                    throw new Exception("Array does not exist!!");
                }
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        if (arr[i, j].Equals(value))
                        {
                            Console.WriteLine($"value {value} is present at rowNumber {i} colNumber {j} ");
                            return;
                        }
                    }
                }
                Console.WriteLine($"value {value} is not present in array");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }

        public void Delete(int rowNumber, int colNumber)
        {
            try
            {
                if (arr == null)
                {
                    throw new Exception("Array does not exist!!");
                }
                arr[rowNumber, colNumber] = defaultValue;
                Console.WriteLine($"value at rowNumber {rowNumber} colNumber {colNumber} set to defaultValue {defaultValue}");
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine($"Invalid Index used for {( rowNumber >= this.numberOfRows ? "rowNumber" : "colNumber" )}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteArray()
        {
            arr = null;
        }
    }
}
