using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roganiser.Models
{
    public class RogTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

    }
}
