using System;
using NUnit.Framework;
using FunctionX;
namespace Test_day_in_month
{
    [TestFixture]
    public class TestCase
    {
        //Based on datepicker.xlsx
        [TestCase(0, 2000, 0)]
        [TestCase(13, 2000, 0)]
        [TestCase(2, 2000, 29)]
        [TestCase(2, 2009, 28)]
        [TestCase(2, 1900, 28)]
        [TestCase(2, 1904, 29)]
        [TestCase(2, 1903, 28)]
        [TestCase(1, 2009, 31)]
        [TestCase(3, 2009, 31)]
        [TestCase(4, 2009, 30)]
        [TestCase(5, 2009, 31)]
        [TestCase(6, 2009, 30)]
        [TestCase(7, 2009, 31)]
        [TestCase(8, 2009, 31)]
        [TestCase(9, 2009, 30)]
        [TestCase(10, 2009, 31)]
        [TestCase(11, 2009, 30)]
        [TestCase(12, 2009, 31)]

        public void DayMonthTest(int month, int year, int result)
        {
            var check = new CheckDayClass();
            Assert.AreEqual(result, check.DayMonthCheck(month, year));
        }
    }
    
}
