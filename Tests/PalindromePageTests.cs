using System;
using NUnit.Framework;
using PageMethods.PalindromePageMethods;

namespace Tests.Selenium
{
    public class PalindromePageTests : BaseTest
    {
        [SetUp]
        public void loadPalindromePage()
        {
            PalindromePageMethods palindromePageDriver = new PalindromePageMethods(driver);
            palindromePageDriver.navigateToPalindromePage();
        }

        [Test]
        public void IsPalindromePageHeadingPresent()
        {
            PalindromePageMethods palindromePageDriver = new PalindromePageMethods(driver);
            palindromePageDriver.isPalindromePageHeadingVisible();
        }
    }
}