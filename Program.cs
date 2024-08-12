using Zinine;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{-7,9};
        int[] inv2 = new int[]{1,3,5};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        int[] answer = Programmers.Solution0812(inv2, 1, 2);
        Utils.PrintIntArray(answer);
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