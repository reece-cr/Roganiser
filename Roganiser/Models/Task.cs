using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roganiser.Models
{
    class Task
    {
        Guid Id { get; set; }
        string Title { get; set; } = string.Empty;
        string Description {  get; set; } = string.Empty;
        bool IsCompleted { get; set; }

    }
}
