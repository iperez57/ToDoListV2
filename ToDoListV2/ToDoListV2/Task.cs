namespace ToDoListV2
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class Task(string name, DateTime dueDate, Priority priority, bool isCompleted = false)
    {
        public string Name { get; } = name;
        public Priority LevelOfImportance { get; } = priority;
        public DateTime Date { get; } = dueDate;
        public bool IsComplete { get; set; } = isCompleted;
        public override string ToString()
        {
            return $"Completed: {IsComplete}\nPriority: {LevelOfImportance}\nTask: {Name}\nDue Date: {Date}\n";
        }


    }

}
