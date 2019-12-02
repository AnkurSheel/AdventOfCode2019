using System.Collections.Generic;

using AdventOfCode2019.Day1;
using AdventOfCode2019.Day2;

using Xunit;

namespace AdventOfCode2019.Tests.Day2
{
    public class GravityAssistTests
    {
        private readonly GravityAssist _gravityAssist;

        public GravityAssistTests()
        {
            _gravityAssist = new GravityAssist();
        }

        [Theory]
        [JsonFileData("Day2/testData.json", "Part1", typeof(string), typeof(int))]
        public void RestoreReturnCorrectCode(string data, int expectedResult)
        {
            var result = _gravityAssist.Restore(data);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [JsonFileData("Day2/testData.json", "Part2", typeof(string), typeof(int))]
        public void CompleteAssistForMoonReturnCorrectCode(string data, int expectedResult)
        {
            var result = _gravityAssist.CompleteAssistForMoon(data);
            Assert.Equal(expectedResult, result);
        }
    }
}