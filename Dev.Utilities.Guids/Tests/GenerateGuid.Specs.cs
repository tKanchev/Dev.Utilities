using Dev.Utilities.Guids.Services.Guids;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Dev.Utilities.Guids.Tests
{
    public class GenerateGuid
    {
        private readonly IGuidService guidService;

        public GenerateGuid()
        {
            this.guidService = new GuidService();
        }

        [Fact]
        public async Task Guid_Service_GenerateSingle_Method_Generates_Valid_Not_Empty_Guid()
        {
            var guid = await this.guidService.GenerateSingle();

            Assert.IsType<Guid>(guid);
            Assert.NotEqual(Guid.Empty, guid);
        }

        [Fact]
        public async Task Guid_Service_GenerateBulk_Method_Generates_Correct_Number_Of_Guids()
        {
            int numberGuidsToGenerate = 10;
            var generatedGuids = await this.guidService.GenerateBulk(numberGuidsToGenerate);

            Assert.IsType<Guid[]>(generatedGuids);
            Assert.Equal(numberGuidsToGenerate, generatedGuids.Count());
        }

        [Fact]
        public async Task Guid_Service_GenerateBulk_Method_Generates_Valid_Guids()
        {
            int numberGuidsToGenerate = 3;
            var generatedGuids = await this.guidService.GenerateBulk(numberGuidsToGenerate);

            Assert.IsType<Guid[]>(generatedGuids);
            foreach (var guid in generatedGuids)
            {
                Assert.NotEqual(Guid.Empty, guid);
            }
        }
    }
}
