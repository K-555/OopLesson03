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
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 17, 14, 20, 12, 28, 19, 30, 24 };

            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            numbers.Select(n => n.ToString("0000")).ToList().ForEach(s => Console.Write(s + " "));  //ToArray()はForEach()使えない
            Console.WriteLine();
            var sortedNumbers = numbers.OrderBy(n => n).Distinct();
            foreach (var nums in sortedNumbers)
            {
                Console.Write(nums + " ");
            }


            //文字列の例
            Console.WriteLine("\n\n--------------------------");
            var words = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook", };

            var lower = words.Select(s => s.ToLower()).ToArray();

            //オブジェクトの例
            Console.WriteLine("\n\n--------------------------");
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(s => s.Title);
            foreach (var title in titles)
            {
                Console.Write(title + " ");
            }

            //ページ数の多い順に並び替え（または金額の高い順）
            Console.WriteLine();
            var OrderPages = books.OrderByDescending(s => s.Pages);
            foreach (var OrderPage in OrderPages)
            {
                Console.Write(OrderPage.Pages + " ");
            }
            Console.WriteLine();
            var OrderPrice = books.OrderByDescending(s => s.Price);
            foreach (var Orderprice in OrderPrice)
            {
                Console.Write(Orderprice.Price + " ");
            }
        }
    }
}
