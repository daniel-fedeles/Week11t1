using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GoatLatinProject.Tests
{
    public class GoatLatinTest
    {
        private GoatLatinClass goatLatin;

        public GoatLatinTest()
        {
            goatLatin = new GoatLatinClass();
        }

        [Theory]
        [InlineData("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [InlineData("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        [Trait("Category", "TestGoatLatin with valid text")]
        public void TestGoatLatinWithValidText(string input, string expected)
        {
            Assert.Equal(expected, goatLatin.ToGoatLatin(input));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [Trait("Category", "GoatLatin with invalid text")]
        public void TestGoatLatinWithInvalidText(string input)
        {
            Assert.Throws<ArgumentException>(() => goatLatin.ToGoatLatin(input));
        }


    }
}
