using System;
using System.Collections.Generic;

namespace SimpleTasksReader.BLL
{
    public class Day
    {
        public List<CustomAction> CustomActions { get; }

        public Day()
        {
            CustomActions = new List<CustomAction>(); 
        }

        public void AddAction(CustomAction customAction)
        {
            CustomActions.Add(customAction);
        }
    }
}