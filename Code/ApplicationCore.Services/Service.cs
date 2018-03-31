using ApplicationCore.Domain.Interfaces;
using ApplicationCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain.Models;

namespace ApplicationCore.Services
{
    public class Service : IService
    {
        private readonly IRepository respository;

        public Service(IRepository respository)
        {
            this.respository = respository;
        }

        public IEnumerable<Program> GetPrograms()
        {
            var programs = this.respository.GetPrograms();

            foreach (var program in programs)
            {
                var stringBuilder = new StringBuilder(program.ProgramName);

                stringBuilder.Replace("'", "''");

                program.ProgramName = string.Concat("'", stringBuilder.ToString(), "'");
            }

            return programs.OrderBy(p => p.ProgramName);
        }
    }
}
