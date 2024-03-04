using System.ComponentModel;

namespace uc3
{

    class generic
    {
        public static T MaxValue<T>(T value1, T value2, T value3) where T : IComparable<T>
        {


            T max = value1;
            if (value2.CompareTo(max) > 0)
            {
                max = value2;
            }
            if (value3.CompareTo(max) > 0)
            {
                max = value3;
            }
            return max;


        }
        public static T MaxValue1<T>(params T[] f) where T : IComparable<T>
        {

            T max = f[0];
            for(int i = 1;i<f.Length;i++)
            {
                if (f[i].CompareTo(max) > 0)
                {
                    max = f[i];
                }
            }
            return max;
        }

    }

    class max
    {
        public void maxnum(int a,int b,int c)
        {
            if(a>b && a>c)
            {
                Console.WriteLine($"max num is {a}");
            }else if(b>c && b>a)
            {
                Console.WriteLine($"max num iz {b}");
            }
            else
            {
                Console.WriteLine($"max num is {c}");
            }
        }
        public void maxnum(float a,float b,float c)
        {
            if (a>b && a>c)
            {
                Console.WriteLine($"max num is {a}");
            }
            else if (b>c && b>a)
            {
                Console.WriteLine($"max num iz {b}");
            }
            else
            {
                Console.WriteLine($"max num is {c}");
            }
        }
        public void maxnum(string a, string b, string c)
        {
            string[] strings = { a,b,c };

            
            string maxString = strings[0];

            if(b.CompareTo(maxString) > 0)
            {
                maxString = b;
            }
            if(c.CompareTo(maxString) > 0)
            {
                maxString=c;
            }
            
            Console.WriteLine("Maximum string: " + maxString);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            max m = new max();
            m.maxnum(3,7,5);
            m.maxnum(3.4f, 5.6f, 7.7f);
            m.maxnum("banana", "orange", "apple");
            
           int result = generic.MaxValue(1,2,3);
            Console.WriteLine($"max int value is {result}");

            float result1 = generic.MaxValue(2.4f, 5.6f, 7.7f);
            Console.WriteLine($"max int value is {result1}");

            string result2 = generic.MaxValue("apple","grapes","mango");
            Console.WriteLine($"max int value is {result2}");



           string s =  generic.MaxValue1("apple", "ball", "pineapple", "mango", "banana");
            Console.WriteLine(s);

            int st = generic.MaxValue1(1,3,5,6,7,4,6,8,2);
            Console.WriteLine(st);


        }
    }
}
