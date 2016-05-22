using SimpleTasksReader.BLL.Models;
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

            Assert.Equal<int>(1, week.Days.Count);
        }
    }
}
