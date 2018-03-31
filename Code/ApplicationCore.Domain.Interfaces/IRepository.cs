namespace ApplicationCore.Domain.Interfaces
{
    using ApplicationCore.Domain.Models;
    using System.Collections.Generic;

    public interface IRepository
    {
        IEnumerable<Program> GetPrograms();
    }
}
