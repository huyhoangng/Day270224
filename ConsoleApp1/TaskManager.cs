using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        // Phương thức thêm công việc mới
        public void AddTask(string name)
        {
            Task newTask = new Task { Name = name };
            newTask.TaskStatusChanged += Task_TaskStatusChanged;
            tasks.Add(newTask);
        }

        // Phương thức hiển thị danh sách các công việc cùng trạng thái của chúng
        public void DisplayTasks()
        {
            Console.WriteLine("Task List:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name}: {(task.Completed ? "Completed" : "Not Completed")}");
            }
        }

        // Phương thức đánh dấu một công việc là đã hoàn thành hoặc chưa hoàn thành
        public void MarkTaskAsCompleted(string name, bool completed)
        {
            Task task = tasks.Find(t => t.Name == name);
            if (task != null)
            {
                task.Completed = completed;
            }
        }

        // Xử lý sự kiện thay đổi trạng thái của công việc
        private void Task_TaskStatusChanged(object sender, TaskStatusChangedEventArg e)
        {
            Console.WriteLine($"Task '{e.TaskName}' status changed to {(e.Completed ? "Completed" : "Not Completed")}");
        }
        public void DisplayCompletedTasks()
        {
            Console.WriteLine("Completed Task List:");
            foreach (var task in tasks)
            {
                if (task.Completed)
                {
                    Console.WriteLine($"{task.Name}");
                }
            }
        }
        public void AddCompletedTask(string name)
        {
            Task newTask = new Task { Name = name, Completed = true };
            newTask.TaskStatusChanged += Task_TaskStatusChanged;
            tasks.Add(newTask);
        }
    }
}
