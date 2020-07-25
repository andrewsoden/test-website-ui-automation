using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageMethods.RegisterPageMethods
{
    class RegisterPageMethods
    {
        public IWebDriver driver;

        public RegisterPageMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By username = By.Id("formFullName");
        public By phoneNumber = By.Id("formPhoneNumber");
        public By email = By.Id("formEmail");
        public By address1 = By.Id("formAddress1");
        public By address2 = By.Id("formAddress2");
        public By city = By.Id("formCity");
        public By state = By.Id("formState");
        public By zip = By.Id("formZip");
        //Pet checkbox
        //Coffee checkbox
        //Submit button
        //Clear button

        public void enterFullName(string textFullName)
        {
            driver.FindElement(username).SendKeys(textFullName);
        }

        public void enterPhoneNumber(string textPhoneNumber)
        {
            driver.FindElement(phoneNumber).SendKeys(textPhoneNumber);
        }

        public void enterEmail(string textEmail)
        {
            driver.FindElement(email).SendKeys(textEmail);
        }

        //address1
        //address2
        //city
        //state
        //zip
        //zip
        //checkbox1
        //checkbox2
    }
}