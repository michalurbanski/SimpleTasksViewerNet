using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SimpleTasksReader.Tests
{
    static class SampleDataRetriever
    {
        public static List<string> GetSampleData()
        {
            List<string> results = new List<string>();

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = "SimpleTasksReader.Tests.SampleData.txt";

            string line; 

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                while((line = reader.ReadLine()) != null)
                {
                    results.Add(line);
                }
            }

            return results; 
        }
    }
}
