using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                Dictionary<int, string> dataPersonal=
                new Dictionary<int, string>();

            dataPersonal.Add(24, "Dewry");
            dataPersonal.Add(23, "Daniela");
            dataPersonal.Add(19, "Daneury");
            dataPersonal.Add(27, "Danny");

            string value = string.Empty;

            dataPersonal.TryGetValue(27, out value);
            Console.WriteLine(value);

            var example = dataPersonal[24];
            Console.WriteLine(example);

            if (!dataPersonal.ContainsKey(2))
            {
                dataPersonal.Add(2, "Liah");
            }

            dataPersonal[2] = "Liah Marie";
            Console.Write(dataPersonal[2]);

            //Bucle traverse dictionary

            foreach (var item in dataPersonal)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            //Delete 
            dataPersonal.Remove(2);


        }
    }
}
