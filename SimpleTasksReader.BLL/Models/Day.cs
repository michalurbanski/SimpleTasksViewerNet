using System;
using System.Collections.Generic;
using System.Globalization;

namespace SimpleTasksReader.BLL.Models
{
    /// <summary>
    /// Represents day. Day has name, date and list of actions.
    /// </summary>
    public class Day
    {
        private string _dayEntry;

        public List<CustomAction> CustomActions { get; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        private Day()
        {
            CustomActions = new List<CustomAction>(); 
        }

        public Day(string dayEntry) : this()
        {
            _dayEntry = dayEntry;

            ParseMetadata(_dayEntry);
        }

        public void AddAction(CustomAction customAction)
        {
            CustomActions.Add(customAction);
        }

        private void ParseMetadata(string entry)
        {
            var splitted = entry.Split();

            Name = splitted[0];
            Date = DateTime.Parse(splitted[1], CultureInfo.InvariantCulture);
        }
    }
}