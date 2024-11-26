using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату для метода Parse:");
        string userInputParse = Console.ReadLine();

        Console.WriteLine("Введите дату для метода ParseExact:");
        string userInputParseExact = Console.ReadLine();

        Console.WriteLine("Введите дату для метода TryParse:");
        string userInputTryParse = Console.ReadLine();

        Console.WriteLine("Введите дату для метода TryParseExact:");
        string userInputTryParseExact = Console.ReadLine();

        string exactFormat = "dd/MM/yyyy"; // Формат для ParseExact и TryParseExact
        CultureInfo provider = CultureInfo.InvariantCulture;

        // Parse
        try
        {
            DateTime date1 = DateTime.Parse(userInputParse, provider);
            Console.WriteLine($"Parse успешен: {date1}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Parse не удалось для строки: {userInputParse}");
        }

        // ParseExact
        try
        {
            DateTime date2 = DateTime.ParseExact(userInputParseExact, exactFormat, provider);
            Console.WriteLine($"ParseExact успешен: {date2}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"ParseExact не удалось для строки: {userInputParseExact}");
        }

        // TryParse
        if (DateTime.TryParse(userInputTryParse, out DateTime result1))
        {
            Console.WriteLine($"TryParse успешен: {result1}");
        }
        else
        {
            Console.WriteLine($"TryParse не удалось для строки: {userInputTryParse}");
        }

        // TryParseExact
        if (DateTime.TryParseExact(userInputTryParseExact, exactFormat, provider, DateTimeStyles.None, out DateTime result2))
        {
            Console.WriteLine($"TryParseExact успешен: {result2}");
        }
        else
        {
            Console.WriteLine($"TryParseExact не удалось для строки: {userInputTryParseExact}");
        }
    }
}
