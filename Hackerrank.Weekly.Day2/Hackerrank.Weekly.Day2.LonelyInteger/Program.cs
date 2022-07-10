class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        Dictionary<int, int> temp = new();

        for (int i = 0; i < a.Count; i++)
        {
            int item = a[i];
            if (temp.TryGetValue(item, out int outputValue))
            {
                temp[item] = outputValue + 1;
            }
            else
            {
                temp.Add(item, 1);
            }
        }

        foreach (var item in temp)
        {
            if (temp[item.Key] == 1)
            {
                return item.Key;
            }
        }

        return -1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ')
            .ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);

    }
}
