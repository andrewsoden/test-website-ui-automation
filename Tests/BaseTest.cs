using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.Selenium
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void TestSetup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--window-size=1920,1080");
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("incognito");
            //chromeOptions.AddArgument("headless");
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