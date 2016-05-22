using Xunit;
using SimpleTasksReader.BLL;
using System;

namespace SimpleTasksReader.Tests.Models
{
    public class DayTests
    {
        [Fact]
        public void Test_Add_Action_To_Day()
        {
            Day day = new Day("Monday 2016-05-01");
            CustomAction customAction = new CustomAction();
            day.AddAction(customAction);

            Assert.Equal<int>(1, day.CustomActions.Count);
        }

        [Fact]
        public void Test_Day_Has_Name_And_Date()
        {
            string dayEntry = "Monday 2016-05-01";
            Day day = new Day(dayEntry);

            Assert.Equal("Monday", day.Name);
            Assert.Equal(new DateTime(2016, 5, 1), day.Date);
        }
    }
}
