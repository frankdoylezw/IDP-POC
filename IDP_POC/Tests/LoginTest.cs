using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace IDP_POC.Tests
{
    [TestFixture]
    class LoginTest
    {
        IWebDriver Driver;
        [SetUp]
        public void SetUp()
        {
            var VendorDirectory = System.IO.Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + @"\Vendor";
            var Service = InternetExplorerDriverService.CreateDefaultService(VendorDirectory);
            Driver = new InternetExplorerDriver(Service);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]

        public void ValidAccount()
        {
            Driver.Navigate().GoToUrl("https://just-t1-identity-testharness-app.azurewebsites.net/");
            Driver.FindElement(By.Id("signInLink")).Click();

            Driver.FindElement(By.Id("signInName")).SendKeys("frank.doyle@justretirement.com");
            Driver.FindElement(By.Id("password")).SendKeys("Password123");
            Driver.FindElement(By.CssSelector("button")).Click();
            Assert.That(Driver.FindElement(By.CssSelector("body > div.container.body-content > div.row > div > dl > dd:nth-child(20)")).Displayed);
            //Console.ReadLine();

        }
    }
}
