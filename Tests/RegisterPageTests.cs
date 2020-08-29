using NUnit.Framework;
using PageMethods.RegisterPageMethods;

namespace Tests.Selenium
{
    public class RegisterPageTests : BaseTest
    {
        [SetUp]
        public void loadRegisterPage()
        {
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.navigateToRegisterPage();
        }

        [Test]
        public void IsRegisterPageHeadingPresent()
        {
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.isRegisterPageHeadingVisible();
        }

        [TestCase("Test", "0430200100", "test@test.com", "120 Very Long Street", "Unit 24b", "Brisbane", "WA", "4000", "Neither", true, TestName = "SuccessfullyRegisterWAPerson")]
        [TestCase("Throwaway Name", "0431555888", "woof@bark.com.au", "52 Laneway Drive", "", "Hobart", "TAS", "4163", "Both", false, TestName = "SuccessfullyRegisterTASPerson")]
        public void SuccessfullyRegisterUser(string fullName, string phoneNumber, string email,
            string address1, string address2, string city, string state, string postcode, string petPreference,
            bool coffeePreference)
        {
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.isRegisterPageHeadingVisible();
            registerPageDriver.enterFullName(fullName);
            registerPageDriver.enterPhoneNumber(phoneNumber);
            registerPageDriver.enterEmail(email);
            registerPageDriver.enterAddress1(address1);
            registerPageDriver.enterAddress2(address2);
            registerPageDriver.enterCity(city);
            registerPageDriver.enterState(state);
            registerPageDriver.enterZip(postcode);
            registerPageDriver.enterPetPreference(petPreference);
            registerPageDriver.enterCoffeePreference(coffeePreference);
            registerPageDriver.clickSubmit();
        }

        [TestCase("Throwaway Name", "0431555888", "woof@bark.com.au", "52 Laneway Drive", "", "Hobart", "TAS", "4163", "Both", false, TestName = "ConfirmClearRemovesData")]
        public void ClearButtonResetsForm(string fullName, string phoneNumber, string email,
            string address1, string address2, string city, string state, string postcode, string petPreference,
            bool coffeePreference)
        {
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.isRegisterPageHeadingVisible();
            registerPageDriver.enterFullName(fullName);
            registerPageDriver.enterPhoneNumber(phoneNumber);
            registerPageDriver.enterEmail(email);
            registerPageDriver.enterAddress1(address1);
            registerPageDriver.enterAddress2(address2);
            registerPageDriver.enterCity(city);
            registerPageDriver.enterState(state);
            registerPageDriver.enterZip(postcode);
            registerPageDriver.enterPetPreference(petPreference);
            registerPageDriver.enterCoffeePreference(coffeePreference);
            
            // TODO - clear form button is broken
            registerPageDriver.clickClearForm();
            registerPageDriver.textFieldReset();
        }
    }
}