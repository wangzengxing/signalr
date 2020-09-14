using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Demo.Services
{
    public class TaskCompleteNotice
    {
        public int TaskId { get; set; }
        public DateTime CompleteTime { get; set; }
    }
}
