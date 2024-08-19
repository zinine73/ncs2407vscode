using System.Security.Cryptography;
using Zinine;
// 지정해 놓은 형식만을 사용한다는 뜻이 된다
using Random = System.Random;

internal class Program
{
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
        public BaseCustomerData baseData;
        public int memberKeep;

        // 생성자
        public CustomerData()
        {
            //this.memberKeep = memberKeep;
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
    }

    public class ChildCustomer : CustomerData
    {
        public string place;

        public bool isCute()
        {
            return true;
        }
    }

    private static void Main(string[] args)
    {
        CustomerData sc = new CustomerData();
        sc.baseData.name = "Lee";
        sc.baseData.age = 30;
        //Console.WriteLine(sc.GetCData());

        CustomerData cc = new CustomerData();
        cc.baseData.name = "Kim";
        cc.baseData.age = 26;
        //Console.WriteLine(cc.GetCData());
        
        ChildCustomer child = new ChildCustomer();
        child.memberKeep = 100;
        child.place = "seoul";
        child.isCute();
        child.GetCData();

        int[] num_list = new int[]{0, 1, 0, 10, 0, 1, 0, 10, 0, -1, -2, -1};
        int[] inv2 = new int[]{58, 44, 27, 10, 100};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        string answer = Programmers.Solution08192(num_list);
        //Utils.PrintIntArray(answer);
        Console.WriteLine(answer);
        //CSharpStudy.DicSample();
    }

    public static int Sum(int from, int to)
    {
        int sum = 0;
        for (int i = from; i <= to; i++)
        {
            sum++;
        }
        return sum;
    }
}