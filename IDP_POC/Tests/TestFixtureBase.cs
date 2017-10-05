using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using IDP_POC.PageObjects;

namespace IDP_POC.Tests
{
    public class TestFixtureBase
    {
        protected IWebDriver _driver;
        protected ILoginPage _login;

        [SetUp]
        public void SetUp()
        {
            var VendorDirectory = System.IO.Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + @"\Vendor";
            var Service = InternetExplorerDriverService.CreateDefaultService(VendorDirectory);
            _driver = new InternetExplorerDriver(Service);
            _login = new LoginPage(_driver);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));


        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
