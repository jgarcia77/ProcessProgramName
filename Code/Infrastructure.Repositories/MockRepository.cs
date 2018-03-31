namespace Infrastructure.Repositories
{
    using ApplicationCore.Domain.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ApplicationCore.Domain.Models;

    public class MockRepository : IRepository
    {
        public IEnumerable<Program> GetPrograms()
        {
            var returnList = new List<Program>
            {
                new Program
                {
                    ProgramId = 1,
                    StationId = 1,
                    ProgramName = "10 O'CLOCK NWS",
                    FlightDate = new DateTime(1990, 3, 11)
                },
                new Program
                {
                    ProgramId = 2,
                    StationId = 1,
                    ProgramName = "ACCESS HOLLYWD",
                    FlightDate = new DateTime(1991, 8, 25)
                },
                new Program
                {
                    ProgramId = 3,
                    StationId = 4,
                    ProgramName = "Jeop",
                    FlightDate = new DateTime(1975, 6, 30)
                },
                new Program
                {
                    ProgramId = 4,
                    StationId = 3,
                    ProgramName = "C O'BRIEN-NBC''Program",
                    FlightDate = new DateTime(1989, 1, 1)
                },
                new Program
                {
                    ProgramId = 5,
                    StationId = 3,
                    ProgramName = "Frasier's",
                    FlightDate = new DateTime(1991, 11, 11)
                },
                new Program
                {
                    ProgramId = 6,
                    StationId = 4,
                    ProgramName = "Barney",
                    FlightDate = new DateTime(1966, 9, 3)
                },
                new Program
                {
                    ProgramId = 7,
                    StationId = 1,
                    ProgramName = "Just Shoot me",
                    FlightDate = new DateTime(1996, 6, 6)
                },
                new Program
                {
                    ProgramId = 8,
                    StationId = 4,
                    ProgramName = "Wheel",
                    FlightDate = new DateTime(1975, 6, 30)
                },
                new Program
                {
                    ProgramId = 9,
                    StationId = 3,
                    ProgramName = "Sesame Street",
                    FlightDate = new DateTime(1971, 5, 16)
                }
            };

            return returnList.OrderBy(p => p.ProgramId);
        }
    }
}
