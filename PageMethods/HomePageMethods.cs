using OpenQA.Selenium;

namespace HomePageMethods
{
    class HomePageMethods
    {
        private IWebDriver driver;

        public HomePageMethods (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}