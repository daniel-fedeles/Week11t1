using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringProblem.Tests
{
    [TestFixture]
    public class ReverseStringTest
    {
        private StringReverse reverse;
        [SetUp]
        public void Setup()
        {
            reverse = new StringReverse();
        }
        [Test]
        [Category("Valid Input")]
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
       

        public void Test_Valid_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            string x = reverse.ReverseOnlyLetters(input);

            //Assert
            Assert.AreEqual(expected, x);

        }

        [Test]
        [Category("Null Input")]
        [TestCase(null, null)]
        public void Test_Null_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => reverse.ReverseOnlyLetters(input));

        }
        [Test]
        [Category("Empty Input")]
        [TestCase("", null)]
        public void Test_Empty_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => reverse.ReverseOnlyLetters(input));

        }

        [TearDown]
        public void CleanUp()
        {
            reverse = null;
        }
    }
}
