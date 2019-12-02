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
            var integers = GetIntegers(data);
            RunProgram(integers, 12, 2);

            return (int)integers[0];
        }

        public int CompleteAssistForMoon(string data)
        {
            var originalIntegers = GetIntegers(data);   
            var integers = new int[originalIntegers.Length];

            var requiredOutput = 19690720;

            var noun = 0;
            var verb = 0;
            for (noun = 0; noun < 99; noun++)
            {
                for (verb = 0; verb < 99; verb++)
                {
                    originalIntegers.CopyTo(integers, 0);
                    RunProgram(integers, noun, verb);
                    if (integers[0] == requiredOutput)
                    {
                        return 100 * noun + verb;
                    }
                }
            }

            return 0;

        }

        private void RunProgram(int[] integers, int noun, int verb)
        {
            var currentIndex = 0;
            integers[1] = noun;
            integers[2] = verb;
            var opcode = 0;
            while (opcode != 99)
            {
                opcode = integers[currentIndex];

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
        }

        private int[] GetIntegers(string data)
        {
            var integers = data.Split(',', StringSplitOptions.RemoveEmptyEntries).AsEnumerable().Select(int.Parse).ToArray();
            return integers;
        }
    }
}