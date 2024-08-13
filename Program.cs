using Zinine;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{-7,9};
        int[] inv2 = new int[]{1,3,5};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        int[] answer = new int[]{};
        try
        {
            answer = Programmers.Solution0812(inv2, 1,1);
            Utils.PrintIntArray(answer);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
        //Console.WriteLine(answer);
        //CSharpStudy.Basic();
    }

    public static int Sum(int from, int to)
    {
        int sum = 0;
        for (int i = from; i <= to; i++)
        {
            sum++;
        }
        return sum;
    }
}