using System;

namespace B_E_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------TASK 1-------------------------
            //int m = 100;
            //int sum = 0;
            //int count = 0;
            //for (int i = 1; i < m; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //Console.WriteLine($"1-den {m}-edek ededler içerisinde 21-e bölünen ededlerin ededi ortasi: {sum / count}");


            //--------------------TASK 2--------------------------
            // a b'den kicik olmalidir
            //int a = 0, b = 100;
            //int sum = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"{a} ile {b} ededleri daxil olmaqla aralarindaki ededlerin cemi :{sum}");

            //------------------TASK 3-----------------------
            // m n'den kicik olmalidir
            //int m = 1, n = 100;
            //int count = 0;
            //for (int i = m+1; i < n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        count++;
            //        i++;
            //    }
            //}
            //Console.WriteLine($"{m} ile {n} arasindaki reqemlerinin ceminin cut olana ededlerin sayi:{count}");


            //-----------------------------------------------------------

            PritName("Samir");
            PritName("Semed","Mirzazade");
            Console.WriteLine(IsEven(7));

        }
        static void PritName(string name)
        {
            Console.WriteLine($"Ad: {name}");
        }

        static void PritName(string name,string surname)
        {
            Console.WriteLine($"Ad ve Soyad: {name} {surname}");

        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

    }
}
