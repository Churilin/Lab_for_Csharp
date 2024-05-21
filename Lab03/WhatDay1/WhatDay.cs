using System;

namespace WhatDay1 
{ 
    enum MonthName
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

    class WhatDay
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день года от 1 до 365:");
            int dayNum = int.Parse(Console.ReadLine());
            int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }

            }

            //if (dayNum <= 31)
            //{ // january
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 28)
            //{ // february
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 28;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // march
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // april
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // may
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}


            //if (dayNum <= 30)
            //{ // june
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // july
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // august
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // september
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // october
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // november
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // december
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //End:
            //    string monthName;
            //switch (monthNum)
            //{
            //    case 0:
            //        monthName = "Январь"; break;
            //    case 1:
            //        monthName = "Февраль"; break;
            //    case 2:
            //        monthName = "Март"; break;
            //    case 3:
            //        monthName = "Апрель"; break;
            //    case 4:
            //        monthName = "Май"; break;
            //    case 5:
            //        monthName = "Июнь"; break;
            //    case 6:
            //        monthName = "Июль"; break;
            //    case 7:
            //        monthName = "Август"; break;
            //    case 8:
            //        monthName = "Сентябрь"; break;
            //    case 9:
            //        monthName = "Октябрь"; break;
            //    case 10:
            //        monthName = "Ноябрь"; break;
            //    case 11:
            //        monthName = "Декабрь"; break;
            //    default:
            //        monthName = " - число месяца который не наступит никогда:)"; break;
            //}
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
                    {
                        Console.WriteLine("{0},{1}", dayNum, monthName);
                    }
        }
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
