using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListV2
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class TaskToDo(string name, DateTime creationDate, Priority priority = Priority.Low, bool isCompleted = false)
    {
        public string Name { get; set; } = name;
        public DateTime Date { get; } = creationDate;
        public Priority LevelOfImportance { get; } = priority;
        public bool IsComplete { get; set; } = isCompleted;
        public override string ToString()
        {
            return $"Completed: {IsComplete}\nPriority: {LevelOfImportance}\nTask: {Name}\nCreation Date: {Date}\n";
        }

        public override bool Equals(object? obj)
        {
            return obj is TaskToDo other && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

}
