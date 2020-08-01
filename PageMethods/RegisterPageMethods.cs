using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Shouldly;

namespace PageMethods.RegisterPageMethods
{
    class RegisterPageMethods
    {
        public IWebDriver driver;

        public RegisterPageMethods(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By navLinkRegister = By.Id("linkRegister");
        public By headingRegisterPage = By.XPath("//h2[contains(text(),'Register')]");
        public By textIdFullName = By.Id("formFullName");
        public By textIdPhoneNumber = By.Id("formPhoneNumber");
        public By textIdEmail = By.Id("formEmail");
        public By textIdAddress1 = By.Id("formAddress1");
        public By textIdAddress2 = By.Id("formAddress2");
        public By textIdCity = By.Id("formCity");
        public By selectorIdState = By.Id("formState");
        public By textIdZip = By.Id("formZip");
        public By radioIdCatPerson = By.Id("inputCatPerson");
        public By radioIdDogPerson = By.Id("inputDogPerson");
        public By radioIdBothPerson = By.Id("inputBothPerson");
        public By radioIdNeitherPerson = By.Id("inputNeitherPerson");
        public By checkboxIdCoffee = By.Id("inputCoffeeCheckbox");
        public By buttonSubmit = By.Id("buttonSubmit");
        public By buttonClearForm = By.Id("buttonClear");


        public void navigateToRegisterPage()
        {
            driver.FindElement(navLinkRegister).Click();
        }

        public void isRegisterPageHeadingVisible()
        {
            string expectedHeading = "Register";
            var heading = driver.FindElement(headingRegisterPage);

            heading.Text.ShouldBe(expectedHeading);
            heading.Displayed.ShouldBe(true);
        }
        public void enterFullName(string textFullName)
        {
            driver.FindElement(textIdFullName).SendKeys(textFullName);
        }

        public void enterPhoneNumber(string textPhoneNumber)
        {
            driver.FindElement(textIdPhoneNumber).SendKeys(textPhoneNumber);
        }

        public void enterEmail(string textEmail)
        {
            driver.FindElement(textIdEmail).SendKeys(textEmail);
        }

        public void enterAddress1(string textAddres1)
        {
            driver.FindElement(textIdAddress1).SendKeys(textAddres1);
        }
        public void enterAddress2(string textAddress2)
        {
            driver.FindElement(textIdAddress2).SendKeys(textAddress2);
        }

        public void enterCity(string textCity)
        {
            driver.FindElement(textIdCity).SendKeys(textCity);
        }

        public void enterState(string textSelection)
        {
            IWebElement StateSelection = driver.FindElement(selectorIdState);
            SelectElement SelectState = new SelectElement(StateSelection);
            SelectState.SelectByValue(textSelection);
        }

        public void enterZip(string textZip)
        {
            driver.FindElement(textIdZip).SendKeys(textZip);
        }

        public void enterPetPreference(string textPetPreference)
        {
            var textPet = textPetPreference.ToLower();

            if (textPet == "cat")
            {
                var element = driver.FindElement(radioIdCatPerson);
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
            }
            else if (textPet == "dog")
            {
                var element = driver.FindElement(radioIdDogPerson);
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
            }
            else if (textPet == "neither")
            {
                var element = driver.FindElement(radioIdNeitherPerson);
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
            }
            else if (textPet == "both")
            {
                var element = driver.FindElement(radioIdBothPerson);
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
            }
        }

        public void enterCoffeePreference(bool loveCoffee)
        {
            if (loveCoffee)
            {
                var element = driver.FindElement(checkboxIdCoffee);
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
            }
            else
            {
            }
        }

        public void clickSubmit()
        {
            driver.FindElement(buttonSubmit).Click();
        }

        public void clickClearForm()
        {
            driver.FindElement(buttonClearForm).Click();
        }
    }
}