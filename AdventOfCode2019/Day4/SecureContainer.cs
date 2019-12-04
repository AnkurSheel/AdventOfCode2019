using System.Collections.Generic;

namespace AdventOfCode2019.Day4
{
    public class PasswordRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class SecureContainer
    {
        private int _numberOfDigits;

        public int GetNumberOfPasswords(PasswordRange data)
        {
            _numberOfDigits = GetNumberOfDigits(data);

            var passwords = GetPasswords(data);
            return passwords.Count;
        }


        public int GetNumberOfPasswordsAdditionalCriteria(PasswordRange data)
        {
            _numberOfDigits = GetNumberOfDigits(data);

            var passwords = GetPasswords(data);
            var updatedPasswords = new List<int>();
            foreach (var password in passwords)
            {
                var digits = GetDigits(password);

                var foundDuplicate = false;

                int previousDigit = digits[0];
                int index = 1;
                while (index < _numberOfDigits)
                {
                    var numberofMatchingAdjacentDigits = 0;
                    int digit = digits[index];
                    while (previousDigit == digit)
                    {
                        numberofMatchingAdjacentDigits++;
                        previousDigit = digit;
                        index++;
                        if (index >= _numberOfDigits)
                        {
                            break;
                        }
                        digit = digits[index];
                    }

                    if (numberofMatchingAdjacentDigits == 1)
                    {
                        foundDuplicate = true;
                    }

                    previousDigit = digit;
                    index++;
                    if (index >= _numberOfDigits)
                    {
                        break;
                    }
                    digit = digits[index];
                }

                if (foundDuplicate)
                {
                    updatedPasswords.Add(password);
                }
            }

            return updatedPasswords.Count;
        }

        private int[] GetDigits(int password)
        {
            var currentNumber = password;
            var digits = new int[_numberOfDigits];
            int currentIndex = 0;
            while (currentNumber > 0)
            {
                digits[currentIndex] =(currentNumber % 10);
                currentNumber /= 10;
                currentIndex++;
            }
            return digits;
        }

        private bool MeetsCriteria(int currentNumber)
        {
            var foundDuplicate = false;
            var previousDigit = currentNumber % 10;
            while (currentNumber > 0)
            {
                currentNumber = currentNumber / 10;

                var digit = currentNumber % 10;
                if (digit > previousDigit)
                {
                    return false;
                }

                if (digit == previousDigit)
                {
                    foundDuplicate = true;
                }

                previousDigit = digit;
            }

            return foundDuplicate;
        }

        private List<int> GetPasswords(PasswordRange data)
        {
            var passwords = new List<int>();

            var currentNumber = data.Min;
            while (currentNumber < data.Max)
            {
                if (MeetsCriteria(currentNumber))
                {
                    passwords.Add(currentNumber);
                }

                currentNumber++;
            }

            return passwords;
        }

        private int GetNumberOfDigits(PasswordRange data)
        {
            var numberOfDigits = 1;
            var max = data.Max;

            while (max / 10 > 0)
            {
                numberOfDigits++;
                max /= 10;
            }

            return numberOfDigits;
        }
    }
}