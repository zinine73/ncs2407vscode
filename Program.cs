using System.Security.Cryptography;
using System.Text;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{12, 4, 15, 46, 38, 1, 14, 56, 32, 10};
        int[] inv2 = new int[]{58, 44, 27, 10, 100};
        //var strl = new string[]{"I", "Love", "Programmers."};
        int answer = Programmers.Solution08282(2, 4);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
    }
}