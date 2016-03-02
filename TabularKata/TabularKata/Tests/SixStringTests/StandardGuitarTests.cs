using NUnit.Framework;
using System;

namespace TabularKata.Tests.SixStringTests
{
    [TestFixture]
    class StandardGuitarTests
    {
        [Test]
        public void Name()
        {
            var subject = new Music(6);
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            subject.AddNote();
            var result = subject.Tabulate();

            Assert.That(result, Is.EqualTo(string.Format("|{0}|{1}|{0}|{1}|{0}|{1}|{0}|{1}|{0}|{1}|{0}|", "-----", Environment.NewLine))); 
        }
    }
}
