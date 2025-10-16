using System.IO;

namespace TarcaliSándorDomonkos_BOVP69_A
{
    internal class Program
    {
        class Kavenap
        {
            public string nev;
            public float ar;
            public string napSzak;
            public string napNeve;
            public string hoNeve;
            public Kavenap(string sor)
            {
                string[] tmpSplitted = sor.Split(';');
                nev = tmpSplitted[0];
                tmpSplitted[1] = tmpSplitted[1].Replace(',','.');
                ar = float.Parse(tmpSplitted[1]);
                napSzak = tmpSplitted[2];
                napNeve = tmpSplitted[3];
                hoNeve = tmpSplitted[4];
            }
        }
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("coffeeshop_dataset.csv");
            List<Kavenap> kavekNapon = new List<Kavenap>();
            for (int i = 1; i < adatok.Length; i++)
            {
                kavekNapon.Add(new Kavenap(adatok[i]));
            }

            Console.WriteLine("2 Feladat");
            Console.Write("Adjon meg egy kave nevet: ");
            string bekertKave = Console.ReadLine();
            int darab = 0;
            float bevetel = 0;
            float ara = 0;
            for (int i = 0; i < kavekNapon.Count; i++)
            {
                if (bekertKave == kavekNapon[i].nev)
                {
                    darab++;
                    bevetel += kavekNapon[i].ar;
                }
            }

            Console.WriteLine($"{bekertKave} kave {darab}-szor adtak el, osszesen a bevetel {bevetel} volt");

            List<string> honapok = new List<string>();
            for (int i = 0; i < kavekNapon.Count; i++)
            {
                if (!honapok.Contains(kavekNapon[i].hoNeve))
                {
                    honapok.Add(kavekNapon[i].hoNeve);                    
                }
            }

            Console.WriteLine("\n3 Feladat");
            float[] bevetelHo = new float[honapok.Count];
            for (int i = 0; i < kavekNapon.Count; i++)
            {
                for (int j = 0; j < honapok.Count; j++)
                {
                    if (honapok[j] == kavekNapon[i].hoNeve)
                    {
                        bevetelHo[j] = bevetelHo[j] + kavekNapon[i].ar;
                    }
                }
            }
            Console.WriteLine($"Legjovedelmezobb honap: {honapok[Array.IndexOf(bevetelHo,bevetelHo.Max())]}");
            Console.WriteLine($"Legszerenyebb honap: {honapok[Array.IndexOf(bevetelHo,bevetelHo.Min())]}");


            Console.WriteLine("\n4 Feladat");
            List<string> napszakok = new List<string>();
            for (int i = 0; i < kavekNapon.Count; i++)
            {
                if (!napszakok.Contains(kavekNapon[i].napSzak))
                {
                    napszakok.Add(kavekNapon[i].napSzak);
                }
            }
            List<string> kavek = new List<string>();
            for (int i = 0; i < kavekNapon.Count; i++)
            {
                if (!kavek.Contains(kavekNapon[i].nev))
                {
                    kavek.Add(kavekNapon[i].nev);
                }
            }

            for (int i = 0; i < napszakok.Count; i++)
            {
                int[] darabok = new int[kavek.Count];
                for (int j = 0; j < kavekNapon.Count; j++)
                {
                    if (kavekNapon[j].napSzak == napszakok[i])
                    {
                        for (int k = 0; k < kavek.Count; k++)
                        {
                            if (kavek[k] == kavekNapon[j].nev)
                            {
                                darabok[k]++;
                            }
                        }
                    }
                }
                Console.WriteLine($"A {napszakok[i]}-ban a legtobbet eladott kave: ");
                int maxValue = darabok.Max();
                for (int j = 0; j < darabok.Length; j++)
                {
                    if (darabok[j] == maxValue)
                    {
                        Console.WriteLine($"\t{kavek[j]}");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
