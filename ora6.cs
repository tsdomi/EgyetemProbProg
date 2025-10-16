namespace het6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Book book = new Book("The hobiit", "x", 10, 10);
            //Console.WriteLine(book.AllDate());
            //book.title = "The hobbit";

            //Book book2 = new Book();
            //book2.title = "the hobbit 2";

            //Console.WriteLine(book.title);
            //Console.WriteLine(book2.title);

            //2
            Runner runner = new Runner(1, "Bela", 3);
            Runner runner2 = new Runner(2, "Sanyi", 2);
            runner.Show();
            runner2.Show();
            while (runner.getDistance() <= 50 || runner2.getDistance() <= 50)
            {
                Console.ReadLine();
                runner.RefreshDistance(1);
                runner.Show();
                runner2.RefreshDistance(1);
                runner2.Show();
            }
        }
    }
    class Runner
    {
        private int id;
        private string name;
        private int velocity;
        private int distance;
        
        public Runner(int id, string name, int velocity)
        {
            this.id = id;
            this.name = name;
            this.velocity = velocity;
            distance = 0;
        }

        public void RefreshDistance(int timeDeltaS)
        {
            distance = distance + velocity*timeDeltaS;
        }

        public void Show()
        {
            //Console.Clear();
            //Console.SetCursorPosition(0, id);
            //Console.Write(name[0]);

            Console.SetCursorPosition(0, id);
            Console.Write(new string(' ', Math.Max(distance - 1, 0)) + name[0]);
        }

        public int getDistance()
        {
            return distance;
        }
    }


    //1
    //class Book
    //{
    //    private string author;
    //    private string title;
    //    private int pageNumber;
    //    private int year;
    //    public string AllDate()
    //    {
    //        return $"{title} - {author} - {pageNumber} - {year}";
    //    }
    //    public Book(string title, string author, int pageNumber, int year)
    //    {
    //        this.title = title;
    //        this.author = author;
    //        this.pageNumber = pageNumber;
    //        this.year = year;
    //    }
    //}
}
