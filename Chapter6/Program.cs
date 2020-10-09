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
            //Console.WriteLine("問題6-1-1");
            //Console.WriteLine(numbers.Max());
            ////問題6-1-2
            //Console.WriteLine("問題6-1-2");
            //int pos = numbers.Length - 2;
            //numbers.Skip(pos).ToList().ForEach(f => Console.Write(f + " "));
            ////問題6-1-3
            //Console.WriteLine();
            //Console.WriteLine("問題6-1-3");
            //numbers.Select(s => s.ToString()).ToList().ForEach(f => Console.Write(f + " "));
            ////問題6-1-4
            //Console.WriteLine();
            //Console.WriteLine("問題6-1-4");
            //numbers.OrderBy(o => o).Take(3).ToList().ForEach(f => Console.Write(f + " "));
            ////問題6-1-5
            //Console.WriteLine();
            //Console.WriteLine("問題6-1-5");
            //Console.WriteLine(numbers.Distinct().Count(c => c > 10));
            #endregion

            #region 問題6-2
            //問題6-2-1
            var books = Books.GetBooks();
            Console.WriteLine("問題6-2-1");
            var book = books.Where(f => f.Title == "ワンダフル・C#ライフ");
            //var book = books.FirstOrDefault(f => f.Title == "ワンダフル・C#ライフ");
            
            foreach (var item in book)
            {
                Console.WriteLine($"価格:{item.Price} ページ数:{item.Pages}");
            }

            //問題6-2-2
            Console.WriteLine("問題6-2-2");
            var selected = books.Count(c => c.Title.Contains("C#"));
            Console.WriteLine($"{selected}冊");

            //問題6-2-3
            Console.WriteLine("問題6-2-3");
            var sa = books.Where(c => c.Title.Contains("C#")).Average(a=>a.Pages);
            Console.WriteLine(sa);

            //問題6-2-4
            Console.WriteLine("問題6-2-4");
            var bookp = books.Where(w => w.Price >= 4000);
            foreach (var bookps in bookp)
            {
                Console.WriteLine(bookps.Title);
            }
            
            //問題6-2-5
            Console.WriteLine("問題6-2-5");
            var pt = books.Where(w => w.Price < 4000).Max(m => m.Pages);
            Console.WriteLine(pt);

            //問題6-2-6
            Console.WriteLine("問題6-2-6");
            var bookpt = books.Where(w => w.Pages >= 400).OrderByDescending(o => o.Price);
            foreach (var bookpts in bookpt)
            {
                Console.WriteLine($"{bookpts.Title}　{bookpts.Price}");
            }

            //問題6-2-7
            Console.WriteLine("問題6-2-7");
            var bookppt = books.Where(w => w.Title.Contains("C#") && w.Pages <= 500);
            foreach (var bookppts in bookppt)
            {
                Console.WriteLine(bookppts.Title);
            }
            #endregion
        }
    }
}
