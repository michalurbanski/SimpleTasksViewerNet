namespace SimpleTasksReader.BLL.Models
{
    /// <summary>
    /// Week has name and can have up to 7 days. 
    /// </summary>
    public class Week
    {
        public string Name { get; set; }

        public Week(string name)
        {
            Name = name; 
        }
    }
}