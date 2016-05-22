using SimpleTasksReader.BLL.Models;
using System;
using System.Linq;
using Xunit;

namespace SimpleTasksReader.Tests.Models
{
    public class WeekTests
    {
        [Fact]
        public void Test_Week_Has_Name()
        {
            Week week = new Week("Week 1");

            Assert.Equal("Week 1", week.Name);  
        }

        [Fact]
        public void Test_Week_Can_Have_Days()
        {
            Week week = new Week("Week 1");
            Day day = new Day("Monday 2016-05-01");

            week.AddDay(day);

            Assert.Equal(1, week.Days.Count);
        }

        [Fact]
        public void Test_Week_Can_Have_Up_To_Seven_Days()
        {
            int allowedDaysNumber = 7;
            Week week = BuildTestWeek(allowedDaysNumber);

            Assert.Equal(7, week.Days.Count);
        }

        [Fact]
        public void Test_Week_Cant_Have_More_Than_Seven_Days()
        {
            int notAllowedDaysNumber = 8;

            Assert.Throws(typeof(InvalidOperationException), () => 
            {
                Week week = BuildTestWeek(notAllowedDaysNumber);
            });
        }

        private Week BuildTestWeek(int daysNumber)
        {
            Week week = new Week("Week 1");
            var days = Enumerable.Range(0, daysNumber).Select(s => new Day("Monday 2016-05-01"));

            foreach (var day in days)
            {
                week.AddDay(day);
            }

            return week; 
        }
    }
}
