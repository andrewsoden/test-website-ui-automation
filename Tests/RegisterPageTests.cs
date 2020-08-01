using NUnit.Framework;
using PageMethods.RegisterPageMethods;
using OpenQA.Selenium;
using System;

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

        [Test]
        public void SuccessfullyRegisterUser()
        {
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.isRegisterPageHeadingVisible();
            registerPageDriver.enterFullName("Test");
            registerPageDriver.enterPhoneNumber("0430200100");
            registerPageDriver.enterEmail("test@test.com");
            registerPageDriver.enterAddress1("120 Very Long Street");
            registerPageDriver.enterAddress2("Unit 24b");
            registerPageDriver.enterCity("Brisbane");
            registerPageDriver.enterState("WA");
            registerPageDriver.enterZip("4000");
            registerPageDriver.enterPetPreference("Neither");
            registerPageDriver.enterCoffeePreference(true);
        }
    }
}