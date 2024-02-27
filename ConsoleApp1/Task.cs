using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void TaskStatusChangedEventHandler(object sender, TaskStatusChangedEventArg e);
    public class Task
    {
        public string Name { get; set; }
        private bool completed;

        // Sự kiện thay đổi trạng thái của công việc
        public event TaskStatusChangedEventHandler TaskStatusChanged;

        public bool Completed
        {
            get { return completed; }
            set
            {
                if (completed != value)
                {
                    completed = value;
                    OnTaskStatusChanged(new TaskStatusChangedEventArg(this.Name, this.Completed));
                }
            }
        }

        // Hàm gửi sự kiện khi trạng thái của công việc thay đổi
        protected virtual void OnTaskStatusChanged(TaskStatusChangedEventArg e)
        {
            TaskStatusChanged?.Invoke(this, e);
        }
    }
}
