using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
           
            
            // Thêm các công việc mới
            taskManager.AddTask("Task 1");
            taskManager.AddTask("Task 2");
            taskManager.AddTask("Task 3");
            taskManager.AddCompletedTask("Task 4");
            taskManager.AddCompletedTask("Task 5");

            // Hiển thị danh sách công việc
            taskManager.DisplayTasks();

            // Đánh dấu một công việc là đã hoàn thành
            taskManager.MarkTaskAsCompleted("Task 2", true);

            // Hiển thị lại danh sách công việc sau khi thay đổi trạng thái
            taskManager.DisplayTasks();
            taskManager.DisplayCompletedTasks();


            Console.ReadLine();
        }
    }
}
