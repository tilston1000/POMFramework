using AventStack.ExtentReports;
using CreatingReports.PageObjects;
using NLog;
using OpenQA.Selenium;

namespace CreatingReports.PageObjects
{
    internal class SignInPage : BaseApplicationPage
    {
        private IWebDriver driver;

        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public SignInPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public bool IsLoaded
        {
            get
            {
                var isLoaded = driver.Url.Contains("controller=authentication");
                Reporter.LogTestStepForBugLogger(Status.Info, "Check if the Sign In page loaded successfully");
                _logger.Trace($"Did sign in page open successfully=>{isLoaded}");
                return isLoaded;
            }
        }
    }
}