class Result
{
    public static string findNumber(List<int> arr, int k)
    {
        if (arr == null || arr.Count == 0) return "NO";

        for (int idx = 0; idx < arr.Count; idx++)
        {
            if (arr[idx] == k)
            {
                return "YES";
            }
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        var result = Result.findNumber(new List<int>() { 1, 2, 4 }, 5);
        Console.WriteLine(result);
    }
}