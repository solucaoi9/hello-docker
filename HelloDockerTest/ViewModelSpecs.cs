using HelloDocker.Models;
using Xunit;

namespace HelloDockerTest
{
    public class UnitTest1
    {
        [Fact]
        public void WhenCreateErrorViewModel_MustBe_CreateCorrectlly()
        {
            var requestId = "123456789012345";
            var vm = new ErrorViewModel() { RequestId = requestId };

            Assert.NotNull(vm);
            Assert.Equal(requestId, vm.RequestId);
        }
    }
}
