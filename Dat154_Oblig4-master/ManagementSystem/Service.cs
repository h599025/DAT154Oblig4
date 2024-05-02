using System;
using System.Collections.Generic;

namespace ManagementSystem
{
    public partial class Service
    {
        public int Roomnr { get; set; }
        public bool Checkedin { get; set; }
        public string? Cleaning { get; set; }
        public string? Service1 { get; set; }
        public string? Maintenance { get; set; }
        public string? Status { get; set; }
        public string? Note { get; set; }

        public virtual Room RoomnrNavigation { get; set; } = null!;
    }
}
