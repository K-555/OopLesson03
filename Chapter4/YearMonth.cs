﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        //4-1-1
        //プロパティ
        public int Year { get; private set; }
        public int Month { get; private set; }

        //コンストラクタ
        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }

        //4-1-2 Is21Centuryプロパティを追加
        public bool Is21Century {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }        
        
        }

        //4-1-3 AddOneMonth()メソッドを追加
        public YearMonth AddOneMonth()
        {
            if (this.Month == 12)
            {
                this.Year++;
                this.Month = 1;
            }
            else
            {
                this.Month++;
            }
            return new YearMonth(this.Year, this.Month);
        }

        #region 4-1-3 別回答
        //public YearMonth AddOneMonth2()
        //{
        //    if (this.Month == 12)
        //    {
        //        return new YearMonth(this.Year + 1, 1);
        //    }
        //    else
        //    {
        //        return new YearMonth(this.Year, this.Month + 1);
        //    }
        //}
        #endregion



        //4-1-4 ToString()メソッドのオーバーライド
        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }

    }
}
