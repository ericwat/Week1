internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Filter By Price\n");

        double[] cars = { 15000.0, 20000.0, 10000.0 };

        //double[] carz = new double[3];
        //carz[0] = 15000.0;
        //carz[1] = 20000.0;
        //carz[2] = 10000.0;

        /* Ascending */
        Console.WriteLine("Low to High Price\n");
        Array.Sort(cars);
        var index = 0;
        foreach (double car in cars)
        {
            ++index;
            Console.WriteLine("Vehicle #{0} - {1:C} MSRP\n", index, car);
        }

        /* Descending */
        //Console.WriteLine("High to Low Price\n");
        //Array.Sort(cars);
        //Array.Reverse(cars);
        //var index = 0;
        //foreach (double car in cars)
        //{
        //    ++index;
        //    Console.WriteLine("Vehicle #{0} - {1:C} MSRP\n", index, car);
        //}
    }
}