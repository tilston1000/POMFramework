using System;
using AventStack.ExtentReports;
using CreatingReports;
using CreatingReports.PageObjects;
using OpenQA.Selenium;

namespace SampleAppFramework2.PageObjects
{
    public class ComplicatedPage : BaseApplicationPage
    {
        public ComplicatedPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoaded
        {
            get
            {
                var isLoaded = Driver.Url.Contains("complicated-page");
                Reporter.LogTestStepForBugLogger(Status.Info, "Check whether the complicated page loaded successfully");
                return isLoaded;
            }
        }

        public RandomStuffSection RandomStuffSection => new RandomStuffSection(Driver);

        public void GoTo()
        {
            var url = ("http://www.ultimateqa.com/complicated-page");
            Driver.Navigate().GoToUrl(url);
            Reporter.LogPassingTestStepToBugLogger($"Navigate to Complicated page at url{url}");
        }
    }
}