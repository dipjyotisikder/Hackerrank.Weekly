class Result
{

    public static void plusMinus(List<int> arr)
    {
        int total = arr.Count;
        Dictionary<int, decimal?> keyValuePairs = new Dictionary<int, decimal?>();

        foreach (int item in arr)
        {
            if (item > 0)
            {
                keyValuePairs[1] = keyValuePairs.TryGetValue(1, out decimal? value) ? (value == null ? 1 : value + 1) : 1;
            }
            else if (item < 0)
            {
                keyValuePairs[2] = keyValuePairs.TryGetValue(2, out decimal? value) ? (value == null ? 1 : value + 1) : 1;
            }
            else if (item == 0)
            {
                keyValuePairs[3] = keyValuePairs.TryGetValue(3, out decimal? value) ? (value == null ? 1 : value + 1) : 1;
            }
            else
            {
                continue;
            }
        }

        var value1 = ((keyValuePairs.TryGetValue(1, out decimal? valueRes) ? valueRes ?? 0 : 0) / total).ToString(format: "0.000000");
        var value2 = ((keyValuePairs.TryGetValue(2, out decimal? valueRes2) ? valueRes2 ?? 0 : 0) / total).ToString(format: "0.000000");
        var value3 = ((keyValuePairs.TryGetValue(3, out decimal? valueRes3) ? valueRes3 ?? 0 : 0) / total).ToString(format: "0.000000");

        Console.WriteLine(value1 + "\n" + value2 + "\n" + value3);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
