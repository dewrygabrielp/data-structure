using System;
using System.Collections;
using System.Collections.Generic;

namespace Tupla
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tuple = new Tuple<int, string, string>(1, "Dewry", "Gabriel");

            var tuple2 = Tuple.Create(2, "Peña", "Valdez");

            var example = Example();
            int integer = example.Item1;
            string name = example.Item2;
            DateTime date = example.Item4;
            Console.WriteLine(date);
        }
       

        private static Tuple<int,string,string, DateTime> Example()
        {
            return new Tuple<int, string, string, DateTime>(3,"Junior","Perez",DateTime.Now);
        }
    }
}
