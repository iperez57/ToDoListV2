﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListV2
{
    public class TaskList()
    {
        private readonly HashSet<string> tasks = [];

        private readonly Dictionary<string, TaskToDo> taskDictionary = new();

        public Dictionary<string, TaskToDo> publicTaskDictionary => taskDictionary;

        public bool AddTask(TaskToDo task)
        {

            if (tasks.Add(task.Name))
            {
                taskDictionary.Add(task.Name, task);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool RemoveTask(TaskToDo task) {
            tasks.Remove(task.Name);
            taskDictionary.Remove(task.Name);
            return true;
        }

        public bool ContainsTask(TaskToDo task) => taskDictionary.ContainsKey(task.Name);
        public bool MarkStatusAsComplete(TaskToDo task)
        {
            //Sometimes it might already be complete? - later
            task.IsComplete = true;
            return true;
        }
        public bool CheckCompleteTask(TaskToDo task)
        {
            return task.IsComplete;
        }

        public TaskToDo? GetTaskByName(string name)
        {
            taskDictionary.TryGetValue(name, out TaskToDo? searchedTask);
            return searchedTask;

        }

        public Priority GetTaskPriority(TaskToDo task)
        {
            return task.LevelOfImportance;
        }

    }
}
