using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void TaskA()
        {
            double[,] mtx1 =
            {
                {1, 1, 1 },
                {2, 3, 4 },
                {3, 1, 0 }
            };
            double[,] mtx2 =
            {
                {1, 1 },
                {2, 0 }
            };
            double[,] mtx3 =
            {
                {1, 1 },
                {0, 2 }
            };
            MyMatrix a = new MyMatrix(mtx1);
            MyMatrix b = new MyMatrix(a);

            Console.WriteLine("Before mtx1 change:\n" + a);
            mtx1[1, 1] = 0;
            Console.WriteLine("After mtx1 change:\n" + a);
            Console.WriteLine();

            Console.WriteLine(b);
            Console.WriteLine();

            MyMatrix c = new MyMatrix(b.ToString());
            Console.WriteLine(c);
            Console.WriteLine();

            MyMatrix m1 = new MyMatrix(mtx2);
            MyMatrix m2 = new MyMatrix(mtx3);
            Console.WriteLine(m1 * m2);
            Console.WriteLine();
            Console.WriteLine(m2 * m1);
            Console.WriteLine();

            double[,] mtx4 =
            {
                {1, 2, 3 },
                {1, 0, -1 }
            };
            MyMatrix M1 = new MyMatrix(mtx4);
            Console.WriteLine(M1);
            Console.WriteLine();
            M1.TransponeMe();
            Console.WriteLine(M1);
            return;
        }


        static void TaskB()
        {
            MyTime t = new MyTime(9, 2, 30);
            Console.WriteLine(t);

            Console.WriteLine("TimeSinceMidnight:");
            Console.WriteLine(t.TimeSinceMidnight());
            Console.WriteLine(new MyTime(24 * 60 * 60 - 1));

            Console.WriteLine("Add one (s/m/h):");
            t = t.AddOneSecond();
            Console.WriteLine(t);
            t = t.AddOneMinute();
            Console.WriteLine(t);
            t = t.AddOneHour();
            Console.WriteLine(t);

            Console.WriteLine("AddSeconds:");
            t = t.AddSeconds(-40000);
            Console.WriteLine(t);

            Console.WriteLine(new MyTime(23, 59, 59).AddSeconds(2));

            Console.WriteLine("Difference:");
            Console.WriteLine(MyTime.Difference(t, new MyTime(4, 20, 0)));

            MyTime t1 = new MyTime(7, 59, 59);
            Console.WriteLine("What lesson {0}: {1}", t1, t1.WhatLesson());
            MyTime t2 = new MyTime(8, 0, 0);
            Console.WriteLine("What lesson {0}: {1}", t2, t2.WhatLesson());
            MyTime t3 = new MyTime(9, 19, 59);
            Console.WriteLine("What lesson {0}: {1}", t3, t3.WhatLesson());
            MyTime t4 = new MyTime(9, 20, 0);
            Console.WriteLine("What lesson {0}: {1}", t4, t4.WhatLesson());
            MyTime t5 = new MyTime(17, 29, 59);
            Console.WriteLine("What lesson {0}: {1}", t5, t5.WhatLesson());
            MyTime t6 = new MyTime(17, 30, 0);
            Console.WriteLine("What lesson {0}: {1}", t6, t6.WhatLesson());
        }
        static void Main(string[] args)
        {
            Console.Write("Task(A/B): ");
            string ans = Console.ReadLine().Trim().ToLower();
            switch (ans)
            {
                case "a":
                    TaskA();
                    break;
                case "b":
                    TaskB();
                    break;
                default:
                    break;
            }
        }
    }
}
