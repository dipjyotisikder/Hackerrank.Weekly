class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        // 1  2  3
        // 1  2  3
        // 1  2  3
        // (2,0), (1,1), (0,2)


        int left = 0;
        int right = 0;
        int arrCount = arr.Count;

        for (int rowIndex = 0; rowIndex < arrCount; rowIndex++)
        {
            List<int> row = arr[rowIndex];
            for (int valueIndex = 0; valueIndex < row.Count; valueIndex++)
            {
                if (rowIndex == valueIndex)
                {
                    left += row[valueIndex];
                }
                if (valueIndex == arrCount - rowIndex - 1)
                {
                    right += row[valueIndex];
                }
            }
        }

        return Math.Abs(left - right);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

    }
}
