using System;

namespace Zinine
{
    public class Utils
    {
        // Integer 배열을 한줄에 출력해주는 함수
        public static void PrintIntArray(int[] answer)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i]);
                if (i != answer.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}