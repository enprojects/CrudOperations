using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public enum Status
    {
         Start=0,
         Running,
         Completed
    }

    public class TaskModel
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
    }
}
