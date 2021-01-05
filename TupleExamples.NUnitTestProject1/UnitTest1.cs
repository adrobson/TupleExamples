using NUnit.Framework;
using System;

namespace TupleExamples.NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void First_Property_Is_Type_String()
        {
            var (retString, retDouble, retInt) = DemoClass.TupleMethod("World", 17.94);

            Assert.AreEqual("System.String", retString.GetType().ToString());
        }

        [Test]
        public void Second_Property_Is_Type_Double()
        {
            var (retString, retDouble, retInt) = DemoClass.TupleMethod("World", 17.94);

            Assert.AreEqual("System.Double", retDouble.GetType().ToString());
        }

        [Test]
        public void Third_Property_Is_Int()
        {
            var (retString, retDouble, retInt) = DemoClass.TupleMethod("World", 17.94);

            Assert.AreEqual("System.Int32", retInt.GetType().ToString());
        }

        [Test]
        public void String_Property_Returns_Hello()
        {
            var (retString, retDouble, retInt) = DemoClass.TupleMethod("World", 17.94);

            Assert.AreEqual("Hello World", retString);
        }

        [Test]
        public void Use_An_Existing_Variable()
        {
            var myString = "Nothing";

            (myString, _, _) = DemoClass.TupleMethod("World", 17.94);

            Assert.AreEqual("Hello World", myString);
        }
    }
}