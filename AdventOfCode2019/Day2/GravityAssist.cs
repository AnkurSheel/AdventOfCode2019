using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019.Day2
{
    public class GravityAssist
    {
        public int Restore(string data)
        {
            var integers = data.Split(',', StringSplitOptions.RemoveEmptyEntries).AsEnumerable().Select(int.Parse).ToArray();
            var currentIndex = 0;
            integers[1] = 12;
            integers[2] = 2;

            while (true)
            {
                var opcode = integers[currentIndex];

                if (opcode == 99)
                {
                    break;
                }

                var input1 = integers[integers[currentIndex + 1]];
                var input2 = integers[integers[currentIndex + 2]];
                var outputPosition = integers[currentIndex + 3];

                if (opcode == 1)
                {
                    integers[outputPosition] = input1 + input2;
                }
                else if (opcode == 2)
                {
                    integers[outputPosition] = input1 * input2;
                }

                currentIndex += 4;
            }

            return (int)integers[0];
        }

        public int CompleteAssistForMoon(string data)
        {
            var noun = 0;
            var verb = 0;
            var requiredOutput = 19690720;

            return 100 * noun + verb;
        }
    }
}