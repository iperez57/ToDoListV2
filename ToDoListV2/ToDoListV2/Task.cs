﻿using System;
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

    public class TaskToDo(string name, DateTime dueDate, Priority priority, bool isCompleted = false)
    {
        public string Name { get; } = name;
        public DateTime Date { get; } = dueDate;
        public Priority LevelOfImportance { get; } = priority;
        public bool IsComplete { get; set; } = isCompleted;
        public override string ToString()
        {
            return $"Completed: {IsComplete}\nPriority: {LevelOfImportance}\nTask: {Name}\nDue Date: {Date}\n";
        }


    }

}
