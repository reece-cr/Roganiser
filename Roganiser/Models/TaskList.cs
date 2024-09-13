using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roganiser.Models
{
    class TaskList
    {
        Guid Id { get; set; }
        string Title { get; set; } = string.Empty;
        string Description { get; set; } = string.Empty;
        List<Task> Tasks { get; set; } = new List<Task>();

    }
}
