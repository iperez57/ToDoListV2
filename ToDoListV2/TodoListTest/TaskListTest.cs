using ToDoListV2;

namespace TodoListTest
{
    [TestClass]
    public sealed class TaskListTest
    {
        [TestMethod]
        public void AddATask()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);

            //Act
            taskList.AddTask(task);

            //Assert
            Assert.IsTrue(taskList.ContainsTask(task));
        }
    }
}
