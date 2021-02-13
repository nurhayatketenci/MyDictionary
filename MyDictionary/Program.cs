using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Nur");
            names.Add("İrem");
            names.Add("Didem");
            names.Add("Eda");


            Console.WriteLine("MyDictionary " + names.Count + " elemanlıdır.");
        }
    }
}
