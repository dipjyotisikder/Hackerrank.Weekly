// This problem converts 12hour time format to 24hour time format.

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s)
    {
        var timeParsed = DateTime.TryParse(s, out DateTime time);
        if (!timeParsed) return s;
        return time.ToString("HH:mm:ss");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        Console.WriteLine(result);
    }
}
