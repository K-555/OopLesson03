using Section01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7-2-2
            //Countプロパティを呼び出して数を出力させる
            Console.WriteLine(abbrs.Count);

            //7-2-3
            //Removeプロパティを呼び出して出力させる
            if (abbrs.Remove("IOC"))
            {
                Console.WriteLine("削除成功");
            }
            else
            {
                Console.WriteLine("削除失敗");
            }

            //7-2-4
            //3文字の省略語だけ取り出す
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
            Console.WriteLine();
            foreach (var item in abbrs.Where(w => w.Key.Length == 3))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            


            // インデクサの利用例
            //var names = new[] { "WHO", "FIFA", "NPT", };
            //foreach (var name in names)
            //{
            //    var fullname = abbrs[name];
            //    if (fullname == null)
            //        Console.WriteLine("{0}は見つかりません", name);
            //    else
            //        Console.WriteLine("{0}={1}", name, fullname);
            //}
            //Console.WriteLine();

            //// ToAbbreviationメソッドの利用例
            //var japanese = "東南アジア諸国連合";
            //var abbreviation = abbrs.ToAbbreviation(japanese);
            //if (abbreviation == null)
            //    Console.WriteLine("{0} は見つかりません", japanese);
            //else
            //    Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            //Console.WriteLine();

            //// FindAllメソッドの利用例
            //foreach (var item in abbrs.FindAll("国際"))
            //{
            //    Console.WriteLine("{0}={1}", item.Key, item.Value);
            //}
            //Console.WriteLine();
        }

    }
}
