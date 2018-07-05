using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Anagrama
{
    [TestFixture]
    public class AnagramaTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void Factorial(int n, int expected)
        {
            Assert.AreEqual(expected, AnagramaResolver.Factorial(n));
        }

        [Test]
        [TestCase("oi")]
        [TestCase("ate")]
        [TestCase("bobo")]
        [TestCase("grito")]
        [TestCase("barata")]
        [TestCase("sobindo")]
        [TestCase("pregando")]
        public void Resolve(string word)
        {
            var result = AnagramaResolver.Resolve(word);

            Assert.AreEqual(AnagramaResolver.Factorial(word.Length), result.Count);
        }
    }
}
