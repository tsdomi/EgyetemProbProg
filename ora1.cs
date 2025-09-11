namespace ConsoleApp1
{
    internal class Program
    {
        static string jelszoBeolvasas()
        {
            string passWorldBack = "";
            while (true)
            {
                ConsoleKeyInfo leNyomott = Console.ReadKey();
                if (leNyomott.Key == ConsoleKey.Backspace)
                {
                    passWorldBack = passWorldBack.Substring(0, passWorldBack.Length - 1);
                    Console.Write(" \b");
                }
                else if(leNyomott.Key != ConsoleKey.Enter)
                {
                    passWorldBack += $"{leNyomott.KeyChar}";
                    Console.Write("\b \b");
                    Console.Write("*");
                }
                else
                {
                    return passWorldBack;
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.Write("hello, world! 1");
            //Console.ReadLine();
            ////ctrl + k + c
            ////ctrl * k + u
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.SetCursorPosition(3, 5);
            ////console.windowheight = "";
            //Console.WindowWidth = 10;
            //Console.WriteLine("hello, world! 2");
            //Console.ReadLine();


            /*//Feladat 1
            Console.WriteLine("Hello, World!");
            */

            /*
            //Feladat 2
            console.windowheight = 10;
            console.windowwidth = 150;
            console.writeline("heloo, world!");
            console.clear();
            console.backgroundcolor = consolecolor.green;
            console.setcursorposition(40, 0);
            console.writeline("785423.");
            */

            /*
            //Feladat 4
            Console.Write("Adja meg az szuletesi evet: ");
            Console.WriteLine($"A felhasznalo a kovetkeyo evben: " + (DateTime.Now.Year-int.Parse(Console.ReadLine())+1));
            */

            /*
            //Feladat 5
            Console.Write("Adja meg a testmagassagat (m): ");
            double magassag = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a testsulyat (kg): ");
            Console.WriteLine($"BMI index: {double.Parse(Console.ReadLine()) / (Math.Pow(magassag, 2))}");
            */

            //Feladat 6
            /*
            Console.Write("Az időtartam másodpercben: ");
            int bekertmasodperc = int.Parse(Console.ReadLine());
            int percVissza = bekertmasodperc / 60;
            int masodpercVisszaSzam = bekertmasodperc % 60;
            string masodpercVisszaSzoveg = "";
            if (masodpercVisszaSzam < 10)
            {
                masodpercVisszaSzoveg = "0" + masodpercVisszaSzam;
            }
            else
            {
                masodpercVisszaSzoveg = $"{masodpercVisszaSzam}";
            }
                Console.WriteLine($"Az időtartam formázva: {bekertmasodperc/60:00}:{bekertmasodperc%60:D2}");
            */

            /*
            //Feladat 7
            Console.Write("Adja meg a jelszavat: ");
            string passwordFirst = Console.ReadLine();
            Console.Clear();
            Console.Write("Adja meg a jelszavat megegyeszer: ");
            if (passwordFirst == Console.ReadLine())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Helyes jelszo megadas");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibas jelszo megadas");
            }
            */

            /*
            //Feladat 8
            Console.Write("Adja meg a jelszavat: ");
            string passwordFirst = jelszoBeolvasas();
            Console.Clear();
            Console.Write("Adja meg a jelszavat megegyeszer: ");
            string passwordSecond = jelszoBeolvasas();
            if (passwordFirst == passwordSecond)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Helyes jelszo megadas");
                
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibas jelszo megadas");
                Console.WriteLine(passwordFirst);
                Console.WriteLine(passwordSecond);
            }
            */

            /*
            //Feladat 9 
            Console.Write("Add meg az első számot: ");
            int szamElso = int.Parse(Console.ReadLine());
            Console.Write("Add meg az második számot: ");
            int szamMasodik = int.Parse(Console.ReadLine());
            Console.Write("Add meg a műveletet: ");
            string muvelet = Console.ReadLine();
            double eredmeny = 0;
            switch (muvelet)
            {
                case "+":
                    eredmeny = szamElso + szamMasodik;
                    break;
                case "-":
                    eredmeny = szamElso - szamMasodik;
                    break;
                case "*":
                    eredmeny = szamElso * szamMasodik;
                    break;
                case "/":
                    eredmeny = szamElso / szamMasodik;
                    break;
            }
            Console.WriteLine($"{szamElso} {muvelet} {szamMasodik} = {eredmeny}");
            */
            
            //Feladat 11
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            List<string> lsita = new List<string>() {"nulla", "egy", "ketto", "harom", "negy", "ot", "hat", "het", "nyolc", "kilenc" };
            Console.WriteLine($"Az általad megadott szám: {lsita[szam]}");
        }
    }
}
