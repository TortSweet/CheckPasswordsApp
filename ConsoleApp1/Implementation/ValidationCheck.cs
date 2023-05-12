using System;
using System.Linq;

namespace CheckPasswordsApp.Implementation
{
    public class ValidationCheck
    {
        public int Counter = 0;
        public void IsValidString(string enteredStr)
        {
            if (string.IsNullOrWhiteSpace(enteredStr))
            {
                throw new ArgumentNullException(nameof(enteredStr), "Entered string must contains data");
            }

            char[] delimiterChars = { ' ', ':' };

            var requiredParams = enteredStr.Split(delimiterChars).Where(x => x != string.Empty).ToArray();

            var nums = requiredParams[1].Split("-");

            var counter = requiredParams[2].Count(character => character == requiredParams[0].ToCharArray()[0]);

            if (int.Parse(nums[0]) <= counter && counter <= int.Parse(nums[1]))
            {
                Counter++;
            }
        }

        public int ShowCount()
        {
            return Counter;
        }
    }
}
