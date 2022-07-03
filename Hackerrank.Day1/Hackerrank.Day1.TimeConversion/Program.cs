﻿class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
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

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
