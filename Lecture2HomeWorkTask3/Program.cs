using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2HomeWorkTask3
{
    class Program
    {
        public static int PopByCycle(int val, int pop)
        {
            if (pop == 0)
            { return 1; }
            int outputVal = 1;
            while (pop > 0)
            {
                outputVal = outputVal * val;
                pop--;
            }
            return outputVal;
        }

        public static void PopByRec(ref int val, int pop)
        {

            if (pop > 1)
            {
                int tempVal = val;
                pop = pop - 1;
                PopByRec(ref val, pop);
                val = val * tempVal;
            }
            else
            {
                if (pop == 0) val = 1;
            }

        }

        public static void PopByRec2(ref int val, int pop)
        {
            if (pop > 1)
            {
                if (pop % 2 != 0)
                {
                    int tempVal = val;
                    pop--;
                    PopByRec2(ref val, pop);
                    val = val * tempVal;
                }
                else
                {
                    val = val * val;
                    pop = pop / 2;
                    PopByRec2(ref val, pop);
                }
            }
            else {
                if (pop == 0) val = 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int origVal = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            int pop = int.Parse(Console.ReadLine());
            int val = origVal;
            Console.WriteLine($"C помощью цикла: {PopByCycle(val, pop)}");
            PopByRec(ref val, pop);
            Console.WriteLine($"C помощью рекурсии: {val}");
            val = origVal;
            PopByRec2(ref val, pop);
            Console.WriteLine($"C помощью цикла: {val}");
            Console.ReadKey();
        }
    }
}
