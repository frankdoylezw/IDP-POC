using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace IDP_POC.PageObjects
{
    class LoginPage: BasePage
    {
        By LoginForm = By.CssSelector("p.lead");
        By SignInLink = By.Id("signInLink");
        By UsernameInput = By.Id("signInName");
        By PasswordInput = By.Id("password");
        By SignInButton = By.CssSelector("button");
        By SuccessMessage = By.CssSelector("body > div.container.body-content > div.row > div > dl > dd:nth-child(20)");
        By IncorrectPasswordMessage = By.CssSelector(".error.pageLevel");

        public LoginPage(IWebDriver driver): base(driver)
        {
            Visit("https://just-identity-testharness-app-t1.azurewebsites.net/");
            Assert.That(IsDisplayed(LoginForm,5));
        }

        public void With(string signInName, string password)
        {
            Click(SignInLink);
            Type(UsernameInput, signInName);
            Type(PasswordInput, password);
            Click(SignInButton);
        }

        public bool SuccessMessagePresent()
        {
            System.Threading.Thread.Sleep(1000);
            return IsDisplayed(SuccessMessage,10);

        }
        public bool IncorrectPasswordMessagePresent()
        {
            System.Threading.Thread.Sleep(1000);
            return IsDisplayed(IncorrectPasswordMessage,10);
        }

    }
}
