using System.Collections.Generic;
using AdventOfCode2019.Day3;
using Xunit;

namespace AdventOfCode2019.Tests.Day3
{
    public class CrossedWiresTests
    {
        private readonly CrossedWires _crossedWires;

        public CrossedWiresTests()
        {
            _crossedWires = new CrossedWires();
        }

        [Theory]
        [JsonFileData("Day3/testData.json", "Part1", typeof(List<string>), typeof(int))]
        public void GetDistanceToClosestIntersectionReturnsBestDistance(List<string> data, int expectedResult)
        {
            var result = _crossedWires.GetDistanceToClosestIntersection(data);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [JsonFileData("Day3/testData.json", "Part2", typeof(List<string>), typeof(int))]
        public void GetMinimumNumberOfStepsToIntersectionReturnsMinimumSteps(List<string> data, int expectedResult)
        {
            var result = _crossedWires.GetMinimumNumberOfStepsToIntersection(data);
            Assert.Equal(expectedResult, result);
        }
    }
}