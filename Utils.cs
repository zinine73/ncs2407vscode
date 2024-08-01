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

        // 나의 꿈을 실현 시켜 줄 함수
        public static void MakeLotto()
        {
            // lotto2는 List를 이용하는 방법, lotto는 배열을 이용
            //List<int> lotto2 = new List<int>();
            int[] lotto = new int[6];

            var random = new Random();
            int count = 0;
            while (count < 6)
            {
                // 공을 하나 뽑고
                int pick = random.Next(1, 46);
                // 이미 뽑은 공들중에 있는지 비교해서
                //if (lotto2.Contains(pick))
                if (IsInIntArray(lotto, pick))
                {
                    // 코드를 더 간결하게 할 수 있지만 일부러 continue 써보려고 이렇게 했음
                    continue;
                }
                // 없으면 배열에 넣는다    
                else
                {
                    //lotto2.Add(pick);
                    lotto[count] = pick;
                }
                count++;
            }
            //lotto2.Sort();
            Array.Sort(lotto);

            //PrintIntArray(lotto2.ToArray());
            PrintIntArray(lotto);
        }

        // Integer배열에 주어진 값이 있는지 판단하는 함수
        public static bool IsInIntArray(int[] array, int val)
        {
            // array 안에 val 값이 있으면 true를 리턴
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    return true;
            }
            // 아니면 false 리턴
            return false;
        }
    }
}