using System;
using System.Linq;

namespace CodeForces;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.


internal static class Program
{
    public static void Main(string[] args)
    {
        Problem208A();
    }

    private static void Problem208A()
    {
        Console.WriteLine(string.Join(" ", Console.ReadLine().Split("WUB", StringSplitOptions.RemoveEmptyEntries)));
    }

    private static void Problem281A()
    {
        var input = Console.ReadLine().ToCharArray();
        input[0] = char.ToUpper(input[0]);
        Console.WriteLine(new string(input));
    }

    private static void Problem1760A()
    {
        var testCases = int.Parse(Console.ReadLine());
        var results = new int[testCases];
        for (int i = 0; i < testCases; i++)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = numbers[0];
            var b = numbers[1];
            var c = numbers[2];

            if (a > Math.Min(b, c) && a < Math.Max(b,c))
            {
                results[i] = a;
            }

            if (b > Math.Min(a, c) && b < Math.Max(a, c))
            {
                results[i] = b;
            }

            if (c > Math.Min(a, b) && c < Math.Max(a, b))
            {
                results[i] = c;
            }
        }

        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine(results[i]);
        }
    }

    private static void Problem405A()
    {
        var numberOfColumns = int.Parse(Console.ReadLine());
        var columnHeights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(string.Join(" ", columnHeights.OrderBy(x => x)));
    }

    private static void Problem133A()
    {
        var output = Console.ReadLine().Any(c => c == 'H' || c == 'Q' || c == '9') ? "YES" : "NO";
        Console.WriteLine(output);
    }

    private static void Problem339A()
    {
        var sortedNumbers = Console.ReadLine().Split(new char[] {'+'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderBy(x => x);
        Console.WriteLine(string.Join("+", sortedNumbers));
    }

    private static void Problem236A()
    {
        var name = Console.ReadLine();
        var distinctChars = name.Distinct().Count();
        if (distinctChars % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }
    }
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8602 // Dereference of a possibly null reference.

}
