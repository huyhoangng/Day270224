using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        public class TaskStatusChangedEventArg : EventArgs
        {
            public string TaskName { get; set; }
            public bool Completed { get; set; }

            public TaskStatusChangedEventArg(string taskName, bool completed)
            {
                TaskName = taskName;
                Completed = completed;
            }
        }
   
}
