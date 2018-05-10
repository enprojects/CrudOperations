using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
    }
}
