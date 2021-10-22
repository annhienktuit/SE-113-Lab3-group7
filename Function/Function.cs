using System;

namespace FunctionX
{
    public class CheckDayClass
    {
        public int DayMonthCheck(int month, int year)
        {
            if (month >= 1 && month <= 12 && year > 0)
            {
                if ((month % 2 == 1 && month <= 7) || (month % 2 == 0 && month > 7))
                {
                    return 31; 
                }
                if (month == 2)
                {
                    if (IsLeapYear(year)) return 29;
                    else return 28;
                }
                return 30;
            }
            return 0;
        }

        public static bool IsLeapYear(int year)
            {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
        public bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12 || day < 1)
                return false;
            if (day <= DayMonthCheck(month, year))
                return true;
            return false;
        }

    }
}
