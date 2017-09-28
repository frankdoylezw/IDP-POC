using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using IDP_POC.PageObjects;

namespace IDP_POC.Tests
{
    [TestFixture]
    class LoginTest
    {
        IWebDriver Driver;
        LoginPage Login;

        [SetUp]
        public void SetUp()
        {
            var VendorDirectory = System.IO.Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + @"\Vendor";
            var Service = InternetExplorerDriverService.CreateDefaultService(VendorDirectory);
            Driver = new InternetExplorerDriver(Service);
            Login = new LoginPage(Driver);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));


        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]

        public void ValidAccountCredentials()
        {
            Login.With("frank.doyle@justretirement.com", "Password123");
            Assert.That(Login.SuccessMessagePresent);
            //Console.ReadLine();

        }
        [Test]

        public void InvalidPassword()
        {
            Login.With("frank.doyle@justretirement.com", "Password124");
            Assert.That(Login.IncorrectPasswordMessagePresent);
            //Console.ReadLine();

        }
    }
}
