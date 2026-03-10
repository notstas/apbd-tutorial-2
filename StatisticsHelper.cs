namespace tutorial_2;

public class StatisticsHelper
{
    public static int calculateAverage(int[] items)
    {
        var sum = 0;
        foreach (var num in items)
        {
            sum += num;
        }
        
        return sum / items.Length;
    }
}