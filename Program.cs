﻿using System.Security.Cryptography;
using System.Text;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{7,9};
        int[,] inv2 = new int[,]{{0,1,2},{1,2,3},{2,3,4},{3,4,5}};
        var str1 = new string[]{"down", "down", "down", "down", "down"};
        var str2 = new bool[]{true,false,true,false};
        Programmers pg = new Programmers();
        int[] answer = pg.Solution1010(str1,num_list);
        Utils.PrintIntArray(answer);
        //Console.WriteLine(answer);
    }
}