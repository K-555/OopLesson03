using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-2-1
            //var datas = new int[] { 1, 2, 3, 4, 5, 6 };
            var ym = new YearMonth[]
            {
                new YearMonth(1980,7),
                new YearMonth(1990,3),
                new YearMonth(2000,1),
                new YearMonth(2005,5),
                new YearMonth(2020,2),

            };

            //4-2-2(呼び出し)
            Console.WriteLine("--- 4-2-2 ---");
            Exercise2_2(ym);
            Console.WriteLine("-------------");
            Console.WriteLine();

            //4-2-3(呼び出し)
            Console.WriteLine("--- 4-2-3 ---");
            Console.WriteLine(FindFirst21C(ym)); 
            Console.WriteLine("-------------");
            Console.WriteLine();

            //4-2-4(呼び出し)
            Console.WriteLine("--- 4-2-4 ---");
            Exercise2_4(ym);
            Console.WriteLine("-------------");
            Console.WriteLine();

            //4-2-5(呼び出し)
            Console.WriteLine("--- 4-2-4 ---");
            Exercise2_5(ym);
            Console.WriteLine("-------------");

        }

        //4-2-2
        private static void Exercise2_2(YearMonth[] ym)
        {
            foreach (var YM in ym)
            {
                Console.WriteLine(YM);
            }
            
        }

        //4-2-3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var YM in yms)
            {
                if (YM.Is21Century) return YM;  //21世紀ならreturnして終了
            }
            //21世紀が存在しなければnullを返却
            return null;
        }

        //4-2-4
        private static void Exercise2_4(YearMonth[] ym)
        {
            var yearmonth = FindFirst21C(ym);
#if true
            var y = yearmonth == null ? "21世紀のデータはありません。" : yearmonth.ToString();
            Console.WriteLine(y);
#else
            if (yearmonth == null)
                Console.WriteLine("21世紀のデータはありません。");
            else  
                Console.WriteLine(yearmonth);
#endif
        }

        private static void Exercise2_5(YearMonth[] ym)
        {
            var array = ym.Select(y => y.AddOneMonth()).ToArray();
            foreach (var YM in array)
            {
                Console.WriteLine(YM);
            }
        }

    }



}
