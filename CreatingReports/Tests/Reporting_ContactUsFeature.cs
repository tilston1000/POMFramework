using AutomationResources;
using CreatingReports.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace CreatingReports.Tests

{
    [TestClass]
    [TestCategory("FinalFramework")]
    public class Reporting_ContactUsFeature : BaseTest
    {
        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        [Description("Validate that the contact us page opens successfully with a form")]
        public void ContactUsFeature_TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.IsLoaded,
                "The contact us page did not open successfully");
        }

        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        [Description("Validate that the contact us page opens when clicking the Contact Us button")]
        public void ContactUsFeature_TCID4()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();
            Assert.IsTrue(homePage.IsLoaded, "Home Page did not open successfully");

            var contactUsPage = homePage.Header.ClickContactUsButton();
            Assert.IsTrue(contactUsPage.IsLoaded, "The contact us page did not open successfully");
        }
    }
}
