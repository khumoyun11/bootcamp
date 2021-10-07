using System;

namespace lesson1.Solutions
{
    class Lab2
    {
        public void Problem9()
        {
            int a = 0;
            int b = 1;
            int c = a + b;

            System.Console.Write($"{a} {b} {c} ");

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");  

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");      

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");     

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");    

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");     

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");      

            a = b;
            b = c;
            c = a+b;

            System.Console.Write($"{c} ");  
        }

        public void Problem8()
        {
            System.Console.WriteLine($"1!={1}");
            System.Console.WriteLine($"2!={1 * 2}");
            System.Console.WriteLine($"3!={1 * 2 * 3}");
            System.Console.WriteLine($"4!={1 * 2 * 3 * 4}");
            System.Console.WriteLine($"5!={1 * 2 * 3 * 4 * 5}");
        }

        public void Problem7()
        {
            Console.WriteLine("Enter number: ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);

            Console.WriteLine($"{a}*1={a*1}");
            Console.WriteLine($"{a}*2={a*2}");
            Console.WriteLine($"{a}*3={a*3}");
            Console.WriteLine($"{a}*4={a*4}");
            Console.WriteLine($"{a}*5={a*5}");
            Console.WriteLine($"{a}*6={a*6}"); 
            Console.WriteLine($"{a}*7={a*7}");
            Console.WriteLine($"{a}*8={a*8}");
            Console.WriteLine($"{a}*9={a*9}");
        }

        public void Problem6()
        {
            System.Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            System.Console.WriteLine(" 23  24  25  26  27  28   1");
        }

        public void Problem5()
        {
            Console.WriteLine("Enter number");
            var a = Console.ReadLine();
            Console.WriteLine(a+a+a+a+a+a);
            Console.WriteLine(a +"    "+a);
            Console.WriteLine(a +"    "+a);
            Console.WriteLine(a+a+a+a+a+a);
        }

        public void Problem4()
        {

            System.Console.Write("Enter month and date: ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            var b = int.Parse(data[1]);

            string A = a.ToString().PadLeft(2, '0');
            string B = b.ToString().PadLeft(2, '0');

            System.Console.WriteLine("Birthday is: " + A + "-" + B + " " + "(mm-dd)");

        }

        public void Problem3()
        {
            Console.WriteLine("Birthdate");
            Console.Write("Enter date: ");
            var date = System.Console.ReadLine();
            Console.Write("Enter month: ");
            var month = Console.ReadLine();

            string Date = date.ToString().PadLeft(2, '0');
            string Month = month.ToString().PadLeft(2, '0');

            System.Console.WriteLine("Birthday is: " + Date + "-" + Month + " " + "(mm-dd)");
        }    

        public void Problem2()
        {
            Console.WriteLine("  A");
            Console.WriteLine(" A A");
            Console.WriteLine("AAAAA");
        }

        public void Problem1()
        {
            
            Console.WriteLine("222222");
            Console.WriteLine("2    2");
            Console.WriteLine("2    2");
            Console.WriteLine("222222");
        }
    }
}