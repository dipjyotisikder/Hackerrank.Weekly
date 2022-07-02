//This solution will find all the Odd numbers between two given limit.

class Result
{
    public static List<int> findNumber(int l, int r)
    {
        var totalDistance = l - r;
        var odds = new List<int>();

        for (int i = 0, value = l; i <= totalDistance; i++, value++)
        {
            if (value % 10 != 0) odds.Add(i);
        }

        return odds;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.findNumber(4, 10);
    }
}