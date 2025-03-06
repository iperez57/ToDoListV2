using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListV2;

namespace ToDoListV2Test
{
    [TestClass]

    public sealed class TaskTest
    {
        [TestMethod]
        public void ToString_OverrideToString_returnsMessage()
        {
            //Arrange 
            TaskList taskList = new();
            TaskToDo task = new("Graduate from College", DateTime.Now, Priority.High, false);

            //Act
            string result = task.ToString();


            //Assert
            Assert.AreEqual("Completed: False\nPriority: High\nTask: Graduate from College\nDue Date: " + DateTime.Now + "\n", result);

        }

    }
}
