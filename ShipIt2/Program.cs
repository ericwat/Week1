internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ship It v2\n");
        Console.WriteLine("Choose a shipping method for your order.\n" +
                          "1-Next Day\n" +
                          "2-Air\n" +
                          "3-Ground\n");

        var shippingCost = 0.0;
        var shippingMethod = Console.ReadLine();
        var couldParse = int.TryParse(shippingMethod, out var parsedValue);

        if (couldParse)
            //shippingCost = parsedValue switch
            //{
            //    1 => 20.0,
            //    2 => 10.0,
            //    3 => 5.0,
            //    _ => shippingCost
            //};
            switch (parsedValue)
            {
                case (int)ShippingMethod.NextDay:
                    shippingCost = 20.0;
                    break;
                case (int)ShippingMethod.Air:
                    shippingCost = 10.0;
                    break;
                case (int)ShippingMethod.Ground:
                    shippingCost = 5.0;
                    break;
            }

        Console.WriteLine("You are paying {0} for shipping. You think outside the box.\n",
            string.Format("{0:C}", shippingCost));

            //Console.WriteLine("You are paying {0:C} for shipping. You think outside the box.\n", shippingCost);

            //Console.WriteLine("You are paying {0} for shipping. You think outside the box.\n",
            //    $"{shippingCost:C}");
    }
}

public enum ShippingMethod
{
    NextDay = 1,
    Air,
    Ground
}