using Cage.Classes;
using System;

namespace Cage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe Käfig");

            Cage<Tiger> tigerCage = new Cage<Tiger>();

            Tiger tiger1 = new Tiger("Franz");
            Tiger tiger2 = new Tiger("Petra");
            Tiger tiger3 = new Tiger("Hans");

            tigerCage.AddAnimale(tiger1);
            tigerCage.AddAnimale(tiger2);
            tigerCage.AddAnimale(tiger3);


            Cage<Monkey> monkeyCage = new Cage<Monkey>();

            Monkey monkey1 = new Monkey("Himmy");
            Monkey monkey2 = new Monkey("Paul");
            Monkey monkey3 = new Monkey("Herr Nilsson");
            Monkey monkey4 = new Monkey("Laura");

            monkeyCage.AddAnimale(monkey1);
            monkeyCage.AddAnimale(monkey2);
            monkeyCage.AddAnimale(monkey3);
            monkeyCage.AddAnimale(monkey4);


            tigerCage.RemoveAnimal(tiger3);

            monkeyCage.RemoveAnimal(monkey1);

          

            

        }
    }
}
