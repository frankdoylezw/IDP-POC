using TechTalk.SpecFlow;
using IDP_POC.PageObjects;
using IDP_POC.Tests;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace UI.RegressionTests.Features
{
    public class FeatureBase: TestFixtureBase
    {
        [BeforeScenario("UI")]
        public void FeatureBaseSetup()
        {
            base.SetUp();
        }



    }
}
