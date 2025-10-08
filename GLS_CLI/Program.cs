using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            Console.WriteLine("3. Feladat:");
            int kulonbozoSoforok = lista.Select(a => a.Sofor).Distinct().Count();
            Console.WriteLine($"\tKülönböző sofőrök száma: {kulonbozoSoforok}");

            Console.WriteLine("4. Feladat:");
            int osszesKm = lista.Sum(a => a.NapiKilometer);
            Console.WriteLine($"\tAz összes megtett kilométer: {osszesKm} km");

            // --- Task 6 ---
            Console.WriteLine("6. Feladat:");
            double osszesFogyasztas = lista.Sum(a => a.Fogyasztas);
            double atlagosFogyasztas =
                AutoAdatok.AtlagFogyasztas(osszesFogyasztas, osszesKm);

            Console.WriteLine($"\tÁtlagos fogyasztás: {atlagosFogyasztas} liter/100 km");
        }
    }
}