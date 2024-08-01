using System;
using System.Text;
using Myevan;

namespace Zinine
{
    public class CSharpStudy
    {
        static void Basic()
        {
            // value타입 데이터형에 ?를 붙여서 null 값도 가능하게 만든다
            int? i = null; // i가 null 값을 가질 수 있다
        }

        static void KoreanJosa()
        {
            // 한글 조사 변환 > using Myevan 해야 Korean.Re~ 사용할 수 있다
            Console.WriteLine($"나(은)는 지금 탕후루(탕)후루 먹고싶다.");
            string a = Korean.ReplaceJosa($"나(은)는");
            string b = Korean.ReplaceJosa($"탕후루(탕)후루");
            Console.WriteLine($"{a} 지금 {b} 먹고싶다.");
        }

        static void csSwitch()
        {
            // switch문은 if문으로 바꿀 수 있다
            int ia = 0;
            // ia값 (0<ia<100) 중 1,2,3 값만 출력하는 switch문
            switch (ia)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(ia);
                    break;
                default:
                    break;
            }

            ia = 1;
            // switch에는 1일때 상황이 있지만 if문에는 없어서 결과가 다르다 
            Console.WriteLine(switchSample(ia));
            Console.WriteLine(ifSample(ia));
        }

        static int switchSample(int ia)
        {
            int answer = 0;
            switch (ia)
            {
                case 0:
                    answer += 1;
                    break;
                case 1: // 1일 때 아무것도 안하고 break...default문도 거치지 않는다
                    break;
                case 2:
                    answer--;
                    break;

                default:
                    answer = answer + 2;
                    break;
            }
            return answer;
        }

        static int ifSample(int ia)
        {
            int answer = 0;
            if (ia == 0)
                answer += 1;
            else if (ia == 2)
                answer--;
            else
            {
                // ia가 1일때 상황을 코딩하지 않았으므로 1일때 여기로 들어온다
                answer = answer + 2;
            }
            return answer;
        }

        static void STnQ()
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            //int val1 = st.Pop();

            Queue<int> qu = new Queue<int>();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            //int val2 = qu.Dequeue();

            int len = st.Count;
            for (int i = 0; i < len; i++)
                Console.WriteLine($"{i + 1} : {st.Pop()} , {qu.Dequeue()}");

            // 배열 연산, 정렬등은 List 를 이용하자
            int[] ina = new int[5] { 3, 5, 7, 1, 2 };
            List<int> li = new List<int>(ina);
            int val = li[0];
            li.Sort();
            // 리스트에 있는 값은 배열에 있는 값을 이용하듯이 인덱스로 지정하면 됨
            val = li[0];
            li.Add(6);
            // Remove는 주어진 값을 지우는 것...없으면 안지움
            // 같은 값이 2개 이상 있을 때 앞에서 부터 지운다
            li.Remove(2);
            // RemoveAt은 해당 인덱스에 있는 값을 지운다 
            li.RemoveAt(2);
            li.Clear();
        }

        private static bool YesOrNo(bool val)
        {
            if (!val)
            {
                val = !val;
            }
            return val;
        }

        private static int Func(int val)
        {
            // StringBuilder를 사용하기 위해서는 using System.Text; 가 필요하다.
            // VSCode에서는 자동으로 넣어준다...다른 곳에서 사용할 때 주의하자
            StringBuilder sb = new StringBuilder();
            sb.Append("What");

            // for문은 간단한 식이라면 {} 없이도 사용할 수 있다
            for (int i = 0; i < 5; i++)
                sb.Append(val);

            // StringBuilder의 값을 실제로 string으로 사용하기 위해선 ToString() 이 필요하다
            Console.WriteLine(sb.ToString());

            // if문도 {} 안 쓰고 사용 가능
            if (val > 90)
                val--;
            else
                val++;

            return val;
        }

        static void WhileSample()
        {
            int ai = 0;
            while (ai < 10)
            {
                ai++;
            }
            //Console.WriteLine(ai);

            ai = 5;
            for (var i = 10; i > 0; i--)
            {
                ai++;
            }

            // ===> while
            ai = 5;
            int ii = 10;
            while (ii > 0)
            {
                ai++;
                ii--;
            }
            Console.WriteLine(ai);
        }

        private static string Sample(int aaa)
        {
            //Func();
            string[] city = new string[5] { "도쿄", "타이베이", "오사카", "홍콩", "발리" };
            var country = new string[5] { "일본", "대만", "일본", "중국", "인도네시아" };
            string[,] trip = new string[2, 5]{{"도쿄", "타이베이", "오사카", "홍콩", "발리"},
        {"일본", "대만", "일본", "중국", "인도네시아"}};

            // 하니가 3살 때 코나키타발루 를 다녀온것을 기억했다. 이걸 list로 만들어 보자
            List<string> city2 = new List<string>(city);
            city2.Insert(3, "코타키나발루");
            // 배열에 있는 모든 요소에 접근하려할 때 foreach 사용하면 좋다
            foreach (string item in city2)
            {
                //Console.WriteLine(item);
            }

            return string.Empty;
        }
    }
}