/*
    Author:         Josue (Josh) Garcia
    Date:           Friday, March 30, 2018
    Description:    The function ProcessProgramName should retrieve all the program names 
                    from the PROGRAM_NAME column in the PROGRAM table, process them, and 
                    display them in alphabetical order. 

                    When displaying the program names, an apostrophe ("'") should be 
                    added to the beginning and the end of each program name. If there are 
                    any apostrophes *within* a program name, then an additional apostrophe 
                    should be added before the existing apostrophe(s). 

                    Use a comma (",") to separate each program name. For example, the 
                    string 'Test1','Test''2','Test3' is the proper output given input 
                    values of Test1, Test'2 and Test3. 

                    Please finish the function ProcessProgramName, so that it produces
                    the correct output.
*/
namespace Clients.ConsoleApplication
{
    using ApplicationCore.Services;
    using ApplicationCore.Services.Interfaces;
    using Infrastructure.Repositories;
    using System;
    using System.Linq;

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
