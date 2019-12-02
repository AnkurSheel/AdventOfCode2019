using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdventOfCode2019.Tests.Day1
{
    class RocketEquationChecker
    {
        public int GetTotalFuelRequirement(List<int> data)
        {
            var totalFuelRequirement = 0;
            foreach (var moduleMass in data)
            {
                var fuelRequiredForModule = (moduleMass / 3) - 2;
                totalFuelRequirement += fuelRequiredForModule;
            }
            return totalFuelRequirement;
        }

        public int GetTotalFuelRequirementWhenFuelHasMass(List<int> data)
        {
            return 0;
        }
    }
}
