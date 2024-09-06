//#define DEVELOP
#define RELEASE
using System;
using System.Text;
using Myevan;

namespace Zinine
{
    #pragma warning restore format
    #region Struct Class
    public abstract class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int money;
        // 외부에서 접근할 수 없고, 자신과 상속받은 클래스만 사용할 수 있음
        protected bool vip = false;

        public bool IsVIP()
        {
            return vip;
        }

        public void WhereSick()
        {
        }

        public DateTime MeetDoctor()
        {
            DateTime dateTime = new DateTime();
            return dateTime;
        }

        public abstract void Diagnosis();
        public virtual void Operation()
        {
            money = 10000;
        }
    }

    public class Dentistry : Patient
    {
        public override void Diagnosis()
        {
            //throw new NotImplementedException();
        }

        public void CleanTeeth()
        {

        }
    }

    public class Otolaryngology : Patient
    {
        public override void Diagnosis()
        {
            throw new NotImplementedException();
        }

        public override void Operation()
        {
            money = 20000;
            vip = true;
        }
    }

    /*
    struct Scustomer
    {
        public string name;
        public int age;

        public string GetSData()
        {
            string data = $"{name}, {age}";
            return data;
        }
    }

    class Ccustomer
    {
        public string name;
        public int age;

        public string GetCData()
        {
            string data = $"{name}, {age}";
            return data;
        }
    }
    */

    public struct BaseCustomerData
    {
        public string name;
        public int age;
    }

    public class CustomerData
    {
        #region public member
        public BaseCustomerData baseData;

        public int memberKeep;
        #endregion

        #region privates
        private int money;
        #endregion
        
        #region functions
        // 생성자
        public CustomerData(int memberKeep)
        {
            this.memberKeep = memberKeep;
        }

        // 소멸자
        ~CustomerData()
        {
        }

        public string GetCData()
        {
            string data = $"{baseData.name}, {baseData.age}, {memberKeep}";
            return data;
        }
        #endregion
    }

    public class ChildCustomer : CustomerData
    {
        public string place;

        public ChildCustomer(int mk) : base(mk)
        {
        }

        public bool isCute()
        {
            return true;
        }
    }


    public class ChessPiece
    {
        public virtual void Move()
        {
            Console.WriteLine("do not move");
        }

        public void SetPosition(int x)
        {

        }

        public void SetPosition(int x, int y = 1)
        {
            
        }

        public void SetPosition()
        {

        }

        public void SetPosition(string str)
        {

        }
    }

    public class Knight : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("한칸 앞으로 대각선 앞으로");
        }
    }

    public class Bishop : ChessPiece
    {

        public override void Move()
        {
            Console.WriteLine("대각선으로 걸리는게 없는 곳");
        }
    }

    public class Rook : ChessPiece
    {
        //public override void Move()
        //{
        //    Console.WriteLine("상하좌우으로 걸리는게 없는 곳");
        //}
    }
    #endregion 

    public class CSharpStudy
    {
        #region delegate & event
        // delegate 선언
        public delegate void MyDelegate(int i);

        // event 필드
        public event MyDelegate runEvent;

        public void RunThis(int val)
        {
            Console.WriteLine($"Run This : {val}");
        }

        public void RunThat(int value)
        {
            Console.WriteLine($"Run That : {value}");
        }

        void RunWho(int val, int val2)
        {
            Console.WriteLine($"Run Who : {val + val2}");
        }

        public void Perform()
        {
            // delegate의 instance 생성
            MyDelegate run = new MyDelegate(RunThis);

            // delegate 실행
            //run(100);

            // 새로운 메서드 연결
            //run = new MyDelegate(RunThat);
            //run(100);

            // 또 새로운 메서드 연결
            //run = RunThis;
            //run(200);

            // 멀티캐스트가 가능하다
            run += RunThat;
            run += RunThis;
            //run(100);

            // event
            runEvent += RunThis;
            runEvent += RunThat;
            runEvent -= RunThis;
            // 이건 내부에서 사용하는거라 에러 안남
            runEvent = RunThis;
            runEvent(100);
        }

        public void Perform2(int val)
        {
            if (runEvent != null)
            {
                runEvent(val);
            }
        }
        #endregion

        public static void Inheritance()
        {
            Dentistry p1 = new Dentistry();
            Otolaryngology p2 = new Otolaryngology();
            p1.WhereSick();
            p1.CleanTeeth();
            p1.MeetDoctor();
            p1.Diagnosis();
            p1.MeetDoctor();

            p2.MeetDoctor();
            p2.Diagnosis();
            p2.Operation();

            if (p1.IsVIP())
            {
                // 주차권
            }
        }

        // Named parameter, Optional parameter
        public static void NamedParam(string name, int age, int money)
        {
        }

        public static void NamedParam2(string name, int age = 1, int money = 0)
        {
        }

        public static void NamedSample()
        {
            NamedParam("Lee", 40, 1000);
            NamedParam(name:"Kim", money:10, age:10);
            NamedParam(age:25, name:"Park", money:0);

            NamedParam2("Choi", 57, 1000000);
            NamedParam2("Yoon");
            NamedParam2("Cho", money:10000);
        }

        #region pass by ref
        // pass by value, pass by ref
        public static void Calculate(ref int a)
        {
            a *= 2;
            Console.WriteLine($"a : {a}");

            // x, y 두 값의 체인지
            int x = 10;
            int y = 20;
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"final x:{x}, y:{y}");
        }
        #endregion pass by ref

        class ListClass
        {
            public List<int> list = new List<int>();
        }

        public static void NullableSample()
        {
            // ?. : null이 아니면 참조하고, null이면 null
            //ListClass lc = new ListClass();
            ListClass lc = null;
            Console.WriteLine(lc?.list.Count);

            // ?? : null이면 오른쪽 값으로 처리
            //Object obj = new Dictionary<int, int>();
            Object obj = null;
            Object a = obj ?? new List<int>();
            Console.WriteLine(a);
        }

        public static int GetListCount(List<int> list)
        {
            /*
            if (list == null)
            {
                return 0;
            }
            else
            {
                return list.Count;
            }
            */
            //return (list == null) ? 0 : list.Count;
            return list?.Count ?? 0;
        }

        public static void CompareToSample()
        {
            int a = 1;
            int b = 0;
            Console.WriteLine(a.CompareTo(b));
            string s1 = "abc";
            string s2 = "abc";
            Console.WriteLine(s1.CompareTo(s2));
            // if (s1 == s2) string 비교시에 ComrateTo 사용하자
            if (s1.CompareTo(s2) == 0) { }
            StringBuilder sb = new StringBuilder();
            sb.Append(s1);
            s2 = sb.ToString();
        }

        public static void ClassSample()
        {
            CustomerData sc = new CustomerData(0);
            sc.baseData.name = "Lee";
            sc.baseData.age = 30;
#if (DEVELOP)
            Console.WriteLine(sc.GetCData());
#else
            Console.WriteLine("");
#endif
            CustomerData cc = new CustomerData(1);
            cc.baseData.name = "Kim";
            cc.baseData.age = 26;
            //Console.WriteLine(cc.GetCData());

            ChildCustomer child = new ChildCustomer(2);
            child.memberKeep = 100;
            child.place = "seoul";
            //child.isCute();
            //child.GetCData();

            CustomerData ch2 = new ChildCustomer(0);

            // 부모클래스로 틀을 잡고 자식클래스로 정의할 수 있다
            ChessPiece cp = new ChessPiece();
            ChessPiece kn = new Knight();
            ChessPiece ro = new Rook();
            ChessPiece bi = new Bishop();

            // 오버라이딩
            cp.Move();
            kn.Move();
            ro.Move();
            bi.Move();

            // 오버로딩
            cp.SetPosition(10);
            cp.SetPosition();
            cp.SetPosition(3);
        }

        private static int hp;

        // Get
        public static int GetHp()
        {
            return hp;
        }

        // Set
        public static void SetHp(int val)
        {
            if (val > 100)
            {
                Console.WriteLine("Over 100...");
            }
            hp = val;
        }

        // property
        public static int mp
        {
            get
            {
                return mp;
            }

            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Over 100...");
                }
                else
                {
                    mp = value;
                }
            }
        }

        private static int speed { get; set; }
        public static int weight;

        public static void Basic()
        {
            // value타입 데이터형에 ?를 붙여서 null 값도 가능하게 만든다
            int? i = null; // i가 null 값을 가질 수 있다

            // 문자열에서 특정 문자열 가져오는 것 > Substring(시작인덱스, 길이)
            string s3 = "C# Programming";
            string subs = s3.Substring(1, 5);
            //Console.WriteLine($"SubString: {subs}");

            string[] str = new string[3] {"AB", "CD", "EF"};
            foreach (var item in str) // item이 string형이고
            //foreach (var item in s3) // item이 char형이다
            {
                Console.WriteLine(item);
            }

        }

        public static void DicSample()
        {
            var loginData = new Dictionary<string, string>();
            loginData.Add("zinine", "password");
            loginData.Add("whdgus", "absvs");
            loginData.Add("aleifj", "ooooa111");
            loginData.Add("yuyuy7878", "00000000");

            //string pw = loginData["zinine"];
            foreach (var item in loginData)
            {
                //Console.WriteLine($"{item.Key} : {item.Value}");
            }

            foreach (string item in loginData.Keys)
            {
                //Console.WriteLine(item);
            }
            
            string checkid = "whdgus";
            if (loginData.ContainsKey(checkid) == false)
            {
                Console.WriteLine($"{checkid} 는 없습니다...");
            }
            else
            {
                Console.WriteLine($"{checkid}의 암호는 {loginData[checkid]}입니다...");
            }
        }

        // Enum
        public enum Direction
        {
            East = 4,
            West = 3,
            South = 2,
            North = 1
        }

        public enum GameState
        {
            Init = 1,
            Lobby,
            Login,
            Main,
            Battle,
            Win,
            Die,
            GameOver,

            none = 0
        }

        public static void EnumSample()
        {
            Direction dir = Direction.South;

            switch (dir)
            {
                case Direction.East:
                case Direction.West:
                    Console.WriteLine(dir);
                    break;

                case Direction.South:
                    break;

                case Direction.North:
                    break;

                default:
                    Console.WriteLine("이런 경우는 없다");
                    break;
            }

            Console.WriteLine($"Your direction is {dir}, value : {(int)dir}");

            GameState state;
            state = GameState.Init;
            if (state == GameState.Battle)
            {
                state = GameState.Win;
            }
        }

        /// <summary>
        /// 한글 조사 변환 > using Myevan 해야 Korean.Re~ 사용할 수 있다
        /// </summary>
        static void KoreanJosa()
        {
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

            // ===> do ~ while
            do
            {
                ai++;
                ii--;
            } while (ii > 0);
            
            Console.WriteLine(ai);
        }

        /// <summary>
        /// 하니가 3살 때 코나키타발루 를 다녀온것을 기억했다. 이걸 list로 만들어 보자
        /// </summary>
        /// <param name="aaa"></param>
        /// <returns></returns>
        private static string Sample(int aaa)
        {
            //Func();
            string[] city = new string[5] { "도쿄", "타이베이", "오사카", "홍콩", "발리" };
            var country = new string[5] { "일본", "대만", "일본", "중국", "인도네시아" };
            string[,] trip = new string[2, 5]{{"도쿄", "타이베이", "오사카", "홍콩", "발리"},
        {"일본", "대만", "일본", "중국", "인도네시아"}};

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

    public class CSharpEvent
    {
        CSharpStudy cs = new CSharpStudy();

        public void EventSample()
        {
            cs.runEvent += cs.RunThis;
            cs.runEvent += cs.RunThat;
            cs.runEvent += RunAnother;
            cs.runEvent -= cs.RunThat;
            // 이건 에러나는 상황
            //cs.runEvent = cs.RunThis;
            //cs.runEvent(100);
            cs.Perform2(100);
        }

        public static void RunAnother(int val)
        {
            Console.WriteLine($"Run another : {val}");
        }
    }
}