using System;
using OpenQA.Selenium;
using Shouldly;

namespace PageMethods.HomePageMethods
{
    class HomePageMethods
    {
        private IWebDriver driver;

        public HomePageMethods (IWebDriver driver)
        {
            this.driver = driver;
        }

        public By navLinkHome = By.Id("linkHome");
        public By headingHomePage = By.XPath("//h2[contains(text(),'Home')]");

        public void navigateToHomePage()
        {
            driver.FindElement(headingHomePage).Click();
        }

        public void isHomePageHeadingVisible()
        {
            string expectedHeading = "Home";
            var heading = driver.FindElement(headingHomePage);

            heading.Text.ShouldBe(expectedHeading);
            heading.Displayed.ShouldBe(true);
        }
    }
}