using System;
using NUnit.Framework;
using PageMethods.HomePageMethods;

namespace Tests.Selenium
{
    public class HomePageTests : BaseTest
    {
        [SetUp]
        public void loadHomePage()
        {
            HomePageMethods homePageDriver = new HomePageMethods(driver);
            homePageDriver.navigateToHomePage();
        }

        [Test]
        public void IsHomePageHeadingPresent()
        {
            HomePageMethods homePageDriver = new HomePageMethods(driver);
            homePageDriver.isHomePageHeadingVisible();
        }
    }
}