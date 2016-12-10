using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Etnath.Utilities.Portable.Attribute;
using Etnath.Utilities.Portable.Helper;
using DescriptionAttribute = Etnath.Utilities.Portable.Attribute.DescriptionAttribute;

namespace Etnath.Utilities.Portable.Test.Attribute
{
    [TestClass]
    public class DescriptionAttributeTest
    {
        [TestMethod]
        public void DescriptionAttributeEnumTestMethod()
        {
            Assert.AreEqual("Foo", EnumTest.test1.GetDescription());
            Assert.AreEqual("Bar", EnumTest.test2.GetDescription());
            Assert.AreEqual(string.Empty, EnumTest.test3.GetDescription());
        }

        [TestMethod]
        public void DescriptionAttributeEqualTestMethod()
        {
            DescriptionAttribute attribute1 = new DescriptionAttribute("equal");
            DescriptionAttribute attribute2 = new DescriptionAttribute("equal");
            DescriptionAttribute attribute3 = new DescriptionAttribute("notEqual");

            Assert.AreEqual(true, attribute1.Equals(attribute2));
            Assert.AreEqual(false, attribute1.Equals(attribute3));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DescriptionAttributeMissingTestMethod()
        {
            EnumTest.test4.GetDescription();
        }

        private enum EnumTest
        {
            [Description("Foo")]
            test1,
            [Description("Bar")]
            test2,
            [Description]
            test3,
            test4
        }

    }
}
