using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            #region 問題6-1
            //問題6-1-1
            Console.WriteLine("問題6-1-1");
            Console.WriteLine(numbers.Max());
            //問題6-1-2
            Console.WriteLine("問題6-1-2");
            int pos = numbers.Length - 2;
            numbers.Skip(pos).ToList().ForEach(f => Console.Write(f + " "));
            //問題6-1-3
            Console.WriteLine();
            Console.WriteLine("問題6-1-3");
            numbers.Select(s => s.ToString()).ToList().ForEach(f => Console.Write(f + " "));
            //問題6-1-4
            Console.WriteLine();
            Console.WriteLine("問題6-1-4");
            numbers.OrderBy(o => o).Take(3).ToList().ForEach(f => Console.Write(f + " "));
            //問題6-1-5
            Console.WriteLine();
            Console.WriteLine("問題6-1-5");
            Console.WriteLine(numbers.Distinct().Count(c => c > 10));
            #endregion
        }
    }
}
