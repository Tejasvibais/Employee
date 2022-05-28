using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main1 (string[]args)
        {
            var a = 10;

           // = "tejasvi";// var can not change type casting after declaration and shows error
;           dynamic a1 = 20;
            a1 = "tejasvi"; // but dynamic var convert the type of var
            Console.WriteLine(a);
            Console.WriteLine(a1);
        }
    }
}
