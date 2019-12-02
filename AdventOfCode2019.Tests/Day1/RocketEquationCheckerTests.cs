using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2019.Tests.Day1
{
    public class RocketEquationCheckerTests
    {
        private readonly RocketEquationChecker _rocketEquationChecker;

        public RocketEquationCheckerTests()
        {
            _rocketEquationChecker = new RocketEquationChecker();
        }

        [Theory]
        [JsonFileData("Day1/testData.json", "Part1", typeof(List<int>), typeof(int))]
        public void GetTotalFuelRequirementReturnCorrectTotalFuelRequirement(List<int> data, int expectedResult)
        {
            var result = _rocketEquationChecker.GetTotalFuelRequirement(data);
            Assert.Equal(expectedResult, result);
        }

    }
}