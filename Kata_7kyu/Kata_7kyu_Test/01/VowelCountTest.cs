using Kata_7kyu._01;
using NUnit.Framework;

namespace Kata_7kyu_Test._01
{
    [TestFixture]
    public class VowelCountTest
    {
        [Test]
        public void TestCase()
        {
            // Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
            Assert.AreEqual(5, VowelCount.GetVowelCount_v2("abracadabra"), "Nope!");
        }
    }
}