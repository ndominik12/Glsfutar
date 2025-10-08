using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI
{
    class Program
    {
        static void Main()
        {
            string[] sorok = File.ReadAllLines("GLS.txt");
            List<AutoAdatok> lista = new List<AutoAdatok>();

            foreach (string sor in sorok)
            {
                if (!string.IsNullOrWhiteSpace(sor))
                    lista.Add(new AutoAdatok(sor));
            }

            Console.WriteLine("2. Feladat:");
            Console.WriteLine($"\tAz autó használatban töltött napjainak száma: {lista.Count}");
        }
    }
}