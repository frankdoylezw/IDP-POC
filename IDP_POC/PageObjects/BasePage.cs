﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace IDP_POC.PageObjects
{
    public class BasePage
    {
        IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        protected void Visit(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        protected IWebElement Find(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected void Click(By locator)
        {
            Find(locator).Click();
        }

        protected void Type(By locator, string inputText)
        {
            Find(locator).SendKeys(inputText);
        }

        protected bool IsDisplayed(By locator)
        {
            try
            {
                return Find(locator).Displayed;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {

                return false;
            }
            
        }
        protected bool IsDisplayed(By locator, int maxWaitTime)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(maxWaitTime));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {

                return false;
            }

        }
    }

}
