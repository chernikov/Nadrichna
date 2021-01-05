using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Tests
{
    [SetUpFixture]
    public class Setup
    {
        [OneTimeSetUp]
        public static void SetupTests()
        {
            Console.WriteLine("Setup");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Console.WriteLine("Tear Down");
        }
    }
}
