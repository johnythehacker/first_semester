using System;

namespace basic_algs
{
    class Program
    {
        // Expr1
        // Yes you can, but it is __CHEAPER__ and __FASTER__
        // to create a new variable in the stack.
        // But if you want to, here is how:
        static void swap_vars()
        {
            int a = 1;
            int b = 2;
            
            a += b;
            b += a - b;
            a -= b;
        }
        
        // Expr2
        static int reverse_number(int num)
        {
            int reversed_num = 0;
            while (num != 0)
            {
                reversed_num = reversed_num * 10;
                reversed_num = reversed_num + num%10;
                num = num/10;
            }

            return reversed_num;
        }
        
        // Expr3
        static int time_to_angle(int hour)
        {
            if (hour % 12 > 6)
                return (12 - hour % 12) * 360 / 12;
 
            return hour % 12 * 360/12;
        }
        
        // Expr4
        static int num_count(int x, int y, int n)
        {
            int c = 0;
            
            // multiply because we don't need to check values upper square root
            // but you can use this too: (int i = 0; i < n; i++)
            for (int i = 2; i * i <= n; i++) 
            {
                if (i % x == 0 && i % y == 0) c++;
            }

            return c;
        }

        // Expr5
        static int even_years_count(int from, int to)
        {
            int years = to - from + 1;
            int even_years = 0;

            for (int i = 0; i < years; i++)
            {
                int year = i + from;
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    even_years++;
            }

            return even_years;
        }
                
        static void Main(string[] args)
        {
            Console.WriteLine(even_years_count(1904, 2000));
        }
    }
}