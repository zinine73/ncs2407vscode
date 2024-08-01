using Zinine;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num_list = new int[]{1,3,5,7};
        int[] inv2 = new int[]{89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        int answer = Programmers.Solution0801(64, 6);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
    }



    static int[] solution0725(string[] strlist)
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
    
    static int solution0723(int[] array)
    {
        int answer = 0;
        List<int> list = new List<int>(array);
        list.Sort();
        //list.Count 대신 array.Length를 사용해도 된다
        int index = (list.Count - 1)/2;
        answer = list[index];
        return answer;
    }

    
    static int solution07242(int n)
    {
        int answer = 0;
        // 나머지를 구하는 연산자는 %
        int piz = n / 7;
        int res = ((n % 7) == 0 )? 0 : 1;
        answer = piz + res;

        return answer;
    }

    static int solution0724(int num1, int num2)
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

    

    public static int solution0722(int[] array, int n) 
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
        foreach(int val in array)
        {
            // foreach문에서 차례로 넘겨주는 값을 가져온다
            // 가져온 값과 n과 비교한다. 두개의 값이 같으면
            if (val == n)
            // 넘겨주는 값에 1을 더한다
                answer += 1;
        }
        return answer;
    }

    public static string solution0719(string my_string, int n){
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
}