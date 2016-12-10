using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Etnath.Utilities.Portable.Patterns;

namespace Etnath.Utilities.Portable.Test.Patterns
{
    [TestClass]
    public class SingletonPattern
    {
        [TestMethod]
        public void SingletonPatternTestMethod()
        {
            Assert.IsNotNull(MySingleton.Instance);
        }

        private class MySingleton : SingletonBase<MySingleton>
        {
        }
    }
}
