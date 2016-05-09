using NUnit.Framework;
using SimpleTasksReader.BLL;

namespace SimpleTasksReader.Tests.Models
{
    [TestFixture]
    public class DayTests
    {
        [Test]
        public void Test_Add_Action_To_Day()
        {
            Day day = new Day();
            CustomAction customAction = new CustomAction(); 
            day.AddAction(customAction);

            Assert.AreEqual(1, day.CustomActions.Count);
        }
    }
}
