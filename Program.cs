using Zinine;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{-7,9};
        int[] inv2 = new int[]{89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        string answer = Programmers.Solution08092("Progra21Sremm3", 6, 12);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
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