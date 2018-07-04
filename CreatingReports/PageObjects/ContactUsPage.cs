using OpenQA.Selenium;
using CreatingReports.PageObjects;
using AventStack.ExtentReports;

namespace CreatingReports.PageObjects
{
    internal class ContactUsPage : BaseApplicationPage
    {
        private IWebDriver driver;

        private IWebElement CenterColumn => Driver.FindElement(By.Id("center_column"));


        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public bool IsLoaded
        { get
            {
                try
                {
                    Reporter.LogTestStepForBugLogger(Status.Info,
                        "Validate that Contact Us page loaded successfully");
                    var displayed = CenterColumn.Displayed;
                    return displayed;
                }
                catch(NoSuchElementException)
                {
                    return false;
                }
            }
        }

        internal void GoTo()
        {
            var url = "http://automationpractice.com/index.php?controller=contact";
            Driver.Navigate().GoToUrl(url);
            Reporter.LogPassingTestStepToBugLogger($"Open url=>{url} for Contact Us page.");
        }
    }
}