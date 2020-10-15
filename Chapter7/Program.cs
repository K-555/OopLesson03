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
            Console.WriteLine("************************");
            Console.WriteLine("*　辞書登録プログラム　*");
            Console.WriteLine("************************");

            Registration();

        }

        static public void Registration()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>();
            do
            {
                //1．登録　2．内容を表示
                Console.WriteLine("1．登録　2．内容を表示　3．終了" );
                Console.Write(">");
                int ot = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ot)
                {
                    case 1:
                        Console.Write("KEYを入力：");
                        var key = Console.ReadLine();
                        Console.Write("VALUEを入力：");
                        var value = Console.ReadLine();

                        if (dict.ContainsKey(key))
                        {
                            dict[key].Add(value);
                        }
                        else
                        {
                            dict[key] = new List<string> { value };
                        }
                        Console.WriteLine("登録されました！");
                        Console.WriteLine();
                        break;
                    case 2:
                        //ディクショナリの内容を列挙 2．内容を表示
                        foreach (var item in dict)
                        {
                            foreach (var term in item.Value)
                            {
                                Console.WriteLine("{0} : {1}", item.Key, term);
                            }
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("数値が違います。");
                        break;
                }

            } while (true);
        }        
    }
}
