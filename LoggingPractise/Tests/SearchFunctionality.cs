using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using AutomationResources;

namespace LoggingPractise.Tests
{
    [TestClass]
    [TestCategory("SearchFunctionality"), TestCategory("LoggingPractise")]
    public class SearchFunctionality : BaseTest
    {
        [TestMethod]
        [Description("Check to make sure that if we search for blouse, that blouse comes back")]
        [TestProperty("Author", "AndyTilston")]
        public void SearchFunctionality_TCID1()
        {
            string stringToSearch = "blouse";

            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search(stringToSearch);
            Assert.IsTrue(searchPage.Contains(Item.Blouse),
                $"When searching for the string=>{stringToSearch}, " +
                $"we did not find it in the search results");
        }
    }
}
