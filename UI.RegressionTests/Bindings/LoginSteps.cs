using TechTalk.SpecFlow;
using IDP_POC.PageObjects;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace IDP_POC.Bindings
{
    [Binding]
    public class LoginSteps
    {
        private readonly ILoginPage _loginPage;
        private readonly IWebDriver Driver;

        public LoginSteps()
        {
            var VendorDirectory = System.IO.Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + @"\Vendor";
            var Service = InternetExplorerDriverService.CreateDefaultService(VendorDirectory);
            Driver = new InternetExplorerDriver(Service);
            _loginPage = new LoginPage(Driver);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [Given(@"the user ""(.*)"" has an account with password ""(.*)"" and logs in")]
        public void GivenTheUserHasAnAccount(string signInName, string password)
        {
            _loginPage.With(signInName, password);
        }
        [Then(@"he should see the Login Successful page")]
        public void ThenHeShouldSeeThePage()
        {
            _loginPage.SuccessMessagePresent();
        }



    }
}
