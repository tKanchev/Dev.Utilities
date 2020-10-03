using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dev.Utilities.Guids.Services.Guids
{
    public class GuidsService : IGuidsService
    {
        public async Task<Guid> GenerateSingle()
            => await Task.Run(() => Guid.NewGuid());

        public async Task<IEnumerable<Guid>> GenerateBulk(int amount)
            => await Task.Run(() => 
            {
                var guids = new Guid[amount];
                for (int i = 0; i < amount; i++)
                {
                    guids[i] = Guid.NewGuid();
                }
                
                return guids; 
            });
    }
}
