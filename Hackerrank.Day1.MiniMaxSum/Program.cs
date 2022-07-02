// Important info
// I was stuck for the only test case : 5 5 5 5 5
// Solved it with for loop instead foreach loop in line : 15 and line 18, inside 'Where'.
// Cause was, at first I did not compare with index in line number : 18.

class Result
{
    public static void miniMaxSum(List<Int64> arr)
    {
        Int64 maxSum = 0;
        Int64 minSum = 0;

        if (arr is null || arr.Count == 0) Console.WriteLine(minSum + " " + maxSum);

        for (int idx = 0; idx < arr.Count; idx++)
        {
            Int64 item = arr[idx];
            Int64 sum = arr.Where((x, i) => i != idx).Select(x => x).Sum();

            if (maxSum == 0) maxSum = sum;
            if (minSum == 0) minSum = sum;

            if (sum > maxSum)
            {
                maxSum = sum;
            }

            if (sum < minSum)
            {
                minSum = sum;
            }
        }

        Console.WriteLine(minSum + " " + maxSum);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
