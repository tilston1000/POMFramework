using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using AutomationResources;

namespace SampleAppFramework2.Tests
{
    [TestClass]
    [TestCategory("SearchingFeature"), TestCategory("SampleApp2")]
    public class SearchFunctionality : BaseTest
    {
        [TestMethod]
        [Description("Check to make sure that if we search for blouse, that blouse comes back")]
        [TestProperty("Author", "AndyTilston")]
        public void TCID1()
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
