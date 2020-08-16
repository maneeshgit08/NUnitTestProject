using System;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class UnitTest1
    {

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("One time setup");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Teardown");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("One time teardown");
        }

        [TestCase]
        public void TestMethod1()
        {
            Console.WriteLine("Test Method 1");
        }
    }
}
