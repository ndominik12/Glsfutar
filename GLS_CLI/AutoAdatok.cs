using System;

namespace GLS_CLI
{
    public class AutoAdatok
    {
        public DateTime Datum { get; }
        public string Sofor { get; }
        public int NapiKilometer { get; }
        public int Csomagok { get; }
        public int Fogyasztas { get; }

        public AutoAdatok(string line)
        {
            string[] adatok = line.Split(';');
            Datum = DateTime.Parse(adatok[0]);
            Sofor = adatok[1];
            NapiKilometer = int.Parse(adatok[2]);
            Csomagok = int.Parse(adatok[3]);
            Fogyasztas = int.Parse(adatok[4]);
        }

        // --- Task 5: Függvénykészítés ---
        public static double AtlagFogyasztas(double osszFogyasztas, double osszKm)
        {
            if (osszKm <= 0 || osszFogyasztas < 0)
                return 0;
            return osszFogyasztas / osszKm * 100;
        }
    }
}