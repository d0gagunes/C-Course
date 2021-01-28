using System;
using System.Collections.Generic;

namespace Collections
{
    class Program   //secili olan kodlari = CTRL K + CTRL C (comment)
    {
        static void Main(string[] args) // CTRL K + CTRL U (Uncomment)
        {
            //string[] names = new string[] { "Engin", "Murat", " Halil ", "Kerem" };    
            //Console.WriteLine(names[0]);                                              
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Ilker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

           List<string> names2 = new List<string>{"Engin", "Murat", "Halil", " Kerem"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ilker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
        }
    }
}
