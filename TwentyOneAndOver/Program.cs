internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("21 And Over");

/*
 *  Reading values from the command line as strings and convert into numbers.
 *  Everything entered in the console is a string. 
 */

// Read string data from the console and store it in a variable as a integer (number).

        const string message = "What year were you born? Enter age and press Enter. Ex. 1996? : \n";
        Console.WriteLine(message);

// reads values from the console as a string object into year
        var year = Console.ReadLine();
        int parsedAge;

// converts a number from string to an integer
        var couldParse = int.TryParse(year, out parsedAge);

// If the conversion was successful then determine if alcohol can be served.
// If the conversion was unsuccessful then ask the user to enter a valid numeric birth year.
        if (couldParse)
        {
            var age = 2022 - parsedAge;
            if (couldParse && age >= 21)
                Console.WriteLine("I can serve you alcohol. Get bent.\n");
            else
                Console.WriteLine("I can't serve you alcohol. Drink water.\n");
        }
        else
        {
            Console.WriteLine("Please enter a valid birth year, ex. 1996\n");
        }
    }
}