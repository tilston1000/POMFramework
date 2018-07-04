using System;
using AventStack.ExtentReports;
using CreatingReports.Tests;
using NLog;
using OpenQA.Selenium;

namespace CreatingReports.PageObjects
{
    internal class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal bool Contains(Item itemToCheckFor)
        {
            Reporter.LogTestStepForBugLogger(Status.Info,
                $"Validate that item=>{itemToCheckFor} exists");

            switch(itemToCheckFor)
            {
                case Item.Blouse:
                    var isBlouseDisplayed = driver.FindElement(By.XPath("//*[@title='Blouse']")).Displayed;
                    return isBlouseDisplayed;
                default:
                    throw new ArgumentOutOfRangeException("No such item exists in this collection");
            }

        }
    }
}