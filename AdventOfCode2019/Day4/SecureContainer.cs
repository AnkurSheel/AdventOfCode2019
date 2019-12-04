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
            var numberOfPasswords = 0;

            _numberOfDigits = GetNumberOfDigits(data);

            var currentNumber = data.Min;
            while (currentNumber < data.Max)
            {
                if (MeetsCriteria(currentNumber))
                {
                    numberOfPasswords++;
                }

                currentNumber++;
            }

            return numberOfPasswords;

        public int GetNumberOfPasswordsAdditionalCriteria(PasswordRange data)
        {
            return 0;
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

        private int GetNumberOfDigits(PasswordRange data)
        {
            var numberOfDigits = 1;
            var max = data.Max;

            while (max % 10 > 0)
            {
                numberOfDigits++;
                max /= 10;
            }

            return numberOfDigits;
        }
    }
}