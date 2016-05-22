using Xunit;
using SimpleTasksReader.BLL;
using System;

namespace SimpleTasksReader.Tests.Models
{
    public class DayTests
    {
        private const string DAY_NAME = "Monday 2016-05-01";

        [Fact]
        public void Test_Add_Action_To_Day()
        {
            Day day = new Day(DAY_NAME);
            CustomAction customAction = new CustomAction();
            day.AddAction(customAction);

            Assert.Equal<int>(1, day.CustomActions.Count);
        }

        [Fact]
        public void Test_Day_Has_Name_And_Date()
        {
            Day day = new Day(DAY_NAME);

            Assert.Equal("Monday", day.Name);
            Assert.Equal(new DateTime(2016, 5, 1), day.Date);
        }
    }
}
