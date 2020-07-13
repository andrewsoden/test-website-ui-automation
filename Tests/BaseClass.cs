using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.Selenium
{
    public class BaseClass
    {
        public IWebDriver driver;

        [SetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://andrewsoden.github.io/test-website/#/");
        }

        [TearDown]
        public void TestTearDown()
        {
            driver.Quit();
        }
    }
}