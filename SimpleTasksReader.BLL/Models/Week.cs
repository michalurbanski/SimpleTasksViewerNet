using System;
using System.Collections.Generic;

namespace SimpleTasksReader.BLL.Models
{
    /// <summary>
    /// Week has name and can have up to 7 days. 
    /// </summary>
    public class Week
    {
        public string Name { get; set; }
        public List<Day> Days { get; set; }

        public Week(string name)
        {
            Name = name;
            Days = new List<Day>(7); 
        }

        public void AddDay(Day day)
        {
            if(Days.Count == 7)
            {
                throw new InvalidOperationException("Week can have only up to 7 days");
            }

            Days.Add(day);
        }
    }
}