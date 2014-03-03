namespace Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests : AssertionHelper
    {
        [Test]
        public void Not_So_Important_Test()
        {
            Expect(true);
        }

        [Test]
        public void Critical_Test()
        {
            throw new NotImplementedException();
        }
    }
}