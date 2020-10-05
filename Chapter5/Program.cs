using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5-1
            //Console.Write("文字列1：");
            //string str1 = Console.ReadLine();
            //Console.Write("文字列2：");
            //string str2 = Console.ReadLine();
            //if (string.Compare(str1, str2, ignoreCase: true) == 0)
            //{
            //    Console.WriteLine("文字列は等しい");
            //}
            //else
            //{
            //    Console.WriteLine("文字列は等しくない");
            //}
            #endregion

            #region 5-2
            //int num ;   //変換後の数値格納用
            //Console.Write("数値：");
            //var number = Console.ReadLine();
            //if (int.TryParse(number, out num))
            //{
            //    Console.WriteLine(num.ToString("#,#"));
            //}
            //else
            //{
            //    Console.WriteLine("数値ではありません");
            //}
            #endregion

            #region 5-3
            //var text = "Jackdaws Love my big sphinx of quartz";

            //5-3-1
            //var count = text.Count(c => c == ' ');
            //Console.WriteLine($"空白は{count}文字ある");

            //5-3-2
            //var target = text.Replace("big", "small");
            //Console.WriteLine(target);

            //5-3-3
            //var count = text.Split(' ').Count();
            ////var count = text.Split(' ').Length;
            //Console.WriteLine($"単語は{count}つある");

            //5-3-4
            //text.Split(' ')
            //    .Where(s => s.Length <= 4)
            //                 .ToList()
            //                 .ForEach(Console.WriteLine);

            //5-3-5
            //var array = text.Split(' ').ToArray();
            //if (array.Length > 0)
            //{
            //    var sb = new StringBuilder(array[0]);
            //    foreach (var word in array.Skip(1))
            //    {
            //        sb.Append(' ');
            //        sb.Append(word);
            //    }
            //    Console.WriteLine(sb);
            //}

            #endregion

            #region 5-4
            var line = "Novelist=谷崎潤一郎;BestWork=春琴沙;Born=1886";

            foreach (var lines in line.Split(';'))
            {
                var word = lines.Split('=');
                Console.WriteLine("{0}:{1}",ToJapanese(word[0]),word[1]);
            }

            #endregion
        }
        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "　　　";
            }
        }
    }
}
