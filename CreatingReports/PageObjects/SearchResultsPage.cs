using CreatingReports;
using CreatingReports.PageObjects;
using OpenQA.Selenium;

namespace CreatingReports.PageObjects
{
    public class SearchResultsPage : BaseApplicationPage
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoaded => Driver.Url.Contains("?s");
    }

}