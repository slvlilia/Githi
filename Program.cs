using System;

enum City
{
    Київ = 1,
    Дніпро,
    Одеса,
    Париж,
    Марсель,
    Ліон,
    Берлін,
    Франкфурт,
    Гамбург
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Список мiст:");
        Console.WriteLine($"{(int)City.Київ} - Київ");
        Console.WriteLine($"{(int)City.Дніпро} - Днiпро");
        Console.WriteLine($"{(int)City.Одеса} - Одеса");
        Console.WriteLine($"{(int)City.Париж} - Париж");
        Console.WriteLine($"{(int)City.Марсель} - Марсель");
        Console.WriteLine($"{(int)City.Ліон} - Лiон");
        Console.WriteLine($"{(int)City.Берлін} - Берлiн");
        Console.WriteLine($"{(int)City.Франкфурт} - Франкфурт");
        Console.WriteLine($"{(int)City.Гамбург} - Гамбург");

        Console.WriteLine("Введiть через кому номери мiст, якi ви хочете вiдвiдати:");
        string input = Console.ReadLine();
        string[] cityNumbers = input.Split(',');
        Console.WriteLine("Перелiк обраних мiст:");

        Console.WriteLine("Україна:");
        foreach (string number in cityNumbers)
        {
            if (Enum.IsDefined(typeof(City), int.Parse(number)))
            {
                City city = (City)int.Parse(number);
                if (city >= City.Київ && city <= City.Одеса)
                {
                    Console.WriteLine($"{number} - {city}");
                }
            }
        }

        Console.WriteLine("Францiя:");
        foreach (string number in cityNumbers)
        {
            if (Enum.IsDefined(typeof(City), int.Parse(number)))
            {
                City city = (City)int.Parse(number);
                if (city >= City.Париж && city <= City.Ліон)
                {
                    Console.WriteLine($"{number} - {city}");
                }
            }
        }

        Console.WriteLine("Нiмечинна:");
        foreach (string number in cityNumbers)
        {
            if (Enum.IsDefined(typeof(City), int.Parse(number)))
            {
                City city = (City)int.Parse(number);
                if (city >= City.Берлін && city <= City.Гамбург)
                {
                    Console.WriteLine($"{number} - {city}");
                }
            }
        }

        Console.WriteLine("Author: Серьоженко Лiлiя Вадимiвна");
    }
}
