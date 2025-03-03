using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListV2
{
    public class TaskList()
    {
        private readonly HashSet<Task> tasks = [];

        public bool AddTask(Task task) => tasks.Add(task);

        public bool RemoveTask(Task task) => tasks.Remove(task);

        public bool CheckCompleteTask(Task task)
        {
            return task.IsComplete;
            //if (task.IsComplete)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public bool MarkStatusAsComplete(Task task)
        {
            //Sometimes it might already be complete? - later
            task.IsComplete = true;
            return true;
        }

        public Task? GetTaskByName(string name)
        {
            return tasks.FirstOrDefault(task => task.Name == name);
        }

        public Priority GetTaskByPriority(Task task)
        {
            return task.LevelOfImportance;
        }
    }
}
