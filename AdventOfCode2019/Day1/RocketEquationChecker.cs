using System;
using System.Collections.Generic;

namespace AdventOfCode2019.Day1
{
    public class RocketEquationChecker
    {
        public int GetTotalFuelRequirement(List<int> data)
        {
            var totalFuelRequirement = 0;
            foreach (var moduleMass in data)
            {
                var fuelRequiredForModule = GetFuelRequiredForModule(moduleMass);
                totalFuelRequirement += fuelRequiredForModule;
            }
            return totalFuelRequirement;
        }

        public int GetTotalFuelRequirementWhenFuelHasMass(List<int> data)
        {
            var totalFuelRequirement = 0;
            foreach (var moduleMass in data)
            {
                var mass = moduleMass;
                var fuelRequiredForModule = 0;
                var totalFuelRequiredForModule = 0;
                do
                {
                    fuelRequiredForModule = GetFuelRequiredForModule(mass);
                    totalFuelRequiredForModule += fuelRequiredForModule;
                    mass = fuelRequiredForModule;
                } while (fuelRequiredForModule > 0);

                GetFuelRequiredForModule(moduleMass);
                totalFuelRequirement += totalFuelRequiredForModule;
            }
            return totalFuelRequirement;
        }
        private int GetFuelRequiredForModule(int moduleMass)
        {
            var fuelRequiredForModule = Math.Max(0, (moduleMass / 3) - 2);
            return fuelRequiredForModule;
        }

    }
}
