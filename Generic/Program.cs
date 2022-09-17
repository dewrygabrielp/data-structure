using System;

namespace Generic
{
    class Program
    {
        public class GenericList<T>
        {
            public void Add(T input) { }
        }
        class TestGenericList
        {
            
        }
        private class ExampleClass { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(24);

            //Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Dewry");

            //Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            Example<int>(7);

            
            
        }
        public static void Example<T>(T type)
        {
            Console.WriteLine(type);
        }
    }
}
