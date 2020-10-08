using static System.Console;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Array(2);
            numbers.Insert(12);
            numbers.Insert(21);
            numbers.Insert(21);
            numbers.Insert(21);
            WriteLine(numbers.IndexOf(21));

            numbers.Print();
        }
    }
}