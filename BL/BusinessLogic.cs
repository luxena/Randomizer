using System;
using System.Collections.Generic;

namespace BL
{
    public class BusinessLogic
    {
        
        public string Randomize(List<string> numbers)
        {
            var random = numbers.PickRandom();

            numbers.Remove(random);

            return random;
        }

        public List<string> GetNumbers(int min, int max)
        {
            List<string> numbers = new List<string>();
            for (int i = min; i <= max; i++)
            {
                numbers.Add(i.ToString());
            }

            return numbers;
        }
    }
}
