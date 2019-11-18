using System;
using NUnit.Framework;

namespace TestGit.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var args = new[] {"test2", "test3", "test4"};
            var firstArg = TestGit.ParseOutFirstArg(args);
            Assert.AreEqual(firstArg, "test3");
        }
    }
}
