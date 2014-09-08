using System;
using System.Collections.Generic;
using System.Linq;

namespace Dispersion
{
    public class Calculator
    {
        int[] _source;
        public Calculator(int[] source)
        {
            _source = source;
        }

        public Tuple<int, int> CalMethod()
        {
            var array = _source;
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            var result = new Tuple<int, int>(0, 0);
            Console.WriteLine("");
            int first = int.MaxValue;
            int last = 0;
            Console.WriteLine("");
            for (int i = 0; i < array.Length - 2; i++)
            {
                
                var claster = array.Skip(i).Take(3).ToList();
             
                int x1 = claster.First();
                int x2 = claster.Last();
                int x3 = x2 - x1;
                first = Math.Min(x3, first);
                last = Math.Max(x3, last);
                claster.ToList().ForEach(c => Console.Write("{0}: ", c));
                Console.WriteLine("= {0}", x3);
                result = new Tuple<int, int>(first, last);
            }
            return result;
        }
    }

    public class Program
    {

        private static void Main()
        {
            var source = GetSource();
            var _calculater = new Calculator(source);
            var result = _calculater.CalMethod();
            Console.WriteLine("");
            Console.WriteLine("Наименьшая  дисперсия {0}, Наибольшая дисперсия {1}", result.Item1, result.Item2);

            Console.ReadKey();
        }
        private static int[] GetSource()
        {
            var array = new int[6];
            Random r = new Random();
            Console.WriteLine("Массив чисел");
            Console.WriteLine(" ");
            for (int i = 0; i< array.Length; i++)
            {
                array[i] = r.Next(1, 101);
                //Console.Write(array[i] + " ");
            }
            return array;
        }
    }
}   
