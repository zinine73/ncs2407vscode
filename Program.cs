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
        int[] inv2 = new int[]{1,1,1,1,0};
        var strl = new string[]{"problemsolving", "practiceguitar", "swim", "studygraph"};
        var str2 = new bool[]{true,false,true,false};
        Programmers pg = new Programmers();
        string[] answer = pg.Solution09202(strl, str2);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
        //CSharpStudy cs = new CSharpStudy();
        //CSharpEvent cse = new CSharpEvent();
        //cse.EventSample();
    }
}