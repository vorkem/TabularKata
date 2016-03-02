using NUnit.Framework;

namespace TabularKata
{
    [TestFixture]
    public class GivenAOneStringGuitar
    {
        [Test]
        public void WhenNoInputsAreSelectedThenNoStringsArePlayed()
        {
            var subject = new Music();
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo("|-----|"));
        }
    }
}
