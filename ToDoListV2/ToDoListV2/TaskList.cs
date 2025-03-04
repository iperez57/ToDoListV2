using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListV2
{
    public class TaskList()
    {
        private readonly HashSet<TaskToDo> tasks = [];

        public bool AddTask(TaskToDo task) => tasks.Add(task);

        public bool RemoveTask(TaskToDo task) => tasks.Remove(task);

        public bool ContainsTask(TaskToDo task) => tasks.Contains(task);

        public bool CheckCompleteTask(TaskToDo task)
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

        public bool MarkStatusAsComplete(TaskToDo task)
        {
            //Sometimes it might already be complete? - later
            task.IsComplete = true;
            return true;
        }

        public TaskToDo? GetTaskByName(string name)
        {
            //Task might not exist - later
            return tasks.FirstOrDefault(task => task.Name == name);
        }

        public Priority GetTaskByPriority(TaskToDo task)
        {
            return task.LevelOfImportance;
        }
    }
}
