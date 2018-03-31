namespace ApplicationCore.Services.Interfaces
{
    using ApplicationCore.Domain.Models;
    using System.Collections.Generic;

    public interface IService
    {
        IEnumerable<Program> GetPrograms();
    }
}
