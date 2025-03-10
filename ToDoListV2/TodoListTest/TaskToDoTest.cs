using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListV2;

namespace ToDoListV2Test
{
    [TestClass]

    public sealed class TaskToDoTest
    {
        [TestMethod]
        public void ToString_OverrideToString_returnsString()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);

            //Act
            string result = task.ToString();


            //Assert
            Assert.AreEqual("Completed: False\nPriority: High\nTask: Graduate from College\nDue Date: " + DateTime.Now + "\n", result);

        }

        [TestMethod]
        public void Equals_OverrideEquals_returnsTrue()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from College", DateTime.Now, Priority.Low, false);
            //Act
            bool result = task.Equals(task2);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetHashCode_OverrideGetHashCode_returnsTrue()
        {
            //Arrange
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);
            TaskToDo task2 = new("Graduate from College", DateTime.Now, Priority.Low, false);
            //Act
            task.GetHashCode();
            task2.GetHashCode();
            bool result = task.GetHashCode() == task2.GetHashCode();
            //Assert
            Assert.IsTrue(result);

        }

    }
}
