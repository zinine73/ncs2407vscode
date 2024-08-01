using System;
using System.Collections.Generic;

namespace Zinine
{
    public class Programmers
    {
        // 양꼬치
        public static int Solution0801(int n, int k)
        {
            int answer =0;
            int yang = n * 12000;
            int free = n / 10;
            int drink = (k - free) * 2000;
            answer = yang + drink;
            return answer;
        }

        // 짝수 홀수 개수
        public static int[] Solution0731(int[] num_list)
        {
            // 리턴할 배열의 크기가 2로 일정하므로 바로 크기를 잡아서 선언한다
            int[] answer = new int[2];
            // num_list의 크기만큼 반복한다
            for (int i = 0; i < num_list.Length; i++)
            {
                // num_list에서 인덱스에 해당하는 값이
                int pick = num_list[i];
                if (pick % 2 == 0)
                // 짝수면 리턴할 배열의 첫번째 공간에
                {
                    answer[0] += 1;
                }
                // 홀수면 두번째 공간에 더해준다
                else
                {
                    answer[1] += 1;
                }
            }
            // foreach 사용할 경우
            /*
            foreach (var item in num_list)
            {
                if (item % 2 == 0)
                {
                    answer[0]++;
                }
                else
                {
                    answer[1]++;
                }
            }
            */
            return answer;
        }
        public static int Solution0729(int n)
        {
            int answer = 0;
            // 0부터 n(포함)까지 반복
            for (int i = 1; i <= n; i++)
            {
                // 짝수인가? n % 2 == 0
                if (i % 2 == 0)
                {
                    // 짝수면 어딘가 더해
                    answer += i;
                }
            }
            return answer;
        }
        public static int Solution0726(int angle)
    {
        int answer = 0;
        if (angle == 90)
        {
            answer = 2;
        }
        else if (angle == 180)
        {
            answer = 4;
        }
        else if ((0<angle) && (angle<90))
        {
            answer = 1;
        }   
        else // 생략 가능한 if...복잡한 식을 여기에 
        {
            answer = 3;
        }

        // ?: 로 풀어보자
        answer = (angle == 90) ? 2 : (angle == 180) ? 4 : ((0<angle) && (angle<90))? 1 : 3; 
        return answer;
    }
    }
}