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
            TaskToDo lookup = new(name, DateTime.Now);
            tasks.TryGetValue(lookup, out TaskToDo? searchedTask);
            return searchedTask;

        }

        public Priority GetTaskPriority(TaskToDo task)
        {
            return task.LevelOfImportance;
        }

    }
}
