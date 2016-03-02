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
            subject.AddNote("-");
            subject.AddNote("-");
            subject.AddNote("-");
            subject.AddNote("-");
            subject.AddNote("-");
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo("|-----|"));
        }

        [Test]
        public void WhenTheSecondFretIsPlayedOnTheThirdBeatThenTheTabIsCorrect()
        {
            var subject = new Music();
            subject.AddNote("-");
            subject.AddNote("-");
            subject.AddNote("2");
            subject.AddNote("-");
            subject.AddNote("-");
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo("|--2--|"));
        }
    }
}
