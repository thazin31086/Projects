using NUnit.Framework;

namespace ExProject.Tests
{
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            string sut = NameJoiner.Join("John", "Smith");

            Assert.That(sut, Is.EqualTo("John Smith"));
        }

        [Test]
        public void ShouldJoinNames_CaseInsensitive()
        {
            string sut = NameJoiner.Join("JOHN", "Smith");

            Assert.That(sut, Is.EqualTo("John Smith").IgnoreCase);
        }

        [Test]
        public void ShouldHaveDefaultGeneratedName()
        {
            var sut = NameJoiner.GenerateName();

            Assert.That(sut, Is.Not.Empty);
        }
        
    }
}
