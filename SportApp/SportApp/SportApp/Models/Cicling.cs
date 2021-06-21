using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.Models
{
    public class Cicling
    {
        public DateTime DateTime { get; set; }
        public DateTime TimeOfEnd { get; set; }
        public DateTime TimeOfStart{ get; set; }
        public DateTime HowLong{ get; set; }
        public string RouteName { get; set; }
        public string Distance { get; set; }
    }
}
