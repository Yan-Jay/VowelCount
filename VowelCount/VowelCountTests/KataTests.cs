using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VowelCount.Tests
{
    [TestClass()]
    public class KataTests
    {
        [DataTestMethod]
        [DataRow("abracadabra", 5, DisplayName = "result_should_return_5")]
        [DataRow("aqqqebbbiuuuo", 7, DisplayName = "result_should_return_4")]
        [DataRow("bcdfghlppppzzz", 0, DisplayName = "result_should_return_0")]
        public void GetVowelCountTestWithNoSpaces(string input,int expect)
        {
            var actural = new Kata().GetVowelCount(input);
            Assert.AreEqual(expect,actural);
        }

        [DataTestMethod]
        [DataRow("  abracadabra", 5, DisplayName = "result_should_return_5")]
        [DataRow("abrac  adabra", 5, DisplayName = "result_should_return_5")]
        [DataRow("abracadabra  ", 5, DisplayName = "result_should_return_5")]
        [DataRow("  abrac  adabra  ", 5, DisplayName = "result_should_return_5")]
        [DataRow("               ", 0, DisplayName = "result_should_return_0")]
        public void GetVowelCountTestWithSpace(string input, int expect)
        {
            var actural = new Kata().GetVowelCount(input);
            Assert.AreEqual(expect, actural);
        }
    }
}