using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using IDP_POC.PageObjects;

namespace IDP_POC.Tests
{
    [TestFixture]
    public class LoginTest: TestFixtureBase
    {
        
        [Test]

        public void ValidAccountCredentials()
        {
            _login.With("frank.doyle@justretirement.com", "Password123");
            Assert.That(_login.SuccessMessagePresent);
            //Console.ReadLine();

        }
        [Test]

        public void InvalidPassword()
        {
            _login.With("frank.doyle@justretirement.com", "Password124");
            Assert.That(_login.IncorrectPasswordMessagePresent);
            //Console.ReadLine();

        }
    }
}
