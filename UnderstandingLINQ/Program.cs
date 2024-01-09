//Console.WriteLine("Hello, World!");

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model="745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //LINQ (Language Integrated Query)

            //LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year
                              select car;
            */


            //LINQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            //var firstCars = myCars.OrderByDescending(p => p.VIN).First(p => p.Year == 2010);
            //Console.WriteLine(firstCars.VIN);

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year ,car.VIN, car.Model);
            }
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2004));

            //myCars.ForEach(p => p.StickerPrice -= 4000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine(myCars.Exists(p => p.Model == "4Runner"));

            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));

            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.VIN, car.StickerPrice};

            Console.WriteLine(bmws.GetType());
            */
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
