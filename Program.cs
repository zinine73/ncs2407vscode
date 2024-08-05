using Zinine;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{180, 120, 140};
        int[] inv2 = new int[]{89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        int answer = Programmers.Solution0805(num_list, 190);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
        //CSharpStudy.EnumSample();
    }
}