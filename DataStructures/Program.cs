using System;
using static System.Console;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new LinkedList.LinkedList();
            numbers.AddLast(10);
            numbers.AddLast(20);
            numbers.AddLast(30);
        }
    }
}