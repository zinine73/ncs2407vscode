using System;
using System.Collections.Generic;
using System.Formats.Asn1;

namespace Zinine
{
    public class Programmers
    {
        // 첫 번째로 나오는 음수
        public static int Solution0816(int[] num_list)
        {
            for (int i = 0; i < num_list.Length; i++)
            {
                if (num_list[i] < 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // n보다 커질 때까지 더하기
        public static int Solution0814(int[] numbers, int n)
        {
            int answer = 0;
            foreach (var item in numbers)
            {
                answer += item;
                if (answer > n)
                {
                    break;
                }
            }
            return answer;
        }

        // 모음 제거
        public static string Solution0813(string my_string)
        {
            string answer = "";
            /*
            answer = my_string.Replace("a", "");
            answer = answer.Replace("e", "");
            answer = answer.Replace("i", "");
            answer = answer.Replace("o", "");
            answer = answer.Replace("u", "");
            */
            answer = my_string.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o","").Replace("u","");
            /*
            foreach (var item in my_string)
            {
                if ((item != 'a') &&
                    (item != 'e') &&
                    (item != 'i') &&
                    (item != 'o') &&
                    (item != 'u'))
                answer += item;
            }
            */
            return answer;
        }

        // 배열 자르기
        public static int[] Solution0812(int[] numbers, int num1, int num2)
        {
            // 리턴할 배열의 크기부터 구하자
            int len = num2 - num1 + 1;
            // 구한 크기만큼 배열을 선언
            int[] answer = new int[len];
            
            // try~catch문 예제 보려고 일부러 에러 발생시킴
            //len = answer[len];
            
            // 구한 크기만큼 돌면서
            for (int i = 0; i < len; i++)
            {
                // 인덱스에 해당 하는 값을 배열에 넣는다
                answer[i] = numbers[i + num1];
            }
            // 배열 리턴
            return answer;
        }

        // 문자열 뒤집기(코딩 기초 트레이닝)
        public static string Solution08092(string my_string, int s, int e)
        {
            char[] chr = my_string.ToArray();
            Array.Reverse(chr, s, e - s + 1);
            return new string(chr);
        }

        // 문자열 뒤집기(코딩테스트 입문)
        public static string Solution0809(string my_string)
        {
            // Array의 뒤집기 : Reverse
            char[] chr = my_string.ToArray();
            Array.Reverse(chr);
            return new string(chr);

            // List
            var list = new List<char>(my_string);
            list.Reverse();
            return new string(list.ToArray());

            // for
            string answer = "";
            for (int i = my_string.Length - 1; i >= 0; i--)
            {
                answer += my_string[i];
            }
            return answer;

            // foreach
            //string answer = "";
            foreach (var item in my_string)
            {
                answer = item + answer;
            }
            return answer;
        }

        // 아이스 아메리카노
        public static int[] Solution0808(int money)
        {
            //return new int[]{money/5500,money%5500};
            int[] answer = new int[2];
            const int coffee = 5500;
            int i = 0;
            for (i = money; i >= coffee; i = i - coffee)
            {
                answer[0] += 1;
            }
            answer[1] = i;
            return answer;
        }

        // 점의 위치 구하기
        public static int Solution0807(int[] dot)
        {
            return (dot[0] >= 0) ? (dot[1] >= 0) ? 1 : 4 : (dot[1] >= 0) ? 2 : 3;
        }

        // 배열 두배 만들기
        public static int[] Solution0806(int[] numbers)
        {
            //int[] answer = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }

        // 머쓱이보다 키 큰 사람
        public static int Solution0805(int[] array, int height)
        {
            int answer = 0;
            //for (int i = 0; i < array.Length; i++)
            foreach (var item in array)
            {
                //if (array[i] > height)
                if (item > height)
                {
                    answer++;
                }
            }
            return answer;
        }

        // 가위 바위 보
        public static string Solution0802(string rsp)
        {
            string answer = "";
            // 주어진 string의 크기만큼 반복한다
            for (int i = 0; i < rsp.Length; i++)
            {
                // 차례대로(인덱스에 따라) 주어진 문자열(혹은 char형)을
                char chr = rsp[i];
                // 가위(2), 바위(0), 보(5)냐에 따라
                // 그걸 이기는 가위바위보의 숫자(결국 문자열)를
                // answer에 넣는다
                if (chr == '2')
                {
                    answer += "0";
                }
                else if (chr == '0')
                {
                    answer += "5";
                }
                else
                {
                    answer += "2";
                }
            }
            // foreach를 사용할 때 ====================================
            answer = "";
            foreach (var item in rsp)
            {
                if (item == '2')        answer += "0";
                else if (item == '0')   answer += "5";
                else                    answer += "2"; 
            }
            return answer;
        }

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

        // 짝수는 싫어요
        public static int[] Solution0730(int n)
        {
            List<int> list = new List<int>();
            //var list2 = new List<int>();

            // 1부터 n(포함)까지 반복
            for (int i = 1; i <= n; i++)
            {
                // 홀수냐?
                if (i % 2 != 0)
                {
                    // 홀수면 List에 넣자
                    list.Add(i);
                }
            }
            // List를 int[] 형식으로 바꿔서 리턴하자
            return list.ToArray();
        }

        // 짝수의 합
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

        // 각도기
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
            else if ((0 < angle) && (angle < 90))
            {
                answer = 1;
            }
            else // 생략 가능한 if...복잡한 식을 여기에 
            {
                answer = 3;
            }

            // ?: 로 풀어보자
            answer = (angle == 90) ? 2 : (angle == 180) ? 4 : ((0 < angle) && (angle < 90)) ? 1 : 3;
            return answer;
        }

        // 배열 원소의 길이
        public static int[] Solution0725(string[] strlist)
        {
            int[] answer = new int[strlist.Length];

            // 주어진 string배열의 크기만큼 반복한다
            for (int i = 0; i < strlist.Length; i++)
            {
                //strlist중에 index i 에 해당하는 string의 길이를
                string str = strlist[i];
                int len = str.Length;
                // answer 배열의 index의 위치에 넣는다
                answer[i] = len;
            }

            // foreach를 사용한 방법
            int val = 0;
            foreach (var item in strlist)
            {
                answer[val] = item.Length;
                val++;
            }
            return answer;
        }

        // 피자 나눠먹기(1)
        public static int Solution07242(int n)
        {
            int answer = 0;
            // 나머지를 구하는 연산자는 %
            int piz = n / 7;
            int res = ((n % 7) == 0) ? 0 : 1;
            answer = piz + res;

            return answer;
        }

        // 숫자 비교하기
        public static int Solution0724(int num1, int num2)
        {
            int answer = 0;
            // if ~ else 를 사용했을 때
            if (num1 != num2)
            {
                answer = -1;
            }
            else// if (num1 != num2) <- 이부분 생략 가능
            {
                answer = 1;
            }

            // ?: (삼항연산자)를 사용했을 때
            answer = (num1 != num2) ? -1 : 1;

            return answer;
        }

        // 중앙값 구하기
        public static int Solution0723(int[] array)
        {
            int answer = 0;
            List<int> list = new List<int>(array);
            list.Sort();
            //list.Count 대신 array.Length를 사용해도 된다
            int index = (list.Count - 1) / 2;
            answer = list[index];
            return answer;
        }

        // 중복된 숫자 갯수
        public static int Solution0722(int[] array, int n)
        {
            int answer = 0;

            // for문 사용
            // 배열의 크기만큼 반복한다
            /*         for (int i = 0; i < array.Length; i++)
                    {
                        // 배열안에 있는 값을 하나씩 가져온다
                        int nn = array[i];
                        // 가져온 값과 n과 비교한다. 두개의 값이 같으면
                        if (nn == n)
                        {
                            //  넘겨주는 값에 1을 더한다
                            answer++;
                        }
                    } */

            // foreach
            // 배열의 크기만큼 반복한다
            foreach (int val in array)
            {
                // foreach문에서 차례로 넘겨주는 값을 가져온다
                // 가져온 값과 n과 비교한다. 두개의 값이 같으면
                if (val == n)
                    // 넘겨주는 값에 1을 더한다
                    answer += 1;
            }
            return answer;
        }

        // 문자 반복 출력하기
        public static string Solution0719(string my_string, int n)
        {
            string answer = "";
            // my_string에 들어있는 각 문자를 처음부터 돌면서 하나씩 얻어와서
            foreach (var item in my_string)
            {
                // n번만큼 돌려서
                for (var i = 0; i < n; i++)
                {
                    // 그걸 answer에 담는다
                    // string연산을 할 경우엔 StringBuilder를 쓰면 효율적이다.
                    answer += item;
                }
            }
            return answer;
        }

        // 배열 뒤집기
        public static int[] Solution0718(int[] num_list)
        {
            int[] answer = new int[num_list.Length];
            for (int i = 0; i < num_list.Length; i++)
            {
                answer[num_list.Length - i - 1] = num_list[i];
            }
            return answer;
        }

        // 배열의 평균값
        public static double Solution0717(int[] numbers)
        {
            double answer = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            answer = answer / numbers.Length;
            return answer;
        }

        // 문자열로 변환
        public static string Solution0715(int n) {
            string answer = "";
            answer = n.ToString();
            return answer;
        }
    }
}