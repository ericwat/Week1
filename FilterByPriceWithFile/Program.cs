using System.Text;

internal class Program
{
    // pre-increment ++i - increment then get the value
    // post-increment i++ - get the value then increment
    public static void Main(string[] args)
    {
        const string path = "C:\\Users\\P2788693\\source\\repos\\Week1\\FilterByPriceWithFile\\data.csv";

        const string path2 = $@"C:\Users\P2788693\source\repos\Week1\FilterByPriceWithFile\data.csv";
        using (var sr = new StreamReader(path2))
        {
            // load data from file
            string[] inputCarData = sr.ReadToEnd().Split(",");

            // clean the data of extraneous characters and place it in a new array
            int[] formattedCarData = new int[inputCarData.Length];

            // trim and convert data from string to int
            int index = 0;
            foreach (var carPrice in inputCarData)
            {
                formattedCarData[index] = ConvertStringToInt(TrimEnd(carPrice));
                index++;
            }

            // sort from low to high
            Array.Sort(formattedCarData);

            // sort from high to low
            //Array.Reverse(formattedCarData);

            // output
            var printIndex = 0;
            foreach (var carPrice in formattedCarData)
            {
                ++printIndex;
                Console.WriteLine("Vehicle #{0} - {1:C} MSRP\n", printIndex, carPrice);
            }
        }
    }

    private static string TrimEnd(string value)
    {
        char[] charsToTrim = { ',', '.', ' ', '?', '\r', '\n' };
        return value.TrimEnd(charsToTrim);
    }

    private static int ConvertStringToInt(string value)
    {
        int parsedValue;
        bool success = int.TryParse(value, out parsedValue);
        return parsedValue;
    }
}