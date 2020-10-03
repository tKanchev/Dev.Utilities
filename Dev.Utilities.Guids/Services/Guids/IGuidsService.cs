using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dev.Utilities.Guids.Services.Guids
{
    public interface IGuidsService
    {
        Task<Guid> GenerateSingle();

        Task<IEnumerable<Guid>> GenerateBulk(int amount);
    }
}
