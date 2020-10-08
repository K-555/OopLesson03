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
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4};
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Where(w => w > 0).Min()}");
            Console.WriteLine($"最大値：{numbers.Max()}");
            Console.WriteLine();

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(x => x > 0).Take(5);
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }

            var books = Books.GetBooks();
            Console.WriteLine();
            Console.WriteLine($"本の平均価格：{books.Average(a => a.Price)}");
            Console.WriteLine($"本の合計価格：{books.Sum(s => s.Price)}");
            Console.WriteLine($"本のページが最大：{books.Max(m => m.Pages)}");
            Console.WriteLine($"高価な本：{books.Max(a => a.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数：{books.Count(s=>s.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？（Anyメソッド）
            Console.WriteLine();
            Console.Write("600ページを超える書籍は");
            Console.WriteLine(books.Any(n => n.Pages > 600) ? "ある" : "ない");

            //すべてが200ページの書籍か？（Allメソッド）
            Console.WriteLine();
            Console.Write("200ページ以上の書籍は");
            Console.WriteLine(books.All(a => a.Pages > 200) ? "ある" : "ない");

            //400ページを超える本は何冊目か？（FirstOrDefaultメソッド）
            Console.WriteLine();
            //var book = books.FirstOrDefault(f => f.Pages > 400);
            //int i;
            //for ( i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Title.Contains(book.Title))  {break;}
            //}
            //Console.WriteLine($"400ページ超える本は{i + 1}冊目にあります。");

            var count = books.FindIndex(f => f.Pages > 1000);
            Console.WriteLine($"400ページ超える本は{count + 1}冊目にあります。");

            //本の値段が400円以上のものを3冊表示
            Console.WriteLine();
            var selected = books.Where(w => w.Price >= 400).Take(3);
            foreach (var select in selected)
            {
                Console.Write(select.Title + " ");
            }
        }
    }
}
