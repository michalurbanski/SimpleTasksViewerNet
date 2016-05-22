using Xunit; 
using SimpleTasksReader.BLL;

namespace SimpleTasksReader.Tests.Models
{
    public class DayTests
    {
        [Fact]
        public void Test_Add_Action_To_Day()
        {
            Day day = new Day();
            CustomAction customAction = new CustomAction();
            day.AddAction(customAction);

            Assert.Equal<int>(1, day.CustomActions.Count);
        }
    }
}
