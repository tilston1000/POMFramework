using System;
using NLog;
using OpenQA.Selenium;
using CreatingReports.PageObjects;
using AventStack.ExtentReports;

namespace CreatingReports.PageObjects
{
    internal class HomePage : BaseApplicationPage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public HomePage(IWebDriver driver) : base(driver)
        {
            Slider = new Slider(driver);
        }

        public Slider Slider { get; set; }
        public HeaderSection Header => new HeaderSection(Driver);

        public bool IsLoaded
        {
            get
            {
                var isLoaded = Driver.Url.Contains("http://automationpractice.com/index.php");
                Reporter.LogTestStepForBugLogger(Status.Info, "Validate whether the Home Page loaded successfully");
                _logger.Trace($"Home page is loaded=>{isLoaded}");
                return isLoaded;
            }
        }

        internal void GoTo()
        {
            var url = "http://automationpractice.com/";
            Driver.Navigate().GoToUrl(url);
            _logger.Info($"Opened url=>{url}");
            Reporter.LogPassingTestStepToBugLogger($"In a browser, go to url=>{url}");
        }

        internal SearchPage Search(string itemToSearchFor)
        {
            _logger.Trace("Attempting to perform a Search.");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
            Driver.FindElement(By.Name("submit_search")).Click();
            Reporter.LogTestStepForBugLogger(AventStack.ExtentReports.Status.Info,
                $"Search for=>{itemToSearchFor} in the search bar on the page");
            //_logger.Info($"Search for an item in the search bar=>{itemToSearchFor}");
            return new SearchPage(Driver);
        }
    }
}