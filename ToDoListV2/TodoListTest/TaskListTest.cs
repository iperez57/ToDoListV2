using System.Collections.Generic;
using ToDoListV2;

namespace TodoListTest
{
    [TestClass]
    public sealed class TaskListTest
    {
        [TestMethod]
        public void AddATasktoHashSet()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);

            //Act
            taskList.AddTask(task);
            List<TaskToDo> list = new List<TaskToDo>();

            //Assert
            Assert.IsTrue(taskList.ContainsTask(task));
        }
        [TestMethod]
        public void AddMultipleTasktoHashSet()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.High, false);
            //Act
            taskList.AddTask(task);
            taskList.AddTask(task2);

            //Assert
            Assert.IsTrue(taskList.ContainsTask(task));
            Assert.IsTrue(taskList.ContainsTask(task2));
        }
        [TestMethod]
        public void RemoveATaskFromHashset()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            taskList.AddTask(task);
            //Act
            taskList.RemoveTask(task);

            //Assert
            Assert.IsFalse(taskList.ContainsTask(task));
        }
        [TestMethod]
        public void RemoveMultipleTaskFromHashSet()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.High, false);
            //Act
            taskList.AddTask(task);
            taskList.AddTask(task2);
            taskList.RemoveTask(task);
            taskList.RemoveTask(task2);

            //Assert
            Assert.IsFalse(taskList.ContainsTask(task));
            Assert.IsFalse(taskList.ContainsTask(task2));
        }
        [TestMethod]
        public void MarkTasksAsComplete()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            taskList.AddTask(task);
            //Act
            taskList.MarkStatusAsComplete(task);

            //Assert
            Assert.IsTrue(task.IsComplete);
        }
        [TestMethod]
        public void CheckTaskIsComplete()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            taskList.AddTask(task);
            //Act
            taskList.MarkStatusAsComplete(task);

            //Assert
            Assert.IsTrue(taskList.CheckCompleteTask(task));
        }
        //Make another test to check if the task is not complete
        //Make another test to check if the task is not complete and complete (multiple)
        [TestMethod]
        public void FindTaskByName()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.High, false);
            //Act
            taskList.AddTask(task);
            taskList.AddTask(task2);

            //Assert
            Assert.AreEqual(task, taskList.GetTaskByName("Graduate from College"));
            Assert.AreEqual(task2, taskList.GetTaskByName("Graduate from MSSA"));
        }
        //Make another test to find a task that does not exist
        [TestMethod]
        public void FindTaskByPriority()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.Low, false);
            //Act
            taskList.AddTask(task);
            taskList.AddTask(task2);

            //Assert
            Assert.AreEqual(Priority.High, taskList.GetTaskByPriority(task));
            Assert.AreEqual(Priority.Low, taskList.GetTaskByPriority(task2));
        }
    }

}
