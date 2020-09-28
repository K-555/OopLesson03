using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok",
                "London","Paris","Berlin","Canberra",
                "Hong Kong",
            };

            #region 問題3-2-1
            //var line = Console.ReadLine();
            //var find = names.FindIndex(s => line == s);
            //Console.WriteLine(find);
            #endregion

            #region 問題3-2-1(改)
            //Boolean bools = true;
            //do
            //{
            #region 別回答
            //Console.Write("都市名：");
            //var line = Console.ReadLine();
            //var find = names.FindIndex(s => line == s);
            //Console.WriteLine(find);
            //Console.WriteLine();
            //if (line == "")
            //{
            //    bools = false;
            //}
            #endregion
            //    Console.Write("都市名：");
            //    var line = Console.ReadLine();
            //    if (string.IsNullOrEmpty(line))
            //    {
            //        break;
            //    }
            //    var find = names.FindIndex(s => s == line);
            //    Console.WriteLine(find);

            //} while (true);
            #endregion

            #region 問題3-2-2
            //var count = names.Count(s => s.Contains('o'));
            //Console.WriteLine(count);
            #endregion

            #region 問題3-2-3
            //var list = new List<string>();
            //list = names.Where(s => s.Contains('o')).ToArray();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 問題3-2-4
            //var ws = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            //foreach (var item in ws)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



        }


    }
}
