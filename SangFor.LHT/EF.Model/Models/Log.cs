using System;
using System.Collections.Generic;

namespace EF.Model.Models
{
    public partial class Log
    {
        public string Content { get; set; }
        public DateTime? Actiontime { get; set; }
    }
}
