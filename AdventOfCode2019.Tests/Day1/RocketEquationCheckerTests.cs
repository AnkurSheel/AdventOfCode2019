using System.Collections.Generic;
using AdventOfCode2019.Day1;
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


        [Theory]
        [JsonFileData("Day1/testData.json", "Part2", typeof(List<int>), typeof(int))]
        public void GetTotalFuelRequirementWhenFuelHasMassReturnCorrectTotalFuelRequirement(List<int> data, int expectedResult)
        {
            var result = _rocketEquationChecker.GetTotalFuelRequirementWhenFuelHasMass(data);
            Assert.Equal(expectedResult, result);
        }
    }
}