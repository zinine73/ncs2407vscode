﻿using System.Security.Cryptography;
using System.Text;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{5, 1, 4};
        int[] inv2 = new int[]{-1, 2};
        var strl = new string[]{"nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx"};
        Programmers pg = new Programmers();
        int answer = pg.Solution09042(inv2);
        //Utils.PrintIntArray(answer);
        //Console.WriteLine(answer);
        CSharpStudy cs = new CSharpStudy();
        cs.Perform();
    }
}