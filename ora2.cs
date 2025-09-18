using System.Runtime;

namespace het2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Feladat 1
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //Feladat 2
            string jelszo = "valami";
            string tmp = "";
            int proba = 0;

            do
            {
                tmp = Console.ReadLine();
                proba++;

            }
            while (proba < 3 && jelszo != tmp);
            if (proba>=3 && tmp != jelszo)
            {
                Console.WriteLine("Hibauzenet");
            }
            */

            /*
            //feladat 3
            int szam = int.Parse(Console.ReadLine());
            int proba = 0;
            Random rnd = new Random();
            while (true)
            {
                int tmp = rnd.Next(1, 1001);
                proba++;
                if (tmp == szam)
                {
                    break;
                }

            }
            Console.WriteLine($"proba {proba}");
            */

            /*
            //Feladat 4
            int jatekos = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int hol = 1;
            int roll = -1;
            //do
            //{
            //    Console.ReadLine();
            //    if (rnd.Next(1,7) == 6)
            //    {
            //        break;
            //    }
            //    if (hol==jatekos)
            //    {
            //        hol = 1;
            //    }
            //    else
            //    {
            //        hol++;
            //    }
            //} while (true);
            do
            {
                for (int i = 0; i < jatekos; i++)
                {
                    roll = rnd.Next(1, 6 + 1);
                    Console.WriteLine($"{i+1}. jatekos dobasa {roll}");
                    if (roll == 6)
                    {
                        break;
                    }
                }
            } while (roll != 6);
            //Console.Clear();
            Console.WriteLine(hol);
            */

            /*
            //Feladat 5
            Random rnd = new Random();
            int gondolt = rnd.Next();
            int tmp = 0;
            do
            {
                tmp = int.Parse(Console.ReadLine());
                if (gondolt >tmp)
                {
                    Console.WriteLine("Nagyobb");
                }
                else if(gondolt < tmp)
                {
                    Console.WriteLine("Kiseebb");
                }
            }
            while (tmp != gondolt);
            Console.WriteLine("Meg van");
            */


            /*
            //Feladat 6
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Az {N} {(N%2 == 0 ? "paros" : "paratlan")}");
            if (N%2==0)
            {
                Console.WriteLine("Paros");
            }
            else
            {
                Console.WriteLine("Paratlan");
            }
            int darab = 0;
            for (int i = 2; i < N; i++)
            {
                if (N%i==0)
                {
                    Console.WriteLine(i);
                    darab++;
                }
            }
            Console.WriteLine(darab);
            //vagy
            //if (darab<1)
            //{
            //    Console.WriteLine("Primszam");
            //}
            //else
            //{
            //    Console.WriteLine("Nem primszam");
            //}

            bool primszam = true;
            for (int i = 2; i < N; i++)
            {
                if (N%i==0)
                {
                    primszam = false;
                }
            }
            if (primszam)
            {
                Console.WriteLine("Primszam");
            }
            else
            {
                Console.WriteLine("Nem primszam");
            }
            */

            /*
            //Feladat 7
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"N = {N}");
            Console.Write($"{N}! = ");
            long osszeg = 1;
            for (int i = N; i > 0; i--)
            {
                Console.Write($"{i}");
                if (i!=1)
                {
                    Console.Write("*");
                }
                osszeg *= i;
            }
            Console.WriteLine($" = {osszeg}");
            */

            /*
            //Feladat 8
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"\t{i*j}\t");
                }
                Console.WriteLine();
            }
            */

            /*
            //Feladat 9
            Console.Write("Masodperc: ");
            int second = int.Parse( Console.ReadLine() );
            Console.Clear();
            while (second>0)
            {
                //Console.Clear();
                Console.WriteLine($"{second/60:00}:{second%60:00}");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(0,0);
                second--;
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("00:00");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Beep();
            */

            /*
            //Feladat 10
            int bemenet = 420;
            string kettes = "";
            do
            {
                
            } while (bemenet>1);
            */

            //Feladat 11
            int kredit = 100;
            int tet = 1;
            int[] veletlen = new int[3];
            Random rnd = new Random();
            do
            {
                Console.SetCursorPosition(0,0);
                Console.WriteLine($"Kredit: {kredit:00000}, Tet: {tet:000}");
                ConsoleKeyInfo tmp = Console.ReadKey();
                if (tmp.Key == ConsoleKey.UpArrow)
                {
                    if (tet<= kredit)
                    {
                        tet++;
                    }
                    
                }
                else if(tmp.Key == ConsoleKey.DownArrow)
                {
                    if (tet > 1)
                    {
                        tet--;
                    }
                }
                else if(tmp.Key == ConsoleKey.Escape || kredit <= 0)
                {
                    break;
                }
                else if(tmp.Key == ConsoleKey.Spacebar)
                {
                    kredit = kredit - tet;
                    veletlen[0] = rnd.Next(0, 10);
                    veletlen[1] = rnd.Next(0, 10);
                    veletlen[2] = rnd.Next(0, 10);
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"{veletlen[0]} : {veletlen[1]} : {veletlen[2]}");
                    if (veletlen[0] == veletlen[1] && veletlen[1] == veletlen[2])
                    {
                        kredit += tet * 50;
                    }
                    else if (veletlen[0] == veletlen[1] || veletlen[0] == veletlen[2] || veletlen[1] == veletlen[2])
                    {
                        kredit += tet * 10;
                    }
                }

            }
            while (kredit>=0);
        }
    }
}
