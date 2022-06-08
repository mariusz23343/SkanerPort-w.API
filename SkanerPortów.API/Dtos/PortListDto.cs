using System;
using System.Collections.Generic;

namespace SkanerPortów.API.Dtos
{
    public class PortListDto
    {
        public Dictionary<int, bool> portDict { get; set; }
        public string IPv4 { get; set; }
        public DateTime ScanDate { get; set; }

    }
}
