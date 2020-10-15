using Section01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary & ToDictionary
            //var employeeDict = new Dictionary<int,Employee>()
            //{
            //    {100,new Employee(100,"清水遼久") },
            //    {112,new Employee(112,"芹沢洋和") },
            //    {125,new Employee(125,"岩瀬奈央子")},
            //};

            ////Console.WriteLine($"{employeeDict.Sum(emp => emp.Value.Id)}");
            ////employeeDict.Where(emp => emp.Value.Id % 2 == 0).ToList().ForEach(c=> Console.WriteLine(c.Value.Name));
            //var num = employeeDict.Where(emp => emp.Value.Id % 2 == 0).ToList();
            //foreach (var item in num)
            //{
            //    Console.WriteLine($"{item.Value.Name}");
            //}

            //リスト
            //var employee = new List<Employee>()
            //{
            //    new Employee(100,"清水遼久"),
            //    new Employee(112,"芹沢洋和"),
            //    new Employee(125,"岩瀬奈央子"),
            //    new Employee(126,"庄野遥花"),
            //    new Employee(127,"安倍庄司"),
            //    new Employee(128,"小池由美子"),
            //    new Employee(129,"麻生巧"),
            //    new Employee(130,"明日香未来"),
            //};

            //var employeeDict = employee.ToDictionary(emp => emp.Id);

            //foreach (KeyValuePair<int, Employee> item in employeeDict.Where(emp => emp.Value.Id % 2 == 0))
            //{
            //    Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //}

            #endregion

            #region Dictionary<MonthDay,string>
            //var lines = File.ReadAllLines("sample.txt");
            //var we = new WordsExtractor(lines);
            //foreach (var word in we.Extract())
            //{
            //    Console.WriteLine(word);
            //}

            //var dict = new Dictionary<MonthDay, string>
            //{
            //    {new MonthDay(3,5), "珊瑚の日"},
            //    {new MonthDay(8,4),"箸の日" },
            //    {new MonthDay(10,3),"登山の日" },
            //};

            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);
            #endregion

            DuplicateKeySample();
        }

        static public void DuplicateKeySample()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
               { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
            };

            // ディクショナリに追加
            var key = "EC";
            var value = "電子商取引";
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new List<string> { value };
            }

            // ディクショナリの内容を列挙
            foreach (var item in dict)
            {
                foreach (var term in item.Value)
                {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }
        }
    }
}
