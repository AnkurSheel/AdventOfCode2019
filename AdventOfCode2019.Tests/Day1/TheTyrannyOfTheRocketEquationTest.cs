using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2019.Tests.Day1
{
    public class TheTyrannyOfTheRocketEquationTest
    {
        private TheTyrannyOfTheRocketEquation _theTyrannyOfTheRocketEquation;

        public TheTyrannyOfTheRocketEquationTest()
        {
            _theTyrannyOfTheRocketEquation = new TheTyrannyOfTheRocketEquation();
        }

        [Theory]
        [JsonFileData("Day1/testData.json", "Part1", typeof(List<int>), typeof(int))]
        public void GetTotalFuelRequirementReturnCorrectTotalFuelRequirement(List<int> data, int expectedResult)
        {
            var result = _theTyrannyOfTheRocketEquation.GetTotalFuelRequirement(data);
            Assert.Equal(expectedResult, result);
        }
    }
}