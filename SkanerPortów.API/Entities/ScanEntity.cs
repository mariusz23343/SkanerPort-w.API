using System;

namespace SkanerPortów.API.Entities
{
    public class ScanEntity
    {
        public int Id { get; set; }
        public int PortNumber { get; set; }
        public bool IsOpen { get; set; }
        public string Ipv4 { get; set; }
        public DateTime ScanDate { get; set; }
    }
}
