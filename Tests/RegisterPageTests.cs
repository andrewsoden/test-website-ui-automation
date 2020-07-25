using NUnit.Framework;
using PageMethods.RegisterPageMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Selenium
{
    public class RegisterPageTests : BaseClass
    {
        [Test]
        public void FirstTest()
        {
            Console.WriteLine("First test");
            driver.FindElement(By.CssSelector("#basic-navbar-nav > div > a:nth-child(1)")).Click();
            
            RegisterPageMethods registerPageDriver = new RegisterPageMethods(driver);
            registerPageDriver.enterFullName("Test");
            registerPageDriver.enterPhoneNumber("0430200100");
            registerPageDriver.enterEmail("test@test.com");
        }
    }
}