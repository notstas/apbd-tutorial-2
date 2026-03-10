namespace tutorial_2;

public class StatisticsHelper
{
    public static int calculateAverage(List<int> items)
    {
        var sum = 0;
        foreach (var num in items)
        {
            sum += num;
        }
        
        return sum / items.Count;
    }

    public static int? findMin(List<int> items)
    {
        int? currentMin = null;

        foreach (var num in items)
        {
            if  (currentMin == null || currentMin < num)
                {
                currentMin = num;
                }
          
        }
        
        return currentMin;
    }
}