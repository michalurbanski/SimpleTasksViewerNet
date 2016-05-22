﻿using SimpleTasksReader.BLL.Models;
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
    }
}