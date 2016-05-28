﻿using Xunit;

namespace SimpleTasksReader.Tests.Operations
{
    public class FileReaderOperations
    {
        [Fact]
        public void Read_Sample_Data_File()
        {
            var sampleData = SampleDataRetriever.GetSampleData();

            Assert.NotNull(sampleData);
            Assert.True(sampleData.Count > 0);
        }
    }
}
