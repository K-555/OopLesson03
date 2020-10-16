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
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1_1(text);  //問題7-1-1
        }

        #region 問題7-1-1
        //static void Exercise1_1(string text)
        //{
        //    var dict = new Dictionary<char, int>();
        //    //foreachで一文字ずつ取り出す
        //    //半角アルファベットが調べる
        //    foreach (var ch in text)
        //    {
        //        //大文字に変換
        //        char chars = char.ToUpper(ch);
        //        if ('A' <= chars && chars <= 'Z')
        //        {
        //            //Keyに存在するか
        //            if (dict.ContainsKey(chars))
        //            {
        //                //登録済み  
        //                dict[chars]++;
        //            }
        //            else
        //            {
        //                //未登録
        //                dict[chars] = 1;
        //            }
        //        }

        //    }
        //    foreach (var item in dict.OrderBy(o => o.Key))
        //    {
        //        Console.WriteLine($"{item.Key}：{item.Value}");
        //    }
        //}
        #endregion
        #region 問題7-1-2
        static void Exercise1_1(string text)
        {
            var dict = new SortedDictionary<char, int>();
            //foreachで一文字ずつ取り出す
            //半角アルファベットが調べる
            foreach (var ch in text)
            {
                //大文字に変換
                char chars = char.ToUpper(ch);
                if ('A' <= chars && chars <= 'Z')
                {
                    //Keyに存在するか
                    if (dict.ContainsKey(chars))
                    {
                        //登録済み  
                        dict[chars]++;
                    }
                    else
                    {
                        //未登録
                        dict[chars] = 1;
                    }
                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}：{item.Value}");
            }
        }
        #endregion
    }
}
