using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CITest;
namespace TestPermutations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perms_should_Match()
        {
            var result = Permutations.Compute(4);
            Assert.IsTrue(result==24);

        }
    }
}
