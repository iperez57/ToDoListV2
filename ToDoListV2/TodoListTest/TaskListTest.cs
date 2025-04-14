using System.Collections.Generic;
using ToDoListV2;

namespace TodoListTest
{
    [TestClass]
    public sealed class TaskListTest
    {
        [TestMethod]
        public void AddTask_toHashSet_true()
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
        public void AddTask_AddDuplicateTaskToHashSet_false()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from College", DateTime.Now, Priority.Low, false);
            //Act
            taskList.AddTask(task);
            bool result = taskList.AddTask(task2);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddTask_AddMultipleTaskstoHashSet_true()
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
        public void RemoveTask_FromHashset_false()
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
        public void RemoveTask_RemoveMultipleTasksFromHashSet_false()
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
        public void MarkTasksAsComplete_ChangesTaskFromFalsetoTrue_true()
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
        public void CheckCompleteTask_SeeIfTaskIsCompleted_true()
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
        [TestMethod]
        public void CheckCompleteTask_SeeIfTaskIsNotCompleted_false()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            taskList.AddTask(task);
            //Act

            //Assert
            Assert.IsFalse(taskList.CheckCompleteTask(task));
        }
        [TestMethod]
        public void CheckCompleteTask_CheckCompletionStatusofMultipleTasks_false_true()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.High, false);
            taskList.AddTask(task);
            //Act
            taskList.MarkStatusAsComplete(task);

            //Assert
            Assert.IsTrue(taskList.CheckCompleteTask(task));
            Assert.IsFalse(taskList.CheckCompleteTask(task2));
        }
        [TestMethod]
        public void GetTaskByName_SearchForTaskInTaskList_ReturnsSearchedTask()
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
        [TestMethod]
        public void GetTaskByName_SearchForTaskThatDoesNotExist_ReturnsNull()
        {
            //Arrange 
            TaskList taskList = new();
            
            //Assert
            Assert.IsNull(taskList.GetTaskByName("Graduate from College"));

        }
        [TestMethod]
        public void GetTaskByPriority_GrabsTaskByName_ReturnsPriorityLevelofTask()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from MSSA", DateTime.Now, Priority.Low, false);
            //Act
            taskList.AddTask(task);
            taskList.AddTask(task2);

            //Assert
            Assert.AreEqual(Priority.High, taskList.GetTaskPriority(task));
            Assert.AreEqual(Priority.Low, taskList.GetTaskPriority(task2));
        }
    }

}
