using System.Security.Cryptography;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{0, 1, 0, 10, 0, 1, 0, 10, 0, -1, -2, -1};
        int[] inv2 = new int[]{58, 44, 27, 10, 100};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        string answer = Programmers.Solution08192(num_list);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
        //CSharpStudy.DicSample();
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