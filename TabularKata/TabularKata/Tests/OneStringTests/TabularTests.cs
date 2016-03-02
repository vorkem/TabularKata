using NUnit.Framework;

namespace TabularKata.Tests.OneStringTests
{
    [TestFixture]
    public class GivenAOneStringGuitar
    {
        [Test]
        public void WhenNoInputsAreSelectedThenNoStringsArePlayed()
        {
            var subject = new Music(1);
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo("|-----|"));
        }

        [Test]
        public void WhenTheSecondFretIsPlayedOnTheThirdBeatThenTheTabIsCorrect()
        {
            var subject = new Music(1);
            subject.AddNote();
            subject.AddNote();
            subject.AddNote(new PlayableNote {StringNumber=1, Fret = 2 });
            subject.AddNote();
            subject.AddNote();
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo("|--2--|"));
        }
    }
}
