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
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized", "incognito");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://andrewsoden.github.io/test-website/#/");
        }

        [TearDown]
        public void TestTearDown()
        {
            driver.Quit();
        }
    }
}