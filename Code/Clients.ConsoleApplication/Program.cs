using ApplicationCore.Services;
using ApplicationCore.Services.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain = ApplicationCore.Domain.Models;

namespace Clients.ConsoleApplication
{
    class Program
    {
        static IService service;

        static void Main(string[] args)
        {
            Init();
            Run();
            End();
        }

        static void Init()
        {
            service = new Service(new MockRepository());
        }

        static void Run()
        {
            var programs = service.GetPrograms();

            var output = string.Join(",", programs.Select(p => p.ProgramName));

            Console.WriteLine(output);
        }

        static void End()
        {
            Console.WriteLine("End of Program");
            Console.Read();
        }
    }
}
