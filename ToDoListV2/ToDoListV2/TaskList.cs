using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListV2
{
    public class TaskList() : IEnumerable<TaskToDo>
    {
        public IEnumerator<TaskToDo> GetEnumerator() => taskDictionary.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public int Count => taskDictionary.Count;
        public bool IsReadOnly => false;
    
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

        public void EditTask(TaskToDo task, string newName)
        {
            if (taskDictionary.ContainsKey(task.Name))
            {
                tasks.Remove(task.Name);
                taskDictionary.Remove(task.Name);
                task.Name = newName;
                tasks.Add(newName);
                taskDictionary.Add(newName, task);
            }
        }

    }
}
