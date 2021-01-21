using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> listem = new MyDictionary<string>();
            listem.Add(" - İlkay");
            listem.Add(" - Salih");
            listem.Add(" - Ahmet");

            Console.WriteLine(" - Adet : " + listem.Count());

            foreach (var item in listem.Listem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Liste Oluştu!");

        }
    }
}
