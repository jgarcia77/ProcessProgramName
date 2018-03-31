namespace ApplicationCore.Domain.Models
{
    using System;

    public class Program
    {
        public int ProgramId { get; set; }
        public int StationId { get; set; }
        public string ProgramName { get; set; }
        public DateTime FlightDate { get; set; }
    }
}
