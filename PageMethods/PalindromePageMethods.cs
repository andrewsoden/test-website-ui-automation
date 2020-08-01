using System;
using OpenQA.Selenium;
using Shouldly;

namespace PageMethods.PalindromePageMethods
{
    class PalindromePageMethods
    {
        private IWebDriver driver;

        public PalindromePageMethods (IWebDriver driver)
        {
            this.driver = driver;
        }

        public By navLinkPalindrome = By.Id("linkPalindrome");
        public By headingPalindromePage = By.XPath("//h2[contains(text(),'Palindrome')]");

        public void navigateToPalindromePage()
        {
            driver.FindElement(navLinkPalindrome).Click();
        }

        public void isPalindromePageHeadingVisible()
        {
            string expectedHeading = "Palindrome Checker";
            var heading = driver.FindElement(headingPalindromePage);

            heading.Text.ShouldBe(expectedHeading);
            heading.Displayed.ShouldBe(true);
        }
    }
}