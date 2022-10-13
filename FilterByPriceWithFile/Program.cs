using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        const string path = "C:\\Users\\P2788693\\source\\repos\\Week1\\FilterByPriceWithFile\\data.csv";

        using (var sr = new StreamReader(path))
        {
            string[] inputData = sr.ReadToEnd().Split(",");
            foreach (var car in inputData)
            {
                TrimEnd(car);
            }
            
            // trim
            
            
            // convert
            
            
            // output
            
            Array.Sort(cars);
            var index = 0;
            foreach (var car in cars)
            {
                ++index;
                Console.WriteLine("Vehicle #{0} - {1:C} MSRP\n", index, TrimEnd(car));
            }
        }

        string TrimEnd(string car)
        { 
           char[] charsToTrim = {',', '.', ' ','?','\r','\n'};
           return car.TrimEnd(charsToTrim);
        }
    }
}