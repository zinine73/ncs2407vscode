using System.Security.Cryptography;
using System.Text;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{5, 1, 4};
        int[] inv2 = new int[]{58, 44, 27, 10, 100};
        var strl = new string[]{"nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx"};
        Programmers pg = new Programmers();
        string[] answer = pg.Solution0903(strl);
        //Utils.PrintIntArray(answer);
        //Console.WriteLine(answer);
        CSharpStudy cs = new CSharpStudy();
        cs.Perform();
    }
}