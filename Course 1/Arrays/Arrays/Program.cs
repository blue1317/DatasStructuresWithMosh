using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Array(3);
            

            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);
            numbers.RemoveAt(2);
            numbers.Insert(50);
           
            numbers.InsertAt(80,3);

            numbers.Print();

            Console.WriteLine();
            Console.WriteLine("Index of: " + numbers.IndexOf(20));
            Console.WriteLine("Index of: " + numbers.IndexOf(200));
            Console.WriteLine("Largest number: " + numbers.LargestNumber());
        }
    }
}
