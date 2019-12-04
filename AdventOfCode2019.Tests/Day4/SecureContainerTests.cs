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
        public void GetNumberOfPasswordsReturnsCorrectNumber(PasswordRange data, int expectedResult)
        {
            var result = _secureContainer.GetNumberOfPasswords(data);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [JsonFileData("Day4/testData.json", "Part2", typeof(PasswordRange), typeof(int))]
        public void GetNumberOfPasswordsAdditionalCriteriaReturnsCorrectNumber(PasswordRange data, int expectedResult)
        {
            var result = _secureContainer.GetNumberOfPasswordsAdditionalCriteria(data);
            Assert.Equal(expectedResult, result);
        }
    }
}