using System;
using tutorial_2;

class Program
{
    static void Main(string[] args)
    {
        List<int> items = new List<int>();

        foreach (var arg in args)
        {
            items.Append(int.Parse(arg));
        }

        var avg = StatisticsHelper.calculateAverage(items);
        var min = StatisticsHelper.findMin(items);
        
        Console.WriteLine($"Your average is {avg}");
        Console.WriteLine($"Your min numbers is {items}");
    }
}