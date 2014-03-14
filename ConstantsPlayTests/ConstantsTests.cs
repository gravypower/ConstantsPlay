using System;
using System.Globalization;
using System.Threading;
using ConstantsPlay;
using ConstantsPlay2010;
using ConstantsPlay2013;
using NUnit.Framework;

namespace ConstantsPlayTests
{
    [TestFixture]
    public class ConstantsTests
    {
        private Constants2013 _constants2013;
        private Constants2010 _constants2010;

        [SetUp]
        public void SetUP()
        {
            _constants2013 = new Constants2013();
            _constants2010 = new Constants2010();
        }

        [Test]
        public void NoTemplateTitleIsSame()
        {
            Console.WriteLine(_constants2013.NoTemplateTitle);
            Console.WriteLine(_constants2010.NoTemplateTitle);

            Assert.That(_constants2013.NoTemplateTitle, Is.EqualTo(_constants2010.NoTemplateTitle));
        }


        [Test]
        public void InvalidTemplateObjectIsDifferent()
        {
            Console.WriteLine(_constants2013.InvalidTemplateObject);
            Console.WriteLine(_constants2010.InvalidTemplateObject);

            Assert.That(_constants2013.InvalidTemplateObject, Is.Not.SameAs(_constants2010.InvalidTemplateObject));
        }

        [Test]
        public void SomeTest()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-AU");

            Console.WriteLine(_constants2013.NoTemplateTitle);
            Console.WriteLine(_constants2010.NoTemplateTitle);
        }

    }
}
