using System.Linq;

namespace VowelCount
{
    public class Kata
    {
        public int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] vowels = {'a','e','i','o','u' };
            foreach (var vowel in vowels)
            {
                vowelCount += str.Count(x => x.Equals(vowel));
            }
            return vowelCount;
        }
    }
}