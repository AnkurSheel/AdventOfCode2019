using AdventOfCode2019.Day4;
using Xunit;

namespace AdventOfCode2019.Tests.Day4
{
    public class SecureContainerTests
    {
        private readonly SecureContainer _secureContainer;

        public SecureContainerTests()
        {
            _secureContainer = new SecureContainer();
        }

        [Theory]
        [JsonFileData("Day4/testData.json", "Part1", typeof(PasswordRange), typeof(int))]
        public void GetDistanceToClosestIntersectionReturnsBestDistance(PasswordRange data, int expectedResult)
        {
            var result = _secureContainer.GetNumberOfPasswords(data);
            Assert.Equal(expectedResult, result);
        }
    }
}