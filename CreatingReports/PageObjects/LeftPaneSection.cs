using CreatingReports;
using CreatingReports.PageObjects;
using OpenQA.Selenium;

namespace CreatingReports.PageObjects
{
    public class LeftPaneSection : BaseApplicationPage
    {
        public LeftPaneSection(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchBox => Driver.FindElements(By.XPath("//form[@role='search']//input[@id='s']"))[0];
        public IWebElement SearchForm => Driver.FindElements(By.XPath("//form[@role='search']"))[1];
        public IWebElement SearchButton => SearchForm.FindElement(By.Id("searchsubmit"));

        public SearchResultsPage Search(string searchString)
        {
            SearchBox.SendKeys(searchString);
            SearchButton.Click();
            Reporter.LogPassingTestStepToBugLogger($"Search for string=>{searchString} in the left pane's Search bar");
            return new SearchResultsPage(Driver);
        }
    }
}