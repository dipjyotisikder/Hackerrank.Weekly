//This solution will find all the Odd numbers between two given limit.
// Limits are inclusive

class Result
{
    public static List<int> findNumber(int l, int r)
    {
        var totalDistance = Math.Abs(l - r);
        var odds = new List<int>();

        for (int i = 0, value = l; i <= totalDistance; i++, value++)
        {
            if (value % 2 != 0) odds.Add(value);
        }

        return odds;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int>? numbers = Result.findNumber(3, 6);

        Console.WriteLine(string.Join(",", numbers));
    }
}