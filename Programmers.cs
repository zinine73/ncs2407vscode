using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;

namespace Zinine
{
    public class Programmers
    {
        // 숨어있는 숫자의 덧셈 (2)
        public int Solution09302(string my_string)
        {
            int answer = 0;
            bool isNumber = false; // 연속으로 숫자인지 아닌지
            int val = 0; // 한개 혹은 연속된 숫자 값
            // my_string 을 char 하나씩 돌면서
            foreach (var item in my_string)
            {
                // 지금 얻어온 char가 숫자냐
                if ((item >= '0')&&(item <= '9'))
                {
                    // 연속으로 숫자면
                    if (isNumber == true)
                    {
                        // val 값에 10 곱하고 계산
                        val = val * 10 + (item - '0');
                    }
                    else // 아니면
                    {
                        // val에 값 더해줌
                        val += (item - '0');
                        // 연속숫자 여부 켜기
                        isNumber = true;
                    }
                } 
                else // 아니면
                {
                    // 연속숫자 여부 끄기
                    isNumber = false;
                    // answer에 val 더하기
                    answer += val;
                    // val 을 0 으로
                    val = 0;
                }
            }
            // answer에 val 더하기
            answer += val;
            return answer;
        }

        // 숨어있는 숫자의 덧셈 (1)
        public int Solution0930(string my_string)
        {
            int answer = 0;
            // my_string은 char 배열이므로, 하나씩 돌자
            foreach (var item in my_string)
            {
                // 얻어온 char가 '0'과 '9' 사이에 있다면
                if ((item >= '0') && (item <= '9'))
                {
                    // answer에 그 값을 더한다
                    answer += (item - '0');
                }
            }
            return answer;
        }

        // 진료순서 정하기
        public int[] Solution0927(int[] emergency)
        {
            int[] answer = new int[emergency.Length];
            var list = new List<int>(emergency);
            list.Sort();
            list.Reverse();
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = list.IndexOf(emergency[i]) + 1;
            }
            return answer;
        }

        // 중복된 문자 제거
        public string Solution0926(string my_string)
        {
            string answer = "";
            // 스트링을 foreach로 반복
            foreach (var item in my_string)
            {
                // answer에 item이 없으면
                if (!answer.Contains(item))
                {
                    // answer에 item 추가
                    answer += item;
                }
            }
            return answer;
        }

        // 피자 나눠 먹기 (2)
        public int Solution0925(int n)
        {
            int answer = 0;
            // 반복
            do
            {
                // 피자 판 수 + 1
                answer++;
            } while (answer*6 % n != 0); // (총 피자조각 갯수 / 사람수 가 0)만족할때까지
            return answer;
        }

        // 이차원 배열 대각선 순회하기
        public int Solution0924(int[,] board, int k)
        {
            int answer = 0;
            // i의 크기만큼 반복
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // j의 크기만큼 반복
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    // i+j <= k 조건 검사
                    if (i+j <= k)
                    {
                        // 만족하면 총합에 추가
                        answer += board[i,j];
                    }
                }
            }
            return answer;
        }

        // 할 일 목록
        public string[] Solution09202(string[] todo_list, bool[] finished)
        {
            // answer 배열의 크기를 구한다
            int len = 0;
            foreach (var item in finished)
            {
                if (item == false) len++;
            }
            // 구한 크기만큼의 answer를 생성한다
            string[] answer = new string[len];
            // answer에 저장할 때 지정할 인덱스 변수(ai)를 하나 만든다
            int ai = 0;
            // for문을 돌면서
            for (int i = 0; i < todo_list.Length; i++)
            {
                // i인덱스의 finished 가 false
                if (finished[i] == false)
                {
                    // answer[ai]에 todo_list[i] 추가 
                    answer[ai] = todo_list[i];
                    // 인덱스(ai) + 1
                    ai++;
                }
            }
            return answer;
        }

        // 인덱스 바꾸기
        public string Solution0920(string my_string, int num1, int num2)
        {
            string answer = "";
            // num1, num2에 해당하는 char를 얻어온다
            char chr1 = my_string[num2];
            char chr2 = my_string[num1];
            // for로 돌면서
            for (int i = 0; i < my_string.Length; i++)
            {
                // num1과 같으면
                if (i == num1)
                    answer += chr1;
                // num2와 같으면
                else if (i == num2)
                    answer += chr2;
                // 아니면
                else
                    answer += my_string[i];
            }
            return answer;
        }

        // 외계행성의 나이
        public string Solution0913(int age)
        {
            string answer = "";
            while (age > 0)
            {
                int val = age % 10;
                char chr = Convert.ToChar(val + 'a');
                answer = chr + answer;
                age = age / 10;
            }
            return answer;
        }

        // 가까운 1찾기
        public int Solution09122(int[] arr, int idx)
        {
            int answer = -1;
            for (int i = idx; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }

        // 369게임
        public int Solution0912(int order)
        {
            int answer = 0;
            string str = order.ToString();
            foreach (var item in str)
            {
                if ((item == '3') || (item == '6') || (item == '9'))
                    answer++;
            }
            return answer;
        }

        // 간단한 식 계산하기
        public int Solution09112(string str)
        {
            int answer = 0;
            // string을 숫자와 수식으로 분리
            string[] sa = str.Split(' ');
            // 각 숫자(string)를 integer로 변환
            int a = Convert.ToInt32(sa[0]);
            int b = Int32.Parse(sa[2]);
            // 각 수식에 맞게 계산
            switch (sa[1])
            {
                case "+":
                    answer = a + b;
                    break;
                case "-":
                    answer = a - b;
                    break;
                case "*":
                    answer = a * b;
                    break;
            }
            return answer;
        }

        // 약수 구하기
        public int[] Solution0911(int n)
        {
            // 리스트 하나 만들고
            var list = new List<int>();
            // 1부터 n까지 반복
            for (int i = 1; i <= n; i++)
            {
                // n이 인덱스 값으로 나누어떨어지면 
                if (n % i == 0)
                {
                    // 그게 약수니까 list에 넣는다
                    list.Add(i);
                }
            }
            // list를 배열형으로 바꿔서 리턴한다
            return list.ToArray();
        }

        // 9로 나눈 나머지
        public int Solution0909(string number)
        {
            // 전체 값을 저장할 변수 하나를 생성
            int total = 0;
            // string은 char형의 배열임을 이용하여,
            // 배열의 각 값을 다 돌면서 더해준다
            foreach (var item in number)
            {
                // 각 item의 integer 값을 더해준다
                //Console.WriteLine(item);
                int val = item - '0';
                total += val;
            }
            // 전체값을 9로 나눈 값을 리턴한다
            return total % 9; 
        }

        // 삼각형의 완성조건 (2)
        public int Solution09052(int[] sides)
        {
            int answer = 0;
            int big = Math.Max(sides[0], sides[1]);
            int small = Math.Min(sides[0], sides[1]);
            // x + small > big
            // big - small < x <= big
            for (int i = big - small + 1; i <= big; i++)
            {
                answer++;
            }
            // big + small > x
            // big < x < big + small
            for (int i = big + 1; i < big + small; i++)
            {
                answer++;
            }

            return answer;
        }

        // 삼각형의 완성조건 (1)
        public int Solution0905(int[] sides)
        {
            //List<int> list = sides.ToList();
            var list = new List<int>();
            foreach (var side in sides)
            {
                list.Add(side);
            }
            list.Sort();
            if (list[2] < list[0] + list[1]) return 1;
            else return 2;
        }

        // 최댓값 만들기(2)
        public int Solution09042(int[] numbers)
        {
            int answer = -100000000;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (answer < numbers[i] * numbers[j])
                    {
                        answer = numbers[i] * numbers[j];
                    }
                }
            }
            return answer;
        }

        // 최댓값 만들기(1)
        public int Solution0904(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (answer < numbers[i] * numbers[j])
                    {
                        answer = numbers[i] * numbers[j];
                    }
                }
            }
            return answer;
        }

        // 5명씩
        public string[] Solution0903(string[] names)
        {
            var answer = new List<string>();
            int idx = 0;
            foreach (string name in names)
            {
                if (idx == 0)
                {
                    answer.Add(name);
                }
                idx++;
                if (idx == 5) idx = 0;
            }

            return answer.ToArray();
        }

        // 콜라츠 수열 만들기
        public int[] Solution0902(int n)
        {
            // List를 하나 만들자
            var list = new List<int>();
            // while문으로 돌리자
            while (n != 1)
            {
                // n을 List에 넣는다
                list.Add(n);
                // n 이 짝수인지 판별
                if (n % 2 == 0)
                {    
                    // 짝수일때 변형
                    n /= 2;
                }
                else
                {
                    // 홀수일때 변형
                    n = 3 * n + 1;
                }
            }
            // 마지막으로 해야할 일
            list.Add(1);
            // List를 배열형식으로 리턴하자
            return list.ToArray();
        } 

        // 세균 증식
        public static int Solution0830(int n, int t)
        {
            return n << t;
        }

        // 배열의 원소만큼 추가하기
        public static int[] Solution0829(int[] arr)
        {
            // list X 생성
            var X = new List<int>();
            // for문으로 arr의 원소를 탐색
            foreach (var item in arr)
            {
                // 각 원소의 크기만큼 X 에 a 값을 추가하는 것을 반복
                for (int j = 0; j < item; j++)
                {
                    X.Add(item);
                } 
            }
            // X를 ToArray를 사용하여 배열로 리턴
            return X.ToArray();
        }

        // 주사위 게임 1
        public static int Solution08282(int a, int b)
        {
            int answer = 0;
            if (a % 2 == 1)
            {
                if (b % 2 == 1)
                {
                    answer = a * a + b * b;
                }
                else
                {
                    answer = 2 * (a + b);
                }
            }
            else
            {
                if (b % 2 == 1)
                {
                    answer = 2 * (a + b);
                }
                else
                {
                    answer = Math.Abs(a - b);
                }
            }
            return answer;
        }

        // 뒤에서 5등 위로
        public static int[] Solution0828(int[] num_list)
        {
            // make List
            var list = new List<int>(num_list);
            //var relist = new List<int>();

            // List sort
            list.Sort();

            // indexer
            //for (int i = 5; i < list.Count; i++)
            //{
            //    relist.Add(list[i]);
            //}
            //return relist.ToArray();

            // RemoveAt
            for (int i = 0; i < 5; i++)
            {
                list.RemoveAt(0);
            }
            return list.ToArray();
        }

        // 0 떼기
        public static string Solution0826(string n_str)
        {
            string answer = "";
            bool zero = true;
            while(zero)
            {
                if(n_str[0] == '0')
                {
                    n_str = n_str.Substring(1);//, n_str.Length - 1);
                }
                else
                { 
                    zero = false; 
                }     
            }
            answer = n_str;
            return answer;
        }

        // 주사위의 개수
        public static int Solution0823(int[] box, int n)
        {
            return (box[0] / n) * (box[1] / n) * (box[2] / n);
        }

        // 홀수 vs 짝수
        public static int Solution0822(int[] num_list)
        {
            int hol = 0;
            int jak = 0;
            for (int i = 0; i < num_list.Length; i++)
            {
                if (i % 2 == 1)
                {
                    hol += num_list[i];
                }
                else
                {
                    jak += num_list[i];
                }
            }
            return Math.Max(hol, jak);
        }

        // 카운트 업
        public static int[] Solution0821(int start, int end)
        {
            // 리턴할 배열의 크기를 먼저 구해보자
            int len = end - start + 1;
            // 구해진 크기만큼 배열을 잡는다
            int[] answer = new int[len];
            // 배열의 크기만큼 반복문을 실행한다
            for (int i = 0; i < answer.Length; i++)
            {
                // 배열에 start부터 반복해서 넣자
                answer[i] = start + i;
            }
            return answer;
        }

        // 두 수의 연산값 비교하기
        public static int Solution0820(int a, int b)
        {
            int answer = 0;
            string apb = $"{a}{b}";
            int iapb = Convert.ToInt32(apb);
            int tab = 2 * a * b;
            if (iapb == tab)
            {
                answer = iapb;
            }
            else
            {
                answer = Math.Max(iapb, tab);
            }
            return answer;
        }
        // 수 조작하기 2
        public static string Solution08192(int[] numlog)
        {
            string answer = "";
            for (int i = 0; i < numlog.Length - 1; i++)
            {
                int val = numlog[i+1] - numlog[i];
                if (val == 1) answer += "w";
                else if (val == -1) answer += "s";
                else if (val == 10) answer += "d";
                else answer += "a";
            }
            return answer;
        }

        // 수 조작하기 1
        public static int Solution0819(int n, string control)
        {
            foreach (var item in control)
            {
                switch (item)
                {
                    case 'w':
                        n += 1;
                        break;
                    case 's':
                        n -= 1;
                        break;
                    case 'd':
                        n += 10;
                        break;
                    case 'a':
                        n -= 10;
                        break;
                }
            }
            return n;
        }

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